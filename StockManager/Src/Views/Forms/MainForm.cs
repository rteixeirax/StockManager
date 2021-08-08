﻿using System;
using System.Windows.Forms;

using StockManager.Src.Data.Entities;
using StockManager.Src.Translations;
using StockManager.Src.Views.ColorTables;
using StockManager.Src.Views.UserControls;

namespace StockManager.Src.Views.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            SetUi();
        }

        /// <summary>
        /// Inventory > Locations button click
        /// </summary>
        public void btnInventoryLocations_Click(object sender, EventArgs e)
        {
            // Show the InventoryLocations view
            pnlViews.Controls.Clear();
            lbViewTitle.Text = $"{Phrases.GlobalInventoryTitle} > {Phrases.GlobalLocations}";
            UserControl ucInventoryLocations = new InventoryLocationsUc(this)
            {
                Dock = DockStyle.Fill
            }; // Passing the MainForm to this UC
            pnlViews.Controls.Add(ucInventoryLocations);
        }

        /// <summary>
        /// Inventory > Products button click
        /// </summary>
        public void btnInventoryProducts_Click(object sender, EventArgs e)
        {
            // Show the InventoryProducts view
            pnlViews.Controls.Clear();
            lbViewTitle.Text = $"{Phrases.GlobalInventoryTitle} > {Phrases.GlobalProducts}";
            UserControl ucInventoryProducts = new InventoryProductsUc(this)
            {
                Dock = DockStyle.Fill
            }; // Passing the MainForm to this UC
            pnlViews.Controls.Add(ucInventoryProducts);
        }

        /// <summary>
        /// Set the Ui after Login/Logout
        /// </summary>
        public void SetUi()
        {
            Text = AppConstants.AppTitle;
            lbAppVersion.Text = AppConstants.AppVersion;

            changePasswordToolStripMenuItem.Text = Phrases.UserChangePassword;
            logoutToolStripMenuItem.Text = Phrases.LoginLogout;

            btnDashboard.Text = $" {Phrases.GlobalDashboard}";
            btnRefillStock.Text = $" {Phrases.RefillStock}";
            btnInventory.Text = $" {Phrases.GlobalInventoryTitle}";
            btnInventoryProducts.Text = Phrases.GlobalProducts;
            btnInventoryLocations.Text = Phrases.GlobalLocations;
            btnInventoryMovements.Text = Phrases.GlobalMovements;
            btnUsers.Text = $" {Phrases.GlobalUsers}";
            btnSettings.Text = $" {Phrases.GlobalSettings}";

            btnExit.Text = $" {Phrases.GlobalExit}";

            // Get the logged In User, if any.
            User loggedInUser = Program.LoggedInUser;

            // Clear panels
            pnlViews.Controls.Clear();

            // Set initial view
            if (loggedInUser == null)
            {
                lbViewTitle.Text = Phrases.LoginWelcome;
                UserControl ucLogin = new LoginUc(this)
                {
                    Dock = DockStyle.Fill
                };
                pnlViews.Controls.Add(ucLogin);
            }
            else
            {
                if (Program.LoggedInUser.Role.Code == "Admin")
                {
                    lbViewTitle.Text = $"{Phrases.GlobalDashboard}";
                    pnlViews.Controls.Add(new DashboardUc { Dock = DockStyle.Fill });
                }
                else
                {
                    lbViewTitle.Text = Phrases.RefillStock;
                    pnlViews.Controls.Add(new RefillStockUc { Dock = DockStyle.Fill });
                }

                // Set the logged in username
                msUsername.Renderer = new ToolStripProfessionalRenderer(new MenuStripProfessionalColorTable());
                msUsername.Items[0].Text = loggedInUser.Username;
            }

            // Set the Ui by role
            RenderButtonsByRole();

            // Set the sub-menu visibility and sidebar marker position
            SetSubMenusVisibility();
            SetMarkerPosition(btnDashboard);

            // Check if exists a new StockManager release.
            Program.CheckForNewRelease();
        }

        /// <summary>
        /// Inventory > Locations button view products click
        /// </summary>
        public void ShowProducLocationsFromLocationsUc(Location location)
        {
            pnlViews.Controls.Clear();

            lbViewTitle.Text = $"{Phrases.GlobalInventoryTitle} > {Phrases.GlobalLocations} > {location.Name} > {Phrases.GlobalProducts.ToLower()}";
            UserControl uc = new InventoryProductLocationsUc(this, location)
            {
                Dock = DockStyle.Fill
            };
            pnlViews.Controls.Add(uc);
        }

        /// <summary>
        /// Inventory > Products button view locations click
        /// </summary>
        public void ShowProducLocationsFromProductsUc(Product product)
        {
            pnlViews.Controls.Clear();

            string productName = $"{product.Reference} {product.Name}";

            lbViewTitle.Text = $"{Phrases.GlobalInventoryTitle} > {Phrases.GlobalProducts} > {productName} > {Phrases.GlobalLocations.ToLower()}";
            UserControl uc = new InventoryProductLocationsUc(this, product)
            {
                Dock = DockStyle.Fill
            };
            pnlViews.Controls.Add(uc);
        }

        /// <summary>
        /// Dashboard button click
        /// </summary>
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            SetSubMenusVisibility();
            SetMarkerPosition(btnDashboard);

            // Show the Dashboard view
            pnlViews.Controls.Clear();
            lbViewTitle.Text = $"{Phrases.GlobalDashboard}";
            UserControl ucDashboard = new DashboardUc { Dock = DockStyle.Fill };
            pnlViews.Controls.Add(ucDashboard);
        }

        /// <summary>
        /// Exit button click
        /// </summary>
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Inventory button click
        /// </summary>
        private void btnInventory_Click(object sender, EventArgs e)
        {
            SetSubMenusVisibility(pnlInventorySubMenu);
            SetMarkerPosition(btnInventory);
        }

        private void btnInventoryMovements_Click(object sender, EventArgs e)
        {
            // Show the InventoryProducts view
            pnlViews.Controls.Clear();
            lbViewTitle.Text = $"{Phrases.GlobalInventoryTitle} > {Phrases.GlobalMovements}";
            UserControl ucInventoryMovements = new InventoryMovementsUc()
            {
                Dock = DockStyle.Fill
            }; // Passing the MainForm to this UC
            pnlViews.Controls.Add(ucInventoryMovements);
        }

        /// <summary>
        /// Refill stock button click
        /// </summary>
        private void btnRefillStock_Click(object sender, EventArgs e)
        {
            SetSubMenusVisibility();
            SetMarkerPosition(btnRefillStock);

            // Show the Dashboard view
            pnlViews.Controls.Clear();
            lbViewTitle.Text = Phrases.RefillStock;
            UserControl ucStockRefilling = new RefillStockUc { Dock = DockStyle.Fill };
            pnlViews.Controls.Add(ucStockRefilling);
        }

        /// <summary>
        /// Settings button click
        /// </summary>
        private void btnSettings_Click(object sender, EventArgs e)
        {
            SetSubMenusVisibility();
            SetMarkerPosition(btnSettings);

            // Show the Settings view
            pnlViews.Controls.Clear();
            lbViewTitle.Text = $"{Phrases.GlobalSettings}";
            UserControl ucSettings = new SettingsUc
            {
                Dock = DockStyle.Fill
            };
            pnlViews.Controls.Add(ucSettings);
        }

        /// <summary>
        /// User button click
        /// </summary>
        private void btnUsers_Click(object sender, EventArgs e)
        {
            SetSubMenusVisibility();
            SetMarkerPosition(btnUsers);

            // Show the UsersUser view
            pnlViews.Controls.Clear();
            lbViewTitle.Text = Phrases.GlobalUsers;
            UserControl ucUsers = new UsersUc
            {
                Dock = DockStyle.Fill
            };
            pnlViews.Controls.Add(ucUsers);
        }

        /// <summary>
        /// Change password menu strip item click
        /// </summary>
        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePasswordForm changePasswordForm = new ChangePasswordForm();
            changePasswordForm.ShowChangePasswordForm();
        }

        /// <summary>
        /// Do Logout menu strip item click
        /// </summary>
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.Logout();
            SetUi();
        }

        /// <summary>
        /// Render only the sidebar button for the logged in user role.
        /// </summary>
        private void RenderButtonsByRole()
        {
            User loggedInUser = Program.LoggedInUser;

            msUsername.Visible = false;
            pnlSideMarker.Visible = false;
            btnDashboard.Visible = false;
            btnRefillStock.Visible = false;
            btnInventory.Visible = false;
            btnUsers.Visible = false;
            btnSettings.Visible = false;

            // If logged in, show the "User" buttons
            if (loggedInUser != null)
            {
                msUsername.Visible = true;
                pnlSideMarker.Visible = true;
                btnRefillStock.Visible = true;

                // Set the position for the refill stock btn
                if (loggedInUser.Role.Code != "Admin")
                {
                    btnRefillStock.Top = btnDashboard.Top;
                }
            }

            // If logged in as "Admin" unlock the other buttons
            if ((loggedInUser != null) && (loggedInUser.Role.Code == "Admin"))
            {
                btnDashboard.Visible = true;
                btnRefillStock.Visible = true;
                btnRefillStock.Top = btnDashboard.Bottom + 6;
                btnInventory.Visible = true;
                btnUsers.Visible = true;
                btnSettings.Visible = true;
            }
        }

        /// <summary>
        /// Set the sidebar marker position
        /// </summary>
        private void SetMarkerPosition(Control btn)
        {
            pnlSideMarker.Height = btn.Height;
            pnlSideMarker.Top = btn.Top;
        }

        /// <summary>
        /// Set the sidebar buttons position when the sub menu is open/closed
        /// </summary>
        private void SetSidebarButtonsPosition(Control subMenu = null)
        {
            // If no sub menu sent, reset all the positions
            btnUsers.Top = ((subMenu != null) && (subMenu == pnlInventorySubMenu) && (pnlInventorySubMenu.Visible))
              ? pnlInventorySubMenu.Bottom
              : pnlInventorySubMenu.Top;
            btnSettings.Top = btnUsers.Bottom + 6;
        }

        /// <summary>
        /// Show/Hide the Inventory sub-menu
        /// </summary>
        private void SetSubMenusVisibility(Control subMenu = null)
        {
            pnlInventorySubMenu.Visible = ((subMenu != null) && (subMenu == pnlInventorySubMenu)
              && (!pnlInventorySubMenu.Visible))
              ? true
              : false;

            SetSidebarButtonsPosition(subMenu);
        }
    }
}
