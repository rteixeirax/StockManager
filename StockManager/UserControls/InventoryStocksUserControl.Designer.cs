namespace StockManager.UserControls
{
  partial class InventoryStocksUserControl
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryStocksUserControl));
      this.panelTopBar = new System.Windows.Forms.Panel();
      this.panelSearch = new System.Windows.Forms.Panel();
      this.buttonSearch = new System.Windows.Forms.Button();
      this.textBoxSearch = new System.Windows.Forms.TextBox();
      this.panelTitle = new System.Windows.Forms.Panel();
      this.labelTitle = new System.Windows.Forms.Label();
      this.panelTopBar.SuspendLayout();
      this.panelSearch.SuspendLayout();
      this.panelTitle.SuspendLayout();
      this.SuspendLayout();
      // 
      // panelTopBar
      // 
      this.panelTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
      this.panelTopBar.Controls.Add(this.panelSearch);
      this.panelTopBar.Controls.Add(this.panelTitle);
      this.panelTopBar.Dock = System.Windows.Forms.DockStyle.Top;
      this.panelTopBar.Location = new System.Drawing.Point(0, 0);
      this.panelTopBar.Name = "panelTopBar";
      this.panelTopBar.Size = new System.Drawing.Size(860, 43);
      this.panelTopBar.TabIndex = 1;
      // 
      // panelSearch
      // 
      this.panelSearch.Controls.Add(this.buttonSearch);
      this.panelSearch.Controls.Add(this.textBoxSearch);
      this.panelSearch.Dock = System.Windows.Forms.DockStyle.Right;
      this.panelSearch.Location = new System.Drawing.Point(620, 0);
      this.panelSearch.Name = "panelSearch";
      this.panelSearch.Size = new System.Drawing.Size(240, 43);
      this.panelSearch.TabIndex = 2;
      // 
      // buttonSearch
      // 
      this.buttonSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
      this.buttonSearch.FlatAppearance.BorderSize = 0;
      this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.buttonSearch.Image = ((System.Drawing.Image)(resources.GetObject("buttonSearch.Image")));
      this.buttonSearch.Location = new System.Drawing.Point(197, 11);
      this.buttonSearch.Name = "buttonSearch";
      this.buttonSearch.Size = new System.Drawing.Size(26, 21);
      this.buttonSearch.TabIndex = 2;
      this.buttonSearch.UseVisualStyleBackColor = true;
      // 
      // textBoxSearch
      // 
      this.textBoxSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
      this.textBoxSearch.ForeColor = System.Drawing.Color.White;
      this.textBoxSearch.Location = new System.Drawing.Point(15, 11);
      this.textBoxSearch.Name = "textBoxSearch";
      this.textBoxSearch.Size = new System.Drawing.Size(179, 22);
      this.textBoxSearch.TabIndex = 0;
      // 
      // panelTitle
      // 
      this.panelTitle.Controls.Add(this.labelTitle);
      this.panelTitle.Dock = System.Windows.Forms.DockStyle.Left;
      this.panelTitle.Location = new System.Drawing.Point(0, 0);
      this.panelTitle.Name = "panelTitle";
      this.panelTitle.Size = new System.Drawing.Size(206, 43);
      this.panelTitle.TabIndex = 1;
      // 
      // labelTitle
      // 
      this.labelTitle.AutoSize = true;
      this.labelTitle.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelTitle.Location = new System.Drawing.Point(11, 11);
      this.labelTitle.Name = "labelTitle";
      this.labelTitle.Size = new System.Drawing.Size(186, 21);
      this.labelTitle.TabIndex = 1;
      this.labelTitle.Text = "Inventory stocks";
      // 
      // InventoryStocksUserControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
      this.Controls.Add(this.panelTopBar);
      this.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ForeColor = System.Drawing.Color.White;
      this.Margin = new System.Windows.Forms.Padding(4);
      this.Name = "InventoryStocksUserControl";
      this.Size = new System.Drawing.Size(860, 420);
      this.panelTopBar.ResumeLayout(false);
      this.panelSearch.ResumeLayout(false);
      this.panelSearch.PerformLayout();
      this.panelTitle.ResumeLayout(false);
      this.panelTitle.PerformLayout();
      this.ResumeLayout(false);

    }

        #endregion

        private System.Windows.Forms.Panel panelTopBar;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label labelTitle;
    }
}
