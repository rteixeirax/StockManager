using System;
using System.Collections.Generic;
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
    public partial class InventoryLocationsUc : UserControl
    {
        private readonly MainForm _mainForm;
        private bool _hasBeenSearching = false; // Flags if the user has been searching

        public InventoryLocationsUc(MainForm mainForm)
        {
            InitializeComponent();

            // Pass the main form to this UC to handle with location products UC
            _mainForm = mainForm;

            // Hide the X button on the search textbox
            btnClearSearchValue.Visible = false;
            SetTranslatedPhrases();
            LoadLocationsAsync().Wait();
        }

        /// <summary>
        /// Fill the Data Grid View
        /// </summary>
        public async Task LoadLocationsAsync(string searchValue = null)
        {
            Spinner.InitSpinner();
            ;
            dgvLocations.Rows.Clear();

            IEnumerable<Location> locations = await AppServices.LocationService
              .GetAllAsync(searchValue);

            foreach (Location location in locations)
            {
                dgvLocations.Rows.Add(
                  location.LocationId,
                  location.Name,
                  location.ProductLocations.Count,
                  location.CreatedAt.ShortDateWithTime()
                );
            }

            Spinner.StopSpinner();
        }

        /// <summary>
        /// Delete button click
        /// </summary>
        private async Task ActionDeleteClickAsync(int[] selectedIds)
        {
            if ((selectedIds.Length > 0) && MessageBox.Show(
            string.Format(Phrases.LocationDialogDeleteBody, selectedIds.Length),
            Phrases.GlobalDialogDeleteTitle,
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes
          )
            {
                try
                {
                    Spinner.InitSpinner();

                    await AppServices.LocationService
                      .DeleteAsync(selectedIds, Program.LoggedInUser.UserId);

                    Spinner.StopSpinner();

                    await LoadLocationsAsync();
                }
                catch (OperationErrorException ex)
                {
                    Spinner.StopSpinner();

                    MessageBox.Show(
                      $"{ex.Errors[0].Error}",
                      Phrases.GlobalDialogWarningTitle,
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Warning
                    );
                }
                catch (ServiceErrorException ex)
                {
                    Spinner.StopSpinner();

                    MessageBox.Show(
                      $"{ex.Errors[0].Error}",
                      Phrases.GlobalDialogErrorTitle,
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Error
                    );
                }
            }
        }

        /// <summary>
        /// Show the location products UC
        /// </summary>
        private async Task ActionDetailsClickAsync(int locationId)
        {
            Spinner.InitSpinner();
            Location location = await AppServices.LocationService.GetByIdAsync(locationId);
            Spinner.StopSpinner();

            _mainForm.ShowProducLocationsFromLocationsUc(location);
        }

        /// <summary>
        /// Edit product button click
        /// </summary>
        private async Task ActionEditClickAsync(int locationId)
        {
            Spinner.InitSpinner();
            Location location = await AppServices.LocationService.GetByIdAsync(locationId);
            Spinner.StopSpinner();

            LocationForm locationForm = new LocationForm(this);
            locationForm.ShowLocationForm(location);
        }

        /// <summary>
        /// Clear search value on picture box click
        /// </summary>
        private async void btnClearSearchValue_Click(object sender, EventArgs e)
        {
            tbSeachText.Text = "";
            _hasBeenSearching = false;
            await LoadLocationsAsync();
        }

        /// <summary>
        /// Create location button click
        /// </summary>
        private void btnCreate_Click(object sender, EventArgs e)
        {
            LocationForm locationForm = new LocationForm(this);
            locationForm.ShowLocationForm();
        }

        /// <summary>
        /// Delete multiple button click
        /// </summary>
        private async void btnDelete_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection selectedItems = dgvLocations.SelectedRows;

            if (selectedItems.Count > 0)
            {
                int[] arrayOfIds = new int[selectedItems.Count];

                for (int i = 0; i < selectedItems.Count; i++)
                {
                    arrayOfIds[i] = int.Parse(selectedItems[i].Cells[0].Value.ToString());
                }

                await ActionDeleteClickAsync(arrayOfIds);
            }
        }

        /// <summary>
        /// Handle with table actions click
        /// </summary>
        private async void dgvLocations_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((dgvLocations.SelectedRows.Count > 0) && (e.RowIndex >= 0))
            {
                int locationId = int.Parse(dgvLocations.Rows[e.RowIndex].Cells[0].Value.ToString());

                switch (e.ColumnIndex)
                {
                    case 4:
                        await ActionEditClickAsync(locationId);
                        break;

                    case 5:
                        await ActionDetailsClickAsync(locationId);
                        break;

                    case 6:
                        await ActionDeleteClickAsync(new int[] { locationId });
                        break;

                    default:
                        break;
                }
            }
        }

        /// <summary>
        /// Search button click
        /// </summary>
        private async void pbSearchIcon_Click(object sender, EventArgs e)
        {
            string searchValue = tbSeachText.Text;

            if (!string.IsNullOrEmpty(searchValue))
            {
                // sets the flag has been searching
                _hasBeenSearching = true;

                await LoadLocationsAsync(searchValue);
            }
        }

        /// <summary>
        /// Set the content strings for the correct app language
        /// </summary>
        private void SetTranslatedPhrases()
        {
            btnCreate.Text = Phrases.GlobalCreate;
            btnDelete.Text = Phrases.GlobalDelete;
            dgvLocations.Columns[1].HeaderText = Phrases.GlobalName;
            dgvLocations.Columns[2].HeaderText = Phrases.GlobalProducts;
            dgvLocations.Columns[3].HeaderText = Phrases.GlobalCreatedAt;
            // Actions
            dgvLocations.Columns[4].CellTemplate.ToolTipText = Phrases.GlobalEdit; // Action edit
            dgvLocations.Columns[5].CellTemplate.ToolTipText = Phrases.GlobalProducts; // Action details
            dgvLocations.Columns[6].CellTemplate.ToolTipText = Phrases.GlobalDelete; // Action delete
        }

        /// <summary>
        /// Call search button click when pressed enter in the textbox
        /// </summary>
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

        /// <summary>
        /// Show/Hide the X button on the search textbox
        /// </summary>
        private async void tbSeachText_TextChanged(object sender, EventArgs e)
        {
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
                await LoadLocationsAsync();
            }
        }
    }
}
