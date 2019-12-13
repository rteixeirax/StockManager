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
      this.topPanel = new System.Windows.Forms.Panel();
      this.leftPanel = new System.Windows.Forms.Panel();
      this.sideMarker = new System.Windows.Forms.Panel();
      this.btnDashboard = new System.Windows.Forms.Button();
      this.btnStocks = new System.Windows.Forms.Button();
      this.labelUsername = new System.Windows.Forms.Label();
      this.labelUser = new System.Windows.Forms.Label();
      this.leftPanel.SuspendLayout();
      this.SuspendLayout();
      // 
      // topPanel
      // 
      this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
      this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
      this.topPanel.Location = new System.Drawing.Point(0, 0);
      this.topPanel.Name = "topPanel";
      this.topPanel.Size = new System.Drawing.Size(1242, 54);
      this.topPanel.TabIndex = 1;
      // 
      // leftPanel
      // 
      this.leftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
      this.leftPanel.Controls.Add(this.labelUsername);
      this.leftPanel.Controls.Add(this.btnStocks);
      this.leftPanel.Controls.Add(this.labelUser);
      this.leftPanel.Controls.Add(this.btnDashboard);
      this.leftPanel.Controls.Add(this.sideMarker);
      this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
      this.leftPanel.Location = new System.Drawing.Point(0, 54);
      this.leftPanel.Name = "leftPanel";
      this.leftPanel.Size = new System.Drawing.Size(213, 590);
      this.leftPanel.TabIndex = 2;
      // 
      // sideMarker
      // 
      this.sideMarker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(232)))), ((int)(((byte)(166)))));
      this.sideMarker.Location = new System.Drawing.Point(0, 51);
      this.sideMarker.Name = "sideMarker";
      this.sideMarker.Size = new System.Drawing.Size(6, 32);
      this.sideMarker.TabIndex = 3;
      // 
      // btnDashboard
      // 
      this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
      this.btnDashboard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
      this.btnDashboard.FlatAppearance.BorderSize = 0;
      this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnDashboard.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnDashboard.ForeColor = System.Drawing.Color.White;
      this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
      this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnDashboard.Location = new System.Drawing.Point(10, 52);
      this.btnDashboard.Name = "btnDashboard";
      this.btnDashboard.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.btnDashboard.Size = new System.Drawing.Size(200, 31);
      this.btnDashboard.TabIndex = 3;
      this.btnDashboard.Text = "Dashboard";
      this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.btnDashboard.UseVisualStyleBackColor = false;
      this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
      // 
      // btnStocks
      // 
      this.btnStocks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
      this.btnStocks.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
      this.btnStocks.FlatAppearance.BorderSize = 0;
      this.btnStocks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnStocks.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnStocks.ForeColor = System.Drawing.Color.White;
      this.btnStocks.Image = ((System.Drawing.Image)(resources.GetObject("btnStocks.Image")));
      this.btnStocks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnStocks.Location = new System.Drawing.Point(10, 89);
      this.btnStocks.Name = "btnStocks";
      this.btnStocks.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.btnStocks.Size = new System.Drawing.Size(200, 31);
      this.btnStocks.TabIndex = 4;
      this.btnStocks.Text = "Stocks";
      this.btnStocks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnStocks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.btnStocks.UseVisualStyleBackColor = false;
      this.btnStocks.Click += new System.EventHandler(this.btnStocks_Click);
      // 
      // labelUsername
      // 
      this.labelUsername.AutoSize = true;
      this.labelUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(232)))), ((int)(((byte)(166)))));
      this.labelUsername.Location = new System.Drawing.Point(55, 18);
      this.labelUsername.Name = "labelUsername";
      this.labelUsername.Size = new System.Drawing.Size(119, 14);
      this.labelUsername.TabIndex = 5;
      this.labelUsername.Text = "Ricardo Teixeira";
      // 
      // labelUser
      // 
      this.labelUser.AutoSize = true;
      this.labelUser.ForeColor = System.Drawing.Color.White;
      this.labelUser.Location = new System.Drawing.Point(7, 18);
      this.labelUser.Name = "labelUser";
      this.labelUser.Size = new System.Drawing.Size(42, 14);
      this.labelUser.TabIndex = 6;
      this.labelUser.Text = "User:";
      // 
      // MainForm
      // 
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
      this.ClientSize = new System.Drawing.Size(1242, 644);
      this.Controls.Add(this.leftPanel);
      this.Controls.Add(this.topPanel);
      this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "MainForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Stock Manager";
      this.leftPanel.ResumeLayout(false);
      this.leftPanel.PerformLayout();
      this.ResumeLayout(false);

    }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Button btnStocks;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Panel sideMarker;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelUser;
    }
}