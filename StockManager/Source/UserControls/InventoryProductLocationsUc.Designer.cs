﻿namespace StockManager.Source.UserControls
{
    partial class InventoryProductLocationsUc
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvProductLocations = new System.Windows.Forms.DataGridView();
            this.columnProductLocationId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnReference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnMinStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnActionEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.columnActionDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnback = new System.Windows.Forms.Button();
            this.pnlActions = new System.Windows.Forms.Panel();
            this.btnStockMovement = new System.Windows.Forms.Button();
            this.btnCreatePdf = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductLocations)).BeginInit();
            this.pnlActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProductLocations
            // 
            this.dgvProductLocations.AllowUserToAddRows = false;
            this.dgvProductLocations.AllowUserToDeleteRows = false;
            this.dgvProductLocations.AllowUserToResizeColumns = false;
            this.dgvProductLocations.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvProductLocations.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvProductLocations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProductLocations.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProductLocations.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvProductLocations.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Courier New", 9.75F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductLocations.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvProductLocations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductLocations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnProductLocationId,
            this.columnReference,
            this.columnLocation,
            this.ColumnStock,
            this.columnMinStock,
            this.columnActionEdit,
            this.columnActionDelete});
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Courier New", 9.75F);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductLocations.DefaultCellStyle = dataGridViewCellStyle13;
            this.dgvProductLocations.EnableHeadersVisualStyles = false;
            this.dgvProductLocations.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.dgvProductLocations.Location = new System.Drawing.Point(8, 45);
            this.dgvProductLocations.MultiSelect = false;
            this.dgvProductLocations.Name = "dgvProductLocations";
            this.dgvProductLocations.ReadOnly = true;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Courier New", 9.75F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductLocations.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvProductLocations.RowHeadersVisible = false;
            this.dgvProductLocations.RowHeadersWidth = 25;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvProductLocations.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvProductLocations.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductLocations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductLocations.Size = new System.Drawing.Size(845, 365);
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
            // columnReference
            // 
            this.columnReference.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnReference.HeaderText = "columnReference";
            this.columnReference.Name = "columnReference";
            this.columnReference.ReadOnly = true;
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
            this.btnback.Location = new System.Drawing.Point(8, 9);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(93, 27);
            this.btnback.TabIndex = 6;
            this.btnback.Text = "btnback";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // pnlActions
            // 
            this.pnlActions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlActions.Controls.Add(this.btnCreatePdf);
            this.pnlActions.Controls.Add(this.btnStockMovement);
            this.pnlActions.Location = new System.Drawing.Point(532, 6);
            this.pnlActions.Name = "pnlActions";
            this.pnlActions.Size = new System.Drawing.Size(325, 34);
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
            this.btnStockMovement.Location = new System.Drawing.Point(200, 4);
            this.btnStockMovement.Name = "btnStockMovement";
            this.btnStockMovement.Size = new System.Drawing.Size(121, 27);
            this.btnStockMovement.TabIndex = 7;
            this.btnStockMovement.Text = "btnStockMovement";
            this.btnStockMovement.UseVisualStyleBackColor = false;
            this.btnStockMovement.Click += new System.EventHandler(this.btnStockMovement_Click);
            // 
            // btnCreatePdf
            // 
            this.btnCreatePdf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCreatePdf.BackColor = System.Drawing.Color.Gray;
            this.btnCreatePdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreatePdf.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreatePdf.ForeColor = System.Drawing.Color.White;
            this.btnCreatePdf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreatePdf.Location = new System.Drawing.Point(26, 4);
            this.btnCreatePdf.Name = "btnCreatePdf";
            this.btnCreatePdf.Size = new System.Drawing.Size(170, 27);
            this.btnCreatePdf.TabIndex = 12;
            this.btnCreatePdf.Text = "btnCreatePdf";
            this.btnCreatePdf.UseVisualStyleBackColor = false;
            this.btnCreatePdf.Click += new System.EventHandler(this.btnCreatePdf_Click);
            // 
            // InventoryProductLocationsUc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvProductLocations);
            this.Controls.Add(this.pnlActions);
            this.Controls.Add(this.btnback);
            this.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "InventoryProductLocationsUc";
            this.Size = new System.Drawing.Size(860, 420);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductLocations)).EndInit();
            this.pnlActions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvProductLocations;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Panel pnlActions;
        private System.Windows.Forms.Button btnStockMovement;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnProductLocationId;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnReference;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnMinStock;
        private System.Windows.Forms.DataGridViewImageColumn columnActionEdit;
        private System.Windows.Forms.DataGridViewImageColumn columnActionDelete;
        private System.Windows.Forms.Button btnCreatePdf;
    }
}
