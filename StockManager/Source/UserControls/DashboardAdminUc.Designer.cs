namespace StockManager.Source.UserControls
{
  partial class DashboardAdminUc
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnStockMovement = new System.Windows.Forms.Button();
            this.lbStockAlerts = new System.Windows.Forms.Label();
            this.pnlActions = new System.Windows.Forms.Panel();
            this.dgvProductStockAlerts = new System.Windows.Forms.DataGridView();
            this.columnProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnProducRef = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnLocationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbUsersCount = new System.Windows.Forms.Label();
            this.lbProductsCount = new System.Windows.Forms.Label();
            this.lbLocationsCount = new System.Windows.Forms.Label();
            this.lbUsers = new System.Windows.Forms.Label();
            this.lbProducts = new System.Windows.Forms.Label();
            this.lbGlobalInfo = new System.Windows.Forms.Label();
            this.tblpGlobalInfo = new System.Windows.Forms.TableLayoutPanel();
            this.lbLocations = new System.Windows.Forms.Label();
            this.pnlActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductStockAlerts)).BeginInit();
            this.tblpGlobalInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStockMovement
            // 
            this.btnStockMovement.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStockMovement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(118)))), ((int)(((byte)(185)))));
            this.btnStockMovement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStockMovement.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockMovement.ForeColor = System.Drawing.Color.White;
            this.btnStockMovement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStockMovement.Location = new System.Drawing.Point(79, 4);
            this.btnStockMovement.Name = "btnStockMovement";
            this.btnStockMovement.Size = new System.Drawing.Size(121, 27);
            this.btnStockMovement.TabIndex = 7;
            this.btnStockMovement.Text = "btnStockMovement";
            this.btnStockMovement.UseVisualStyleBackColor = false;
            this.btnStockMovement.Click += new System.EventHandler(this.btnStockMovement_Click);
            // 
            // lbStockAlerts
            // 
            this.lbStockAlerts.AutoSize = true;
            this.lbStockAlerts.BackColor = System.Drawing.Color.Transparent;
            this.lbStockAlerts.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStockAlerts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.lbStockAlerts.Location = new System.Drawing.Point(4, 171);
            this.lbStockAlerts.Name = "lbStockAlerts";
            this.lbStockAlerts.Size = new System.Drawing.Size(153, 22);
            this.lbStockAlerts.TabIndex = 26;
            this.lbStockAlerts.Text = "lbStockAlerts";
            // 
            // pnlActions
            // 
            this.pnlActions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlActions.Controls.Add(this.btnStockMovement);
            this.pnlActions.Location = new System.Drawing.Point(654, 9);
            this.pnlActions.Name = "pnlActions";
            this.pnlActions.Size = new System.Drawing.Size(203, 34);
            this.pnlActions.TabIndex = 27;
            // 
            // dgvProductStockAlerts
            // 
            this.dgvProductStockAlerts.AllowUserToAddRows = false;
            this.dgvProductStockAlerts.AllowUserToDeleteRows = false;
            this.dgvProductStockAlerts.AllowUserToResizeColumns = false;
            this.dgvProductStockAlerts.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvProductStockAlerts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProductStockAlerts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProductStockAlerts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProductStockAlerts.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvProductStockAlerts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductStockAlerts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProductStockAlerts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductStockAlerts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnProductName,
            this.columnProducRef,
            this.columnLocationName,
            this.columnStock});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductStockAlerts.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProductStockAlerts.EnableHeadersVisualStyles = false;
            this.dgvProductStockAlerts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.dgvProductStockAlerts.Location = new System.Drawing.Point(8, 205);
            this.dgvProductStockAlerts.Name = "dgvProductStockAlerts";
            this.dgvProductStockAlerts.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductStockAlerts.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProductStockAlerts.RowHeadersVisible = false;
            this.dgvProductStockAlerts.RowHeadersWidth = 25;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvProductStockAlerts.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvProductStockAlerts.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductStockAlerts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductStockAlerts.Size = new System.Drawing.Size(845, 429);
            this.dgvProductStockAlerts.TabIndex = 23;
            // 
            // columnProductName
            // 
            this.columnProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnProductName.HeaderText = "columnProductName";
            this.columnProductName.Name = "columnProductName";
            this.columnProductName.ReadOnly = true;
            // 
            // columnProducRef
            // 
            this.columnProducRef.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnProducRef.HeaderText = "columnProducRef";
            this.columnProducRef.Name = "columnProducRef";
            this.columnProducRef.ReadOnly = true;
            this.columnProducRef.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // columnLocationName
            // 
            this.columnLocationName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnLocationName.HeaderText = "columnLocationName";
            this.columnLocationName.Name = "columnLocationName";
            this.columnLocationName.ReadOnly = true;
            // 
            // columnStock
            // 
            this.columnStock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnStock.HeaderText = "columnStock";
            this.columnStock.Name = "columnStock";
            this.columnStock.ReadOnly = true;
            // 
            // lbUsersCount
            // 
            this.lbUsersCount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbUsersCount.AutoSize = true;
            this.lbUsersCount.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsersCount.ForeColor = System.Drawing.Color.Black;
            this.lbUsersCount.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbUsersCount.Location = new System.Drawing.Point(303, 16);
            this.lbUsersCount.Name = "lbUsersCount";
            this.lbUsersCount.Size = new System.Drawing.Size(104, 16);
            this.lbUsersCount.TabIndex = 8;
            this.lbUsersCount.Text = "lbUsersCount";
            this.lbUsersCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbProductsCount
            // 
            this.lbProductsCount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbProductsCount.AutoSize = true;
            this.lbProductsCount.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProductsCount.ForeColor = System.Drawing.Color.Black;
            this.lbProductsCount.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbProductsCount.Location = new System.Drawing.Point(149, 16);
            this.lbProductsCount.Name = "lbProductsCount";
            this.lbProductsCount.Size = new System.Drawing.Size(128, 16);
            this.lbProductsCount.TabIndex = 7;
            this.lbProductsCount.Text = "lbProductsCount";
            this.lbProductsCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbLocationsCount
            // 
            this.lbLocationsCount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbLocationsCount.AutoSize = true;
            this.lbLocationsCount.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLocationsCount.ForeColor = System.Drawing.Color.Black;
            this.lbLocationsCount.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbLocationsCount.Location = new System.Drawing.Point(3, 16);
            this.lbLocationsCount.Name = "lbLocationsCount";
            this.lbLocationsCount.Size = new System.Drawing.Size(136, 16);
            this.lbLocationsCount.TabIndex = 6;
            this.lbLocationsCount.Text = "lbLocationsCount";
            this.lbLocationsCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbUsers
            // 
            this.lbUsers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbUsers.AutoSize = true;
            this.lbUsers.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(118)))), ((int)(((byte)(185)))));
            this.lbUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbUsers.Location = new System.Drawing.Point(323, 0);
            this.lbUsers.Name = "lbUsers";
            this.lbUsers.Size = new System.Drawing.Size(64, 16);
            this.lbUsers.TabIndex = 5;
            this.lbUsers.Text = "lbUsers";
            // 
            // lbProducts
            // 
            this.lbProducts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbProducts.AutoSize = true;
            this.lbProducts.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProducts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(118)))), ((int)(((byte)(185)))));
            this.lbProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbProducts.Location = new System.Drawing.Point(169, 0);
            this.lbProducts.Name = "lbProducts";
            this.lbProducts.Size = new System.Drawing.Size(88, 16);
            this.lbProducts.TabIndex = 4;
            this.lbProducts.Text = "lbProducts";
            this.lbProducts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbGlobalInfo
            // 
            this.lbGlobalInfo.AutoSize = true;
            this.lbGlobalInfo.BackColor = System.Drawing.Color.Transparent;
            this.lbGlobalInfo.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGlobalInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.lbGlobalInfo.Location = new System.Drawing.Point(4, 50);
            this.lbGlobalInfo.Name = "lbGlobalInfo";
            this.lbGlobalInfo.Size = new System.Drawing.Size(142, 22);
            this.lbGlobalInfo.TabIndex = 28;
            this.lbGlobalInfo.Text = "lbGlobalInfo";
            // 
            // tblpGlobalInfo
            // 
            this.tblpGlobalInfo.AutoSize = true;
            this.tblpGlobalInfo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tblpGlobalInfo.ColumnCount = 3;
            this.tblpGlobalInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblpGlobalInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblpGlobalInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblpGlobalInfo.Controls.Add(this.lbLocations, 0, 0);
            this.tblpGlobalInfo.Controls.Add(this.lbUsersCount, 2, 1);
            this.tblpGlobalInfo.Controls.Add(this.lbProductsCount, 1, 1);
            this.tblpGlobalInfo.Controls.Add(this.lbProducts, 1, 0);
            this.tblpGlobalInfo.Controls.Add(this.lbLocationsCount, 0, 1);
            this.tblpGlobalInfo.Controls.Add(this.lbUsers, 2, 0);
            this.tblpGlobalInfo.Location = new System.Drawing.Point(2, 86);
            this.tblpGlobalInfo.Name = "tblpGlobalInfo";
            this.tblpGlobalInfo.RowCount = 2;
            this.tblpGlobalInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblpGlobalInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblpGlobalInfo.Size = new System.Drawing.Size(426, 32);
            this.tblpGlobalInfo.TabIndex = 29;
            // 
            // lbLocations
            // 
            this.lbLocations.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbLocations.AutoSize = true;
            this.lbLocations.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLocations.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(118)))), ((int)(((byte)(185)))));
            this.lbLocations.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbLocations.Location = new System.Drawing.Point(23, 0);
            this.lbLocations.Name = "lbLocations";
            this.lbLocations.Size = new System.Drawing.Size(96, 16);
            this.lbLocations.TabIndex = 9;
            this.lbLocations.Text = "lbLocations";
            this.lbLocations.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DashboardAdminUc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.tblpGlobalInfo);
            this.Controls.Add(this.lbGlobalInfo);
            this.Controls.Add(this.lbStockAlerts);
            this.Controls.Add(this.pnlActions);
            this.Controls.Add(this.dgvProductStockAlerts);
            this.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DashboardAdminUc";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Size = new System.Drawing.Size(860, 643);
            this.pnlActions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductStockAlerts)).EndInit();
            this.tblpGlobalInfo.ResumeLayout(false);
            this.tblpGlobalInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.Button btnStockMovement;
        private System.Windows.Forms.Label lbStockAlerts;
        private System.Windows.Forms.Panel pnlActions;
        private System.Windows.Forms.DataGridView dgvProductStockAlerts;
        private System.Windows.Forms.Label lbGlobalInfo;
        private System.Windows.Forms.Label lbUsersCount;
        private System.Windows.Forms.Label lbProductsCount;
        private System.Windows.Forms.Label lbLocationsCount;
        private System.Windows.Forms.Label lbUsers;
        private System.Windows.Forms.Label lbProducts;
        private System.Windows.Forms.TableLayoutPanel tblpGlobalInfo;
        private System.Windows.Forms.Label lbLocations;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnProducRef;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnLocationName;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnStock;
    }
}
