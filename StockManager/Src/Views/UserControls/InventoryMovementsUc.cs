using System;
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
    public partial class InventoryMovementsUc : UserControl
    {
        private bool _hasBeenSearching = false; // Flags if the user has been searching
        private IEnumerable<StockMovement> _movements;

        public InventoryMovementsUc()
        {
            InitializeComponent();
            LoadInitialDataAsync().Wait();
        }

        public async Task LoadDataAsync()
        {
            Spinner.InitSpinner();

            dgvMovements.Rows.Clear();

            IEnumerable<StockMovement> movements = await AppServices
                .StockMovementService.GetAllAsync(GetOptions());

            _movements = movements;

            movements.ToList().ForEach((stockMovement) => {
                dgvMovements.Rows.Add(
                  stockMovement.StockMovementId,
                  stockMovement.CreatedAt.ShortDateWithTime(),
                  stockMovement.User?.Username,
                  stockMovement.Product?.Reference,
                  stockMovement.Product?.Name,
                  stockMovement.ConcatMovementString(),
                  stockMovement.Qty,
                  stockMovement.Stock
                );
            });

            Spinner.StopSpinner();
        }

        private async void btClearFilterDate_Click(object sender, EventArgs e)
        {
            SetInitialDateTimePickerValues();

            btClearFilterDate.Visible = false;
            await LoadDataAsync();
        }

        private async void btClearFilterLocation_Click(object sender, EventArgs e)
        {
            cbLocations.SelectedItem = null;
            btClearFilterLocation.Visible = false;
            await LoadDataAsync();
        }

        private async void btClearFilterUser_Click(object sender, EventArgs e)
        {
            cbUsers.SelectedItem = null;
            btClearFilterUser.Visible = false;
            await LoadDataAsync();
        }

        private async void btnClearSearchValue_Click(object sender, EventArgs e)
        {
            tbSeachText.Text = "";
            _hasBeenSearching = false;
            await LoadDataAsync();
        }

        private async void btnCreatePdf_Click(object sender, EventArgs e)
        {
            try
            {
                if (!_movements.Any())
                {
                    MessageBox.Show(Phrases.GlobalDialogExportWarningBody, Phrases.GlobalDialogWarningTitle,
                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (MessageBox.Show(Phrases.GlobalDialogExportBody, Phrases.GlobalDialogExportTitle,
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Spinner.InitSpinner();

                    await AppServices.StockMovementService.ExportStockMovementsToPDFAsync(
                        new ExportData<IEnumerable<StockMovement>, StockMovementOptions>(_movements, GetOptions()));

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

        private async void btnStockMovement_Click(object sender, EventArgs e)
        {
            Location mainLocation = await AppServices.LocationService.GetMainAsync(true);
            ManualStockMovementForm manualStockMovementForm = new ManualStockMovementForm(this, mainLocation);
            await manualStockMovementForm.ShowManualStockMovementFormAsync();
        }

        private async void cbLocations_SelectionChangeCommitted(object sender, EventArgs e)
        {
            btClearFilterLocation.Visible = true;
            await LoadDataAsync();
        }

        private async void cbUsers_SelectionChangeCommitted(object sender, EventArgs e)
        {
            btClearFilterUser.Visible = true;
            await LoadDataAsync();
        }

        private async void dtpEnd_CloseUp(object sender, EventArgs e)
        {
            dtpStart.MaxDate = dtpEnd.Value;
            btClearFilterDate.Visible = true;
            await LoadDataAsync();
        }

        private async void dtpStart_CloseUp(object sender, EventArgs e)
        {
            dtpEnd.MinDate = dtpStart.Value;
            btClearFilterDate.Visible = true;
            await LoadDataAsync();
        }

        private StockMovementOptions GetOptions()
        {
            StockMovementOptions options = new StockMovementOptions()
            {
                SearchValue = tbSeachText.Text,
                LocationId = ( int? )cbLocations.SelectedValue,
                UserId = ( int? )cbUsers.SelectedValue,
                StartDate = dtpStart.Value,
                EndDate = dtpEnd.Value
            };

            return options;
        }

        private async Task LoadFiltersDataAsync()
        {
            Spinner.InitSpinner();

            IEnumerable<Location> locations = await AppServices.LocationService.GetAllAsync();
            cbLocations.DataSource = locations;
            cbLocations.ValueMember = "LocationId";
            cbLocations.DisplayMember = "Name";
            cbLocations.SelectedItem = null;

            IEnumerable<User> users = await AppServices.UserService.GetAllAsync();
            cbUsers.DataSource = users;
            cbUsers.ValueMember = "UserId";
            cbUsers.DisplayMember = "Username";
            cbUsers.SelectedItem = null;

            SetInitialDateTimePickerValues();

            Spinner.StopSpinner();
        }

        private async Task LoadInitialDataAsync()
        {
            btnClearSearchValue.Visible = false;
            btClearFilterLocation.Visible = false;
            btClearFilterUser.Visible = false;
            btClearFilterDate.Visible = false;

            SetTranslatedPhrases();

            await LoadFiltersDataAsync();
            await LoadDataAsync();
        }

        private async void pbSearchIcon_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbSeachText.Text))
            {
                // sets the flag has been searching
                _hasBeenSearching = true;
                await LoadDataAsync();
            }
        }

        private void SetInitialDateTimePickerValues()
        {
            dtpStart.MaxDate = DateTime.Today;
            dtpStart.MinDate = new DateTime(1753, 1, 1);
            dtpStart.Value = DateTime.Today;

            dtpEnd.MaxDate = DateTime.Now.AddYears(10);
            dtpEnd.MinDate = dtpStart.Value;
            dtpEnd.Value = dtpStart.Value;
        }

        private void SetTranslatedPhrases()
        {
            btnCreatePdf.Text = Phrases.GlobalExportToPDF;
            btnStockMovement.Text = Phrases.GlobalCreateMov;

            lbFilterDate.Text = $"{Phrases.GlobalFilterBy} {Phrases.GlobalDate}";
            lbFilterLocation.Text = $"{Phrases.GlobalFilterBy} {Phrases.GlobalLocation}";
            lbFilterUser.Text = $"{Phrases.GlobalFilterBy} {Phrases.GlobalUser}";

            dgvMovements.Columns[1].HeaderText = Phrases.GlobalDate;
            dgvMovements.Columns[2].HeaderText = Phrases.GlobalUser;
            dgvMovements.Columns[3].HeaderText = Phrases.GlobalReference;
            dgvMovements.Columns[4].HeaderText = Phrases.GlobalProduct;
            dgvMovements.Columns[5].HeaderText = Phrases.GlobalMovement;
            dgvMovements.Columns[6].HeaderText = Phrases.StockMovementQty;
            dgvMovements.Columns[7].HeaderText = Phrases.StockMovementStockAcc;
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
    }
}
