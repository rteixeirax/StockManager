using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using StockManager.Src.Data.Entities;
using StockManager.Src.Models;
using StockManager.Src.Services;
using StockManager.Src.Translations;
using StockManager.Src.Views.Components;
using StockManager.Src.Views.Forms;

namespace StockManager.Src.Views.UserControls
{
    public partial class InventoryProductLocationsUc : UserControl
    {
        private readonly Location _location;
        private readonly MainForm _mainForm;
        private readonly Product _product;

        public InventoryProductLocationsUc()
        {
            InitializeComponent();
        }

        // Called from the InventoryProductsUc
        public InventoryProductLocationsUc(MainForm mainForm, Product product) : this()
        {
            // Set the MainForm pointer
            _mainForm = mainForm;

            // Set the selected product
            _product = product;

            // Hide product locations table ref column
            columnReference.Visible = false;

            SetTranslatedPhrases();
            LoadProductLocations();
        }

        // Called from the InventoryLocationsUc
        public InventoryProductLocationsUc(MainForm mainForm, Location location) : this()
        {
            // Set the MainForm pointer
            _mainForm = mainForm;

            // Set the selected location
            _location = location;

            // Show product locations table ref column
            columnReference.Visible = true;

            SetTranslatedPhrases();
            LoadProductLocations();
        }

        /// <summary>
        /// Fill the UC content
        /// </summary>
        public void LoadProductLocations()
        {
            Spinner.InitSpinner();

            dgvProductLocations.Rows.Clear();

            if (_product != null)
            {
                LoadDataByProduct();
            }
            else if (_location != null)
            {
                LoadDataByLocation();
            }

            Spinner.StopSpinner();
        }

        private async Task ActionDeleteClickAsync(int id)
        {
            if ((id > 0) && MessageBox.Show(
             Phrases.GlobalDialogDeleteProductLocationBody,
             Phrases.GlobalDialogDeleteTitle,
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes
             )
            {
                try
                {
                    Spinner.InitSpinner();

                    await AppServices.ProductLocationService
                      .DeleteAsyn(id, Program.LoggedInUser.UserId);

                    // Reload Ui
                    LoadProductLocations();

                    Spinner.StopSpinner();
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

        private async Task ActionEditClickAsync(int id)
        {
            Spinner.InitSpinner();

            ProductLocation productLocation = await AppServices.ProductLocationService.GetByIdAsync(id);
            Spinner.StopSpinner();
            ProductLocationForm productLocationForm = new ProductLocationForm(this);
            productLocationForm.ShowLocationForm(productLocation);
        }

        /// <summary>
        /// Go back to products/locations list
        /// </summary>
        private void btnback_Click(object sender, EventArgs e)
        {
            if (_product != null)
            {
                _mainForm.btnInventoryProducts_Click(sender, e);
            }
            else
            {
                _mainForm.btnInventoryLocations_Click(sender, e);
            }
        }

        private async void btnCreatePdf_Click(object sender, EventArgs e)
        {
            try
            {
                ICollection<ProductLocation> productLocations = (_product != null)
                    ? _product?.ProductLocations
                    : _location?.ProductLocations;

                if (!productLocations.Any())
                {
                    MessageBox.Show(Phrases.GlobalDialogExportWarningBody, Phrases.GlobalDialogWarningTitle,
                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (MessageBox.Show(Phrases.GlobalDialogExportBody, Phrases.GlobalDialogExportTitle,
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Spinner.InitSpinner();

                    if (_location != null)
                    {
                        await AppServices.ProductLocationService
                            .ExportProductLocationsFromLocationToPDFAsync(productLocations);
                    }
                    else
                    {
                        await AppServices.ProductLocationService
                            .ExportProductLocationsFromProductToPDFAsync(productLocations);
                    }

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
            if (_product != null)
            {
                ManualStockMovementForm manualStockMovementForm = new ManualStockMovementForm(this, _product);
                await manualStockMovementForm.ShowManualStockMovementFormAsync();
            }
            else if (_location != null)
            {
                ManualStockMovementForm manualStockMovementForm = new ManualStockMovementForm(this, _location);
                await manualStockMovementForm.ShowManualStockMovementFormAsync();
            }
        }

        /// <summary>
        /// Handle with table actions click
        /// </summary>
        private async void dgvProductLocations_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((dgvProductLocations.SelectedRows.Count > 0) && (e.RowIndex >= 0))
            {
                int id = int.Parse(dgvProductLocations.Rows[e.RowIndex].Cells[0].Value.ToString());

                switch (e.ColumnIndex)
                {
                    case 5:
                        await ActionEditClickAsync(id);
                        break;

                    case 6:
                        await ActionDeleteClickAsync(id);
                        break;

                    default:
                        break;
                }
            }
        }

        /// <summary>
        /// Populate the UC data for the given location
        /// </summary>
        private void LoadDataByLocation()
        {
            // fill the Location products table
            _location.ProductLocations?.ToList().ForEach((productLocation) => {
                dgvProductLocations.Rows.Add(
                 productLocation.ProductLocationId,
                 productLocation.Product.Reference,
                 productLocation.Product.Name,
                 productLocation.Stock,
                 productLocation.MinStock
               );
            });
        }

        /// <summary>
        /// Populate the UC data for the given product
        /// </summary>
        private void LoadDataByProduct()
        {
            // fill the ProductLocations table
            _product.ProductLocations?.ToList().ForEach((productLocation) => {
                dgvProductLocations.Rows.Add(
                 productLocation.ProductLocationId,
                 "", // The ref column only render for the location
                 productLocation.Location.Name,
                 productLocation.Stock,
                 productLocation.MinStock
               );
            });
        }

        /// <summary>
        /// Set the content strings for the correct app language
        /// </summary>
        private void SetTranslatedPhrases()
        {
            btnback.Text = Phrases.GlobalBack;
            btnCreatePdf.Text = Phrases.GlobalExportToPDF;
            btnStockMovement.Text = Phrases.GlobalCreateMov;

            dgvProductLocations.Columns[1].HeaderText = Phrases.GlobalReference;

            dgvProductLocations.Columns[2].HeaderText = (_product != null)
              ? Phrases.ProductLocationTableHeader
              : Phrases.GlobalProduct;

            dgvProductLocations.Columns[3].HeaderText = Phrases.StockMovementsStock;
            dgvProductLocations.Columns[4].HeaderText = Phrases.StockMovementMinStock;
            dgvProductLocations.Columns[5].CellTemplate.ToolTipText = Phrases.GlobalEdit;
            dgvProductLocations.Columns[6].CellTemplate.ToolTipText = Phrases.GlobalDelete;
        }
    }
}
