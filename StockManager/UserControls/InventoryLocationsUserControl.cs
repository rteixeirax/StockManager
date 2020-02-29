using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockManager.Storage.Models;
using StockManager.Forms;
using StockManager.Types;

namespace StockManager.UserControls
{
  public partial class InventoryLocationsUserControl : UserControl
  {
    public InventoryLocationsUserControl()
    {
      InitializeComponent();

      // Hide the X button on the search textbox
      btnClearSearchValue.Visible = false;
      this.LoadLocations().Wait();
    }

    /// <summary>
    /// Init the loading spinner
    /// </summary>
    private void InitSpinner() { Cursor.Current = Cursors.WaitCursor; }
    /// <summary>
    /// Stop the loading spinner
    /// </summary>
    private void StopSpinner() { Cursor.Current = Cursors.Default; }

    /// <summary>
    /// Fill the Data Grid View
    /// </summary>
    public async Task LoadLocations(string searchValue = null)
    {
      this.InitSpinner();

      dgvLocations.Rows.Clear();

      IEnumerable<Location> locations = await Program.LocationService
        .GetLocationsAsync(searchValue);

      foreach (Location location in locations)
      {
        dgvLocations.Rows.Add(
          location.LocationId,
          location.Name,
          999,
          location.CreatedAt?.ToString("MM/dd/yyyy HH:mm:ss")
        );
      }

      this.StopSpinner();
    }

    /// <summary>
    /// Create location button click
    /// </summary>
    private void btnCreate_Click(object sender, EventArgs e)
    {
      LocationForm locationForm = new LocationForm(this);
      locationForm.ShowLocationForm();
    }

    /// <summary>
    /// Edit location button click
    /// </summary>
    private async void btnEdit_Click(object sender, EventArgs e)
    {
      if (dgvLocations.SelectedRows.Count > 0)
      {
        this.InitSpinner();

        Location location = await Program.LocationService
          .GetLocationByIdAsync(int.Parse(dgvLocations.SelectedRows[0].Cells[0].Value.ToString()));

        this.StopSpinner();

        LocationForm locationForm = new LocationForm(this);
        locationForm.ShowLocationForm(location);
      }
    }

    /// <summary>
    /// Delete location button click
    /// </summary>
    private async void btnDelete_Click(object sender, EventArgs e)
    {
      DataGridViewSelectedRowCollection selectedLocations = dgvLocations.SelectedRows;

      if ((selectedLocations.Count > 0)
        && MessageBox.Show(
        $"Delete {selectedLocations.Count} location(s)?",
        "Are you sure?",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes
      )
      {
        try
        {
          this.InitSpinner();

          int[] locationIds = new int[selectedLocations.Count];

          for (int i = 0; i < selectedLocations.Count; i++)
          {
            locationIds[i] = int.Parse(selectedLocations[i].Cells[0].Value.ToString());
          }

          await Program.LocationService.DeleteLocationAsync(locationIds);

          this.StopSpinner();

          await this.LoadLocations();
        }
        catch (OperationErrorException ex)
        {
          this.StopSpinner();

          MessageBox.Show(
          $"{ex.Errors[0].Error}",
          "Operation error",
          MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
      }
    }

    /// <summary>
    /// Search button click
    /// </summary>
    private async void pbSearchIcon_Click(object sender, EventArgs e)
    {
      string searchValue = tbSeachText.Text;

      if (!string.IsNullOrEmpty(searchValue))
      {
        await this.LoadLocations(searchValue);
      }
    }

    /// <summary>
    /// Clear search value picture box click
    /// </summary>
    private async void btnClearSearchValue_Click(object sender, EventArgs e)
    {
      tbSeachText.Text = "";
      await this.LoadLocations();
    }

    /// <summary>
    /// Call search button click when pressed enter in the textbox
    /// </summary>
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

    /// <summary>
    /// Show/Hide the X button on the search textbox
    /// </summary>
    private void tbSeachText_TextChanged(object sender, EventArgs e)
    {
      btnClearSearchValue.Visible = (tbSeachText.Text.Length > 0);
    }
  }
}
