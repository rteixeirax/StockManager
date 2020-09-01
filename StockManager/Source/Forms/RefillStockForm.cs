using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using StockManager.Core.Source;
using StockManager.Core.Source.Types;
using StockManager.Services.Source;
using StockManager.Source.Components;
using StockManager.Source.UserControls;
using StockManager.Translations.Source;

namespace StockManager.Source.Forms
{
    public partial class RefillStockForm : Form
    {
        private readonly DashboardUc _dashboardUc;
        private readonly int _locationId;
        private readonly int _productId;
        private readonly string _productName;

        public RefillStockForm(DashboardUc dashboardUc, int locationId, int productId, string productName)
        {
            InitializeComponent();

            _dashboardUc = dashboardUc;
            _locationId = locationId;
            _productId = productId;
            _productName = productName;

            SetTranslatedPhrases();
        }

        public void ShowRefilStockForm(float currentStock, float refillQty)
        {
            numCurrentStock.Value = ( decimal )currentStock;
            numRefillQty.Value = ( decimal )refillQty;

            lbErrorCurrentStock.Visible = false;
            lbErrorRefillQty.Visible = false;

            ShowDialog();
        }

        private void SetTranslatedPhrases()
        {
            Text = AppInfo.GetViewTitle(Phrases.RefillStock);

            lbTitle.Text = $"{Phrases.GlobalProduct}: {_productName}";

            lbCurrentStock.Text = Phrases.RefillStockStockAtEndOfShift;
            lbRefillQty.Text = Phrases.RefillStockRefilledQty;

            btnCancel.Text = Phrases.GlobalCancel;
            btnSave.Text = Phrases.GlobalSave;
        }

        private async void btnSave_Click(object sender, System.EventArgs e)
        {
            try
            {
                Spinner.InitSpinner();

                float currentStock = float.Parse(numCurrentStock.Value.ToString());
                float refilledQty = float.Parse(numRefillQty.Value.ToString());

                await AppServices.StockMovementService.RefillStockAsync(
                    _locationId,
                    _productId,
                    currentStock,
                    refilledQty,
                    Program.LoggedInUser.UserId
                );

                Spinner.StopSpinner();

                // Update the table with the new data
                await _dashboardUc.UpdateTable(refilledQty);

                // Close the dialog
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

        private void ShowFormErrors(List<ErrorType> errors)
        {
            lbErrorCurrentStock.Visible = false;
            lbErrorRefillQty.Visible = false;

            foreach (ErrorType err in errors)
            {
                if (err.Field == "CurrentStock")
                {
                    lbErrorCurrentStock.Text = err.Error;
                    lbErrorCurrentStock.Visible = true;
                }

                if (err.Field == "RefillQty")
                {
                    lbErrorRefillQty.Text = err.Error;
                    lbErrorRefillQty.Visible = true;
                }
            }
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
