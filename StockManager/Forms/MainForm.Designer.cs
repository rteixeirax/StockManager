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
      this.lbUsername = new System.Windows.Forms.Label();
      this.lbSignIn = new System.Windows.Forms.Label();
      this.pnlSideBarAvatar = new System.Windows.Forms.Panel();
      this.label1 = new System.Windows.Forms.Label();
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
      this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
      this.pnlViews = new System.Windows.Forms.Panel();
      this.ucUsers = new StockManager.UserControls.UsersUserControl();
      this.ucDashboard = new StockManager.UserControls.DashboardUserControl();
      this.ucSettings = new StockManager.Controls.SettingsUserControl();
      this.ucInventoryStocks = new StockManager.UserControls.InventoryStocksUserControl();
      this.ucInventoryCategories = new StockManager.UserControls.InventoryCategoriesUserControl();
      this.pnlSidebar.SuspendLayout();
      this.pnlSideBarAvatar.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.pnlInventorySubMenu.SuspendLayout();
      this.pnlViews.SuspendLayout();
      this.SuspendLayout();
      // 
      // pnlSidebar
      // 
      this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
      this.pnlSidebar.Controls.Add(this.lbUsername);
      this.pnlSidebar.Controls.Add(this.lbSignIn);
      this.pnlSidebar.Controls.Add(this.pnlSideBarAvatar);
      this.pnlSidebar.Controls.Add(this.pnlInventorySubMenu);
      this.pnlSidebar.Controls.Add(this.btnExit);
      this.pnlSidebar.Controls.Add(this.btnSettings);
      this.pnlSidebar.Controls.Add(this.btnUsers);
      this.pnlSidebar.Controls.Add(this.btnInventory);
      this.pnlSidebar.Controls.Add(this.btnDashboard);
      this.pnlSidebar.Controls.Add(this.pnlSideMarker);
      this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
      this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
      this.pnlSidebar.Name = "pnlSidebar";
      this.pnlSidebar.Size = new System.Drawing.Size(241, 729);
      this.pnlSidebar.TabIndex = 2;
      // 
      // lbUsername
      // 
      this.lbUsername.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
      this.lbUsername.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbUsername.ForeColor = System.Drawing.Color.White;
      this.lbUsername.Location = new System.Drawing.Point(20, 648);
      this.lbUsername.Name = "lbUsername";
      this.lbUsername.Size = new System.Drawing.Size(172, 17);
      this.lbUsername.TabIndex = 5;
      this.lbUsername.Text = "Ricardo Teixeira";
      this.lbUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // lbSignIn
      // 
      this.lbSignIn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
      this.lbSignIn.AutoSize = true;
      this.lbSignIn.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbSignIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(118)))), ((int)(((byte)(185)))));
      this.lbSignIn.Location = new System.Drawing.Point(18, 632);
      this.lbSignIn.Name = "lbSignIn";
      this.lbSignIn.Size = new System.Drawing.Size(91, 14);
      this.lbSignIn.TabIndex = 6;
      this.lbSignIn.Text = "Signed in as";
      // 
      // pnlSideBarAvatar
      // 
      this.pnlSideBarAvatar.Controls.Add(this.label1);
      this.pnlSideBarAvatar.Controls.Add(this.pictureBox1);
      this.pnlSideBarAvatar.Dock = System.Windows.Forms.DockStyle.Top;
      this.pnlSideBarAvatar.ForeColor = System.Drawing.Color.White;
      this.pnlSideBarAvatar.Location = new System.Drawing.Point(0, 0);
      this.pnlSideBarAvatar.Name = "pnlSideBarAvatar";
      this.pnlSideBarAvatar.Size = new System.Drawing.Size(241, 66);
      this.pnlSideBarAvatar.TabIndex = 7;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(57, 22);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(153, 22);
      this.label1.TabIndex = 1;
      this.label1.Text = "Stock Manager";
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
      this.btnExit.TabIndex = 9;
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
      this.btnSettings.TabIndex = 8;
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
      this.btnUsers.TabIndex = 7;
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
      this.btnInventory.TabIndex = 4;
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
      this.btnDashboard.TabIndex = 3;
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
      // pnlViews
      // 
      this.pnlViews.AutoSize = true;
      this.pnlViews.BackColor = System.Drawing.SystemColors.Control;
      this.pnlViews.Controls.Add(this.ucUsers);
      this.pnlViews.Controls.Add(this.ucDashboard);
      this.pnlViews.Controls.Add(this.ucSettings);
      this.pnlViews.Controls.Add(this.ucInventoryStocks);
      this.pnlViews.Controls.Add(this.ucInventoryCategories);
      this.pnlViews.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pnlViews.ForeColor = System.Drawing.Color.White;
      this.pnlViews.Location = new System.Drawing.Point(241, 0);
      this.pnlViews.Name = "pnlViews";
      this.pnlViews.Size = new System.Drawing.Size(767, 729);
      this.pnlViews.TabIndex = 8;
      // 
      // ucUsers
      // 
      this.ucUsers.BackColor = System.Drawing.Color.Transparent;
      this.ucUsers.Dock = System.Windows.Forms.DockStyle.Fill;
      this.ucUsers.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ucUsers.ForeColor = System.Drawing.Color.White;
      this.ucUsers.Location = new System.Drawing.Point(0, 0);
      this.ucUsers.Margin = new System.Windows.Forms.Padding(4);
      this.ucUsers.Name = "ucUsers";
      this.ucUsers.Size = new System.Drawing.Size(767, 729);
      this.ucUsers.TabIndex = 1;
      // 
      // ucDashboard
      // 
      this.ucDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
      this.ucDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
      this.ucDashboard.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ucDashboard.ForeColor = System.Drawing.Color.White;
      this.ucDashboard.Location = new System.Drawing.Point(0, 0);
      this.ucDashboard.Margin = new System.Windows.Forms.Padding(4);
      this.ucDashboard.Name = "ucDashboard";
      this.ucDashboard.Size = new System.Drawing.Size(767, 729);
      this.ucDashboard.TabIndex = 0;
      // 
      // ucSettings
      // 
      this.ucSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
      this.ucSettings.Dock = System.Windows.Forms.DockStyle.Fill;
      this.ucSettings.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ucSettings.ForeColor = System.Drawing.Color.White;
      this.ucSettings.Location = new System.Drawing.Point(0, 0);
      this.ucSettings.Margin = new System.Windows.Forms.Padding(4);
      this.ucSettings.Name = "ucSettings";
      this.ucSettings.Size = new System.Drawing.Size(767, 729);
      this.ucSettings.TabIndex = 4;
      // 
      // ucInventoryStocks
      // 
      this.ucInventoryStocks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
      this.ucInventoryStocks.Dock = System.Windows.Forms.DockStyle.Fill;
      this.ucInventoryStocks.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ucInventoryStocks.ForeColor = System.Drawing.Color.White;
      this.ucInventoryStocks.Location = new System.Drawing.Point(0, 0);
      this.ucInventoryStocks.Margin = new System.Windows.Forms.Padding(4);
      this.ucInventoryStocks.Name = "ucInventoryStocks";
      this.ucInventoryStocks.Size = new System.Drawing.Size(767, 729);
      this.ucInventoryStocks.TabIndex = 3;
      // 
      // ucInventoryCategories
      // 
      this.ucInventoryCategories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
      this.ucInventoryCategories.Dock = System.Windows.Forms.DockStyle.Fill;
      this.ucInventoryCategories.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ucInventoryCategories.ForeColor = System.Drawing.Color.White;
      this.ucInventoryCategories.Location = new System.Drawing.Point(0, 0);
      this.ucInventoryCategories.Margin = new System.Windows.Forms.Padding(4);
      this.ucInventoryCategories.Name = "ucInventoryCategories";
      this.ucInventoryCategories.Size = new System.Drawing.Size(767, 729);
      this.ucInventoryCategories.TabIndex = 2;
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
      this.pnlViews.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Panel pnlSideMarker;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Panel pnlInventorySubMenu;
        private System.Windows.Forms.Button btnStocks;
        private System.Windows.Forms.Button btnStockCategories;
        private System.Windows.Forms.Panel pnlSideBarAvatar;
    private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel pnlViews;
        private UserControls.DashboardUserControl ucDashboard;
        private UserControls.UsersUserControl ucUsers;
        private Controls.SettingsUserControl ucSettings;
        private UserControls.InventoryStocksUserControl ucInventoryStocks;
        private UserControls.InventoryCategoriesUserControl ucInventoryCategories;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbSignIn;
    }
}