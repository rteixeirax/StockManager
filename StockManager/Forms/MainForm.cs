using StockManager.ColorTables;
using StockManager.Database.Models;
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
      this.SetUi();
    }

    /*
     * Set the Ui after Login/Logout
     */
    public void SetUi()
    {
      // Get the logged In User, if any.
      User loggedInUser = Program.loggedInUser;

      // Clear panels
      pnlViews.Controls.Clear();

      // Set initial view
      if (loggedInUser == null)
      {
        lbViewTitle.Text = "Welcome";
        UserControl ucLogin = new LoginUserControl(this);
        ucLogin.Dock = DockStyle.Fill;
        pnlViews.Controls.Add(ucLogin);
      }
      else
      {
        lbViewTitle.Text = "Dashboard";
        UserControl ucDashboard = new DashboardUserControl();
        ucDashboard.Dock = DockStyle.Fill;
        pnlViews.Controls.Add(ucDashboard);

        // Set the logged in username
        msUsername.Renderer = new ToolStripProfessionalRenderer(new MenuStripProfessionalColorTable());
        msUsername.Items[0].Text = loggedInUser.Username;
      }

      // Set the Ui by role
      this.RenderButtonsByRole();

      // Set the sub-menu visibility and sidebar marker position
      this.SetSubMenusVisibility();
      this.SetMarkerPosition(btnDashboard);
    }

    /*
     * Render only the sidebar button for the logged in user role.
     */
    private void RenderButtonsByRole()
    {
      User loggedInUser = Program.loggedInUser;

      msUsername.Visible = false;
      pnlSideMarker.Visible = false;
      btnDashboard.Visible = false;
      btnInventory.Visible = false;
      btnUsers.Visible = false;
      btnSettings.Visible = false;

      // If logged in, show the "User" buttons
      if (loggedInUser != null)
      { 
        msUsername.Visible = true;
        pnlSideMarker.Visible = true;
        btnDashboard.Visible = true;
      }

      // If logged in as "Admin" unlock the other buttons
      if ((loggedInUser != null) && (loggedInUser.Role.Code == "Admin"))
      { 
        btnInventory.Visible = true;
        btnUsers.Visible = true;
        btnSettings.Visible = true;
      }
    }

    /*
     * Set the sidebar marker position
     */
    private void SetMarkerPosition(Control btn)
    {
      pnlSideMarker.Height = btn.Height;
      pnlSideMarker.Top = btn.Top;
    }

    /*
     * Show/Hide the Inventory sub-menu
     */
    private void SetSubMenusVisibility(Control subMenu = null)
    {
      pnlInventorySubMenu.Visible = ((subMenu != null) && (subMenu == pnlInventorySubMenu) && (!pnlInventorySubMenu.Visible))
        ? true
        : false;

      this.SetSidebarButtonsPosition(subMenu);
    }

    /*
     * Set the sidebar buttons position when the sub menu is open/closed
     */
    private void SetSidebarButtonsPosition(Control subMenu = null)
    {
      // If no sub menu sent, reset all the positions
      btnUsers.Top = ((subMenu != null) && (subMenu == pnlInventorySubMenu) && (pnlInventorySubMenu.Visible))
        ? pnlInventorySubMenu.Bottom
        : pnlInventorySubMenu.Top;
      btnSettings.Top = btnUsers.Bottom + 6;
    }

    /*
     * Dashboard button click
     */
    private void btnDashboard_Click(object sender, EventArgs e)
    {
      this.SetSubMenusVisibility();
      this.SetMarkerPosition(btnDashboard);

      // Show the Dashboard view 
      pnlViews.Controls.Clear();
      lbViewTitle.Text = "Dashboard"; 
      UserControl ucDashboard = new DashboardUserControl();
      ucDashboard.Dock = DockStyle.Fill;
      pnlViews.Controls.Add(ucDashboard);
    }

    /*
     * Inventory button click
     */
    private void btnInventory_Click(object sender, EventArgs e)
    {
      this.SetSubMenusVisibility(pnlInventorySubMenu);
      this.SetMarkerPosition(btnInventory);
    }

    /*
     * Inventory > Categories button click
     */
    private void btnStockCategories_Click(object sender, EventArgs e)
    {
      // Show the InventoryCategories view 
      pnlViews.Controls.Clear();
      lbViewTitle.Text = "Inventory > Categories";
      UserControl ucInventoryCategories = new InventoryCategoriesUserControl();
      ucInventoryCategories.Dock = DockStyle.Fill;
      pnlViews.Controls.Add(ucInventoryCategories);
    }

    /*
     * Inventory > Stocks button click
     */
    private void btnStocks_Click(object sender, EventArgs e)
    {
      // Show the InventoryStocks view 
      pnlViews.Controls.Clear();
      lbViewTitle.Text = "Inventory > Stocks";
      UserControl ucInventoryStocks = new InventoryStocksUserControl();
      ucInventoryStocks.Dock = DockStyle.Fill;
      pnlViews.Controls.Add(ucInventoryStocks);
    }

    /*
     * User button click
     */
    private void btnUsers_Click(object sender, EventArgs e)
    {
      this.SetSubMenusVisibility();
      this.SetMarkerPosition(btnUsers);

      // Show the UsersUser view 
      pnlViews.Controls.Clear();
      lbViewTitle.Text = "Users";
      UserControl ucUsers = new UsersUserControl();
      ucUsers.Dock = DockStyle.Fill;
      pnlViews.Controls.Add(ucUsers);
    }

    /*
     * Settings button click
     */
    private void btnSettings_Click(object sender, EventArgs e)
    {
      this.SetSubMenusVisibility();
      this.SetMarkerPosition(btnSettings);

      // Show the Settings view 
      pnlViews.Controls.Clear();
      lbViewTitle.Text = "Settings";
      UserControl ucSettings = new SettingsUserControl();
      ucSettings.Dock = DockStyle.Fill;
      pnlViews.Controls.Add(ucSettings);
    }

    /*
     * Change password menu strip item click
     */
    private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
    {
      var changePasswordForm = new ChangePasswordForm();
      changePasswordForm.ShowChangePasswordForm();
    }

    /*
     * Do Logout menu strip item click
     */
    private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Program.Logout();
      this.SetUi();
    }

    /*
     * Exit button click
     */
    private void btnExit_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }
  }
}
