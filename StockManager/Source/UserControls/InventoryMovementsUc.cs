﻿using StockManager.Services.Source;
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
            this.LoadMovements().Wait();
        }

        public async Task LoadMovements()
        {
            Spinner.InitSpinner();
            dgvMovements.Rows.Clear();
            await this.LoadData();
            Spinner.StopSpinner();
        }

        private async void btnClearSearchValue_Click(object sender, System.EventArgs e)
        {
            tbSeachText.Text = "";
            _hasBeenSearching = false;
            await this.LoadData();
        }

        private async Task LoadData(string searchValue = "")
        {
            dgvMovements.Rows.Clear();
            var movements = await AppServices.StockMovementService.GetAllAsync(searchValue);
            movements.ToList().ForEach((stockMovement) =>
            {
                dgvMovements.Rows.Add(

                    stockMovement.StockMovementId,
                    stockMovement.CreatedAt.ShortDateWithTime(),
                    "",
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
            await this.LoadData(tbSeachText.Text);
        }

        private void SetTranslatedPhrases()
        {
            dgvMovements.Columns[1].HeaderText = Phrases.GlobalDate;
            dgvMovements.Columns[3].HeaderText = Phrases.GlobalProduct;
            dgvMovements.Columns[4].HeaderText = Phrases.GlobalMovement;
            dgvMovements.Columns[5].HeaderText = Phrases.StockMovementQty;
            dgvMovements.Columns[6].HeaderText = Phrases.StockMovementStockAcc;
            dgvMovements.Columns[7].HeaderText = Phrases.GlobalUser;
        }

        private void tbSeachText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.pbSearchIcon_Click(sender, e);
                // Remove the annoying beep
                e.Handled = true;
            }
            else if (e.KeyChar == (char)Keys.Escape)
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
            else if ((tbSeachText.Text.Any()) && _hasBeenSearching)
            {
                _hasBeenSearching = false;
                btnClearSearchValue.Visible = false;
                await this.LoadData();
            }
        }
    }
}