using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockManager.Storage.Source.Models;
using StockManager.Source.Forms;
using StockManager.Translations.Source;
using StockManager.Source.Components;
using StockManager.Services.Source;
using StockManager.Utilities.Source;
using System.Drawing;

namespace StockManager.Source.UserControls {
  public partial class InventoryProductLocationsUserControl : UserControl {
    private readonly MainForm _mainForm;
    private readonly Product _product;

    public InventoryProductLocationsUserControl(MainForm mainForm, Product product) {
      InitializeComponent();

      // Set the MainForm pointer
      _mainForm = mainForm;

      // Set the selected product
      _product = product;

      // Set initial state
      lbErrorLocation.Visible = false;
      lbErrorMinStock.Visible = false;
      lbErrorQty.Visible = false;

      this.SetTranslatedPhrases();
      this.LoadProductLocationsAsync().Wait();
    }

    /// <summary>
    /// Set the content strings for the correct app language
    /// </summary>
    private void SetTranslatedPhrases() {
      btnback.Text = Phrases.GlobalBack;
      btnAddLocation.Text = Phrases.GlobalAdd;

      lbLocation.Text = Phrases.GlobalLocation;
      lbQty.Text = Phrases.StockMovementQty;
      lbMinStock.Text = Phrases.StockMovementMinStock;
      lbFormTitle.Text = Phrases.ProductLocationAddToLocation;
      dgvProductLocations.Columns[1].HeaderText = Phrases.ProductLocationTableHeader;
      dgvProductLocations.Columns[2].HeaderText = Phrases.StockMovementQty;
      dgvProductLocations.Columns[3].HeaderText = Phrases.StockMovementMinStock;
      dgvProductLocations.Columns[4].CellTemplate.ToolTipText = Phrases.GlobalDelete;

      lbProductStockMovements.Text = Phrases.StockMovementsLabel;
      dgvProductStockMovements.Columns[1].HeaderText = Phrases.GlobalDate;
      dgvProductStockMovements.Columns[2].HeaderText = Phrases.StockMovementFrom;
      dgvProductStockMovements.Columns[3].HeaderText = Phrases.StockMovementTo;
      dgvProductStockMovements.Columns[4].HeaderText = Phrases.StockMovementQty;
      dgvProductStockMovements.Columns[5].HeaderText = Phrases.StockMovementStockAcc;
      dgvProductStockMovements.Columns[6].HeaderText = Phrases.GlobalUser;
    }


    /// <summary>
    /// Fill the UC content
    /// </summary>
    private async Task LoadProductLocationsAsync() {
      Spinner.InitSpinner();

      dgvProductLocations.Rows.Clear();
      dgvProductStockMovements.Rows.Clear();

      // Get locations for the dropdown
      IEnumerable<Location> locations = await AppServices.LocationService.GetLocationsAsync();
      cbLocations.DataSource = locations;
      cbLocations.ValueMember = "LocationId";
      cbLocations.DisplayMember = "Name";

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
        .ToList().ForEach((stockMovement) => {
          dgvProductStockMovements.Rows.Add(
           stockMovement.StockMovementId,
           Format.DateTimeFormat(stockMovement.CreatedAt),
           stockMovement.FromLocation?.Name,
           stockMovement.ToLocation?.Name,
           stockMovement.Qty,
           stockMovement.Stock,
           stockMovement.User.Username
         );
        });

      Spinner.StopSpinner();
    }

    /// <summary>
    /// Go back to products list
    /// </summary>
    private void btnback_Click(object sender, EventArgs e) {
      _mainForm.btnInventoryProducts_Click(sender, e);
    }

    /// <summary>
    /// Remove product location button click
    /// </summary>
    private void dgvProductLocations_CellContentClick(object sender, DataGridViewCellEventArgs e) {
      if (e.ColumnIndex == 4) {
        //Write here your code...
        int productLocationId = int.Parse(dgvProductLocations.Rows[e.RowIndex].Cells[0].Value.ToString());

        // TODO: Write the code
        // - Show dialog
        // - If yes, delete the location
        // Same a the normal delete
        MessageBox.Show("You will delete the product location ID: " + productLocationId);
      }
    }
  }
}
