namespace StockManager.UserControls
{
  partial class InventoryProductsUserControl
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
      System.Windows.Forms.PictureBox pbSearchIcon;
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryProductsUserControl));
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
      this.pnlActions = new System.Windows.Forms.Panel();
      this.btnDelete = new System.Windows.Forms.Button();
      this.btnEdit = new System.Windows.Forms.Button();
      this.btnCreate = new System.Windows.Forms.Button();
      this.dgvProducts = new System.Windows.Forms.DataGridView();
      this.columnProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.columnReference = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.columnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColumnStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColumnCreatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.tbSeachText = new System.Windows.Forms.TextBox();
      this.pnbSearchBox = new System.Windows.Forms.Panel();
      this.btnClearSearchValue = new System.Windows.Forms.Button();
      pbSearchIcon = new System.Windows.Forms.PictureBox();
      ((System.ComponentModel.ISupportInitialize)(pbSearchIcon)).BeginInit();
      this.pnlActions.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
      this.pnbSearchBox.SuspendLayout();
      this.SuspendLayout();
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
      // pnlActions
      // 
      this.pnlActions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.pnlActions.Controls.Add(this.btnDelete);
      this.pnlActions.Controls.Add(this.btnEdit);
      this.pnlActions.Controls.Add(this.btnCreate);
      this.pnlActions.Location = new System.Drawing.Point(557, 5);
      this.pnlActions.Name = "pnlActions";
      this.pnlActions.Size = new System.Drawing.Size(300, 34);
      this.pnlActions.TabIndex = 14;
      // 
      // btnDelete
      // 
      this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
      this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnDelete.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnDelete.ForeColor = System.Drawing.Color.White;
      this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnDelete.Location = new System.Drawing.Point(203, 4);
      this.btnDelete.Name = "btnDelete";
      this.btnDelete.Size = new System.Drawing.Size(93, 27);
      this.btnDelete.TabIndex = 9;
      this.btnDelete.Text = "Delete";
      this.btnDelete.UseVisualStyleBackColor = false;
      this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
      // 
      // btnEdit
      // 
      this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(173)))), ((int)(((byte)(78)))));
      this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnEdit.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnEdit.ForeColor = System.Drawing.Color.White;
      this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnEdit.Location = new System.Drawing.Point(104, 3);
      this.btnEdit.Name = "btnEdit";
      this.btnEdit.Size = new System.Drawing.Size(93, 27);
      this.btnEdit.TabIndex = 8;
      this.btnEdit.Text = "Edit";
      this.btnEdit.UseVisualStyleBackColor = false;
      this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
      // 
      // btnCreate
      // 
      this.btnCreate.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
      this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnCreate.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnCreate.ForeColor = System.Drawing.Color.White;
      this.btnCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnCreate.Location = new System.Drawing.Point(5, 3);
      this.btnCreate.Name = "btnCreate";
      this.btnCreate.Size = new System.Drawing.Size(93, 27);
      this.btnCreate.TabIndex = 7;
      this.btnCreate.Text = "Add new";
      this.btnCreate.UseVisualStyleBackColor = false;
      this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
      // 
      // dgvProducts
      // 
      this.dgvProducts.AllowUserToAddRows = false;
      this.dgvProducts.AllowUserToDeleteRows = false;
      this.dgvProducts.AllowUserToOrderColumns = true;
      dataGridViewCellStyle16.BackColor = System.Drawing.Color.LightGray;
      dataGridViewCellStyle16.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Black;
      dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(118)))), ((int)(((byte)(185)))));
      dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.White;
      this.dgvProducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
      this.dgvProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dgvProducts.BackgroundColor = System.Drawing.SystemColors.Control;
      this.dgvProducts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
      dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
      dataGridViewCellStyle17.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
      dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
      dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.White;
      dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
      this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnProductId,
            this.columnReference,
            this.columnName,
            this.ColumnStock,
            this.ColumnCreatedAt});
      dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle18.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle18.ForeColor = System.Drawing.Color.White;
      dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.Black;
      dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.dgvProducts.DefaultCellStyle = dataGridViewCellStyle18;
      this.dgvProducts.EnableHeadersVisualStyles = false;
      this.dgvProducts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
      this.dgvProducts.Location = new System.Drawing.Point(8, 45);
      this.dgvProducts.Name = "dgvProducts";
      this.dgvProducts.ReadOnly = true;
      dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle19.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle19.ForeColor = System.Drawing.Color.Black;
      dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.Black;
      dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dgvProducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
      this.dgvProducts.RowHeadersWidth = 25;
      dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle20.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle20.ForeColor = System.Drawing.Color.Black;
      dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(118)))), ((int)(((byte)(185)))));
      dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.White;
      this.dgvProducts.RowsDefaultCellStyle = dataGridViewCellStyle20;
      this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgvProducts.Size = new System.Drawing.Size(845, 371);
      this.dgvProducts.TabIndex = 13;
      // 
      // columnProductId
      // 
      this.columnProductId.HeaderText = "ProductId";
      this.columnProductId.Name = "columnProductId";
      this.columnProductId.ReadOnly = true;
      this.columnProductId.Visible = false;
      // 
      // columnReference
      // 
      this.columnReference.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.columnReference.HeaderText = "Reference";
      this.columnReference.Name = "columnReference";
      this.columnReference.ReadOnly = true;
      this.columnReference.Resizable = System.Windows.Forms.DataGridViewTriState.True;
      // 
      // columnName
      // 
      this.columnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.columnName.HeaderText = "Name";
      this.columnName.Name = "columnName";
      this.columnName.ReadOnly = true;
      // 
      // ColumnStock
      // 
      this.ColumnStock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.ColumnStock.HeaderText = "Stock";
      this.ColumnStock.Name = "ColumnStock";
      this.ColumnStock.ReadOnly = true;
      // 
      // ColumnCreatedAt
      // 
      this.ColumnCreatedAt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.ColumnCreatedAt.HeaderText = "Created at";
      this.ColumnCreatedAt.Name = "ColumnCreatedAt";
      this.ColumnCreatedAt.ReadOnly = true;
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
      // pnbSearchBox
      // 
      this.pnbSearchBox.Controls.Add(pbSearchIcon);
      this.pnbSearchBox.Controls.Add(this.btnClearSearchValue);
      this.pnbSearchBox.Controls.Add(this.tbSeachText);
      this.pnbSearchBox.Location = new System.Drawing.Point(3, 6);
      this.pnbSearchBox.Name = "pnbSearchBox";
      this.pnbSearchBox.Size = new System.Drawing.Size(324, 33);
      this.pnbSearchBox.TabIndex = 15;
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
      // InventoryProductsUserControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.Control;
      this.Controls.Add(this.pnlActions);
      this.Controls.Add(this.dgvProducts);
      this.Controls.Add(this.pnbSearchBox);
      this.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ForeColor = System.Drawing.Color.White;
      this.Margin = new System.Windows.Forms.Padding(4);
      this.Name = "InventoryProductsUserControl";
      this.Size = new System.Drawing.Size(860, 420);
      ((System.ComponentModel.ISupportInitialize)(pbSearchIcon)).EndInit();
      this.pnlActions.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
      this.pnbSearchBox.ResumeLayout(false);
      this.pnbSearchBox.PerformLayout();
      this.ResumeLayout(false);

    }

        #endregion

        private System.Windows.Forms.Panel pnlActions;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.TextBox tbSeachText;
        private System.Windows.Forms.Panel pnbSearchBox;
        private System.Windows.Forms.Button btnClearSearchValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnReference;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCreatedAt;
    }
}
