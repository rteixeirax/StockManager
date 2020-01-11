namespace StockManager.Forms
{
  partial class MainForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      this.pnlSidebar = new System.Windows.Forms.Panel();
      this.lbSignIn = new System.Windows.Forms.Label();
      this.pnlSideBarAvatar = new System.Windows.Forms.Panel();
      this.lbAppName = new System.Windows.Forms.Label();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.pnlInventorySubMenu = new System.Windows.Forms.Panel();
      this.btnStocks = new System.Windows.Forms.Button();
      this.btnStockCategories = new System.Windows.Forms.Button();
      this.btnExit = new System.Windows.Forms.Button();
      this.btnSettings = new System.Windows.Forms.Button();
      this.btnUsers = new System.Windows.Forms.Button();
      this.btnInventory = new System.Windows.Forms.Button();
      this.btnDashboard = new System.Windows.Forms.Button();
      this.pnlSideMarker = new System.Windows.Forms.Panel();
      this.msUsername = new System.Windows.Forms.MenuStrip();
      this.usernameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
      this.pnlViews = new System.Windows.Forms.Panel();
      this.pnlSidebar.SuspendLayout();
      this.pnlSideBarAvatar.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.pnlInventorySubMenu.SuspendLayout();
      this.msUsername.SuspendLayout();
      this.SuspendLayout();
      // 
      // pnlSidebar
      // 
      this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
      this.pnlSidebar.Controls.Add(this.lbSignIn);
      this.pnlSidebar.Controls.Add(this.pnlSideBarAvatar);
      this.pnlSidebar.Controls.Add(this.pnlInventorySubMenu);
      this.pnlSidebar.Controls.Add(this.btnExit);
      this.pnlSidebar.Controls.Add(this.btnSettings);
      this.pnlSidebar.Controls.Add(this.btnUsers);
      this.pnlSidebar.Controls.Add(this.btnInventory);
      this.pnlSidebar.Controls.Add(this.btnDashboard);
      this.pnlSidebar.Controls.Add(this.pnlSideMarker);
      this.pnlSidebar.Controls.Add(this.msUsername);
      this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
      this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
      this.pnlSidebar.Name = "pnlSidebar";
      this.pnlSidebar.Size = new System.Drawing.Size(241, 729);
      this.pnlSidebar.TabIndex = 2;
      // 
      // lbSignIn
      // 
      this.lbSignIn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
      this.lbSignIn.AutoSize = true;
      this.lbSignIn.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbSignIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(118)))), ((int)(((byte)(185)))));
      this.lbSignIn.Location = new System.Drawing.Point(15, 621);
      this.lbSignIn.Name = "lbSignIn";
      this.lbSignIn.Size = new System.Drawing.Size(91, 14);
      this.lbSignIn.TabIndex = 6;
      this.lbSignIn.Text = "Signed in as";
      // 
      // pnlSideBarAvatar
      // 
      this.pnlSideBarAvatar.Controls.Add(this.lbAppName);
      this.pnlSideBarAvatar.Controls.Add(this.pictureBox1);
      this.pnlSideBarAvatar.Dock = System.Windows.Forms.DockStyle.Top;
      this.pnlSideBarAvatar.ForeColor = System.Drawing.Color.White;
      this.pnlSideBarAvatar.Location = new System.Drawing.Point(0, 0);
      this.pnlSideBarAvatar.Name = "pnlSideBarAvatar";
      this.pnlSideBarAvatar.Size = new System.Drawing.Size(241, 65);
      this.pnlSideBarAvatar.TabIndex = 7;
      // 
      // lbAppName
      // 
      this.lbAppName.AutoSize = true;
      this.lbAppName.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbAppName.Location = new System.Drawing.Point(59, 21);
      this.lbAppName.Name = "lbAppName";
      this.lbAppName.Size = new System.Drawing.Size(153, 22);
      this.lbAppName.TabIndex = 1;
      this.lbAppName.Text = "Stock Manager";
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
      this.pictureBox1.Location = new System.Drawing.Point(9, 11);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(52, 42);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pictureBox1.TabIndex = 0;
      this.pictureBox1.TabStop = false;
      // 
      // pnlInventorySubMenu
      // 
      this.pnlInventorySubMenu.Controls.Add(this.btnStocks);
      this.pnlInventorySubMenu.Controls.Add(this.btnStockCategories);
      this.pnlInventorySubMenu.Location = new System.Drawing.Point(39, 165);
      this.pnlInventorySubMenu.Name = "pnlInventorySubMenu";
      this.pnlInventorySubMenu.Size = new System.Drawing.Size(187, 71);
      this.pnlInventorySubMenu.TabIndex = 0;
      // 
      // btnStocks
      // 
      this.btnStocks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
      this.btnStocks.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
      this.btnStocks.FlatAppearance.BorderSize = 0;
      this.btnStocks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnStocks.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnStocks.ForeColor = System.Drawing.Color.White;
      this.btnStocks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnStocks.Location = new System.Drawing.Point(3, 36);
      this.btnStocks.Name = "btnStocks";
      this.btnStocks.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.btnStocks.Size = new System.Drawing.Size(155, 27);
      this.btnStocks.TabIndex = 11;
      this.btnStocks.Text = "Stocks";
      this.btnStocks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnStocks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.btnStocks.UseVisualStyleBackColor = false;
      this.btnStocks.Click += new System.EventHandler(this.btnStocks_Click);
      // 
      // btnStockCategories
      // 
      this.btnStockCategories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
      this.btnStockCategories.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
      this.btnStockCategories.FlatAppearance.BorderSize = 0;
      this.btnStockCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnStockCategories.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnStockCategories.ForeColor = System.Drawing.Color.White;
      this.btnStockCategories.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnStockCategories.Location = new System.Drawing.Point(3, 3);
      this.btnStockCategories.Name = "btnStockCategories";
      this.btnStockCategories.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.btnStockCategories.Size = new System.Drawing.Size(155, 27);
      this.btnStockCategories.TabIndex = 10;
      this.btnStockCategories.Text = "Categories";
      this.btnStockCategories.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnStockCategories.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.btnStockCategories.UseVisualStyleBackColor = false;
      this.btnStockCategories.Click += new System.EventHandler(this.btnStockCategories_Click);
      // 
      // btnExit
      // 
      this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
      this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
      this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
      this.btnExit.FlatAppearance.BorderSize = 0;
      this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnExit.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnExit.ForeColor = System.Drawing.Color.White;
      this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
      this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnExit.Location = new System.Drawing.Point(18, 677);
      this.btnExit.Name = "btnExit";
      this.btnExit.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.btnExit.Size = new System.Drawing.Size(214, 40);
      this.btnExit.TabIndex = 5;
      this.btnExit.Text = " Exit";
      this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.btnExit.UseVisualStyleBackColor = false;
      this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
      // 
      // btnSettings
      // 
      this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
      this.btnSettings.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
      this.btnSettings.FlatAppearance.BorderSize = 0;
      this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnSettings.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnSettings.ForeColor = System.Drawing.Color.White;
      this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
      this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnSettings.Location = new System.Drawing.Point(10, 279);
      this.btnSettings.Name = "btnSettings";
      this.btnSettings.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.btnSettings.Size = new System.Drawing.Size(216, 31);
      this.btnSettings.TabIndex = 4;
      this.btnSettings.Text = " Settings";
      this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.btnSettings.UseVisualStyleBackColor = false;
      this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
      // 
      // btnUsers
      // 
      this.btnUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
      this.btnUsers.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
      this.btnUsers.FlatAppearance.BorderSize = 0;
      this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnUsers.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnUsers.ForeColor = System.Drawing.Color.White;
      this.btnUsers.Image = ((System.Drawing.Image)(resources.GetObject("btnUsers.Image")));
      this.btnUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnUsers.Location = new System.Drawing.Point(10, 242);
      this.btnUsers.Name = "btnUsers";
      this.btnUsers.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.btnUsers.Size = new System.Drawing.Size(216, 31);
      this.btnUsers.TabIndex = 3;
      this.btnUsers.Text = " Users";
      this.btnUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.btnUsers.UseVisualStyleBackColor = false;
      this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
      // 
      // btnInventory
      // 
      this.btnInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
      this.btnInventory.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
      this.btnInventory.FlatAppearance.BorderSize = 0;
      this.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnInventory.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnInventory.ForeColor = System.Drawing.Color.White;
      this.btnInventory.Image = ((System.Drawing.Image)(resources.GetObject("btnInventory.Image")));
      this.btnInventory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnInventory.Location = new System.Drawing.Point(10, 128);
      this.btnInventory.Name = "btnInventory";
      this.btnInventory.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.btnInventory.Size = new System.Drawing.Size(216, 31);
      this.btnInventory.TabIndex = 2;
      this.btnInventory.Text = " Inventory";
      this.btnInventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnInventory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.btnInventory.UseVisualStyleBackColor = false;
      this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
      // 
      // btnDashboard
      // 
      this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
      this.btnDashboard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
      this.btnDashboard.FlatAppearance.BorderSize = 0;
      this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnDashboard.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnDashboard.ForeColor = System.Drawing.Color.White;
      this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
      this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnDashboard.Location = new System.Drawing.Point(10, 91);
      this.btnDashboard.Name = "btnDashboard";
      this.btnDashboard.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.btnDashboard.Size = new System.Drawing.Size(216, 31);
      this.btnDashboard.TabIndex = 1;
      this.btnDashboard.Text = " Dashboard";
      this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.btnDashboard.UseVisualStyleBackColor = false;
      this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
      // 
      // pnlSideMarker
      // 
      this.pnlSideMarker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(118)))), ((int)(((byte)(185)))));
      this.pnlSideMarker.Location = new System.Drawing.Point(0, 91);
      this.pnlSideMarker.Name = "pnlSideMarker";
      this.pnlSideMarker.Size = new System.Drawing.Size(6, 32);
      this.pnlSideMarker.TabIndex = 3;
      // 
      // msUsername
      // 
      this.msUsername.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
      this.msUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
      this.msUsername.Dock = System.Windows.Forms.DockStyle.None;
      this.msUsername.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.msUsername.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usernameToolStripMenuItem});
      this.msUsername.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
      this.msUsername.Location = new System.Drawing.Point(7, 635);
      this.msUsername.Name = "msUsername";
      this.msUsername.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
      this.msUsername.Size = new System.Drawing.Size(99, 24);
      this.msUsername.TabIndex = 10;
      this.msUsername.Text = "menuStrip1";
      // 
      // usernameToolStripMenuItem
      // 
      this.usernameToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
      this.usernameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changePasswordToolStripMenuItem,
            this.logoutToolStripMenuItem});
      this.usernameToolStripMenuItem.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.usernameToolStripMenuItem.ForeColor = System.Drawing.Color.White;
      this.usernameToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("usernameToolStripMenuItem.Image")));
      this.usernameToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
      this.usernameToolStripMenuItem.Name = "usernameToolStripMenuItem";
      this.usernameToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
      this.usernameToolStripMenuItem.Text = "Username";
      // 
      // changePasswordToolStripMenuItem
      // 
      this.changePasswordToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
      this.changePasswordToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.changePasswordToolStripMenuItem.ForeColor = System.Drawing.Color.White;
      this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
      this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
      this.changePasswordToolStripMenuItem.Text = "Change password";
      this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
      // 
      // logoutToolStripMenuItem
      // 
      this.logoutToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
      this.logoutToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.logoutToolStripMenuItem.ForeColor = System.Drawing.Color.White;
      this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
      this.logoutToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
      this.logoutToolStripMenuItem.Text = "Logout";
      this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
      // 
      // pnlViews
      // 
      this.pnlViews.AutoSize = true;
      this.pnlViews.BackColor = System.Drawing.SystemColors.Control;
      this.pnlViews.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pnlViews.ForeColor = System.Drawing.Color.White;
      this.pnlViews.Location = new System.Drawing.Point(241, 0);
      this.pnlViews.Name = "pnlViews";
      this.pnlViews.Size = new System.Drawing.Size(767, 729);
      this.pnlViews.TabIndex = 8;
      // 
      // MainForm
      // 
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
      this.ClientSize = new System.Drawing.Size(1008, 729);
      this.Controls.Add(this.pnlViews);
      this.Controls.Add(this.pnlSidebar);
      this.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MainMenuStrip = this.msUsername;
      this.MinimumSize = new System.Drawing.Size(800, 600);
      this.Name = "MainForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Stock Manager";
      this.pnlSidebar.ResumeLayout(false);
      this.pnlSidebar.PerformLayout();
      this.pnlSideBarAvatar.ResumeLayout(false);
      this.pnlSideBarAvatar.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.pnlInventorySubMenu.ResumeLayout(false);
      this.msUsername.ResumeLayout(false);
      this.msUsername.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Panel pnlSideMarker;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Panel pnlInventorySubMenu;
        private System.Windows.Forms.Button btnStocks;
        private System.Windows.Forms.Button btnStockCategories;
        private System.Windows.Forms.Panel pnlSideBarAvatar;
    private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel pnlViews;
        private System.Windows.Forms.Label lbAppName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbSignIn;
        private System.Windows.Forms.MenuStrip msUsername;
        private System.Windows.Forms.ToolStripMenuItem usernameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
  }
}