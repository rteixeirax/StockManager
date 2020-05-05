using StockManager.Components;
using StockManager.Services;
using StockManager.Storage.Source.Models;
using StockManager.Translations.Source;
using StockManager.Types.Source;
using StockManager.UserControls;
using StockManager.Utilities.Source;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace StockManager.Forms {
  public partial class LocationForm : Form {
    private int locationId = 0;
    private readonly InventoryLocationsUserControl inventoryLocationsUserControl;

    public LocationForm(InventoryLocationsUserControl inventoryLocationsUserControl) {
      InitializeComponent();
      this.inventoryLocationsUserControl = inventoryLocationsUserControl;
      this.SetTranslatedPhrases();
    }

    /// <summary>
    /// Set the content strings for the correct app language
    /// </summary>
    private void SetTranslatedPhrases() {
      lbTitle.Text = Phrases.LocationInfo;
      lbName.Text = Phrases.GlobalName;
      btnCancel.Text = Phrases.GlobalCancel;
      btnSave.Text = Phrases.GlobalSave;
    }

    /// <summary>
    /// Show Location Form and set the initial values
    /// </summary>
    public void ShowLocationForm(Location location = null) {
      // Set the locationId. Means that is a edit
      this.locationId = (location != null) ? location.LocationId : 0;

      // Set the Form title
      this.Text = (this.locationId != 0)
        ? AppInfo.GetViewTitle(Phrases.LocationEdit)
        : AppInfo.GetViewTitle(Phrases.LocationCreate);

      // hide the error labels
      lbErrorName.Visible = false;

      // Edit
      if (location != null) {
        tbName.Text = location.Name;
      }

      this.ShowDialog();
    }

    /// <summary>
    /// Show the form errors, if any.
    /// </summary>
    private void ShowFormErrors(List<ErrorType> errors) {
      lbErrorName.Visible = false;

      foreach (ErrorType err in errors) {
        if (err.Field == "Name") {
          lbErrorName.Text = err.Error;
          lbErrorName.Visible = true;
        }
      }
    }

    /// <summary>
    /// Create/Update button click
    /// </summary>
    private async void btnSave_Click(object sender, EventArgs e) {
      try {
        Location location = new Location {
          Name = tbName.Text
        };

        Spinner.InitSpinner();

        if ((this.locationId != 0)) {
          location.LocationId = locationId;
          await AppServices.LocationService.EditLocationAsync(location);
        } else {
          await AppServices.LocationService.CreateLocationAsync(location);
        }

        Spinner.StopSpinner();

        await this.inventoryLocationsUserControl.LoadLocationsAsync();

        this.Close();
      } catch (OperationErrorException ex) {
        Spinner.StopSpinner();

        if (ex.Errors.Count() > 0) {
          this.ShowFormErrors(ex.Errors);
        }
      }
    }

    /// <summary>
    /// Close button click
    /// </summary>
    private void btnCancel_Click(object sender, EventArgs e) {
      this.Close();
    }
  }
}
