using StockManager.Database.Source.Models;
using StockManager.Services.Source;
using StockManager.Source.Components;
using StockManager.Source.UserControls;
using StockManager.Translations.Source;
using StockManager.Types.Source;
using StockManager.Utilities.Source;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManager.Source.Forms
{
  public partial class ManualStockMovementForm : Form
  {
    private readonly InventoryProductLocationsUc _inventoryProductLocationsUc;
    private readonly Product _product;
    private readonly Location _location;
    private IEnumerable<Location> _locations;

    public ManualStockMovementForm(
      InventoryProductLocationsUc inventoryProductLocationsUc,
      Product product,
      Location location
    )
    {
      InitializeComponent();

      _inventoryProductLocationsUc = inventoryProductLocationsUc;
      _product = product;
      _location = location;

      this.SetTranslatedPhrases();
    }

    private void SetTranslatedPhrases()
    {
      lbTitle.Text = Phrases.StockMovementManualMovement;
      lbFrom.Text = Phrases.StockMovementFrom;
      lbTo.Text = Phrases.StockMovementTo;
      lbProduct.Text = Phrases.GlobalProduct;
      lbQty.Text = Phrases.StockMovementQty;
      btnCancel.Text = Phrases.GlobalCancel;
      btnSave.Text = Phrases.GlobalSubmit;
    }

    public async Task ShowManualStockMovementFormAsync()
    {
      this.Text = AppInfo.GetViewTitle(Phrases.StockMovementCreate);

      // hide the error labels
      lbErrorQty.Visible = false;

      Spinner.InitSpinner();

      // Get the locations
      _locations = await AppServices.LocationService.GetLocationsAsync();

      // From 
      cbFrom.DataSource = _locations;
      cbFrom.ValueMember = "LocationId";
      cbFrom.DisplayMember = "Name";

      // Get the main location
      Location fromLocation = _locations.First(x => x.IsMain == true);

      // Set the From location if the form was called from the InventoryLocationUc
      if (_location != null)
      {
        cbFrom.SelectedItem = _locations.First(x => x.LocationId == _location.LocationId);
        // set the fromLocation with the given location
        fromLocation = _location;
      }

      // To
      cbTo.BindingContext = new BindingContext();
      cbTo.DataSource = _locations.Where(x => x.LocationId != fromLocation.LocationId).ToList();
      cbTo.ValueMember = "LocationId";
      cbTo.DisplayMember = "Name";

      //cbTo.SelectedItem = locations.First(x => x.LocationId != fromLocation.LocationId);

      this.SetProductComboboxData(fromLocation);

      Spinner.StopSpinner();
      this.ShowDialog();
    }

    private void SetProductComboboxData(Location fromLocation)
    {
      IEnumerable<Product> products = fromLocation.ProductLocations
       .Select((pl) => {
         Product product = new Product {
           ProductId = pl.Product.ProductId,
           Reference = pl.Product.Reference,
           Name = $"{pl.Product.Name}({pl.Stock})",
         };

         return product;
       }).ToList();

      // Get the products
      cbProduct.DataSource = products;
      cbProduct.ValueMember = "ProductId";
      cbProduct.DisplayMember = "Name";

      // Set the Product if the form was called from the InventoryProductsUc
      if (_product != null)
      {
        cbProduct.SelectedItem = products.First(x => x.ProductId == _product.ProductId);
      }
    }

    private void ShowFormErrors(List<ErrorType> errors)
    {
      lbErrorQty.Visible = false;

      foreach (ErrorType err in errors)
      {
        if (err.Field == "qty")
        {
          lbErrorQty.Text = err.Error;
          lbErrorQty.Visible = true;
        }
      }
    }

    /// <summary>
    /// When the From cb change, need to reset the Product cb data
    /// </summary>
    private void cbFrom_SelectionChangeCommitted(object sender, EventArgs e)
    {
      Location fromLocation = ( Location )cbFrom.SelectedItem;
      Location toLocation = ( Location )cbTo.SelectedItem;

      // Set the new To location data by remove the From location from the list
      cbTo.DataSource = _locations.Where(x => x.LocationId != fromLocation.LocationId).ToList();

      // If the new From location isn't the selecetd To location, keep it.
      // Otherwise the To location will be cleared
      if (fromLocation.LocationId != toLocation.LocationId)
      {
        cbTo.SelectedItem = toLocation;
      }

      this.SetProductComboboxData(fromLocation);
    }

    private async void btnSave_Click(object sender, EventArgs e)
    {
      try
      {
        Spinner.InitSpinner();

        await AppServices.StockMovementService.MoveStockBetweenLocationsAsync(
          int.Parse(cbFrom.SelectedValue.ToString()),
          int.Parse(cbTo.SelectedValue.ToString()),
          int.Parse(cbProduct.SelectedValue.ToString()),
          float.Parse(numQty.Value.ToString()),
          Program.LoggedInUser.UserId
        );

        Spinner.StopSpinner();

        // Update stock movements table
        await _inventoryProductLocationsUc.LoadProductLocations();

        // Close form
        this.btnCancel_Click(sender, e);
      }
      catch (OperationErrorException ex)
      {
        Spinner.StopSpinner();

        if (ex.Errors.Count() > 0)
        {
          this.ShowFormErrors(ex.Errors);
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

    private void btnCancel_Click(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}
