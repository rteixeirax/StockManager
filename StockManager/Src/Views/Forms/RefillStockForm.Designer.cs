namespace StockManager.Src.Views.Forms
{
    partial class RefillStockForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RefillStockForm));
            this.pnlBody = new System.Windows.Forms.Panel();
            this.numRefillQty = new System.Windows.Forms.NumericUpDown();
            this.numCurrentStock = new System.Windows.Forms.NumericUpDown();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbErrorRefillQty = new System.Windows.Forms.Label();
            this.lbErrorCurrentStock = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lbRefillQty = new System.Windows.Forms.Label();
            this.lbCurrentStock = new System.Windows.Forms.Label();
            this.pnlBody.SuspendLayout();
            (( System.ComponentModel.ISupportInitialize )(this.numRefillQty)).BeginInit();
            (( System.ComponentModel.ISupportInitialize )(this.numCurrentStock)).BeginInit();
            this.pnlTopBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBody
            // 
            this.pnlBody.BackColor = System.Drawing.SystemColors.Control;
            this.pnlBody.Controls.Add(this.numRefillQty);
            this.pnlBody.Controls.Add(this.numCurrentStock);
            this.pnlBody.Controls.Add(this.btnCancel);
            this.pnlBody.Controls.Add(this.pnlTopBar);
            this.pnlBody.Controls.Add(this.lbErrorRefillQty);
            this.pnlBody.Controls.Add(this.lbErrorCurrentStock);
            this.pnlBody.Controls.Add(this.btnSave);
            this.pnlBody.Controls.Add(this.lbRefillQty);
            this.pnlBody.Controls.Add(this.lbCurrentStock);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 0);
            this.pnlBody.Margin = new System.Windows.Forms.Padding(4);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(451, 299);
            this.pnlBody.TabIndex = 8;
            // 
            // numRefillQty
            // 
            this.numRefillQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numRefillQty.Font = new System.Drawing.Font("Courier New", 11.25F);
            this.numRefillQty.Location = new System.Drawing.Point(103, 149);
            this.numRefillQty.Margin = new System.Windows.Forms.Padding(4);
            this.numRefillQty.Maximum = new decimal(new int[] {
            -1530494977,
            232830,
            0,
            0});
            this.numRefillQty.Name = "numRefillQty";
            this.numRefillQty.Size = new System.Drawing.Size(252, 24);
            this.numRefillQty.TabIndex = 1;
            this.numRefillQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numRefillQty.ThousandsSeparator = true;
            this.numRefillQty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDown);
            // 
            // numCurrentStock
            // 
            this.numCurrentStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numCurrentStock.Font = new System.Drawing.Font("Courier New", 11.25F);
            this.numCurrentStock.Location = new System.Drawing.Point(103, 83);
            this.numCurrentStock.Margin = new System.Windows.Forms.Padding(4);
            this.numCurrentStock.Maximum = new decimal(new int[] {
            -1530494977,
            232830,
            0,
            0});
            this.numCurrentStock.Name = "numCurrentStock";
            this.numCurrentStock.Size = new System.Drawing.Size(252, 24);
            this.numCurrentStock.TabIndex = 0;
            this.numCurrentStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numCurrentStock.ThousandsSeparator = true;
            this.numCurrentStock.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDown);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb((( int )((( byte )(217)))), (( int )((( byte )(83)))), (( int )((( byte )(79)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (( byte )(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(103, 229);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 32);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.BackColor = System.Drawing.Color.FromArgb((( int )((( byte )(26)))), (( int )((( byte )(29)))), (( int )((( byte )(33)))));
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
            this.lbTitle.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (( byte )(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.White;
            this.lbTitle.Location = new System.Drawing.Point(16, 14);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(87, 22);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "lbTitle";
            // 
            // lbErrorRefillQty
            // 
            this.lbErrorRefillQty.AutoSize = true;
            this.lbErrorRefillQty.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, (( byte )(0)));
            this.lbErrorRefillQty.ForeColor = System.Drawing.Color.Red;
            this.lbErrorRefillQty.Location = new System.Drawing.Point(106, 174);
            this.lbErrorRefillQty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbErrorRefillQty.MaximumSize = new System.Drawing.Size(252, 0);
            this.lbErrorRefillQty.Name = "lbErrorRefillQty";
            this.lbErrorRefillQty.Size = new System.Drawing.Size(120, 16);
            this.lbErrorRefillQty.TabIndex = 15;
            this.lbErrorRefillQty.Text = "lbErrorRefillQty";
            // 
            // lbErrorCurrentStock
            // 
            this.lbErrorCurrentStock.AutoSize = true;
            this.lbErrorCurrentStock.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, (( byte )(0)));
            this.lbErrorCurrentStock.ForeColor = System.Drawing.Color.Red;
            this.lbErrorCurrentStock.Location = new System.Drawing.Point(106, 108);
            this.lbErrorCurrentStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbErrorCurrentStock.Name = "lbErrorCurrentStock";
            this.lbErrorCurrentStock.Size = new System.Drawing.Size(141, 16);
            this.lbErrorCurrentStock.TabIndex = 14;
            this.lbErrorCurrentStock.Text = "lbErrorCurrentStock";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb((( int )((( byte )(92)))), (( int )((( byte )(184)))), (( int )((( byte )(92)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (( byte )(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(235, 229);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 32);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "btnSave";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lbRefillQty
            // 
            this.lbRefillQty.AutoSize = true;
            this.lbRefillQty.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (( byte )(0)));
            this.lbRefillQty.ForeColor = System.Drawing.Color.FromArgb((( int )((( byte )(5)))), (( int )((( byte )(118)))), (( int )((( byte )(185)))));
            this.lbRefillQty.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbRefillQty.Location = new System.Drawing.Point(100, 130);
            this.lbRefillQty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbRefillQty.Name = "lbRefillQty";
            this.lbRefillQty.Size = new System.Drawing.Size(96, 16);
            this.lbRefillQty.TabIndex = 9;
            this.lbRefillQty.Text = "lbRefillQty";
            // 
            // lbCurrentStock
            // 
            this.lbCurrentStock.AutoSize = true;
            this.lbCurrentStock.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (( byte )(0)));
            this.lbCurrentStock.ForeColor = System.Drawing.Color.FromArgb((( int )((( byte )(5)))), (( int )((( byte )(118)))), (( int )((( byte )(185)))));
            this.lbCurrentStock.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbCurrentStock.Location = new System.Drawing.Point(100, 64);
            this.lbCurrentStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCurrentStock.Name = "lbCurrentStock";
            this.lbCurrentStock.Size = new System.Drawing.Size(120, 16);
            this.lbCurrentStock.TabIndex = 2;
            this.lbCurrentStock.Text = "lbCurrentStock";
            // 
            // RefillStockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 299);
            this.Controls.Add(this.pnlBody);
            this.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = (( System.Drawing.Icon )(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RefillStockForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Stock Manager | Edit stock";
            this.pnlBody.ResumeLayout(false);
            this.pnlBody.PerformLayout();
            (( System.ComponentModel.ISupportInitialize )(this.numRefillQty)).EndInit();
            (( System.ComponentModel.ISupportInitialize )(this.numCurrentStock)).EndInit();
            this.pnlTopBar.ResumeLayout(false);
            this.pnlTopBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbErrorRefillQty;
        private System.Windows.Forms.Label lbErrorCurrentStock;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lbRefillQty;
        private System.Windows.Forms.Label lbCurrentStock;
        private System.Windows.Forms.NumericUpDown numRefillQty;
        private System.Windows.Forms.NumericUpDown numCurrentStock;
    }
}