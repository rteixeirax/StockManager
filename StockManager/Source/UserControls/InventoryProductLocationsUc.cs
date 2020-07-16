using StockManager.Database.Source.Models;
using StockManager.Services.Source;
using StockManager.Source.Components;
using StockManager.Source.Extensions;
using StockManager.Source.Forms;
using StockManager.Translations.Source;
using StockManager.Types.Source;
using StockManager.Utilities.Source;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManager.Source.UserControls
{
    public partial class InventoryProductLocationsUc : UserControl
    {
        private readonly Location _location;
        private readonly MainForm _mainForm;
        private readonly Product _product;

        public InventoryProductLocationsUc(MainForm mainForm, Product product = null, Location location = null)
        {
            InitializeComponent();

            // Set the MainForm pointer
            _mainForm = mainForm;

            // Set the selected product/location
            _product = product;
            _location = location;

            // Show/hide the stock movement product name column
            columnName.Visible = (location != null);

            this.SetTranslatedPhrases();
            this.LoadProductLocations().Wait();
        }

        /// <summary>
        /// Fill the UC content
        /// </summary>
        public async Task LoadProductLocations()
        {
            Spinner.InitSpinner();

            dgvProductLocations.Rows.Clear();
            dgvProductStockMovements.Rows.Clear();

            if (_product != null)
            {
                this.LoadDataByProduct();
            }
            else
            {
                await this.LoadDataByLocation();
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

                    if (_product != null)
                    {
                        await AppServices.ProductLocationService
                          .DeleteProductLocationAsyn(id, Program.LoggedInUser.UserId);
                    }
                    else
                    {
                        await AppServices.ProductLocationService
                          .DeleteProductLocationAsyn(id, Program.LoggedInUser.UserId);
                    }

                    // Reload Ui
                    await this.LoadProductLocations();
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

            ProductLocation productLocation = await AppServices.ProductLocationService.GetProductLocationByIdAsync(id);
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

        private async void btnStockMovement_Click(object sender, EventArgs e)
        {
            ManualStockMovementForm manualStockMovementForm = new ManualStockMovementForm(this, _product, _location);
            await manualStockMovementForm.ShowManualStockMovementFormAsync();
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
                    case 4:
                        await this.ActionEditClickAsync(id);
                        break;

                    case 5:
                        await this.ActionDeleteClickAsync(id);
                        break;

                    default:
                        break;
                }
            }
        }

        /// <summary>
        /// Populate the UC data for the given location
        /// </summary>
        private async Task LoadDataByLocation()
        {
            // fill the Location products table
            _location.ProductLocations?.ToList().ForEach((productLocation) => {
                dgvProductLocations.Rows.Add(
                 productLocation.ProductLocationId,
                 productLocation.Product.Name,
                 productLocation.Stock,
                 productLocation.MinStock
               );
            });

            // fill the location stock movements table
            IEnumerable<StockMovement> stockMovements = await AppServices.LocationService
              .GetLocationStockMovements(_location.LocationId);

            stockMovements.ToList().ForEach((stockMovement) => {
                dgvProductStockMovements.Rows.Add(
                 stockMovement.StockMovementId,
                 stockMovement.CreatedAt.ShortDateWithTime(),
                 stockMovement.Product.Name,
                 stockMovement.ConcatMovementString(),
                 stockMovement.Qty,
                 stockMovement.Stock,
                 stockMovement.User?.Username
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
                 productLocation.Location.Name,
                 productLocation.Stock,
                 productLocation.MinStock
               );
            });

            // populate the stock movments table
            _product.StockMovements?.OrderByDescending(x => x.CreatedAt)
              .ToList()
              .ForEach((stockMovement) => {
                  dgvProductStockMovements.Rows.Add(
              stockMovement.StockMovementId,
              stockMovement.CreatedAt.ShortDateWithTime(),
              "", // The name column only render for the location stock movement
              stockMovement.ConcatMovementString(),
              stockMovement.Qty,
              stockMovement.Stock,
              stockMovement.User?.Username
            );
              });
        }

        /// <summary>
        /// Set the content strings for the correct app language
        /// </summary>
        private void SetTranslatedPhrases()
        {
            btnback.Text = Phrases.GlobalBack;
            btnStockMovement.Text = Phrases.GlobalCreateMov;

            dgvProductLocations.Columns[1].HeaderText = (_product != null)
              ? Phrases.ProductLocationTableHeader
              : Phrases.GlobalProduct;

            dgvProductLocations.Columns[2].HeaderText = Phrases.StockMovementsStock;
            dgvProductLocations.Columns[3].HeaderText = Phrases.StockMovementMinStock;
            dgvProductLocations.Columns[4].CellTemplate.ToolTipText = Phrases.GlobalEdit;
            dgvProductLocations.Columns[5].CellTemplate.ToolTipText = Phrases.GlobalDelete;

            lbProductStockMovements.Text = Phrases.StockMovementsLabel;
            dgvProductStockMovements.Columns[1].HeaderText = Phrases.GlobalDate;
            dgvProductStockMovements.Columns[2].HeaderText = Phrases.GlobalProduct;
            dgvProductStockMovements.Columns[3].HeaderText = Phrases.GlobalMovement;
            dgvProductStockMovements.Columns[4].HeaderText = Phrases.StockMovementQty;
            dgvProductStockMovements.Columns[5].HeaderText = Phrases.StockMovementStockAcc;
            dgvProductStockMovements.Columns[6].HeaderText = Phrases.GlobalUser;
        }
    }
}
