namespace StockManager.Source.UserControls
{
  partial class InventoryProductsUc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryProductsUc));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlActions = new System.Windows.Forms.Panel();
            this.btnCreatePdf = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.columnProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnReference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCreatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnActionEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.columnActionDetails = new System.Windows.Forms.DataGridViewImageColumn();
            this.columnActionDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.tbSeachText = new System.Windows.Forms.TextBox();
            this.pnbSearchBox = new System.Windows.Forms.Panel();
            this.btnClearSearchValue = new System.Windows.Forms.Button();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
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
            this.pnlActions.Controls.Add(this.btnCreatePdf);
            this.pnlActions.Controls.Add(this.btnDelete);
            this.pnlActions.Controls.Add(this.btnCreate);
            this.pnlActions.Location = new System.Drawing.Point(470, 6);
            this.pnlActions.Name = "pnlActions";
            this.pnlActions.Size = new System.Drawing.Size(386, 34);
            this.pnlActions.TabIndex = 14;
            // 
            // btnCreatePdf
            // 
            this.btnCreatePdf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCreatePdf.BackColor = System.Drawing.Color.Gray;
            this.btnCreatePdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreatePdf.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreatePdf.ForeColor = System.Drawing.Color.White;
            this.btnCreatePdf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreatePdf.Location = new System.Drawing.Point(19, 3);
            this.btnCreatePdf.Name = "btnCreatePdf";
            this.btnCreatePdf.Size = new System.Drawing.Size(170, 27);
            this.btnCreatePdf.TabIndex = 12;
            this.btnCreatePdf.Text = "btnCreatePdf";
            this.btnCreatePdf.UseVisualStyleBackColor = false;
            this.btnCreatePdf.Click += new System.EventHandler(this.btnCreatePdf_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(290, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(93, 27);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreate.Location = new System.Drawing.Point(193, 3);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(93, 27);
            this.btnCreate.TabIndex = 13;
            this.btnCreate.Text = "Add new";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.AllowUserToResizeColumns = false;
            this.dgvProducts.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvProducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProducts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProducts.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvProducts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnProductId,
            this.columnReference,
            this.columnName,
            this.ColumnStock,
            this.ColumnCreatedAt,
            this.columnActionEdit,
            this.columnActionDetails,
            this.columnActionDelete});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProducts.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProducts.EnableHeadersVisualStyles = false;
            this.dgvProducts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.dgvProducts.Location = new System.Drawing.Point(8, 45);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvProducts.RowHeadersVisible = false;
            this.dgvProducts.RowHeadersWidth = 25;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvProducts.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvProducts.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(845, 365);
            this.dgvProducts.TabIndex = 13;
            this.dgvProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellContentClick);
            // 
            // columnProductId
            // 
            this.columnProductId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
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
            // columnActionEdit
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.columnActionEdit.DefaultCellStyle = dataGridViewCellStyle3;
            this.columnActionEdit.HeaderText = "";
            this.columnActionEdit.Image = global::StockManager.Properties.Resources.icon_pencil_drawing_24px;
            this.columnActionEdit.MinimumWidth = 30;
            this.columnActionEdit.Name = "columnActionEdit";
            this.columnActionEdit.ReadOnly = true;
            this.columnActionEdit.Width = 30;
            // 
            // columnActionDetails
            // 
            this.columnActionDetails.HeaderText = "";
            this.columnActionDetails.Image = ((System.Drawing.Image)(resources.GetObject("columnActionDetails.Image")));
            this.columnActionDetails.MinimumWidth = 30;
            this.columnActionDetails.Name = "columnActionDetails";
            this.columnActionDetails.ReadOnly = true;
            this.columnActionDetails.Width = 30;
            // 
            // columnActionDelete
            // 
            this.columnActionDelete.HeaderText = "";
            this.columnActionDelete.Image = global::StockManager.Properties.Resources.icon_delete_bin_24px;
            this.columnActionDelete.MinimumWidth = 30;
            this.columnActionDelete.Name = "columnActionDelete";
            this.columnActionDelete.ReadOnly = true;
            this.columnActionDelete.Width = 30;
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
            this.tbSeachText.TabIndex = 15;
            this.tbSeachText.TextChanged += new System.EventHandler(this.tbSeachText_TextChanged);
            this.tbSeachText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSeachText_KeyPress);
            // 
            // pnbSearchBox
            // 
            this.pnbSearchBox.Controls.Add(pbSearchIcon);
            this.pnbSearchBox.Controls.Add(this.btnClearSearchValue);
            this.pnbSearchBox.Controls.Add(this.tbSeachText);
            this.pnbSearchBox.Location = new System.Drawing.Point(3, 7);
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
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::StockManager.Properties.Resources.icon_pencil_drawing_24px;
            this.dataGridViewImageColumn1.MinimumWidth = 24;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 24;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn2.Image")));
            this.dataGridViewImageColumn2.MinimumWidth = 24;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Width = 24;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.HeaderText = "";
            this.dataGridViewImageColumn3.Image = global::StockManager.Properties.Resources.icon_delete_bin_24px;
            this.dataGridViewImageColumn3.MinimumWidth = 24;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.ReadOnly = true;
            this.dataGridViewImageColumn3.Width = 24;
            // 
            // InventoryProductsUc
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
            this.Name = "InventoryProductsUc";
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
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.TextBox tbSeachText;
        private System.Windows.Forms.Panel pnbSearchBox;
        private System.Windows.Forms.Button btnClearSearchValue;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
    private System.Windows.Forms.DataGridViewTextBoxColumn columnProductId;
    private System.Windows.Forms.DataGridViewTextBoxColumn columnReference;
    private System.Windows.Forms.DataGridViewTextBoxColumn columnName;
    private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStock;
    private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCreatedAt;
    private System.Windows.Forms.DataGridViewImageColumn columnActionEdit;
    private System.Windows.Forms.DataGridViewImageColumn columnActionDetails;
    private System.Windows.Forms.DataGridViewImageColumn columnActionDelete;
        private System.Windows.Forms.Button btnCreatePdf;
    }
}
