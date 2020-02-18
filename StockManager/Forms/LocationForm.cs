using StockManager.Database.Models;
using StockManager.Types;
using StockManager.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManager.Forms
{
  public partial class LocationForm : Form
  {
    private int locationId = 0;
    private readonly InventoryLocationsUserControl inventoryLocationsUserControl;

    public LocationForm(InventoryLocationsUserControl inventoryLocationsUserControl)
    {
      InitializeComponent();
      this.inventoryLocationsUserControl = inventoryLocationsUserControl;
    }

    /// <summary>
    /// Show Location Form and set the initial values
    /// </summary>
    public void ShowLocationForm(Location location = null)
    {
      // Spinner
      Cursor.Current = Cursors.WaitCursor;

      // Set the locationId. Means that is a edit
      this.locationId = (location != null) ? location.LocationId : 0;

      // Set the Form title
      this.Text = (this.locationId != 0)
        ? "Stock Manager | Edit location"
        : "Stock Manager | Create new location";

      // hide the error labels
      lbErrorName.Visible = false;

      // Edit
      if (location != null)
      {
        tbName.Text = location.Name;
      }

      this.ShowDialog();
    }

    /// <summary>
    /// Show the form errors, if any.
    /// </summary>
    private void ShowFormErrors(List<ErrorType> errors)
    {
      lbErrorName.Visible = false;

      foreach (var err in errors)
      {
        if (err.Field == "Name")
        {
          lbErrorName.Text = err.Error;
          lbErrorName.Visible = true;
        }
      }
    }

    /// <summary>
    /// Create/Update button click
    /// </summary>
    private void btnSave_Click(object sender, EventArgs e)
    {
      Location location = new Location();
      location.Name = tbName.Text;

      List<ErrorType> errors = (this.locationId != 0)
        ? Program.LocationServices.UpdateLocation(this.locationId, location)
        : Program.LocationServices.CreateLocation(location);

      if (errors.Count == 0)
      {
        this.inventoryLocationsUserControl.LoadLocations();
        this.Close();
      }
      else
      {
        this.ShowFormErrors(errors);
      }
    }

    /// <summary>
    /// Close button click
    /// </summary>
    private void btnCancel_Click(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}
