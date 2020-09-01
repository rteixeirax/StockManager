namespace StockManager.Source.UserControls
{
    partial class DashboardUc
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
            System.Windows.Forms.PictureBox pbSearchIconx;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardUc));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.columnProductLocationId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnProducRef = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCurrentStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnRefillQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.lbLocation = new System.Windows.Forms.Label();
            this.cbLocations = new System.Windows.Forms.ComboBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbSeachText = new System.Windows.Forms.TextBox();
            this.btnClearSearchValue = new System.Windows.Forms.Button();
            this.pnbSearchBox = new System.Windows.Forms.Panel();
            this.lbProductLocation = new System.Windows.Forms.Label();
            pbSearchIconx = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pbSearchIconx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.pnbSearchBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbSearchIconx
            // 
            pbSearchIconx.BackColor = System.Drawing.Color.LightGray;
            pbSearchIconx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pbSearchIconx.Cursor = System.Windows.Forms.Cursors.Hand;
            pbSearchIconx.Image = ((System.Drawing.Image)(resources.GetObject("pbSearchIconx.Image")));
            pbSearchIconx.Location = new System.Drawing.Point(5, 6);
            pbSearchIconx.Name = "pbSearchIconx";
            pbSearchIconx.Size = new System.Drawing.Size(24, 22);
            pbSearchIconx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            pbSearchIconx.TabIndex = 5;
            pbSearchIconx.TabStop = false;
            pbSearchIconx.Click += new System.EventHandler(this.pbSearchIcon_Click);
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Courier New", 9.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnProductLocationId,
            this.columnProductId,
            this.columnProducRef,
            this.columnProductName,
            this.columnCurrentStock,
            this.columnRefillQty,
            this.columnEdit});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Courier New", 9.75F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducts.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProducts.EnableHeadersVisualStyles = false;
            this.dgvProducts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.dgvProducts.Location = new System.Drawing.Point(9, 173);
            this.dgvProducts.Name = "dgvProducts";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Courier New", 9.75F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProducts.RowHeadersVisible = false;
            this.dgvProducts.RowHeadersWidth = 25;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvProducts.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvProducts.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducts.RowTemplate.Height = 30;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(845, 461);
            this.dgvProducts.TabIndex = 30;
            this.dgvProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellContentClick);
            // 
            // columnProductLocationId
            // 
            this.columnProductLocationId.HeaderText = "columnProductLocationId";
            this.columnProductLocationId.Name = "columnProductLocationId";
            this.columnProductLocationId.Visible = false;
            // 
            // columnProductId
            // 
            this.columnProductId.HeaderText = "columnProductId";
            this.columnProductId.Name = "columnProductId";
            this.columnProductId.Visible = false;
            // 
            // columnProducRef
            // 
            this.columnProducRef.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnProducRef.HeaderText = "columnProducRef";
            this.columnProducRef.Name = "columnProducRef";
            this.columnProducRef.ReadOnly = true;
            this.columnProducRef.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // columnProductName
            // 
            this.columnProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnProductName.HeaderText = "columnProductName";
            this.columnProductName.Name = "columnProductName";
            this.columnProductName.ReadOnly = true;
            // 
            // columnCurrentStock
            // 
            this.columnCurrentStock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnCurrentStock.HeaderText = "columnCurrentStock";
            this.columnCurrentStock.Name = "columnCurrentStock";
            this.columnCurrentStock.ReadOnly = true;
            this.columnCurrentStock.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // columnRefillQty
            // 
            this.columnRefillQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnRefillQty.HeaderText = "columnRefillQty";
            this.columnRefillQty.Name = "columnRefillQty";
            this.columnRefillQty.ReadOnly = true;
            this.columnRefillQty.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // columnEdit
            // 
            this.columnEdit.HeaderText = "";
            this.columnEdit.Image = global::StockManager.Properties.Resources.icon_pencil_drawing_24px;
            this.columnEdit.MinimumWidth = 30;
            this.columnEdit.Name = "columnEdit";
            this.columnEdit.ReadOnly = true;
            this.columnEdit.Width = 30;
            // 
            // lbLocation
            // 
            this.lbLocation.AutoSize = true;
            this.lbLocation.BackColor = System.Drawing.Color.Transparent;
            this.lbLocation.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.lbLocation.Location = new System.Drawing.Point(5, 21);
            this.lbLocation.Name = "lbLocation";
            this.lbLocation.Size = new System.Drawing.Size(120, 22);
            this.lbLocation.TabIndex = 33;
            this.lbLocation.Text = "lbLocation";
            // 
            // cbLocations
            // 
            this.cbLocations.BackColor = System.Drawing.Color.White;
            this.cbLocations.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbLocations.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLocations.ForeColor = System.Drawing.Color.Black;
            this.cbLocations.FormattingEnabled = true;
            this.cbLocations.Location = new System.Drawing.Point(9, 46);
            this.cbLocations.Name = "cbLocations";
            this.cbLocations.Size = new System.Drawing.Size(256, 24);
            this.cbLocations.TabIndex = 34;
            this.cbLocations.SelectionChangeCommitted += new System.EventHandler(this.cbLocations_SelectionChangeCommitted);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ColumnProductLocationId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "columnProducRef";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.HeaderText = "columnProductName";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.HeaderText = "columnProductName";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.HeaderText = "columnCurrentStock";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.HeaderText = "columnRefillQty";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // tbSeachText
            // 
            this.tbSeachText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbSeachText.BackColor = System.Drawing.Color.White;
            this.tbSeachText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSeachText.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSeachText.Location = new System.Drawing.Point(27, 6);
            this.tbSeachText.Name = "tbSeachText";
            this.tbSeachText.Size = new System.Drawing.Size(266, 22);
            this.tbSeachText.TabIndex = 4;
            this.tbSeachText.TextChanged += new System.EventHandler(this.tbSeachText_TextChanged);
            this.tbSeachText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSeachText_KeyPress);
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
            this.btnClearSearchValue.Location = new System.Drawing.Point(274, 7);
            this.btnClearSearchValue.Name = "btnClearSearchValue";
            this.btnClearSearchValue.Size = new System.Drawing.Size(17, 20);
            this.btnClearSearchValue.TabIndex = 11;
            this.btnClearSearchValue.UseVisualStyleBackColor = false;
            this.btnClearSearchValue.Click += new System.EventHandler(this.btnClearSearchValue_Click);
            // 
            // pnbSearchBox
            // 
            this.pnbSearchBox.Controls.Add(pbSearchIconx);
            this.pnbSearchBox.Controls.Add(this.btnClearSearchValue);
            this.pnbSearchBox.Controls.Add(this.tbSeachText);
            this.pnbSearchBox.Location = new System.Drawing.Point(5, 134);
            this.pnbSearchBox.Name = "pnbSearchBox";
            this.pnbSearchBox.Size = new System.Drawing.Size(302, 33);
            this.pnbSearchBox.TabIndex = 35;
            // 
            // lbProductLocation
            // 
            this.lbProductLocation.AutoSize = true;
            this.lbProductLocation.BackColor = System.Drawing.Color.Transparent;
            this.lbProductLocation.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProductLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.lbProductLocation.Location = new System.Drawing.Point(5, 103);
            this.lbProductLocation.Name = "lbProductLocation";
            this.lbProductLocation.Size = new System.Drawing.Size(197, 22);
            this.lbProductLocation.TabIndex = 36;
            this.lbProductLocation.Text = "lbProductLocation";
            // 
            // DashboardUc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbProductLocation);
            this.Controls.Add(this.pnbSearchBox);
            this.Controls.Add(this.cbLocations);
            this.Controls.Add(this.lbLocation);
            this.Controls.Add(this.dgvProducts);
            this.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DashboardUc";
            this.Size = new System.Drawing.Size(860, 643);
            ((System.ComponentModel.ISupportInitialize)(pbSearchIconx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.pnbSearchBox.ResumeLayout(false);
            this.pnbSearchBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Label lbLocation;
        private System.Windows.Forms.ComboBox cbLocations;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TextBox tbSeachText;
        private System.Windows.Forms.Button btnClearSearchValue;
        private System.Windows.Forms.Panel pnbSearchBox;
        private System.Windows.Forms.Label lbProductLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnProductLocationId;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnProducRef;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCurrentStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnRefillQty;
        private System.Windows.Forms.DataGridViewImageColumn columnEdit;
    }
}
