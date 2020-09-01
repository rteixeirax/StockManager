using System;
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
    public partial class RefillStockUc : UserControl
    {
        private int _rowIndex = -1; // Nothing selected
        private int _selectedLocationId; // Save the selected location Id
        private bool _hasBeenSearching = false; // Flags if the user has been searching

        private readonly Dictionary<int, float> _memorizing;

        public RefillStockUc()
        {
            InitializeComponent();

            // Hide the X button on the search textbox
            btnClearSearchValue.Visible = false;

            // Initializing our memo helper
            _memorizing = new Dictionary<int, float>();

            SetTranslatedPhrases();
            LoadDataAsync().Wait();
        }

        public async Task UpdateTable(float refiledQty)
        {
            /*
             * Ok, bear with me. When the user refill the stock, we need to update the table with the
             * refilled qty. At the same time we reload the table to update the new product location stock.
             * With that in mind, we need to memorize the refilled qty for each product to keep the table column
             * with the correct refilled qty, otherwise after we reload the data it shows zero.
             */

            if (_rowIndex >= 0)
            {
                dgvProducts.Rows[_rowIndex].Cells[5].Value = refiledQty;

                int plocationId = int.Parse(dgvProducts.Rows[_rowIndex].Cells[0].Value.ToString());

                if (_memorizing.ContainsKey(plocationId))
                {
                    _memorizing[plocationId] = refiledQty;
                }
                else
                {
                    _memorizing.Add(plocationId, refiledQty);
                }

                // Reset the row index
                _rowIndex = -1;

                // sets the flag has been searching
                _hasBeenSearching = !string.IsNullOrEmpty(tbSeachText.Text);

                // If the user has been searching, we need to show him the table with the correct elements.
                // For that to happend, we need to send the searchValue, if any.
                // Otherwise the table will reload and lose the user searching.
                await LoadProductsTableDataAsync(_selectedLocationId, (_hasBeenSearching ? tbSeachText.Text : null));
            }
        }

        private void SetTranslatedPhrases()
        {
            lbLocation.Text = Phrases.GlobalLocation;
            lbProductLocation.Text = Phrases.GlobalProducts;

            dgvProducts.Columns[2].HeaderText = Phrases.GlobalReference;
            dgvProducts.Columns[3].HeaderText = Phrases.GlobalProduct;
            dgvProducts.Columns[4].HeaderText = Phrases.StockMovementsStock;
            dgvProducts.Columns[5].HeaderText = Phrases.RefillStockRefilledQty;
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

        private async Task LoadProductsTableDataAsync(int locationId, string searchValue = null)
        {
            // Clear products table
            dgvProducts.Rows.Clear();

            // Set the selected location id
            _selectedLocationId = locationId;

            IEnumerable<ProductLocation> pLocations = await AppServices.ProductLocationService
                   .FindAllByLocationIdAsync(locationId, searchValue);

            pLocations?.ToList().ForEach((plocation) => dgvProducts.Rows.Add(
                plocation.ProductLocationId,
                plocation.ProductId,
                plocation?.Product?.Reference,
                plocation?.Product?.Name,
                plocation?.Stock,
                _memorizing.ContainsKey(plocation.ProductLocationId) ? _memorizing[plocation.ProductLocationId] : 0
            ));
        }

        private async void cbLocations_SelectionChangeCommitted(object sender, EventArgs e)
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

                int productId = int.Parse(dgvProducts.Rows[e.RowIndex].Cells[1].Value.ToString());
                string productRef = dgvProducts.Rows[e.RowIndex].Cells[2].Value.ToString();
                string productName = dgvProducts.Rows[e.RowIndex].Cells[3].Value.ToString();
                float currentStock = float.Parse(dgvProducts.Rows[e.RowIndex].Cells[4].Value.ToString());
                float refillQty = float.Parse(dgvProducts.Rows[e.RowIndex].Cells[5].Value.ToString());

                RefillStockForm refilStockForm = new RefillStockForm(this, _selectedLocationId, productId, $"{productRef} {productName}");
                refilStockForm.ShowRefillStockForm(currentStock, refillQty);
            }
        }

        private async void pbSearchIcon_Click(object sender, EventArgs e)
        {
            string searchValue = tbSeachText.Text;

            if (!string.IsNullOrEmpty(searchValue))
            {
                // sets the flag has been searching
                _hasBeenSearching = true;
                await LoadProductsTableDataAsync(_selectedLocationId, searchValue);
            }
        }

        private async void btnClearSearchValue_Click(object sender, EventArgs e)
        {
            tbSeachText.Text = "";
            _hasBeenSearching = false;
            await LoadProductsTableDataAsync(_selectedLocationId);
        }

        private void tbSeachText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ( char )Keys.Enter)
            {
                pbSearchIcon_Click(sender, e);
                // Remove the annoying beep
                e.Handled = true;
            }
            else if (e.KeyChar == ( char )Keys.Escape)
            {
                btnClearSearchValue_Click(sender, e);
                // Remove the annoying beep
                e.Handled = true;
            }
        }

        private async void tbSeachText_TextChanged(object sender, EventArgs e)
        {
            btnClearSearchValue.Visible = (tbSeachText.Text.Length > 0);

            if (tbSeachText.Text.Length > 0)
            {
                btnClearSearchValue.Visible = true;

                // If the user clear all the search box text after doing some search, i need to
                // query the DB without any search param to show all table data.
            }
            else if ((tbSeachText.Text.Length == 0) && _hasBeenSearching)
            {
                _hasBeenSearching = false;
                btnClearSearchValue.Visible = false;
                await LoadProductsTableDataAsync(_selectedLocationId);
            }
        }
    }
}
