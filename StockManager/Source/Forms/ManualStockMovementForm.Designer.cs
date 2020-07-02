namespace StockManager.Source.Forms
{
  partial class ManualStockMovementForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManualStockMovementForm));
      this.pnlBody = new System.Windows.Forms.Panel();
      this.cbProduct = new System.Windows.Forms.ComboBox();
      this.lbProduct = new System.Windows.Forms.Label();
      this.numQty = new System.Windows.Forms.NumericUpDown();
      this.cbTo = new System.Windows.Forms.ComboBox();
      this.btnCancel = new System.Windows.Forms.Button();
      this.pnlTopBar = new System.Windows.Forms.Panel();
      this.lbTitle = new System.Windows.Forms.Label();
      this.btnSave = new System.Windows.Forms.Button();
      this.lbTo = new System.Windows.Forms.Label();
      this.lbQty = new System.Windows.Forms.Label();
      this.cbFrom = new System.Windows.Forms.ComboBox();
      this.lbFrom = new System.Windows.Forms.Label();
      this.pnlBody.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numQty)).BeginInit();
      this.pnlTopBar.SuspendLayout();
      this.SuspendLayout();
      // 
      // pnlBody
      // 
      this.pnlBody.BackColor = System.Drawing.SystemColors.Control;
      this.pnlBody.Controls.Add(this.cbProduct);
      this.pnlBody.Controls.Add(this.lbProduct);
      this.pnlBody.Controls.Add(this.numQty);
      this.pnlBody.Controls.Add(this.cbTo);
      this.pnlBody.Controls.Add(this.btnCancel);
      this.pnlBody.Controls.Add(this.pnlTopBar);
      this.pnlBody.Controls.Add(this.btnSave);
      this.pnlBody.Controls.Add(this.lbTo);
      this.pnlBody.Controls.Add(this.lbQty);
      this.pnlBody.Controls.Add(this.cbFrom);
      this.pnlBody.Controls.Add(this.lbFrom);
      this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pnlBody.Location = new System.Drawing.Point(0, 0);
      this.pnlBody.Name = "pnlBody";
      this.pnlBody.Size = new System.Drawing.Size(451, 363);
      this.pnlBody.TabIndex = 8;
      // 
      // cbProduct
      // 
      this.cbProduct.BackColor = System.Drawing.Color.White;
      this.cbProduct.Cursor = System.Windows.Forms.Cursors.Hand;
      this.cbProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbProduct.ForeColor = System.Drawing.Color.Black;
      this.cbProduct.FormattingEnabled = true;
      this.cbProduct.Location = new System.Drawing.Point(101, 193);
      this.cbProduct.Name = "cbProduct";
      this.cbProduct.Size = new System.Drawing.Size(252, 24);
      this.cbProduct.TabIndex = 21;
      // 
      // lbProduct
      // 
      this.lbProduct.AutoSize = true;
      this.lbProduct.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(118)))), ((int)(((byte)(185)))));
      this.lbProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.lbProduct.Location = new System.Drawing.Point(98, 174);
      this.lbProduct.Name = "lbProduct";
      this.lbProduct.Size = new System.Drawing.Size(80, 16);
      this.lbProduct.TabIndex = 20;
      this.lbProduct.Text = "lbProduct";
      // 
      // numQty
      // 
      this.numQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.numQty.Font = new System.Drawing.Font("Courier New", 11.25F);
      this.numQty.Location = new System.Drawing.Point(103, 249);
      this.numQty.Maximum = new decimal(new int[] {
            -1530494977,
            232830,
            0,
            0});
      this.numQty.Name = "numQty";
      this.numQty.Size = new System.Drawing.Size(252, 24);
      this.numQty.TabIndex = 19;
      this.numQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.numQty.ThousandsSeparator = true;
      // 
      // cbTo
      // 
      this.cbTo.BackColor = System.Drawing.Color.White;
      this.cbTo.Cursor = System.Windows.Forms.Cursors.Hand;
      this.cbTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbTo.ForeColor = System.Drawing.Color.Black;
      this.cbTo.FormattingEnabled = true;
      this.cbTo.Location = new System.Drawing.Point(103, 137);
      this.cbTo.Name = "cbTo";
      this.cbTo.Size = new System.Drawing.Size(252, 24);
      this.cbTo.TabIndex = 18;
      // 
      // btnCancel
      // 
      this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
      this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnCancel.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnCancel.ForeColor = System.Drawing.Color.White;
      this.btnCancel.Location = new System.Drawing.Point(103, 305);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(120, 32);
      this.btnCancel.TabIndex = 17;
      this.btnCancel.Text = "btnCancel";
      this.btnCancel.UseVisualStyleBackColor = false;
      // 
      // pnlTopBar
      // 
      this.pnlTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
      this.pnlTopBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.pnlTopBar.Controls.Add(this.lbTitle);
      this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
      this.pnlTopBar.Location = new System.Drawing.Point(0, 0);
      this.pnlTopBar.Name = "pnlTopBar";
      this.pnlTopBar.Size = new System.Drawing.Size(451, 44);
      this.pnlTopBar.TabIndex = 16;
      // 
      // lbTitle
      // 
      this.lbTitle.AutoSize = true;
      this.lbTitle.BackColor = System.Drawing.Color.Transparent;
      this.lbTitle.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbTitle.ForeColor = System.Drawing.Color.White;
      this.lbTitle.Location = new System.Drawing.Point(12, 11);
      this.lbTitle.Name = "lbTitle";
      this.lbTitle.Size = new System.Drawing.Size(87, 22);
      this.lbTitle.TabIndex = 1;
      this.lbTitle.Text = "lbTitle";
      // 
      // btnSave
      // 
      this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
      this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnSave.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnSave.ForeColor = System.Drawing.Color.White;
      this.btnSave.Location = new System.Drawing.Point(235, 305);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(120, 32);
      this.btnSave.TabIndex = 4;
      this.btnSave.Text = "btnSave";
      this.btnSave.UseVisualStyleBackColor = false;
      // 
      // lbTo
      // 
      this.lbTo.AutoSize = true;
      this.lbTo.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(118)))), ((int)(((byte)(185)))));
      this.lbTo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.lbTo.Location = new System.Drawing.Point(100, 118);
      this.lbTo.Name = "lbTo";
      this.lbTo.Size = new System.Drawing.Size(40, 16);
      this.lbTo.TabIndex = 9;
      this.lbTo.Text = "lbTo";
      // 
      // lbQty
      // 
      this.lbQty.AutoSize = true;
      this.lbQty.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbQty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(118)))), ((int)(((byte)(185)))));
      this.lbQty.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.lbQty.Location = new System.Drawing.Point(100, 230);
      this.lbQty.Name = "lbQty";
      this.lbQty.Size = new System.Drawing.Size(48, 16);
      this.lbQty.TabIndex = 8;
      this.lbQty.Text = "lbQty";
      // 
      // cbFrom
      // 
      this.cbFrom.BackColor = System.Drawing.Color.White;
      this.cbFrom.Cursor = System.Windows.Forms.Cursors.Hand;
      this.cbFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbFrom.ForeColor = System.Drawing.Color.Black;
      this.cbFrom.FormattingEnabled = true;
      this.cbFrom.Location = new System.Drawing.Point(103, 83);
      this.cbFrom.Name = "cbFrom";
      this.cbFrom.Size = new System.Drawing.Size(252, 24);
      this.cbFrom.TabIndex = 3;
      this.cbFrom.SelectionChangeCommitted += new System.EventHandler(this.cbFrom_SelectedIndexChanged);
      // 
      // lbFrom
      // 
      this.lbFrom.AutoSize = true;
      this.lbFrom.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbFrom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(118)))), ((int)(((byte)(185)))));
      this.lbFrom.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.lbFrom.Location = new System.Drawing.Point(100, 64);
      this.lbFrom.Name = "lbFrom";
      this.lbFrom.Size = new System.Drawing.Size(56, 16);
      this.lbFrom.TabIndex = 2;
      this.lbFrom.Text = "lbFrom";
      // 
      // ManualStockMovementForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(451, 363);
      this.Controls.Add(this.pnlBody);
      this.Font = new System.Drawing.Font("Courier New", 9.75F);
      this.ForeColor = System.Drawing.Color.White;
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Margin = new System.Windows.Forms.Padding(4);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "ManualStockMovementForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Stock Manager | Move stock";
      this.pnlBody.ResumeLayout(false);
      this.pnlBody.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numQty)).EndInit();
      this.pnlTopBar.ResumeLayout(false);
      this.pnlTopBar.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel pnlBody;
    private System.Windows.Forms.Button btnCancel;
    private System.Windows.Forms.Panel pnlTopBar;
    private System.Windows.Forms.Label lbTitle;
    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.Label lbTo;
    private System.Windows.Forms.Label lbQty;
    private System.Windows.Forms.ComboBox cbFrom;
    private System.Windows.Forms.Label lbFrom;
    private System.Windows.Forms.NumericUpDown numQty;
    private System.Windows.Forms.ComboBox cbTo;
    private System.Windows.Forms.ComboBox cbProduct;
    private System.Windows.Forms.Label lbProduct;
  }
}