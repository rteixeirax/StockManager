using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using StockManager.Core.Source.Models;
using StockManager.Services.Source;
using StockManager.Source.Components;
using StockManager.Translations.Source;

namespace StockManager.Source.UserControls
{
    public partial class DashboardUc : UserControl
    {
        public DashboardUc()
        {
            InitializeComponent();
            SetTranslatedPhrases();
            LoadDataAsync().Wait();
        }

        private void SetTranslatedPhrases()
        {
            lbLocation.Text = Phrases.GlobalLocation;

            dgvProducts.Columns[1].HeaderText = Phrases.GlobalReference;
            dgvProducts.Columns[2].HeaderText = Phrases.GlobalProduct;
            dgvProducts.Columns[3].HeaderText = Phrases.StockMovementQty;
        }

        private async Task LoadDataAsync()
        {
            Spinner.InitSpinner();

            IEnumerable<Location> locations = await AppServices.LocationService.GetAllAsync();
            List<Location> filteredLocations = locations.Where(x => !x.IsMain).ToList();

            cbLocations.DataSource = filteredLocations;
            cbLocations.ValueMember = "LocationId";
            cbLocations.DisplayMember = "Name";

            await LoadProductsTableDataAsync(filteredLocations.ElementAt(0).LocationId);

            Spinner.StopSpinner();
        }

        private async Task LoadProductsTableDataAsync(int locationId)
        {
            dgvProducts.Rows.Clear();

            IEnumerable<ProductLocation> pLocations = await AppServices.ProductLocationService
                   .FindAllByLocationIdAsync(locationId);

            pLocations?.ToList().ForEach((plocation) => dgvProducts.Rows.Add(
                plocation.ProductLocationId,
                plocation?.Product?.Reference,
                plocation?.Product?.Name,
                "TODO: Add input" // TODO: Add input here
            ));
        }

        private async void cbLocations_SelectionChangeCommitted(object sender, System.EventArgs e)
        {
            Location location = ( Location )cbLocations.SelectedItem;

            if (location != null)
            {
                Spinner.InitSpinner();
                await LoadProductsTableDataAsync(location.LocationId);
                Spinner.StopSpinner();
            }
        }
    }
}
