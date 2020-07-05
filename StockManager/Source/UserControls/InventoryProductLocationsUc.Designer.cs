namespace StockManager.Source.UserControls {
  partial class InventoryProductLocationsUc {
    /// <summary> 
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
      this.dgvProductLocations = new System.Windows.Forms.DataGridView();
      this.columnProductLocationId = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.columnLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColumnStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.columnMinStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.columnActionEdit = new System.Windows.Forms.DataGridViewImageColumn();
      this.columnActionDelete = new System.Windows.Forms.DataGridViewImageColumn();
      this.btnback = new System.Windows.Forms.Button();
      this.pnlTop = new System.Windows.Forms.Panel();
      this.dgvProductStockMovements = new System.Windows.Forms.DataGridView();
      this.columnStockMovementId = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.columnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.columnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.columnMovement = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.columnQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.columnStockAcc = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.columnUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.lbProductStockMovements = new System.Windows.Forms.Label();
      this.pnlActions = new System.Windows.Forms.Panel();
      this.btnStockMovement = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.dgvProductLocations)).BeginInit();
      this.pnlTop.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvProductStockMovements)).BeginInit();
      this.pnlActions.SuspendLayout();
      this.SuspendLayout();
      // 
      // dgvProductLocations
      // 
      this.dgvProductLocations.AllowUserToAddRows = false;
      this.dgvProductLocations.AllowUserToDeleteRows = false;
      this.dgvProductLocations.AllowUserToResizeColumns = false;
      this.dgvProductLocations.AllowUserToResizeRows = false;
      dataGridViewCellStyle21.BackColor = System.Drawing.Color.LightGray;
      dataGridViewCellStyle21.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle21.ForeColor = System.Drawing.Color.Black;
      dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(118)))), ((int)(((byte)(185)))));
      dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.White;
      this.dgvProductLocations.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle21;
      this.dgvProductLocations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dgvProductLocations.BackgroundColor = System.Drawing.SystemColors.Control;
      this.dgvProductLocations.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
      dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
      dataGridViewCellStyle22.Font = new System.Drawing.Font("Courier New", 9.75F);
      dataGridViewCellStyle22.ForeColor = System.Drawing.Color.White;
      dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
      dataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.White;
      dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dgvProductLocations.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
      this.dgvProductLocations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvProductLocations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnProductLocationId,
            this.columnLocation,
            this.ColumnStock,
            this.columnMinStock,
            this.columnActionEdit,
            this.columnActionDelete});
      dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle23.Font = new System.Drawing.Font("Courier New", 9.75F);
      dataGridViewCellStyle23.ForeColor = System.Drawing.Color.White;
      dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.Black;
      dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.dgvProductLocations.DefaultCellStyle = dataGridViewCellStyle23;
      this.dgvProductLocations.EnableHeadersVisualStyles = false;
      this.dgvProductLocations.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
      this.dgvProductLocations.Location = new System.Drawing.Point(4, 4);
      this.dgvProductLocations.MultiSelect = false;
      this.dgvProductLocations.Name = "dgvProductLocations";
      this.dgvProductLocations.ReadOnly = true;
      dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle24.Font = new System.Drawing.Font("Courier New", 9.75F);
      dataGridViewCellStyle24.ForeColor = System.Drawing.Color.Black;
      dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.Black;
      dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dgvProductLocations.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
      this.dgvProductLocations.RowHeadersVisible = false;
      this.dgvProductLocations.RowHeadersWidth = 25;
      dataGridViewCellStyle25.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle25.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle25.ForeColor = System.Drawing.Color.Black;
      dataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
      dataGridViewCellStyle25.SelectionForeColor = System.Drawing.Color.Black;
      this.dgvProductLocations.RowsDefaultCellStyle = dataGridViewCellStyle25;
      this.dgvProductLocations.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Control;
      this.dgvProductLocations.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
      this.dgvProductLocations.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
      this.dgvProductLocations.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
      this.dgvProductLocations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgvProductLocations.Size = new System.Drawing.Size(845, 281);
      this.dgvProductLocations.TabIndex = 4;
      this.dgvProductLocations.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductLocations_CellContentClick);
      // 
      // columnProductLocationId
      // 
      this.columnProductLocationId.HeaderText = "columnProductLocationId";
      this.columnProductLocationId.Name = "columnProductLocationId";
      this.columnProductLocationId.ReadOnly = true;
      this.columnProductLocationId.Visible = false;
      // 
      // columnLocation
      // 
      this.columnLocation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.columnLocation.HeaderText = "columnLocation";
      this.columnLocation.Name = "columnLocation";
      this.columnLocation.ReadOnly = true;
      this.columnLocation.Resizable = System.Windows.Forms.DataGridViewTriState.True;
      // 
      // ColumnStock
      // 
      this.ColumnStock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.ColumnStock.HeaderText = "ColumnStock";
      this.ColumnStock.Name = "ColumnStock";
      this.ColumnStock.ReadOnly = true;
      // 
      // columnMinStock
      // 
      this.columnMinStock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.columnMinStock.HeaderText = "columnMinStock";
      this.columnMinStock.Name = "columnMinStock";
      this.columnMinStock.ReadOnly = true;
      // 
      // columnActionEdit
      // 
      this.columnActionEdit.HeaderText = "";
      this.columnActionEdit.Image = global::StockManager.Properties.Resources.icon_pencil_drawing_24px;
      this.columnActionEdit.MinimumWidth = 24;
      this.columnActionEdit.Name = "columnActionEdit";
      this.columnActionEdit.ReadOnly = true;
      this.columnActionEdit.Width = 24;
      // 
      // columnActionDelete
      // 
      this.columnActionDelete.HeaderText = "";
      this.columnActionDelete.Image = global::StockManager.Properties.Resources.icon_delete_bin_24px;
      this.columnActionDelete.MinimumWidth = 24;
      this.columnActionDelete.Name = "columnActionDelete";
      this.columnActionDelete.ReadOnly = true;
      this.columnActionDelete.Width = 24;
      // 
      // btnback
      // 
      this.btnback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
      this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnback.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnback.ForeColor = System.Drawing.Color.White;
      this.btnback.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnback.Location = new System.Drawing.Point(8, 12);
      this.btnback.Name = "btnback";
      this.btnback.Size = new System.Drawing.Size(93, 27);
      this.btnback.TabIndex = 6;
      this.btnback.Text = "btnback";
      this.btnback.UseVisualStyleBackColor = false;
      this.btnback.Click += new System.EventHandler(this.btnback_Click);
      // 
      // pnlTop
      // 
      this.pnlTop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.pnlTop.Controls.Add(this.dgvProductLocations);
      this.pnlTop.Location = new System.Drawing.Point(4, 44);
      this.pnlTop.Name = "pnlTop";
      this.pnlTop.Size = new System.Drawing.Size(849, 289);
      this.pnlTop.TabIndex = 20;
      // 
      // dgvProductStockMovements
      // 
      this.dgvProductStockMovements.AllowUserToAddRows = false;
      this.dgvProductStockMovements.AllowUserToDeleteRows = false;
      this.dgvProductStockMovements.AllowUserToResizeColumns = false;
      this.dgvProductStockMovements.AllowUserToResizeRows = false;
      dataGridViewCellStyle26.BackColor = System.Drawing.Color.LightGray;
      dataGridViewCellStyle26.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle26.ForeColor = System.Drawing.Color.Black;
      dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(118)))), ((int)(((byte)(185)))));
      dataGridViewCellStyle26.SelectionForeColor = System.Drawing.Color.White;
      this.dgvProductStockMovements.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle26;
      this.dgvProductStockMovements.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dgvProductStockMovements.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
      this.dgvProductStockMovements.BackgroundColor = System.Drawing.SystemColors.Control;
      this.dgvProductStockMovements.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
      dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
      dataGridViewCellStyle27.Font = new System.Drawing.Font("Courier New", 9.75F);
      dataGridViewCellStyle27.ForeColor = System.Drawing.Color.White;
      dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
      dataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.White;
      dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dgvProductStockMovements.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle27;
      this.dgvProductStockMovements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvProductStockMovements.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnStockMovementId,
            this.columnDate,
            this.columnName,
            this.columnMovement,
            this.columnQty,
            this.columnStockAcc,
            this.columnUser});
      dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle28.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle28.Font = new System.Drawing.Font("Courier New", 9.75F);
      dataGridViewCellStyle28.ForeColor = System.Drawing.Color.White;
      dataGridViewCellStyle28.SelectionBackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle28.SelectionForeColor = System.Drawing.Color.Black;
      dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dgvProductStockMovements.DefaultCellStyle = dataGridViewCellStyle28;
      this.dgvProductStockMovements.EnableHeadersVisualStyles = false;
      this.dgvProductStockMovements.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
      this.dgvProductStockMovements.Location = new System.Drawing.Point(8, 374);
      this.dgvProductStockMovements.Name = "dgvProductStockMovements";
      this.dgvProductStockMovements.ReadOnly = true;
      dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle29.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle29.Font = new System.Drawing.Font("Courier New", 9.75F);
      dataGridViewCellStyle29.ForeColor = System.Drawing.Color.Black;
      dataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle29.SelectionForeColor = System.Drawing.Color.Black;
      dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dgvProductStockMovements.RowHeadersDefaultCellStyle = dataGridViewCellStyle29;
      this.dgvProductStockMovements.RowHeadersVisible = false;
      this.dgvProductStockMovements.RowHeadersWidth = 25;
      dataGridViewCellStyle30.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle30.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle30.ForeColor = System.Drawing.Color.Black;
      dataGridViewCellStyle30.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
      dataGridViewCellStyle30.SelectionForeColor = System.Drawing.Color.Black;
      this.dgvProductStockMovements.RowsDefaultCellStyle = dataGridViewCellStyle30;
      this.dgvProductStockMovements.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Control;
      this.dgvProductStockMovements.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
      this.dgvProductStockMovements.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
      this.dgvProductStockMovements.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
      this.dgvProductStockMovements.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dgvProductStockMovements.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgvProductStockMovements.Size = new System.Drawing.Size(845, 260);
      this.dgvProductStockMovements.TabIndex = 5;
      // 
      // columnStockMovementId
      // 
      this.columnStockMovementId.HeaderText = "columnStockMovementId";
      this.columnStockMovementId.Name = "columnStockMovementId";
      this.columnStockMovementId.ReadOnly = true;
      this.columnStockMovementId.Visible = false;
      // 
      // columnDate
      // 
      this.columnDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.columnDate.HeaderText = "columnDate";
      this.columnDate.Name = "columnDate";
      this.columnDate.ReadOnly = true;
      // 
      // columnName
      // 
      this.columnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.columnName.HeaderText = "columnName";
      this.columnName.Name = "columnName";
      this.columnName.ReadOnly = true;
      this.columnName.Visible = false;
      // 
      // columnMovement
      // 
      this.columnMovement.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.columnMovement.HeaderText = "columnMovement";
      this.columnMovement.Name = "columnMovement";
      this.columnMovement.ReadOnly = true;
      this.columnMovement.Resizable = System.Windows.Forms.DataGridViewTriState.True;
      // 
      // columnQty
      // 
      this.columnQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.columnQty.HeaderText = "columnQty";
      this.columnQty.Name = "columnQty";
      this.columnQty.ReadOnly = true;
      // 
      // columnStockAcc
      // 
      this.columnStockAcc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.columnStockAcc.HeaderText = "columnStockAcc";
      this.columnStockAcc.Name = "columnStockAcc";
      this.columnStockAcc.ReadOnly = true;
      // 
      // columnUser
      // 
      this.columnUser.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.columnUser.HeaderText = "columnUser";
      this.columnUser.Name = "columnUser";
      this.columnUser.ReadOnly = true;
      // 
      // lbProductStockMovements
      // 
      this.lbProductStockMovements.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.lbProductStockMovements.AutoSize = true;
      this.lbProductStockMovements.BackColor = System.Drawing.Color.Transparent;
      this.lbProductStockMovements.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbProductStockMovements.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
      this.lbProductStockMovements.Location = new System.Drawing.Point(5, 348);
      this.lbProductStockMovements.Name = "lbProductStockMovements";
      this.lbProductStockMovements.Size = new System.Drawing.Size(263, 22);
      this.lbProductStockMovements.TabIndex = 21;
      this.lbProductStockMovements.Text = "lbProductStockMovements";
      // 
      // pnlActions
      // 
      this.pnlActions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.pnlActions.Controls.Add(this.btnStockMovement);
      this.pnlActions.Location = new System.Drawing.Point(654, 9);
      this.pnlActions.Name = "pnlActions";
      this.pnlActions.Size = new System.Drawing.Size(203, 34);
      this.pnlActions.TabIndex = 22;
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
      // InventoryProductLocationsUc
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.pnlActions);
      this.Controls.Add(this.lbProductStockMovements);
      this.Controls.Add(this.dgvProductStockMovements);
      this.Controls.Add(this.pnlTop);
      this.Controls.Add(this.btnback);
      this.Font = new System.Drawing.Font("Courier New", 9.75F);
      this.ForeColor = System.Drawing.Color.White;
      this.Margin = new System.Windows.Forms.Padding(4);
      this.Name = "InventoryProductLocationsUc";
      this.Size = new System.Drawing.Size(860, 643);
      ((System.ComponentModel.ISupportInitialize)(this.dgvProductLocations)).EndInit();
      this.pnlTop.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dgvProductStockMovements)).EndInit();
      this.pnlActions.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion
        private System.Windows.Forms.DataGridView dgvProductLocations;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Panel pnlTop;
    private System.Windows.Forms.DataGridView dgvProductStockMovements;
    private System.Windows.Forms.Label lbProductStockMovements;
    private System.Windows.Forms.DataGridViewTextBoxColumn columnProductLocationId;
    private System.Windows.Forms.DataGridViewTextBoxColumn columnLocation;
    private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStock;
    private System.Windows.Forms.DataGridViewTextBoxColumn columnMinStock;
    private System.Windows.Forms.DataGridViewImageColumn columnActionEdit;
    private System.Windows.Forms.DataGridViewImageColumn columnActionDelete;
    private System.Windows.Forms.DataGridViewTextBoxColumn columnStockMovementId;
    private System.Windows.Forms.DataGridViewTextBoxColumn columnDate;
    private System.Windows.Forms.DataGridViewTextBoxColumn columnName;
    private System.Windows.Forms.DataGridViewTextBoxColumn columnMovement;
    private System.Windows.Forms.DataGridViewTextBoxColumn columnQty;
    private System.Windows.Forms.DataGridViewTextBoxColumn columnStockAcc;
    private System.Windows.Forms.DataGridViewTextBoxColumn columnUser;
    private System.Windows.Forms.Panel pnlActions;
    private System.Windows.Forms.Button btnStockMovement;
  }
}
