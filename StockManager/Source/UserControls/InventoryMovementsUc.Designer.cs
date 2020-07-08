namespace StockManager.Source.UserControls
{
    partial class InventoryMovementsUc
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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.PictureBox pbSearchIcon;
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryMovementsUc));
      this.dgvMovements = new System.Windows.Forms.DataGridView();
      this.pnbSearchBox = new System.Windows.Forms.Panel();
      this.btnClearSearchValue = new System.Windows.Forms.Button();
      this.tbSeachText = new System.Windows.Forms.TextBox();
      this.columnStockMovementId = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.columnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.columnProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.columnMovement = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.columnQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.columnStockAcc = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.columnUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.pnlActions = new System.Windows.Forms.Panel();
      this.btnStockMovement = new System.Windows.Forms.Button();
      pbSearchIcon = new System.Windows.Forms.PictureBox();
      ((System.ComponentModel.ISupportInitialize)(this.dgvMovements)).BeginInit();
      this.pnbSearchBox.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(pbSearchIcon)).BeginInit();
      this.pnlActions.SuspendLayout();
      this.SuspendLayout();
      // 
      // dgvMovements
      // 
      this.dgvMovements.AllowUserToAddRows = false;
      this.dgvMovements.AllowUserToDeleteRows = false;
      this.dgvMovements.AllowUserToResizeColumns = false;
      this.dgvMovements.AllowUserToResizeRows = false;
      dataGridViewCellStyle31.BackColor = System.Drawing.Color.LightGray;
      dataGridViewCellStyle31.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle31.ForeColor = System.Drawing.Color.Black;
      dataGridViewCellStyle31.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(118)))), ((int)(((byte)(185)))));
      dataGridViewCellStyle31.SelectionForeColor = System.Drawing.Color.White;
      this.dgvMovements.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle31;
      this.dgvMovements.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dgvMovements.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
      this.dgvMovements.BackgroundColor = System.Drawing.SystemColors.Control;
      this.dgvMovements.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
      dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
      dataGridViewCellStyle32.Font = new System.Drawing.Font("Courier New", 9.75F);
      dataGridViewCellStyle32.ForeColor = System.Drawing.Color.White;
      dataGridViewCellStyle32.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
      dataGridViewCellStyle32.SelectionForeColor = System.Drawing.Color.White;
      dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dgvMovements.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle32;
      this.dgvMovements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvMovements.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnStockMovementId,
            this.columnDate,
            this.columnProduct,
            this.columnMovement,
            this.columnQty,
            this.columnStockAcc,
            this.columnUser});
      dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle33.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle33.Font = new System.Drawing.Font("Courier New", 9.75F);
      dataGridViewCellStyle33.ForeColor = System.Drawing.Color.White;
      dataGridViewCellStyle33.SelectionBackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle33.SelectionForeColor = System.Drawing.Color.Black;
      dataGridViewCellStyle33.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dgvMovements.DefaultCellStyle = dataGridViewCellStyle33;
      this.dgvMovements.EnableHeadersVisualStyles = false;
      this.dgvMovements.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
      this.dgvMovements.Location = new System.Drawing.Point(8, 45);
      this.dgvMovements.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.dgvMovements.Name = "dgvMovements";
      this.dgvMovements.ReadOnly = true;
      dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle34.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle34.Font = new System.Drawing.Font("Courier New", 9.75F);
      dataGridViewCellStyle34.ForeColor = System.Drawing.Color.Black;
      dataGridViewCellStyle34.SelectionBackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle34.SelectionForeColor = System.Drawing.Color.Black;
      dataGridViewCellStyle34.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dgvMovements.RowHeadersDefaultCellStyle = dataGridViewCellStyle34;
      this.dgvMovements.RowHeadersVisible = false;
      this.dgvMovements.RowHeadersWidth = 25;
      dataGridViewCellStyle35.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle35.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle35.ForeColor = System.Drawing.Color.Black;
      dataGridViewCellStyle35.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
      dataGridViewCellStyle35.SelectionForeColor = System.Drawing.Color.Black;
      this.dgvMovements.RowsDefaultCellStyle = dataGridViewCellStyle35;
      this.dgvMovements.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Empty;
      this.dgvMovements.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Empty;
      this.dgvMovements.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Empty;
      this.dgvMovements.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Empty;
      this.dgvMovements.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgvMovements.Size = new System.Drawing.Size(845, 365);
      this.dgvMovements.TabIndex = 17;
      // 
      // pnbSearchBox
      // 
      this.pnbSearchBox.Controls.Add(pbSearchIcon);
      this.pnbSearchBox.Controls.Add(this.btnClearSearchValue);
      this.pnbSearchBox.Controls.Add(this.tbSeachText);
      this.pnbSearchBox.Location = new System.Drawing.Point(3, 7);
      this.pnbSearchBox.Name = "pnbSearchBox";
      this.pnbSearchBox.Size = new System.Drawing.Size(324, 33);
      this.pnbSearchBox.TabIndex = 18;
      // 
      // pbSearchIcon
      // 
      pbSearchIcon.BackColor = System.Drawing.Color.LightGray;
      pbSearchIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      pbSearchIcon.Cursor = System.Windows.Forms.Cursors.Hand;
      pbSearchIcon.Image = ((System.Drawing.Image)(resources.GetObject("pbSearchIcon.Image")));
      pbSearchIcon.Location = new System.Drawing.Point(5, 6);
      pbSearchIcon.Name = "pbSearchIcon";
      pbSearchIcon.Size = new System.Drawing.Size(24, 22);
      pbSearchIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
      pbSearchIcon.TabIndex = 5;
      pbSearchIcon.TabStop = false;
      pbSearchIcon.Click += new System.EventHandler(this.pbSearchIcon_Click);
      // 
      // btnClearSearchValue
      // 
      this.btnClearSearchValue.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.btnClearSearchValue.BackColor = System.Drawing.Color.White;
      this.btnClearSearchValue.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnClearSearchValue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnClearSearchValue.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnClearSearchValue.ForeColor = System.Drawing.Color.White;
      this.btnClearSearchValue.Image = ((System.Drawing.Image)(resources.GetObject("btnClearSearchValue.Image")));
      this.btnClearSearchValue.Location = new System.Drawing.Point(285, 7);
      this.btnClearSearchValue.Name = "btnClearSearchValue";
      this.btnClearSearchValue.Size = new System.Drawing.Size(17, 20);
      this.btnClearSearchValue.TabIndex = 11;
      this.btnClearSearchValue.UseVisualStyleBackColor = false;
      this.btnClearSearchValue.Click += new System.EventHandler(this.btnClearSearchValue_Click);
      // 
      // tbSeachText
      // 
      this.tbSeachText.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.tbSeachText.BackColor = System.Drawing.Color.White;
      this.tbSeachText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.tbSeachText.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tbSeachText.Location = new System.Drawing.Point(30, 6);
      this.tbSeachText.Name = "tbSeachText";
      this.tbSeachText.Size = new System.Drawing.Size(274, 22);
      this.tbSeachText.TabIndex = 4;
      this.tbSeachText.TextChanged += new System.EventHandler(this.tbSeachText_TextChanged);
      this.tbSeachText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSeachText_KeyPress);
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
      // columnProduct
      // 
      this.columnProduct.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.columnProduct.HeaderText = "columnProduct";
      this.columnProduct.Name = "columnProduct";
      this.columnProduct.ReadOnly = true;
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
      // pnlActions
      // 
      this.pnlActions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.pnlActions.Controls.Add(this.btnStockMovement);
      this.pnlActions.Location = new System.Drawing.Point(654, 6);
      this.pnlActions.Name = "pnlActions";
      this.pnlActions.Size = new System.Drawing.Size(203, 34);
      this.pnlActions.TabIndex = 23;
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
      // InventoryMovementsUc
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.pnlActions);
      this.Controls.Add(this.pnbSearchBox);
      this.Controls.Add(this.dgvMovements);
      this.Font = new System.Drawing.Font("Courier New", 9.75F);
      this.ForeColor = System.Drawing.Color.White;
      this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.Name = "InventoryMovementsUc";
      this.Size = new System.Drawing.Size(860, 420);
      ((System.ComponentModel.ISupportInitialize)(this.dgvMovements)).EndInit();
      this.pnbSearchBox.ResumeLayout(false);
      this.pnbSearchBox.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(pbSearchIcon)).EndInit();
      this.pnlActions.ResumeLayout(false);
      this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvMovements;
    private System.Windows.Forms.Panel pnbSearchBox;
    private System.Windows.Forms.Button btnClearSearchValue;
    private System.Windows.Forms.TextBox tbSeachText;
    private System.Windows.Forms.DataGridViewTextBoxColumn columnStockMovementId;
    private System.Windows.Forms.DataGridViewTextBoxColumn columnDate;
    private System.Windows.Forms.DataGridViewTextBoxColumn columnProduct;
    private System.Windows.Forms.DataGridViewTextBoxColumn columnMovement;
    private System.Windows.Forms.DataGridViewTextBoxColumn columnQty;
    private System.Windows.Forms.DataGridViewTextBoxColumn columnStockAcc;
    private System.Windows.Forms.DataGridViewTextBoxColumn columnUser;
    private System.Windows.Forms.Panel pnlActions;
    private System.Windows.Forms.Button btnStockMovement;
  }
}
