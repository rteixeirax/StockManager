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
    private readonly Location _location;

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
    /// Set the content strings for the correct app language
    /// </summary>
    private void SetTranslatedPhrases()
    {
      btnback.Text = Phrases.GlobalBack;

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
          Format.DateTimeFormat(stockMovement.CreatedAt),
          "", // The name column only render for the location stock movement
          this.ConcatMovementString(stockMovement),
          stockMovement.Qty,
          stockMovement.Stock,
          stockMovement.User?.Username
        );
        });
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
         Format.DateTimeFormat(stockMovement.CreatedAt),
         stockMovement.Product.Name,
         this.ConcatMovementString(stockMovement),
         stockMovement.Qty,
         stockMovement.Stock,
         stockMovement.User?.Username
       );
      });
    }

    /// <summary>
    /// Concat the "from" and "to" location names.
    /// </summary>
    private string ConcatMovementString(StockMovement stockMovement)
    {
      string fromLocation = (stockMovement.FromLocation != null)
          ? stockMovement.FromLocation.Name
          : stockMovement.FromLocationName;

      string toLocation = (stockMovement.ToLocation != null)
        ? stockMovement.ToLocation.Name
        : stockMovement.ToLocationName;

      string concat = $"{Phrases.StockMovementFrom}: {(fromLocation ?? "---")}"
        + Environment.NewLine
        + $"{Phrases.StockMovementTo}: {toLocation}";

      return concat;
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

    private async Task ActionEditClickAsync(int id)
    {
      Spinner.InitSpinner();

      ProductLocation productLocation = await AppServices.ProductLocationService.GetProductLocationByIdAsync(id);
      Spinner.StopSpinner();
      ProductLocationForm productLocationForm = new ProductLocationForm(this);
      productLocationForm.ShowLocationForm(productLocation);
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
  }
}
