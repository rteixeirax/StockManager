using StockManager.Database.Source.Models;
using StockManager.Services.Source;
using StockManager.Source.Components;
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
    private readonly MainForm _mainForm;
    private readonly Product _product;

    public InventoryProductLocationsUc(MainForm mainForm, Product product)
    {
      InitializeComponent();

      // Set the MainForm pointer
      _mainForm = mainForm;

      // Set the selected product
      _product = product;

      this.SetTranslatedPhrases();
      this.LoadProductLocations();
    }

    /// <summary>
    /// Set the content strings for the correct app language
    /// </summary>
    private void SetTranslatedPhrases()
    {
      btnback.Text = Phrases.GlobalBack;
     
      dgvProductLocations.Columns[1].HeaderText = Phrases.ProductLocationTableHeader;
      dgvProductLocations.Columns[2].HeaderText = Phrases.StockMovementsStock;
      dgvProductLocations.Columns[3].HeaderText = Phrases.StockMovementMinStock;
      dgvProductLocations.Columns[4].CellTemplate.ToolTipText = Phrases.GlobalEdit;
      dgvProductLocations.Columns[5].CellTemplate.ToolTipText = Phrases.GlobalDelete;

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
    public void LoadProductLocations()
    {
      Spinner.InitSpinner();

      dgvProductLocations.Rows.Clear();
      dgvProductStockMovements.Rows.Clear();

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
          string fromLocation = (stockMovement.FromLocation != null)
            ? stockMovement.FromLocation.Name
            : stockMovement.FromLocationName;

          string toLocation = (stockMovement.ToLocation != null)
            ? stockMovement.ToLocation.Name
            : stockMovement.ToLocationName;

          dgvProductStockMovements.Rows.Add(
           stockMovement.StockMovementId,
           Format.DateTimeFormat(stockMovement.CreatedAt),
           ((stockMovement.User == null) && (fromLocation != null)) ? $"*{fromLocation}" : fromLocation,
           ((stockMovement.User == null) && (toLocation != null)) ? $"*{toLocation}" : toLocation,
           stockMovement.Qty,
           stockMovement.Stock,
           stockMovement.User?.Username
         );
        });

      Spinner.StopSpinner();
    }

    /// <summary>
    /// Go back to products list
    /// </summary>
    private void btnback_Click(object sender, EventArgs e)
    {
      _mainForm.btnInventoryProducts_Click(sender, e);
    }

    /// <summary>
    /// Handle with table actions click
    /// </summary>
    private async void dgvProductLocations_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
      if ((dgvProductLocations.SelectedRows.Count > 0) && (e.RowIndex >= 0))
      {
        int productLocationId = int.Parse(dgvProductLocations.Rows[e.RowIndex].Cells[0].Value.ToString());
        string locationName = dgvProductLocations.Rows[e.RowIndex].Cells[1].Value.ToString();

        switch (e.ColumnIndex)
        {
          case 4:
            await this.ActionEditClickAsync(productLocationId);
            break;
          case 5:
            await this.ActionDeleteClickAsync(productLocationId, locationName);
            break;
          default:
            break;
        }
      }
    }

    private async Task ActionEditClickAsync(int productLocationId)
    {
      Spinner.InitSpinner();
      ProductLocation productLocation = await AppServices.ProductLocationService.GetProductLocationByIdAsync(productLocationId);
      Spinner.StopSpinner();

      ProductLocationForm productLocationForm = new ProductLocationForm(this);
      productLocationForm.ShowLocationForm(productLocation);
    }

    private async Task ActionDeleteClickAsync(int productLocationId, string locationName)
    {
      if ((productLocationId > 0) && MessageBox.Show(
       string.Format(Phrases.GlobalDialogDeleteProductLocationBody, locationName),
       Phrases.GlobalDialogDeleteTitle,
         MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes
       )
      {
        try
        {
          Spinner.InitSpinner();

          await AppServices.ProductLocationService
            .DeleteProductLocationAsyn(productLocationId, Program.LoggedInUser.UserId);

          // Reload Ui
          this.LoadProductLocations();
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
  }
}
