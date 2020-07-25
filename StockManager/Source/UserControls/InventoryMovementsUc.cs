using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using StockManager.Core.Source.Extensions;
using StockManager.Core.Source.Models;
using StockManager.Services.Source;
using StockManager.Source.Components;
using StockManager.Source.Forms;
using StockManager.Translations.Source;

namespace StockManager.Source.UserControls
{
    public partial class InventoryMovementsUc : UserControl
    {
        private readonly MainForm _mainForm;
        private bool _hasBeenSearching = false; // Flags if the user has been searching

        public InventoryMovementsUc(MainForm mainForm)
        {
            InitializeComponent();

            // Set the MainForm pointer
            _mainForm = mainForm;
            btnClearSearchValue.Visible = false;
            SetTranslatedPhrases();
            LoadMovementsAsync().Wait();
        }

        public async Task LoadMovementsAsync()
        {
            Spinner.InitSpinner();
            dgvMovements.Rows.Clear();
            await LoadDataAsync();
            Spinner.StopSpinner();
        }

        private async void btnClearSearchValue_Click(object sender, System.EventArgs e)
        {
            tbSeachText.Text = "";
            _hasBeenSearching = false;
            await LoadDataAsync();
        }

        private async void btnStockMovement_Click(object sender, System.EventArgs e)
        {
            Location mainLocation = await AppServices.LocationService.GetMainAsync(true);
            ManualStockMovementForm manualStockMovementForm = new ManualStockMovementForm(this, mainLocation);
            await manualStockMovementForm.ShowManualStockMovementFormAsync();
        }

        private async Task LoadDataAsync(string searchValue = "")
        {
            dgvMovements.Rows.Clear();
            System.Collections.Generic.IEnumerable<StockMovement> movements = await AppServices.StockMovementService.GetAllAsync(searchValue);
            movements.ToList().ForEach((stockMovement) => {
                dgvMovements.Rows.Add(
                  stockMovement.StockMovementId,
                  stockMovement.CreatedAt.ShortDateWithTime(),
                  stockMovement.Product?.Name,
                  stockMovement.ConcatMovementString(),
                  stockMovement.Qty,
                  stockMovement.Stock,
                  stockMovement.User?.Username
                );
            });
        }

        private async void pbSearchIcon_Click(object sender, System.EventArgs e)
        {
            string searchValue = tbSeachText.Text;

            if (!string.IsNullOrEmpty(searchValue))
            {
                // sets the flag has been searching
                _hasBeenSearching = true;
                await LoadDataAsync(searchValue);
            }
        }

        private void SetTranslatedPhrases()
        {
            btnStockMovement.Text = Phrases.GlobalCreateMov;

            dgvMovements.Columns[1].HeaderText = Phrases.GlobalDate;
            dgvMovements.Columns[2].HeaderText = Phrases.GlobalProduct;
            dgvMovements.Columns[3].HeaderText = Phrases.GlobalMovement;
            dgvMovements.Columns[4].HeaderText = Phrases.StockMovementQty;
            dgvMovements.Columns[5].HeaderText = Phrases.StockMovementStockAcc;
            dgvMovements.Columns[6].HeaderText = Phrases.GlobalUser;
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

        private async void tbSeachText_TextChanged(object sender, System.EventArgs e)
        {
            if (tbSeachText.Text.Any())
            {
                btnClearSearchValue.Visible = true;

                // If the user clear all the search box text after doing some search, i need to
                // query the DB without any search param to show all table data.
            }
            else if (!tbSeachText.Text.Any() && _hasBeenSearching)
            {
                _hasBeenSearching = false;
                btnClearSearchValue.Visible = false;
                await LoadDataAsync();
            }
        }
    }
}
