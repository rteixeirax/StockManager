using System.Threading.Tasks;
using System.Windows.Forms;

using StockManager.Database.Source.Models;
using StockManager.Services.Source;
using StockManager.Source.Forms;
using StockManager.Translations.Source;

namespace StockManager.Source.UserControls
{
    public partial class DashboardAdminUc : UserControl
    {
        public DashboardAdminUc()
        {
            InitializeComponent();
            SetTranslatedPhrases();
            LoadDataAsync().Wait();
        }

        public async Task LoadDataAsync()
        {
            int locationsCount = await AppServices.LocationService.CountAsync();
            int productsCount = await AppServices.ProductService.CountAsync();
            int usersCount = await AppServices.UserService.CountAsync();

            lbLocationsCount.Text = locationsCount.ToString();
            lbProductsCount.Text = productsCount.ToString();
            lbUsersCount.Text = usersCount.ToString();
        }

        private async void btnStockMovement_Click(object sender, System.EventArgs e)
        {
            Location mainLocation = await AppServices.LocationService.GetMainLocationAsync(true);
            ManualStockMovementForm manualStockMovementForm = new ManualStockMovementForm(this, mainLocation);
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
