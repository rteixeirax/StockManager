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
    }

    #region HELPER FUNCTIONS
    private void SetMarkerPosition(Control btn)
    {
      sideMarker.Height = btn.Height;
      sideMarker.Top = btn.Top;
    }

    private void SetSubMenusVisibility(Control subMenu = null)
    {
      panelStocksSubMenu.Visible = ((subMenu != null) && (subMenu == panelStocksSubMenu) && (!panelStocksSubMenu.Visible))
        ? true
        : false;

      this.SetSidebarButtonsPosition(subMenu);
    }

    private void SetSidebarButtonsPosition(Control subMenu = null)
    {
      // If no sub menu sent, reset all the positions
      btnUsers.Top = ((subMenu != null) && (subMenu == panelStocksSubMenu) && (panelStocksSubMenu.Visible))
        ? panelStocksSubMenu.Bottom
        : panelStocksSubMenu.Top;
      btnSettings.Top = btnUsers.Bottom + 6;
    }
    #endregion HELPER FUNCTIONS

    #region FORM EVENTS
    private void btnDashboard_Click(object sender, EventArgs e)
    {
      this.SetSubMenusVisibility();
      this.SetMarkerPosition(btnDashboard);
    }

    private void btnStocks_Click(object sender, EventArgs e)
    {
      this.SetSubMenusVisibility(panelStocksSubMenu);
      this.SetMarkerPosition(btnStocks);
    }

    private void btnUsers_Click(object sender, EventArgs e)
    {
      this.SetSubMenusVisibility();
      this.SetMarkerPosition(btnUsers);
    }

    private void btnSettings_Click(object sender, EventArgs e)
    {
      this.SetSubMenusVisibility();
      this.SetMarkerPosition(btnSettings);
    }
    #endregion FORM EVENTS
  }
}
