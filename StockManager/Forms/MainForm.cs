using StockManager.ColorTables;
using System;
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

      // Set the logged in username
      msUsername.Renderer = new ToolStripProfessionalRenderer(new MenuStripProfessionalColorTable());
      msUsername.Items[0].Text = "Ricardo Teixeira";
    }

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
      this.SetSubMenusVisibility();
      this.SetMarkerPosition(btnUsers);
      ucUsers.ShowUserControl();
    }

    private void btnSettings_Click(object sender, EventArgs e)
    {
      ucSettings.BringToFront();
      this.SetSubMenusVisibility();
      this.SetMarkerPosition(btnSettings);
    }

    private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
    {
      var changePasswordForm = new ChangePasswordForm();
      changePasswordForm.ShowChangePasswordForm();
    }

    private void btnExit_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }
  }
}
