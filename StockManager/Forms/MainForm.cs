using StockManager.ColorTables;
using StockManager.Storage.Models;
using StockManager.UserControls;
using System;
using System.Windows.Forms;

namespace StockManager.Forms {
  public partial class MainForm : Form {
    public MainForm() {
      InitializeComponent();
      this.SetUi();
    }

    /// <summary>
    /// Set the Ui after Login/Logout
    /// </summary>
    public void SetUi() {
      lbAppVersion.Text = "v.0.0.1";

      // Get the logged In User, if any.
      User loggedInUser = Program.LoggedInUser;

      // Clear panels
      pnlViews.Controls.Clear();

      // Set initial view
      if (loggedInUser == null) {
        lbViewTitle.Text = "Welcome";
        UserControl ucLogin = new LoginUserControl(this);
        ucLogin.Dock = DockStyle.Fill;
        pnlViews.Controls.Add(ucLogin);
      } else {
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

    /// <summary>
    /// Render only the sidebar button for the logged in user role.
    /// </summary>
    private void RenderButtonsByRole() {
      User loggedInUser = Program.LoggedInUser;

      msUsername.Visible = false;
      pnlSideMarker.Visible = false;
      btnDashboard.Visible = false;
      btnInventory.Visible = false;
      btnUsers.Visible = false;
      btnSettings.Visible = false;

      // If logged in, show the "User" buttons
      if (loggedInUser != null) {
        msUsername.Visible = true;
        pnlSideMarker.Visible = true;
        btnDashboard.Visible = true;
      }

      // If logged in as "Admin" unlock the other buttons
      if ((loggedInUser != null) && (loggedInUser.Role.Code == "Admin")) {
        btnInventory.Visible = true;
        btnUsers.Visible = true;
        btnSettings.Visible = true;
      }
    }

    /// <summary>
    /// Set the sidebar marker position
    /// </summary>
    private void SetMarkerPosition(Control btn) {
      pnlSideMarker.Height = btn.Height;
      pnlSideMarker.Top = btn.Top;
    }

    /// <summary>
    /// Show/Hide the Inventory sub-menu
    /// </summary>
    private void SetSubMenusVisibility(Control subMenu = null) {
      pnlInventorySubMenu.Visible = ((subMenu != null) && (subMenu == pnlInventorySubMenu)
        && (!pnlInventorySubMenu.Visible))
        ? true
        : false;

      this.SetSidebarButtonsPosition(subMenu);
    }

    /// <summary>
    /// Set the sidebar buttons position when the sub menu is open/closed
    /// </summary>
    private void SetSidebarButtonsPosition(Control subMenu = null) {
      // If no sub menu sent, reset all the positions
      btnUsers.Top = ((subMenu != null) && (subMenu == pnlInventorySubMenu) && (pnlInventorySubMenu.Visible))
        ? pnlInventorySubMenu.Bottom
        : pnlInventorySubMenu.Top;
      btnSettings.Top = btnUsers.Bottom + 6;
    }

    /// <summary>
    /// Dashboard button click
    /// </summary>
    private void btnDashboard_Click(object sender, EventArgs e) {
      this.SetSubMenusVisibility();
      this.SetMarkerPosition(btnDashboard);

      // Show the Dashboard view
      pnlViews.Controls.Clear();
      lbViewTitle.Text = "Dashboard";
      UserControl ucDashboard = new DashboardUserControl();
      ucDashboard.Dock = DockStyle.Fill;
      pnlViews.Controls.Add(ucDashboard);
    }

    /// <summary>
    /// Inventory button click
    /// </summary>
    private void btnInventory_Click(object sender, EventArgs e) {
      this.SetSubMenusVisibility(pnlInventorySubMenu);
      this.SetMarkerPosition(btnInventory);
    }

    /// <summary>
    /// Inventory > Locations button click
    /// </summary>
    private void btnInventoryLocations_Click(object sender, EventArgs e) {
      // Show the InventoryLocations view
      pnlViews.Controls.Clear();
      lbViewTitle.Text = "Inventory > Locations";
      UserControl ucInventoryLocations = new InventoryLocationsUserControl();
      ucInventoryLocations.Dock = DockStyle.Fill;
      pnlViews.Controls.Add(ucInventoryLocations);
    }

    /// <summary>
    /// Inventory > Stocks button click
    /// </summary>
    private void btnInventoryStocks_Click(object sender, EventArgs e) {
      // Show the InventoryStocks view
      pnlViews.Controls.Clear();
      lbViewTitle.Text = "Inventory > Stocks";
      UserControl ucInventoryStocks = new InventoryStocksUserControl();
      ucInventoryStocks.Dock = DockStyle.Fill;
      pnlViews.Controls.Add(ucInventoryStocks);
    }

    /// <summary>
    /// User button click
    /// </summary>
    private void btnUsers_Click(object sender, EventArgs e) {
      this.SetSubMenusVisibility();
      this.SetMarkerPosition(btnUsers);

      // Show the UsersUser view
      pnlViews.Controls.Clear();
      lbViewTitle.Text = "Users";
      UserControl ucUsers = new UsersUserControl();
      ucUsers.Dock = DockStyle.Fill;
      pnlViews.Controls.Add(ucUsers);
    }

    /// <summary>
    /// Settings button click
    /// </summary>
    private void btnSettings_Click(object sender, EventArgs e) {
      this.SetSubMenusVisibility();
      this.SetMarkerPosition(btnSettings);

      // Show the Settings view
      pnlViews.Controls.Clear();
      lbViewTitle.Text = "Settings";
      UserControl ucSettings = new SettingsUserControl();
      ucSettings.Dock = DockStyle.Fill;
      pnlViews.Controls.Add(ucSettings);
    }

    /// <summary>
    /// Change password menu strip item click
    /// </summary>
    private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e) {
      var changePasswordForm = new ChangePasswordForm();
      changePasswordForm.ShowChangePasswordForm();
    }

    /// <summary>
    /// Do Logout menu strip item click
    /// </summary>
    private void logoutToolStripMenuItem_Click(object sender, EventArgs e) {
      Program.Logout();
      this.SetUi();
    }

    /// <summary>
    /// LinkLabel click
    /// </summary>
    private void linklbTwitter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
      System.Diagnostics.Process.Start("https://twitter.com/ricardotx86");
    }

    /// <summary>
    /// Exit button click
    /// </summary>
    private void btnExit_Click(object sender, EventArgs e) {
      Application.Exit();
    }
  }
}
