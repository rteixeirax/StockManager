using StockManager.Database.Source.Models;
using StockManager.Services.Source;
using StockManager.Source.Components;
using StockManager.Source.Extensions;
using StockManager.Source.Forms;
using StockManager.Translations.Source;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            this.SetTranslatedPhrases();
            this.LoadMovementsAsync().Wait();
        }

        public async Task LoadMovementsAsync()
        {
            Spinner.InitSpinner();
            dgvMovements.Rows.Clear();
            await this.LoadDataAsync();
            Spinner.StopSpinner();
        }

        private async void btnClearSearchValue_Click(object sender, System.EventArgs e)
        {
            tbSeachText.Text = "";
            _hasBeenSearching = false;
            await this.LoadDataAsync();
        }

        private async Task LoadDataAsync(string searchValue = "")
        {
            dgvMovements.Rows.Clear();
            var movements = await AppServices.StockMovementService.GetAllAsync(searchValue);
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
                await this.LoadDataAsync(searchValue);
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
                this.pbSearchIcon_Click(sender, e);
                // Remove the annoying beep
                e.Handled = true;
            }
            else if (e.KeyChar == ( char )Keys.Escape)
            {
                this.btnClearSearchValue_Click(sender, e);
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
                await this.LoadDataAsync();
            }
        }

        private async void btnStockMovement_Click(object sender, System.EventArgs e)
        {
            Location mainLocation = await AppServices.LocationService.GetMainLocationAsync();
            ManualStockMovementForm manualStockMovementForm = new ManualStockMovementForm(null, null, mainLocation, this);
            await manualStockMovementForm.ShowManualStockMovementFormAsync();
        }
    }
}