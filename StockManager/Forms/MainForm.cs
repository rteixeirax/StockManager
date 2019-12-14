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
      dashboardUserControl.BringToFront();
    }

    #region HELPER FUNCTIONS
    private void SetMarkerPosition(Control btn)
    {
      sideMarker.Height = btn.Height;
      sideMarker.Top = btn.Top;
    }

    private void SetSubMenusVisibility(Control subMenu = null)
    {
      panelInventorySubMenu.Visible = ((subMenu != null) && (subMenu == panelInventorySubMenu) && (!panelInventorySubMenu.Visible))
        ? true
        : false;

      this.SetSidebarButtonsPosition(subMenu);
    }

    private void SetSidebarButtonsPosition(Control subMenu = null)
    {
      // If no sub menu sent, reset all the positions
      btnUsers.Top = ((subMenu != null) && (subMenu == panelInventorySubMenu) && (panelInventorySubMenu.Visible))
        ? panelInventorySubMenu.Bottom
        : panelInventorySubMenu.Top;
      btnSettings.Top = btnUsers.Bottom + 6;
    }
    #endregion HELPER FUNCTIONS

    #region FORM EVENTS
    private void btnDashboard_Click(object sender, EventArgs e)
    {
      dashboardUserControl.BringToFront();
      this.SetSubMenusVisibility();
      this.SetMarkerPosition(btnDashboard);
    }

    private void btnInventory_Click(object sender, EventArgs e)
    {
      this.SetSubMenusVisibility(panelInventorySubMenu);
      this.SetMarkerPosition(btnInventory);
    }
    private void btnStockCategories_Click(object sender, EventArgs e)
    {
      inventoryCategoriesUserControl.BringToFront();
    }
    private void btnStockCategories_Click_1(object sender, EventArgs e)
    {
      inventoryCategoriesUserControl.BringToFront();
    }
    private void btnStocks_Click(object sender, EventArgs e)
    {
      inventoryStocksUserControl.BringToFront();
    }

    private void btnUsers_Click(object sender, EventArgs e)
    {
      usersUserControl.BringToFront();
      this.SetSubMenusVisibility();
      this.SetMarkerPosition(btnUsers);
    }

    private void btnSettings_Click(object sender, EventArgs e)
    {
      settingsUserControl.BringToFront();
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
