using StockManager.ColorTables;
using StockManager.UserControls;
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

      // Set initial view
      pnlViews.Controls.Clear();
      UserControl ucDashboard = new DashboardUserControl();
      ucDashboard.Dock = DockStyle.Fill;
      pnlViews.Controls.Add(ucDashboard);

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
      this.SetSubMenusVisibility();
      this.SetMarkerPosition(btnDashboard);

      // Show the Dashboard view 
      pnlViews.Controls.Clear();
      UserControl ucDashboard = new DashboardUserControl();
      ucDashboard.Dock = DockStyle.Fill;
      pnlViews.Controls.Add(ucDashboard);
    }

    private void btnInventory_Click(object sender, EventArgs e)
    {
      this.SetSubMenusVisibility(pnlInventorySubMenu);
      this.SetMarkerPosition(btnInventory);
    }
    private void btnStockCategories_Click(object sender, EventArgs e)
    {
      // Show the InventoryCategories view 
      pnlViews.Controls.Clear();
      UserControl ucInventoryCategories = new InventoryCategoriesUserControl();
      ucInventoryCategories.Dock = DockStyle.Fill;
      pnlViews.Controls.Add(ucInventoryCategories);
    }
    private void btnStocks_Click(object sender, EventArgs e)
    {
      // Show the InventoryCategories view 
      pnlViews.Controls.Clear();
      UserControl ucInventoryStocks = new InventoryStocksUserControl();
      ucInventoryStocks.Dock = DockStyle.Fill;
      pnlViews.Controls.Add(ucInventoryStocks);
    }

    private void btnUsers_Click(object sender, EventArgs e)
    {
      this.SetSubMenusVisibility();
      this.SetMarkerPosition(btnUsers);

      // Show the UsersUser view 
      pnlViews.Controls.Clear();
      UserControl ucUsers = new UsersUserControl();
      ucUsers.Dock = DockStyle.Fill;
      pnlViews.Controls.Add(ucUsers);
    }

    private void btnSettings_Click(object sender, EventArgs e)
    {
      this.SetSubMenusVisibility();
      this.SetMarkerPosition(btnSettings);

      // Show the Settings view 
      pnlViews.Controls.Clear();
      UserControl ucSettings = new SettingsUserControl();
      ucSettings.Dock = DockStyle.Fill;
      pnlViews.Controls.Add(ucSettings);
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
