namespace StockManager.Source.UserControls
{
    partial class SettingsUc
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
            this.lbLanguage = new System.Windows.Forms.Label();
            this.cbLanguage = new System.Windows.Forms.ComboBox();
            this.pnlActions = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lbLanguageWarning = new System.Windows.Forms.Label();
            this.numDefaultGlobalMinStock = new System.Windows.Forms.NumericUpDown();
            this.lbDefaultGlobalMinStock = new System.Windows.Forms.Label();
            this.lbDefaultGlobalMinStockWarning = new System.Windows.Forms.Label();
            this.lbDocumentsFolder = new System.Windows.Forms.Label();
            this.cbDocumentsFolder = new System.Windows.Forms.ComboBox();
            this.lbDocumentsFolderPath = new System.Windows.Forms.Label();
            this.pnlActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDefaultGlobalMinStock)).BeginInit();
            this.SuspendLayout();
            // 
            // lbLanguage
            // 
            this.lbLanguage.AutoSize = true;
            this.lbLanguage.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLanguage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(118)))), ((int)(((byte)(185)))));
            this.lbLanguage.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbLanguage.Location = new System.Drawing.Point(12, 38);
            this.lbLanguage.Name = "lbLanguage";
            this.lbLanguage.Size = new System.Drawing.Size(88, 16);
            this.lbLanguage.TabIndex = 10;
            this.lbLanguage.Text = "lbLanguage";
            // 
            // cbLanguage
            // 
            this.cbLanguage.BackColor = System.Drawing.Color.White;
            this.cbLanguage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLanguage.ForeColor = System.Drawing.Color.Black;
            this.cbLanguage.FormattingEnabled = true;
            this.cbLanguage.Location = new System.Drawing.Point(15, 57);
            this.cbLanguage.Name = "cbLanguage";
            this.cbLanguage.Size = new System.Drawing.Size(252, 24);
            this.cbLanguage.TabIndex = 14;
            this.cbLanguage.SelectionChangeCommitted += new System.EventHandler(this.cbLanguage_SelectionChangeCommitted);
            // 
            // pnlActions
            // 
            this.pnlActions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlActions.Controls.Add(this.btnCancel);
            this.pnlActions.Controls.Add(this.btnSave);
            this.pnlActions.Location = new System.Drawing.Point(658, 3);
            this.pnlActions.Name = "pnlActions";
            this.pnlActions.Size = new System.Drawing.Size(199, 34);
            this.pnlActions.TabIndex = 11;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(102, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(93, 27);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(5, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(93, 27);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "btnSave";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lbLanguageWarning
            // 
            this.lbLanguageWarning.AutoSize = true;
            this.lbLanguageWarning.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLanguageWarning.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.lbLanguageWarning.Location = new System.Drawing.Point(13, 84);
            this.lbLanguageWarning.MaximumSize = new System.Drawing.Size(350, 0);
            this.lbLanguageWarning.Name = "lbLanguageWarning";
            this.lbLanguageWarning.Size = new System.Drawing.Size(126, 15);
            this.lbLanguageWarning.TabIndex = 15;
            this.lbLanguageWarning.Text = "lbLanguageWarning";
            // 
            // numDefaultGlobalMinStock
            // 
            this.numDefaultGlobalMinStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numDefaultGlobalMinStock.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDefaultGlobalMinStock.Location = new System.Drawing.Point(14, 222);
            this.numDefaultGlobalMinStock.Maximum = new decimal(new int[] {
            -1530494977,
            232830,
            0,
            0});
            this.numDefaultGlobalMinStock.Name = "numDefaultGlobalMinStock";
            this.numDefaultGlobalMinStock.Size = new System.Drawing.Size(252, 24);
            this.numDefaultGlobalMinStock.TabIndex = 16;
            this.numDefaultGlobalMinStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numDefaultGlobalMinStock.ThousandsSeparator = true;
            // 
            // lbDefaultGlobalMinStock
            // 
            this.lbDefaultGlobalMinStock.AutoSize = true;
            this.lbDefaultGlobalMinStock.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDefaultGlobalMinStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(118)))), ((int)(((byte)(185)))));
            this.lbDefaultGlobalMinStock.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbDefaultGlobalMinStock.Location = new System.Drawing.Point(12, 202);
            this.lbDefaultGlobalMinStock.Name = "lbDefaultGlobalMinStock";
            this.lbDefaultGlobalMinStock.Size = new System.Drawing.Size(192, 16);
            this.lbDefaultGlobalMinStock.TabIndex = 17;
            this.lbDefaultGlobalMinStock.Text = "lbDefaultGlobalMinStock";
            // 
            // lbDefaultGlobalMinStockWarning
            // 
            this.lbDefaultGlobalMinStockWarning.AutoSize = true;
            this.lbDefaultGlobalMinStockWarning.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDefaultGlobalMinStockWarning.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.lbDefaultGlobalMinStockWarning.Location = new System.Drawing.Point(12, 249);
            this.lbDefaultGlobalMinStockWarning.MaximumSize = new System.Drawing.Size(350, 0);
            this.lbDefaultGlobalMinStockWarning.Name = "lbDefaultGlobalMinStockWarning";
            this.lbDefaultGlobalMinStockWarning.Size = new System.Drawing.Size(217, 15);
            this.lbDefaultGlobalMinStockWarning.TabIndex = 18;
            this.lbDefaultGlobalMinStockWarning.Text = "lbDefaultGlobalMinStockWarning";
            // 
            // lbDocumentsFolder
            // 
            this.lbDocumentsFolder.AutoSize = true;
            this.lbDocumentsFolder.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDocumentsFolder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(118)))), ((int)(((byte)(185)))));
            this.lbDocumentsFolder.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbDocumentsFolder.Location = new System.Drawing.Point(12, 120);
            this.lbDocumentsFolder.Name = "lbDocumentsFolder";
            this.lbDocumentsFolder.Size = new System.Drawing.Size(144, 16);
            this.lbDocumentsFolder.TabIndex = 20;
            this.lbDocumentsFolder.Text = "lbDocumentsFolder";
            // 
            // cbDocumentsFolder
            // 
            this.cbDocumentsFolder.BackColor = System.Drawing.Color.White;
            this.cbDocumentsFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbDocumentsFolder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDocumentsFolder.ForeColor = System.Drawing.Color.Black;
            this.cbDocumentsFolder.FormattingEnabled = true;
            this.cbDocumentsFolder.Location = new System.Drawing.Point(15, 139);
            this.cbDocumentsFolder.Name = "cbDocumentsFolder";
            this.cbDocumentsFolder.Size = new System.Drawing.Size(252, 24);
            this.cbDocumentsFolder.TabIndex = 15;
            this.cbDocumentsFolder.SelectionChangeCommitted += new System.EventHandler(this.cbDocumentsFolder_SelectionChangeCommitted);
            // 
            // lbDocumentsFolderPath
            // 
            this.lbDocumentsFolderPath.AutoSize = true;
            this.lbDocumentsFolderPath.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDocumentsFolderPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.lbDocumentsFolderPath.Location = new System.Drawing.Point(13, 167);
            this.lbDocumentsFolderPath.MaximumSize = new System.Drawing.Size(350, 0);
            this.lbDocumentsFolderPath.Name = "lbDocumentsFolderPath";
            this.lbDocumentsFolderPath.Size = new System.Drawing.Size(154, 15);
            this.lbDocumentsFolderPath.TabIndex = 21;
            this.lbDocumentsFolderPath.Text = "lbDocumentsFolderPath";
            // 
            // SettingsUc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.lbDocumentsFolderPath);
            this.Controls.Add(this.lbDocumentsFolder);
            this.Controls.Add(this.cbDocumentsFolder);
            this.Controls.Add(this.lbDefaultGlobalMinStockWarning);
            this.Controls.Add(this.numDefaultGlobalMinStock);
            this.Controls.Add(this.lbDefaultGlobalMinStock);
            this.Controls.Add(this.lbLanguageWarning);
            this.Controls.Add(this.pnlActions);
            this.Controls.Add(this.lbLanguage);
            this.Controls.Add(this.cbLanguage);
            this.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SettingsUc";
            this.Size = new System.Drawing.Size(860, 420);
            this.pnlActions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numDefaultGlobalMinStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbLanguage;
        private System.Windows.Forms.ComboBox cbLanguage;
        private System.Windows.Forms.Panel pnlActions;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lbLanguageWarning;
        private System.Windows.Forms.NumericUpDown numDefaultGlobalMinStock;
        private System.Windows.Forms.Label lbDefaultGlobalMinStock;
        private System.Windows.Forms.Label lbDefaultGlobalMinStockWarning;
        private System.Windows.Forms.Label lbDocumentsFolder;
        private System.Windows.Forms.ComboBox cbDocumentsFolder;
        private System.Windows.Forms.Label lbDocumentsFolderPath;
    }
}
