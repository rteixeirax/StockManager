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

            dgvProducts.Columns[2].HeaderText = Phrases.GlobalReference;
            dgvProducts.Columns[3].HeaderText = Phrases.GlobalProduct;
            dgvProducts.Columns[4].HeaderText = Phrases.StockMovementQty;
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
                plocation.LocationId,
                plocation.ProductId,
                plocation?.Product?.Reference,
                plocation?.Product?.Name,
                0
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

        private async void btnSubmit_Click(object sender, System.EventArgs e)
        {
            int errorsCount = 0;

            Spinner.InitSpinner();

            for (int i = 0; i < dgvProducts.Rows.Count; i++)
            {
                int locationId = int.Parse(dgvProducts.Rows[i].Cells[0].Value.ToString());
                int productId = int.Parse(dgvProducts.Rows[i].Cells[1].Value.ToString());
                float qty = float.Parse(dgvProducts.Rows[i].Cells[4].Value.ToString());

                // TODO: change this.
                // The table should have the input to the stock count and the stock refill

                // TODO: Wrappe this in a try/catch, catch the errors and save them in a list. Show them in a message later.
                // Show to the user what stock movements went wrong.

                if (qty > 0)
                {
                    try
                    {
                        // Only create the stock movement if has qty to move.
                        await AppServices.StockMovementService.RefillStockAsync(locationId, productId, qty, Program.LoggedInUser.UserId);
                    }
                    catch
                    {
                        errorsCount++;
                    }
                }
            }

            if (errorsCount > 0)
            {
                MessageBox.Show(
                    "TODO: add message", // TODO: Change phrase to try again later
                    Phrases.GlobalDialogWarningTitle,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
            else
            {
                MessageBox.Show(
                   "TODO: add message",
                   Phrases.GlobalDialogErrorTitle, // TODO: change phrase to a success
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information
               );
            }

            Spinner.StopSpinner();
        }
    }
}
