using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockManager.Database.Source.Models;
using StockManager.Source.Forms;
using StockManager.Translations.Source;
using StockManager.Source.Components;
using StockManager.Services.Source;
using StockManager.Utilities.Source;
using StockManager.Types.Source;

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
      lbStock.Text = Phrases.StockMovementsStock;
      lbMinStock.Text = Phrases.StockMovementMinStock;
      lbFormTitle.Text = Phrases.ProductLocationAddToLocation;
      dgvProductLocations.Columns[1].HeaderText = Phrases.ProductLocationTableHeader;
      dgvProductLocations.Columns[2].HeaderText = Phrases.StockMovementsStock;
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

      // Set initial state
      lbErrorLocation.Visible = false;
      lbErrorStock.Visible = false;
      lbErrorMinStock.Visible = false;

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

    private void ShowFormErrors(List<ErrorType> errors) {
      lbErrorLocation.Visible = false;
      lbErrorStock.Visible = false;
      lbErrorMinStock.Visible = false;

      errors.ForEach((err) => {
        if (err.Field == "LocationId") {
          lbErrorLocation.Text = err.Error;
          lbErrorLocation.Visible = true;
        }

        if (err.Field == "Stock") {
          lbErrorStock.Text = err.Error;
          lbErrorStock.Visible = true;
        }

        if (err.Field == "MinStock") {
          lbErrorMinStock.Text = err.Error;
          lbErrorMinStock.Visible = true;
        }
      });
    }

    private async void btnAddLocation_Click(object sender, EventArgs e) {
      try {
        Spinner.InitSpinner();

        ProductLocation productLocation = new ProductLocation() {
          ProductId = _product.ProductId,
          LocationId = int.Parse(cbLocations.SelectedValue.ToString()),
          Stock = float.Parse(numStock.Value.ToString()),
          MinStock = float.Parse(numMinStock.Value.ToString())
        };

        await AppServices.ProductLocationService
          .AddProductLocationAsync(productLocation, Program.LoggedInUser.UserId);

        Spinner.StopSpinner();

        // Reload Ui
        await this.LoadProductLocationsAsync();
      } catch (OperationErrorException ex) {
        Spinner.StopSpinner();

        if (ex.Errors.Count() > 0) {
          this.ShowFormErrors(ex.Errors);
        }
      } catch (ServiceErrorException ex) {
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
    /// Remove product location button click
    /// </summary>
    private async void dgvProductLocations_CellContentClick(object sender, DataGridViewCellEventArgs e) {
      if ((e.ColumnIndex == 4) && (e.RowIndex >= 0)) {
        int productLocationId = int.Parse(dgvProductLocations.Rows[e.RowIndex].Cells[0].Value.ToString());
        string locationName = dgvProductLocations.Rows[e.RowIndex].Cells[1].Value.ToString();

        await this.ActionDeleteClickAsync(productLocationId, locationName);
      }
    }

    private async Task ActionDeleteClickAsync(int productLocationId, string locationName) {
      if ((productLocationId > 0) && MessageBox.Show(
       string.Format(Phrases.GlobalDialogDeleteBodyWithParam, locationName),
       Phrases.GlobalDialogDeleteTitle,
         MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes
       ) {
        try {
          Spinner.InitSpinner();

          await AppServices.ProductLocationService
            .DeleteProductLocationAsyn(productLocationId, Program.LoggedInUser.UserId);

          // Reload Ui
          await this.LoadProductLocationsAsync();
          Spinner.StopSpinner();

        } catch (ServiceErrorException ex) {
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
  }
}
