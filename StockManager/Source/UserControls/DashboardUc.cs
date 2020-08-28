using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using StockManager.Core.Source.Models;
using StockManager.Services.Source;
using StockManager.Source.Components;
using StockManager.Source.Forms;
using StockManager.Translations.Source;

namespace StockManager.Source.UserControls
{
    public partial class DashboardUc : UserControl
    {
        private int _rowIndex = -1; // Nothing selected

        public DashboardUc()
        {
            InitializeComponent();
            SetTranslatedPhrases();
            LoadDataAsync().Wait();
        }

        public void UpdateTable(float currentStock, float refiledQty)
        {
            if (_rowIndex >= 0)
            {
                dgvProducts.Rows[_rowIndex].Cells[4].Value = currentStock;
                dgvProducts.Rows[_rowIndex].Cells[5].Value = refiledQty;

                // Reset the row index
                _rowIndex = -1;
            }
        }

        private void SetTranslatedPhrases()
        {
            lbLocation.Text = Phrases.GlobalLocation;

            dgvProducts.Columns[2].HeaderText = Phrases.GlobalReference;
            dgvProducts.Columns[3].HeaderText = Phrases.GlobalProduct;
            dgvProducts.Columns[4].HeaderText = "Current stock"; // TODO: Change this
            dgvProducts.Columns[5].HeaderText = "Refill Qty";
            // Actions
            dgvProducts.Columns[6].CellTemplate.ToolTipText = Phrases.GlobalEdit; // Action edit
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
                plocation?.Stock,
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

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((dgvProducts.SelectedRows.Count > 0) && (e.RowIndex >= 0) && (e.ColumnIndex == 6))
            {
                // Save the index to update the data after.
                _rowIndex = e.RowIndex;

                int locationId = int.Parse(dgvProducts.Rows[e.RowIndex].Cells[0].Value.ToString());
                int productId = int.Parse(dgvProducts.Rows[e.RowIndex].Cells[1].Value.ToString());
                string productRef = dgvProducts.Rows[e.RowIndex].Cells[2].Value.ToString();
                string productName = dgvProducts.Rows[e.RowIndex].Cells[3].Value.ToString();
                float currentStock = float.Parse(dgvProducts.Rows[e.RowIndex].Cells[4].Value.ToString());
                float refillQty = float.Parse(dgvProducts.Rows[e.RowIndex].Cells[5].Value.ToString());

                RefillStockForm refilStockForm = new RefillStockForm(this, locationId, productId, $"{productRef} {productName}");
                refilStockForm.ShowRefilStockForm(currentStock, refillQty);
            }
        }
    }
}
