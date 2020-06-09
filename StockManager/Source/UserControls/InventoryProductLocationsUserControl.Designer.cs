namespace StockManager.Source.UserControls {
  partial class InventoryProductLocationsUserControl {
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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
      this.cbLocations = new System.Windows.Forms.ComboBox();
      this.pnlForm = new System.Windows.Forms.Panel();
      this.panel1 = new System.Windows.Forms.Panel();
      this.lbFormTitle = new System.Windows.Forms.Label();
      this.btnAddLocation = new System.Windows.Forms.Button();
      this.lbErrorLocation = new System.Windows.Forms.Label();
      this.lbMinStock = new System.Windows.Forms.Label();
      this.numMinStock = new System.Windows.Forms.NumericUpDown();
      this.lbStock = new System.Windows.Forms.Label();
      this.numStock = new System.Windows.Forms.NumericUpDown();
      this.lbLocation = new System.Windows.Forms.Label();
      this.dgvProductLocations = new System.Windows.Forms.DataGridView();
      this.columnProductLocationId = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.columnLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColumnStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.columnMinStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.columnActionDelete = new System.Windows.Forms.DataGridViewImageColumn();
      this.btnback = new System.Windows.Forms.Button();
      this.pnlTop = new System.Windows.Forms.Panel();
      this.dgvProductStockMovements = new System.Windows.Forms.DataGridView();
      this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.columnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.columnStockAcc = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.columnUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.lbProductStockMovements = new System.Windows.Forms.Label();
      this.pnlForm.SuspendLayout();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numMinStock)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numStock)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgvProductLocations)).BeginInit();
      this.pnlTop.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvProductStockMovements)).BeginInit();
      this.SuspendLayout();
      // 
      // cbLocations
      // 
      this.cbLocations.FormattingEnabled = true;
      this.cbLocations.Location = new System.Drawing.Point(53, 48);
      this.cbLocations.Margin = new System.Windows.Forms.Padding(4);
      this.cbLocations.Name = "cbLocations";
      this.cbLocations.Size = new System.Drawing.Size(167, 24);
      this.cbLocations.TabIndex = 0;
      // 
      // pnlForm
      // 
      this.pnlForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.pnlForm.BackColor = System.Drawing.Color.Transparent;
      this.pnlForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.pnlForm.Controls.Add(this.panel1);
      this.pnlForm.Controls.Add(this.btnAddLocation);
      this.pnlForm.Controls.Add(this.lbErrorLocation);
      this.pnlForm.Controls.Add(this.lbMinStock);
      this.pnlForm.Controls.Add(this.numMinStock);
      this.pnlForm.Controls.Add(this.lbStock);
      this.pnlForm.Controls.Add(this.numStock);
      this.pnlForm.Controls.Add(this.cbLocations);
      this.pnlForm.Controls.Add(this.lbLocation);
      this.pnlForm.ForeColor = System.Drawing.Color.Transparent;
      this.pnlForm.Location = new System.Drawing.Point(4, 4);
      this.pnlForm.Margin = new System.Windows.Forms.Padding(4);
      this.pnlForm.Name = "pnlForm";
      this.pnlForm.Size = new System.Drawing.Size(280, 281);
      this.pnlForm.TabIndex = 1;
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
      this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.panel1.Controls.Add(this.lbFormTitle);
      this.panel1.Location = new System.Drawing.Point(-1, -1);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(280, 23);
      this.panel1.TabIndex = 22;
      // 
      // lbFormTitle
      // 
      this.lbFormTitle.AutoSize = true;
      this.lbFormTitle.BackColor = System.Drawing.Color.Transparent;
      this.lbFormTitle.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbFormTitle.ForeColor = System.Drawing.Color.White;
      this.lbFormTitle.Location = new System.Drawing.Point(4, 3);
      this.lbFormTitle.Name = "lbFormTitle";
      this.lbFormTitle.Size = new System.Drawing.Size(96, 16);
      this.lbFormTitle.TabIndex = 1;
      this.lbFormTitle.Text = "lbFormTitle";
      // 
      // btnAddLocation
      // 
      this.btnAddLocation.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.btnAddLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
      this.btnAddLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnAddLocation.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnAddLocation.ForeColor = System.Drawing.Color.White;
      this.btnAddLocation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnAddLocation.Location = new System.Drawing.Point(87, 240);
      this.btnAddLocation.Name = "btnAddLocation";
      this.btnAddLocation.Size = new System.Drawing.Size(93, 27);
      this.btnAddLocation.TabIndex = 3;
      this.btnAddLocation.Text = "btnAddLocation";
      this.btnAddLocation.UseVisualStyleBackColor = false;
      this.btnAddLocation.Click += new System.EventHandler(this.btnAddLocation_Click);
      // 
      // lbErrorLocation
      // 
      this.lbErrorLocation.AutoSize = true;
      this.lbErrorLocation.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbErrorLocation.ForeColor = System.Drawing.Color.Red;
      this.lbErrorLocation.Location = new System.Drawing.Point(50, 76);
      this.lbErrorLocation.Name = "lbErrorLocation";
      this.lbErrorLocation.Size = new System.Drawing.Size(113, 16);
      this.lbErrorLocation.TabIndex = 15;
      this.lbErrorLocation.Text = "lbErrorLocation";
      // 
      // lbMinStock
      // 
      this.lbMinStock.AutoSize = true;
      this.lbMinStock.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold);
      this.lbMinStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(118)))), ((int)(((byte)(185)))));
      this.lbMinStock.Location = new System.Drawing.Point(50, 171);
      this.lbMinStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lbMinStock.Name = "lbMinStock";
      this.lbMinStock.Size = new System.Drawing.Size(88, 16);
      this.lbMinStock.TabIndex = 5;
      this.lbMinStock.Text = "lbMinStock";
      // 
      // numMinStock
      // 
      this.numMinStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.numMinStock.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.numMinStock.ForeColor = System.Drawing.Color.Black;
      this.numMinStock.Location = new System.Drawing.Point(53, 190);
      this.numMinStock.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
      this.numMinStock.Name = "numMinStock";
      this.numMinStock.Size = new System.Drawing.Size(167, 24);
      this.numMinStock.TabIndex = 2;
      this.numMinStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.numMinStock.ThousandsSeparator = true;
      // 
      // lbStock
      // 
      this.lbStock.AutoSize = true;
      this.lbStock.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold);
      this.lbStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(118)))), ((int)(((byte)(185)))));
      this.lbStock.Location = new System.Drawing.Point(50, 99);
      this.lbStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lbStock.Name = "lbStock";
      this.lbStock.Size = new System.Drawing.Size(48, 16);
      this.lbStock.TabIndex = 3;
      this.lbStock.Text = "lbQty";
      // 
      // numStock
      // 
      this.numStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.numStock.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.numStock.ForeColor = System.Drawing.Color.Black;
      this.numStock.Location = new System.Drawing.Point(53, 117);
      this.numStock.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
      this.numStock.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.numStock.Name = "numStock";
      this.numStock.Size = new System.Drawing.Size(167, 24);
      this.numStock.TabIndex = 1;
      this.numStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.numStock.ThousandsSeparator = true;
      this.numStock.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      // 
      // lbLocation
      // 
      this.lbLocation.AutoSize = true;
      this.lbLocation.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold);
      this.lbLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(118)))), ((int)(((byte)(185)))));
      this.lbLocation.Location = new System.Drawing.Point(50, 29);
      this.lbLocation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lbLocation.Name = "lbLocation";
      this.lbLocation.Size = new System.Drawing.Size(88, 16);
      this.lbLocation.TabIndex = 2;
      this.lbLocation.Text = "lbLocation";
      // 
      // dgvProductLocations
      // 
      this.dgvProductLocations.AllowUserToAddRows = false;
      this.dgvProductLocations.AllowUserToDeleteRows = false;
      this.dgvProductLocations.AllowUserToResizeColumns = false;
      this.dgvProductLocations.AllowUserToResizeRows = false;
      dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
      dataGridViewCellStyle1.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
      dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(118)))), ((int)(((byte)(185)))));
      dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
      this.dgvProductLocations.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
      this.dgvProductLocations.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dgvProductLocations.BackgroundColor = System.Drawing.SystemColors.Control;
      this.dgvProductLocations.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
      dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
      dataGridViewCellStyle2.Font = new System.Drawing.Font("Courier New", 9.75F);
      dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
      dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
      dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
      dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dgvProductLocations.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
      this.dgvProductLocations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvProductLocations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnProductLocationId,
            this.columnLocation,
            this.ColumnStock,
            this.columnMinStock,
            this.columnActionDelete});
      dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle3.Font = new System.Drawing.Font("Courier New", 9.75F);
      dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
      dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
      dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.dgvProductLocations.DefaultCellStyle = dataGridViewCellStyle3;
      this.dgvProductLocations.EnableHeadersVisualStyles = false;
      this.dgvProductLocations.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
      this.dgvProductLocations.Location = new System.Drawing.Point(291, 4);
      this.dgvProductLocations.MultiSelect = false;
      this.dgvProductLocations.Name = "dgvProductLocations";
      this.dgvProductLocations.ReadOnly = true;
      dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle4.Font = new System.Drawing.Font("Courier New", 9.75F);
      dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
      dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
      dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dgvProductLocations.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
      this.dgvProductLocations.RowHeadersVisible = false;
      this.dgvProductLocations.RowHeadersWidth = 25;
      dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle5.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
      dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
      dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
      this.dgvProductLocations.RowsDefaultCellStyle = dataGridViewCellStyle5;
      this.dgvProductLocations.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Control;
      this.dgvProductLocations.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
      this.dgvProductLocations.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
      this.dgvProductLocations.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
      this.dgvProductLocations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgvProductLocations.Size = new System.Drawing.Size(558, 281);
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
      this.pnlTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.pnlTop.Controls.Add(this.dgvProductLocations);
      this.pnlTop.Controls.Add(this.pnlForm);
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
      dataGridViewCellStyle6.BackColor = System.Drawing.Color.LightGray;
      dataGridViewCellStyle6.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
      dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(118)))), ((int)(((byte)(185)))));
      dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
      this.dgvProductStockMovements.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
      this.dgvProductStockMovements.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dgvProductStockMovements.BackgroundColor = System.Drawing.SystemColors.Control;
      this.dgvProductStockMovements.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
      dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
      dataGridViewCellStyle7.Font = new System.Drawing.Font("Courier New", 9.75F);
      dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
      dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
      dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
      dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dgvProductStockMovements.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
      this.dgvProductStockMovements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvProductStockMovements.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.columnDate,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.columnStockAcc,
            this.columnUser});
      dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle8.Font = new System.Drawing.Font("Courier New", 9.75F);
      dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
      dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
      dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.dgvProductStockMovements.DefaultCellStyle = dataGridViewCellStyle8;
      this.dgvProductStockMovements.EnableHeadersVisualStyles = false;
      this.dgvProductStockMovements.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
      this.dgvProductStockMovements.Location = new System.Drawing.Point(8, 374);
      this.dgvProductStockMovements.Name = "dgvProductStockMovements";
      this.dgvProductStockMovements.ReadOnly = true;
      dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle9.Font = new System.Drawing.Font("Courier New", 9.75F);
      dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
      dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
      dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dgvProductStockMovements.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
      this.dgvProductStockMovements.RowHeadersVisible = false;
      this.dgvProductStockMovements.RowHeadersWidth = 25;
      dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle10.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
      dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
      dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
      this.dgvProductStockMovements.RowsDefaultCellStyle = dataGridViewCellStyle10;
      this.dgvProductStockMovements.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Control;
      this.dgvProductStockMovements.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
      this.dgvProductStockMovements.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
      this.dgvProductStockMovements.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
      this.dgvProductStockMovements.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgvProductStockMovements.Size = new System.Drawing.Size(845, 260);
      this.dgvProductStockMovements.TabIndex = 5;
      // 
      // dataGridViewTextBoxColumn1
      // 
      this.dataGridViewTextBoxColumn1.HeaderText = "columnStockMovementId";
      this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
      this.dataGridViewTextBoxColumn1.ReadOnly = true;
      this.dataGridViewTextBoxColumn1.Visible = false;
      // 
      // columnDate
      // 
      this.columnDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.columnDate.HeaderText = "columnDate";
      this.columnDate.Name = "columnDate";
      this.columnDate.ReadOnly = true;
      // 
      // dataGridViewTextBoxColumn2
      // 
      this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.dataGridViewTextBoxColumn2.HeaderText = "columnFrom";
      this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
      this.dataGridViewTextBoxColumn2.ReadOnly = true;
      this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
      // 
      // dataGridViewTextBoxColumn3
      // 
      this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.dataGridViewTextBoxColumn3.HeaderText = "columnTo";
      this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
      this.dataGridViewTextBoxColumn3.ReadOnly = true;
      // 
      // dataGridViewTextBoxColumn4
      // 
      this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.dataGridViewTextBoxColumn4.HeaderText = "columnQty";
      this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
      this.dataGridViewTextBoxColumn4.ReadOnly = true;
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
      // InventoryProductLocationsUserControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.lbProductStockMovements);
      this.Controls.Add(this.dgvProductStockMovements);
      this.Controls.Add(this.pnlTop);
      this.Controls.Add(this.btnback);
      this.Font = new System.Drawing.Font("Courier New", 9.75F);
      this.ForeColor = System.Drawing.Color.White;
      this.Margin = new System.Windows.Forms.Padding(4);
      this.Name = "InventoryProductLocationsUserControl";
      this.Size = new System.Drawing.Size(860, 643);
      this.pnlForm.ResumeLayout(false);
      this.pnlForm.PerformLayout();
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numMinStock)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numStock)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgvProductLocations)).EndInit();
      this.pnlTop.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dgvProductStockMovements)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.ComboBox cbLocations;
        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.Label lbLocation;
        private System.Windows.Forms.NumericUpDown numStock;
        private System.Windows.Forms.Label lbMinStock;
        private System.Windows.Forms.NumericUpDown numMinStock;
        private System.Windows.Forms.Label lbStock;
        private System.Windows.Forms.Label lbErrorLocation;
        private System.Windows.Forms.Label lbFormTitle;
        private System.Windows.Forms.DataGridView dgvProductLocations;
        private System.Windows.Forms.Button btnAddLocation;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Panel pnlTop;
    private System.Windows.Forms.DataGridView dgvProductStockMovements;
    private System.Windows.Forms.Label lbProductStockMovements;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.DataGridViewTextBoxColumn columnProductLocationId;
    private System.Windows.Forms.DataGridViewTextBoxColumn columnLocation;
    private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStock;
    private System.Windows.Forms.DataGridViewTextBoxColumn columnMinStock;
    private System.Windows.Forms.DataGridViewImageColumn columnActionDelete;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private System.Windows.Forms.DataGridViewTextBoxColumn columnDate;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    private System.Windows.Forms.DataGridViewTextBoxColumn columnStockAcc;
    private System.Windows.Forms.DataGridViewTextBoxColumn columnUser;
  }
}
