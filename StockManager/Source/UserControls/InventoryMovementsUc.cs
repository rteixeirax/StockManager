using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using StockManager.Core.Source.Extensions;
using StockManager.Core.Source.Models;
using StockManager.Core.Source.Types;
using StockManager.Services.Source;
using StockManager.Source.Components;
using StockManager.Source.Forms;
using StockManager.Translations.Source;

namespace StockManager.Source.UserControls
{
    public partial class InventoryMovementsUc : UserControl
    {
        private bool _hasBeenSearching = false; // Flags if the user has been searching

        public InventoryMovementsUc()
        {
            InitializeComponent();

            btnClearSearchValue.Visible = false;

            dtpStart.MaxDate = DateTime.Today;
            dtpStart.MinDate = new DateTime(1753, 1, 1);
            dtpStart.Value = DateTime.Today;

            dtpEnd.MaxDate = DateTime.Now.AddYears(10);
            dtpEnd.MinDate = dtpStart.Value;
            dtpEnd.Value = dtpStart.Value;

            SetTranslatedPhrases();
            LoadDataAsync().Wait();
        }

        public async Task LoadDataAsync()
        {
            Spinner.InitSpinner();

            dgvMovements.Rows.Clear();

            StockMovementOptions options = new StockMovementOptions()
            {
                SearchValue = tbSeachText.Text,
                StartDate = dtpStart.Value,
                EndDate = dtpEnd.Value
            };

            IEnumerable<StockMovement> movements = await AppServices.StockMovementService.GetAllAsync(options);

            movements.ToList().ForEach((stockMovement) => {
                dgvMovements.Rows.Add(
                  stockMovement.StockMovementId,
                  stockMovement.CreatedAt.ShortDateWithTime(),
                  stockMovement.Product?.Reference,
                  stockMovement.Product?.Name,
                  stockMovement.ConcatMovementString(),
                  stockMovement.Qty,
                  stockMovement.Stock,
                  stockMovement.User?.Username
                );
            });

            Spinner.StopSpinner();
        }

        private async void btnClearSearchValue_Click(object sender, EventArgs e)
        {
            tbSeachText.Text = "";
            _hasBeenSearching = false;
            await LoadDataAsync();
        }

        private async void btnStockMovement_Click(object sender, EventArgs e)
        {
            Location mainLocation = await AppServices.LocationService.GetMainAsync(true);
            ManualStockMovementForm manualStockMovementForm = new ManualStockMovementForm(this, mainLocation);
            await manualStockMovementForm.ShowManualStockMovementFormAsync();
        }

        private async void pbSearchIcon_Click(object sender, EventArgs e)
        {
            string searchValue = tbSeachText.Text;

            if (!string.IsNullOrEmpty(searchValue))
            {
                // sets the flag has been searching
                _hasBeenSearching = true;
                await LoadDataAsync();
            }
        }

        private void SetTranslatedPhrases()
        {
            btnStockMovement.Text = Phrases.GlobalCreateMov;

            lbFilter.Text = Phrases.GlobalFilters;
            lbFilterDate.Text = Phrases.GlobalDate;
            lbFilterLocation.Text = Phrases.GlobalLocation;
            lbFilterUser.Text = Phrases.GlobalUser;

            dgvMovements.Columns[1].HeaderText = Phrases.GlobalDate;
            dgvMovements.Columns[2].HeaderText = Phrases.GlobalReference;
            dgvMovements.Columns[3].HeaderText = Phrases.GlobalProduct;
            dgvMovements.Columns[4].HeaderText = Phrases.GlobalMovement;
            dgvMovements.Columns[5].HeaderText = Phrases.StockMovementQty;
            dgvMovements.Columns[6].HeaderText = Phrases.StockMovementStockAcc;
            dgvMovements.Columns[7].HeaderText = Phrases.GlobalUser;
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

        private async void dtpStart_CloseUp(object sender, EventArgs e)
        {
            dtpEnd.MinDate = dtpStart.Value;
            await LoadDataAsync();
        }

        private async void dtpEnd_CloseUp(object sender, EventArgs e)
        {
            dtpStart.MaxDate = dtpEnd.Value;
            await LoadDataAsync();
        }
    }
}
