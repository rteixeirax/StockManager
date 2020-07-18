using StockManager.Database.Source.Models;
using StockManager.Services.Source;
using StockManager.Source.Forms;
using StockManager.Translations.Source;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManager.Source.UserControls
{
    public partial class DashboardAdminUc : UserControl
    {
        public DashboardAdminUc()
        {
            InitializeComponent();
            this.SetTranslatedPhrases();
        }

        public void LoadDataAsync()
        {
            // TODO: write the code
            Console.WriteLine("Loading data....");
        }

        private async void btnStockMovement_Click(object sender, System.EventArgs e)
        {
            Location mainLocation = await AppServices.LocationService.GetMainLocationAsync(true);
            ManualStockMovementForm manualStockMovementForm = new ManualStockMovementForm(null, null, mainLocation, null, this);
            await manualStockMovementForm.ShowManualStockMovementFormAsync();
        }

        private void SetTranslatedPhrases()
        {
            btnStockMovement.Text = Phrases.GlobalCreateMov;

            lbGlobalInfo.Text = Phrases.GlobalInfo;
            lbLocations.Text = Phrases.GlobalLocations;
            lbLocationsCount.Text = "0";
            lbProducts.Text = Phrases.GlobalProducts;
            lbProductsCount.Text = "0";
            lbUsers.Text = Phrases.GlobalUsers;
            lbUsersCount.Text = "0";

            lbStockAlerts.Text = Phrases.GlobalStockAlerts;
            dgvProductStockAlerts.Columns[0].HeaderText = Phrases.GlobalProduct;
            dgvProductStockAlerts.Columns[1].HeaderText = Phrases.GlobalReference;
            dgvProductStockAlerts.Columns[2].HeaderText = Phrases.GlobalLocation;
            dgvProductStockAlerts.Columns[3].HeaderText = Phrases.StockMovementsStock;
        }
    }
}
