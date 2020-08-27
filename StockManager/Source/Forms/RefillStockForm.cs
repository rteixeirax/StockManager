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
            Text = AppInfo.GetViewTitle("Refill stock"); // TODO: Change this

            lbTitle.Text = $"{Phrases.GlobalProduct}: {_productName}";

            // TODO: Change this
            lbCurrentStock.Text = "Current stock";
            lbRefillQty.Text = "Refill qty";

            btnCancel.Text = Phrases.GlobalCancel;
            btnSave.Text = Phrases.GlobalSave;
        }

        private async void btnSave_Click(object sender, System.EventArgs e)
        {
            try
            {
                Spinner.InitSpinner();

                float currentStock = float.Parse(numCurrentStock.Value.ToString());
                float refiledlQty = float.Parse(numRefillQty.Value.ToString());

                await AppServices.StockMovementService.RefillStockAsync(
                    _locationId,
                    _productId,
                    currentStock,
                    refiledlQty,
                    Program.LoggedInUser.UserId
                );

                Spinner.StopSpinner();

                // TODO: Create a function in the DashboardUC that recive
                // the locationId, productId, currentStock and the refilledQty.
                // That function should update the table with that values.

                btnCancel_Click(sender, e);

                // TODO: add a catch to catch the DB errors and show an message box to the user
            }
            catch (OperationErrorException ex)
            {
                Spinner.StopSpinner();

                if (ex.Errors.Any())
                {
                    ShowFormErrors(ex.Errors);
                }
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

                if (err.Field == "qty")
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
