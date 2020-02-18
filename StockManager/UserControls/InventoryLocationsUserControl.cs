using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockManager.Database.Models;

namespace StockManager.UserControls
{
  public partial class InventoryLocationsUserControl : UserControl
  {
    public InventoryLocationsUserControl()
    {
      InitializeComponent();

      // Hide the X button on the search textbox
      btnClearSearchValue.Visible = false;

      this.LoadLocations();
    }

    /// <summary>
    /// Fill the Data Grid View
    /// </summary>
    public void LoadLocations(string searchValue = null)
    {
      // Spinner
      Cursor.Current = Cursors.WaitCursor;

      dgvLocations.Rows.Clear();
      IEnumerable<Location> locations = Program.LocationServices.GetLocations(searchValue);

      foreach (Location location in locations)
      {
        dgvLocations.Rows.Add(
          location.LocationId,
          location.Name,
          999,
          location.CreatedAt?.ToString("MM/dd/yyyy HH:mm:ss")
        );
      }
    }

    /// <summary>
    /// Delete location button click
    /// </summary>
    private void btnDelete_Click(object sender, EventArgs e)
    {
      DataGridViewSelectedRowCollection selectedLocations = dgvLocations.SelectedRows;

      if ((selectedLocations.Count > 0)
        && MessageBox.Show(
        $"Delete {selectedLocations.Count} location(s)?",
        "Are you sure?",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes
      )
      {
        // Spinner
        Cursor.Current = Cursors.WaitCursor;

        int[] locationIds = new int[selectedLocations.Count];

        for (int i = 0; i < selectedLocations.Count; i++)
        {
          locationIds[i] = int.Parse(selectedLocations[i].Cells[0].Value.ToString());
        }

        if (Program.LocationServices.DeleteLocations(locationIds))
        {
          this.LoadLocations();
        }
      }
    }

    /// <summary>
    /// Search button click
    /// </summary>
    private void pbSearchIcon_Click(object sender, EventArgs e)
    {
      string searchValue = tbSeachText.Text;

      if (!string.IsNullOrEmpty(searchValue))
      {
        this.LoadLocations(searchValue);

        // Remove spinner
        Cursor.Current = Cursors.Default;
      }
    }

    /// <summary>
    /// Clear search value picture box click
    /// </summary>
    private void btnClearSearchValue_Click(object sender, EventArgs e)
    {
      tbSeachText.Text = "";
      this.LoadLocations();

      // Remove spinner
      Cursor.Current = Cursors.Default;
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
