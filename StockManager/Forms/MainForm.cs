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
  public partial class MainForm : Form
  {
    public MainForm()
    {
      InitializeComponent();
      this.SetSubMenusVisibility();
      this.SetMarkerPosition(btnDashboard);

      // initialize with dashboard panel
      ucDashboard.BringToFront();
    }

    #region HELPER FUNCTIONS
    private void SetMarkerPosition(Control btn)
    {
      pnlSideMarker.Height = btn.Height;
      pnlSideMarker.Top = btn.Top;
    }

    private void SetSubMenusVisibility(Control subMenu = null)
    {
      pnlInventorySubMenu.Visible = ((subMenu != null) && (subMenu == pnlInventorySubMenu) && (!pnlInventorySubMenu.Visible))
        ? true
        : false;

      this.SetSidebarButtonsPosition(subMenu);
    }

    private void SetSidebarButtonsPosition(Control subMenu = null)
    {
      // If no sub menu sent, reset all the positions
      btnUsers.Top = ((subMenu != null) && (subMenu == pnlInventorySubMenu) && (pnlInventorySubMenu.Visible))
        ? pnlInventorySubMenu.Bottom
        : pnlInventorySubMenu.Top;
      btnSettings.Top = btnUsers.Bottom + 6;
    }
    #endregion HELPER FUNCTIONS

    #region FORM EVENTS
    private void btnDashboard_Click(object sender, EventArgs e)
    {
      ucDashboard.BringToFront();
      this.SetSubMenusVisibility();
      this.SetMarkerPosition(btnDashboard);
    }

    private void btnInventory_Click(object sender, EventArgs e)
    {
      this.SetSubMenusVisibility(pnlInventorySubMenu);
      this.SetMarkerPosition(btnInventory);
    }
    private void btnStockCategories_Click(object sender, EventArgs e)
    {
      ucInventoryCategories.BringToFront();
    }
    private void btnStocks_Click(object sender, EventArgs e)
    {
      ucInventoryStocks.BringToFront();
    }

    private void btnUsers_Click(object sender, EventArgs e)
    {
      ucUsers.BringToFront();
      this.SetSubMenusVisibility();
      this.SetMarkerPosition(btnUsers);
    }

    private void btnSettings_Click(object sender, EventArgs e)
    {
      ucSettings.BringToFront();
      this.SetSubMenusVisibility();
      this.SetMarkerPosition(btnSettings);
    }
    #endregion FORM EVENTS

    private void btnExit_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }
  }
}
