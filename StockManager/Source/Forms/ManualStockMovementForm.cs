using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using StockManager.Core.Source;
using StockManager.Core.Source.Models;
using StockManager.Core.Source.Types;
using StockManager.Services.Source;
using StockManager.Source.Components;
using StockManager.Source.UserControls;
using StockManager.Translations.Source;

namespace StockManager.Source.Forms
{
    public partial class ManualStockMovementForm : Form
    {
        private readonly DashboardAdminUc _dashboardAdminUc;
        private readonly InventoryMovementsUc _inventoryMovementsUc;
        private readonly InventoryProductLocationsUc _inventoryProductLocationsUc;
        private readonly Location _location;
        private readonly Product _product;
        private IEnumerable<Location> _locations;

        public ManualStockMovementForm()
        {
            InitializeComponent();
            SetTranslatedPhrases();
        }

        // Called from the Products InventoryProductLocationsUc
        public ManualStockMovementForm(InventoryProductLocationsUc inventoryProductLocationsUc, Product product) : this()
        {
            _inventoryProductLocationsUc = inventoryProductLocationsUc;
            _product = product;
        }

        // Called from the Locations InventoryProductLocationsUc
        public ManualStockMovementForm(InventoryProductLocationsUc inventoryProductLocationsUc, Location location) : this()
        {
            _inventoryProductLocationsUc = inventoryProductLocationsUc;
            _location = location;
        }

        // Called from the InventoryMovementsUc
        public ManualStockMovementForm(InventoryMovementsUc inventoryMovementsUc, Location location) : this()
        {
            _inventoryMovementsUc = inventoryMovementsUc;
            _location = location;
        }

        // Called from the DashboardAdminUc
        public ManualStockMovementForm(DashboardAdminUc dashboardAdminUc, Location location) : this()
        {
            _dashboardAdminUc = dashboardAdminUc;
            _location = location;
        }

        public async Task ShowManualStockMovementFormAsync()
        {
            Text = AppInfo.GetViewTitle(Phrases.StockMovementCreate);

            // hide the error labels
            lbErrorQty.Visible = false;

            Spinner.InitSpinner();

            // Get the locations
            _locations = await AppServices.LocationService.GetAllAsync();

            SetFormComboboxesData();

            Spinner.StopSpinner();
            ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Spinner.InitSpinner();

                Location fromLocation = ( Location )cbFrom.SelectedItem;
                Location toLocation = ( Location )cbTo.SelectedItem;
                Product product = ( Product )cbProduct.SelectedItem;
                float qty = float.Parse(numQty.Value.ToString());

                if (checkMainLocationMoves.Checked)
                {
                    await AppServices.StockMovementService.CreateMovementInsideMainLocationAsync(
                      product.ProductId,
                      qty,
                      (toLocation.LocationId == 0), // 0: entry; -1: exit;
                      Program.LoggedInUser.UserId
                    );
                }
                else
                {
                    await AppServices.StockMovementService.MoveStockBetweenLocationsAsync(
                      fromLocation.LocationId,
                      toLocation.LocationId,
                      product.ProductId,
                      qty,
                      Program.LoggedInUser.UserId
                    );
                }

                Spinner.StopSpinner();

                // Update stock movements table
                if (_inventoryMovementsUc != null)
                {
                    await _inventoryMovementsUc.LoadMovementsAsync();
                }
                else if (_inventoryProductLocationsUc != null)
                {
                    await _inventoryProductLocationsUc.LoadProductLocations();
                }
                else
                {
                    await _dashboardAdminUc.LoadDataAsync();
                }

                // Close form
                btnCancel_Click(sender, e);
            }
            catch (OperationErrorException ex)
            {
                Spinner.StopSpinner();

                if (ex.Errors.Any())
                {
                    ShowFormErrors(ex.Errors);
                }
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

        /// <summary>
        /// When the From cb change, need to reset the Product cb data
        /// </summary>
        private void cbFrom_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Location fromLocation = ( Location )cbFrom.SelectedItem;
            Location toLocation = ( Location )cbTo.SelectedItem;

            // Set the new To location data by remove the From location from the list
            cbTo.DataSource = _locations.Where(x => x.LocationId != fromLocation.LocationId).ToList();

            // If the new From location isn't the selecetd To location, keep it. Otherwise the To
            // location will be cleared
            if (fromLocation.LocationId != toLocation.LocationId)
            {
                cbTo.SelectedItem = toLocation;
            }

            SetProductComboboxData(fromLocation);
        }

        private void checkMainLocationMoves_Click(object sender, EventArgs e)
        {
            Spinner.InitSpinner();

            if (checkMainLocationMoves.Checked)
            {
                lbFrom.Text = Phrases.GlobalMainLocation;
                lbTo.Text = Phrases.GlobalMovement;

                // Get the main location
                Location mainLocation = _locations.First(x => x.IsMain == true);
                cbFrom.SelectedItem = mainLocation;

                List<Location> entryExitMovements = new List<Location>
                {
                  new Location() { LocationId = 0, Name = Phrases.GlobalMovementEntry },
                  new Location() { LocationId = -1, Name = Phrases.GlobalMovementExit }
                };

                //cbTo.BindingContext = new BindingContext();
                cbTo.DataSource = entryExitMovements;

                SetProductComboboxData(mainLocation);
            }
            else
            {
                SetFormComboboxesData();
            }

            cbFrom.Enabled = !checkMainLocationMoves.Checked;

            Spinner.StopSpinner();
        }

        private void SetFormComboboxesData()
        {
            // From
            cbFrom.DataSource = _locations;
            cbFrom.ValueMember = "LocationId";
            cbFrom.DisplayMember = "Name";

            // Get the main location
            Location fromLocation = _locations.First(x => x.IsMain == true);

            // Set the From location if the form was called from the InventoryLocationUc / InventoryMovementsUc
            if (_location != null)
            {
                cbFrom.SelectedItem = _locations.First(x => x.LocationId == _location.LocationId);
                // set the fromLocation with the given location
                fromLocation = _location;
            }

            // To
            cbTo.BindingContext = new BindingContext();
            cbTo.DataSource = _locations.Where(x => x.LocationId != fromLocation.LocationId).ToList();
            cbTo.ValueMember = "LocationId";
            cbTo.DisplayMember = "Name";

            SetProductComboboxData(fromLocation);
        }

        private void SetProductComboboxData(Location fromLocation)
        {
            IEnumerable<Product> products = fromLocation.ProductLocations
             .Select((pl) => {
                 Product product = new Product
                 {
                     ProductId = pl.Product.ProductId,
                     Reference = pl.Product.Reference,
                     Name = $"{pl.Product.Name}({pl.Stock})",
                 };

                 return product;
             }).ToList();

            // Get the products
            cbProduct.DataSource = products;
            cbProduct.ValueMember = "ProductId";
            cbProduct.DisplayMember = "Name";

            // Set the Product if the form was called from the InventoryProductsUc
            if (_product != null)
            {
                cbProduct.SelectedItem = products.First(x => x.ProductId == _product.ProductId);
            }
        }

        private void SetTranslatedPhrases()
        {
            lbTitle.Text = Phrases.StockMovementManualMovement;
            checkMainLocationMoves.Text = Phrases.StockMovementOnlyMainLocation;
            lbFrom.Text = Phrases.StockMovementFrom;
            lbTo.Text = Phrases.StockMovementTo;
            lbProduct.Text = Phrases.GlobalProduct;
            lbQty.Text = Phrases.StockMovementQty;
            btnCancel.Text = Phrases.GlobalCancel;
            btnSave.Text = Phrases.GlobalSubmit;
        }

        private void ShowFormErrors(List<ErrorType> errors)
        {
            lbErrorQty.Visible = false;

            foreach (ErrorType err in errors)
            {
                if (err.Field == "qty")
                {
                    lbErrorQty.Text = err.Error;
                    lbErrorQty.Visible = true;
                }
            }
        }
    }
}
