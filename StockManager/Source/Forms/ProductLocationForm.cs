using System;
using System.Windows.Forms;

using StockManager.Database.Source.Models;
using StockManager.Services.Source;
using StockManager.Source.Components;
using StockManager.Source.UserControls;
using StockManager.Translations.Source;
using StockManager.Types.Source;
using StockManager.Utilities.Source;

namespace StockManager.Source.Forms
{
    public partial class ProductLocationForm : Form
    {
        private readonly InventoryProductLocationsUc _inventoryProductLocationsUc;
        private ProductLocation _productLocation = null;

        public ProductLocationForm(InventoryProductLocationsUc inventoryProductLocationsUc)
        {
            InitializeComponent();
            _inventoryProductLocationsUc = inventoryProductLocationsUc;
            SetTranslatedPhrases();
        }

        /// <summary>
        /// Show Location Form and set the initial values
        /// </summary>
        public void ShowLocationForm(ProductLocation productLocation)
        {
            _productLocation = productLocation;

            Text = AppInfo.GetViewTitle($"{_productLocation.Location.Name} | {Phrases.ProductLocationMinStockEdit}");
            lbTitle.Text = string.Format(Phrases.ProductLocationMinStockInfo, _productLocation.Product.Reference);

            // hide the error labels
            numMinStock.Value = decimal.Parse(productLocation.MinStock.ToString());

            ShowDialog();
        }

        /// <summary>
        /// Close button click
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Update button click
        /// </summary>
        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Spinner.InitSpinner();

                await AppServices.ProductLocationService.UpdateProductLocationMinStock(
                  _productLocation.ProductLocationId,
                  float.Parse(numMinStock.Value.ToString())
                );

                Spinner.StopSpinner();

                await _inventoryProductLocationsUc.LoadProductLocations();

                Close();
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
        }

        /// <summary>
        /// Set the content strings for the correct app language
        /// </summary>
        private void SetTranslatedPhrases()
        {
            lbMinStock.Text = Phrases.StockMovementMinStock;
            btnCancel.Text = Phrases.GlobalCancel;
            btnSave.Text = Phrases.GlobalSave;
        }
    }
}
