using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using StockManager.Src.Data.Entities;
using StockManager.Src.Extensions;
using StockManager.Src.Models;
using StockManager.Src.Services;
using StockManager.Src.Translations;
using StockManager.Src.Views.Components;
using StockManager.Src.Views.Forms;

namespace StockManager.Src.Views.UserControls
{
    public partial class DashboardUc : UserControl
    {
        private IEnumerable<Notification> _notifications;

        public DashboardUc()
        {
            InitializeComponent();
            SetTranslatedPhrases();
            LoadDataAsync().Wait();
        }

        public async Task LoadDataAsync()
        {
            Spinner.InitSpinner();
            dgvProductStockAlerts.Rows.Clear();

            int locationsCount = await AppServices.LocationService.CountAsync();
            int productsCount = await AppServices.ProductService.CountAsync();
            int usersCount = await AppServices.UserService.CountAsync();

            lbLocationsCount.Text = locationsCount.ToString();
            lbProductsCount.Text = productsCount.ToString();
            lbUsersCount.Text = usersCount.ToString();

            IEnumerable<Notification> notifications = await AppServices.NotificationService.GetAllAsync();

            _notifications = notifications;

            notifications?.ToList().ForEach(notification => dgvProductStockAlerts.Rows.Add(
                notification.CreatedAt.ShortDateWithTime(),
                notification.ProductLocation?.Product?.Reference,
                notification.ProductLocation?.Product?.Name,
                notification.ProductLocation?.Location?.Name,
                notification.ProductLocation?.MinStock,
                notification.ProductLocation?.Stock
            ));

            Spinner.StopSpinner();
        }

        private async void btnCreatePdf_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (!_notifications.Any())
                {
                    MessageBox.Show(Phrases.GlobalDialogExportWarningBody, Phrases.GlobalDialogWarningTitle,
                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (MessageBox.Show(Phrases.GlobalDialogExportBody, Phrases.GlobalDialogExportTitle,
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Spinner.InitSpinner();

                    await AppServices.NotificationService.ExportNotificationsToPDFAsync(_notifications);

                    Spinner.StopSpinner();
                }
            }
            catch (ServiceErrorException ex)
            {
                Spinner.StopSpinner();

                MessageBox.Show($"{ex.Errors[0].Error}", Phrases.GlobalDialogErrorTitle,
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnStockMovement_Click(object sender, System.EventArgs e)
        {
            Location mainLocation = await AppServices.LocationService.GetMainAsync(true);
            ManualStockMovementForm manualStockMovementForm = new ManualStockMovementForm(this, mainLocation);
            await manualStockMovementForm.ShowManualStockMovementFormAsync();
        }

        private void SetTranslatedPhrases()
        {
            btnCreatePdf.Text = Phrases.GlobalExportToPDF;
            btnStockMovement.Text = Phrases.GlobalCreateMov;

            lbGlobalInfo.Text = Phrases.GlobalInfo;
            lbLocations.Text = Phrases.GlobalLocations;
            lbLocationsCount.Text = "0";
            lbProducts.Text = Phrases.GlobalProducts;
            lbProductsCount.Text = "0";
            lbUsers.Text = Phrases.GlobalUsers;
            lbUsersCount.Text = "0";

            lbStockAlerts.Text = Phrases.GlobalStockAlerts;
            dgvProductStockAlerts.Columns[0].HeaderText = Phrases.GlobalDate;
            dgvProductStockAlerts.Columns[1].HeaderText = Phrases.GlobalReference;
            dgvProductStockAlerts.Columns[2].HeaderText = Phrases.GlobalProduct;
            dgvProductStockAlerts.Columns[3].HeaderText = Phrases.GlobalLocation;
            dgvProductStockAlerts.Columns[4].HeaderText = Phrases.StockMovementMinStock;
            dgvProductStockAlerts.Columns[5].HeaderText = Phrases.StockMovementsStock;
        }
    }
}
