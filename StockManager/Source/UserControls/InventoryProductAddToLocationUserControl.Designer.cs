namespace StockManager.Source.UserControls {
  partial class InventoryProductAddToLocationUserControl {
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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.PictureBox pbSearchIcon;
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryProductAddToLocationUserControl));
      this.cbLocations = new System.Windows.Forms.ComboBox();
      this.pnlForm = new System.Windows.Forms.Panel();
      this.lbErrorMinStock = new System.Windows.Forms.Label();
      this.lbErrorQty = new System.Windows.Forms.Label();
      this.lbErrorLocation = new System.Windows.Forms.Label();
      this.lbMinStock = new System.Windows.Forms.Label();
      this.numMinStock = new System.Windows.Forms.NumericUpDown();
      this.lbQty = new System.Windows.Forms.Label();
      this.numQty = new System.Windows.Forms.NumericUpDown();
      this.lbLocation = new System.Windows.Forms.Label();
      this.pnlFormHeader = new System.Windows.Forms.Panel();
      this.lbFormTitle = new System.Windows.Forms.Label();
      this.pnProductLocations = new System.Windows.Forms.Panel();
      this.pnlProductLocationsHeader = new System.Windows.Forms.Panel();
      this.lbProductLocationsTitle = new System.Windows.Forms.Label();
      this.dgvProductLocations = new System.Windows.Forms.DataGridView();
      this.columnProductLocationId = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.columnLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColumnStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.columnMinStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.pnbSearchBox = new System.Windows.Forms.Panel();
      this.btnClearSearchValue = new System.Windows.Forms.Button();
      this.tbSeachText = new System.Windows.Forms.TextBox();
      this.pnlActions = new System.Windows.Forms.Panel();
      this.btnAddLocation = new System.Windows.Forms.Button();
      this.btnViewMovements = new System.Windows.Forms.Button();
      this.btnback = new System.Windows.Forms.Button();
      pbSearchIcon = new System.Windows.Forms.PictureBox();
      this.pnlForm.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numMinStock)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numQty)).BeginInit();
      this.pnlFormHeader.SuspendLayout();
      this.pnProductLocations.SuspendLayout();
      this.pnlProductLocationsHeader.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvProductLocations)).BeginInit();
      this.pnbSearchBox.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(pbSearchIcon)).BeginInit();
      this.pnlActions.SuspendLayout();
      this.SuspendLayout();
      // 
      // cbLocations
      // 
      this.cbLocations.FormattingEnabled = true;
      this.cbLocations.Location = new System.Drawing.Point(4, 70);
      this.cbLocations.Margin = new System.Windows.Forms.Padding(4);
      this.cbLocations.Name = "cbLocations";
      this.cbLocations.Size = new System.Drawing.Size(167, 24);
      this.cbLocations.TabIndex = 0;
      // 
      // pnlForm
      // 
      this.pnlForm.Controls.Add(this.pnlFormHeader);
      this.pnlForm.Controls.Add(this.lbErrorMinStock);
      this.pnlForm.Controls.Add(this.lbErrorQty);
      this.pnlForm.Controls.Add(this.lbErrorLocation);
      this.pnlForm.Controls.Add(this.lbMinStock);
      this.pnlForm.Controls.Add(this.numMinStock);
      this.pnlForm.Controls.Add(this.lbQty);
      this.pnlForm.Controls.Add(this.numQty);
      this.pnlForm.Controls.Add(this.cbLocations);
      this.pnlForm.Controls.Add(this.lbLocation);
      this.pnlForm.Location = new System.Drawing.Point(4, 50);
      this.pnlForm.Margin = new System.Windows.Forms.Padding(4);
      this.pnlForm.Name = "pnlForm";
      this.pnlForm.Size = new System.Drawing.Size(852, 118);
      this.pnlForm.TabIndex = 1;
      // 
      // lbErrorMinStock
      // 
      this.lbErrorMinStock.AutoSize = true;
      this.lbErrorMinStock.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbErrorMinStock.ForeColor = System.Drawing.Color.Red;
      this.lbErrorMinStock.Location = new System.Drawing.Point(348, 97);
      this.lbErrorMinStock.Name = "lbErrorMinStock";
      this.lbErrorMinStock.Size = new System.Drawing.Size(113, 16);
      this.lbErrorMinStock.TabIndex = 17;
      this.lbErrorMinStock.Text = "lbErrorMinStock";
      // 
      // lbErrorQty
      // 
      this.lbErrorQty.AutoSize = true;
      this.lbErrorQty.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbErrorQty.ForeColor = System.Drawing.Color.Red;
      this.lbErrorQty.Location = new System.Drawing.Point(192, 96);
      this.lbErrorQty.Name = "lbErrorQty";
      this.lbErrorQty.Size = new System.Drawing.Size(78, 16);
      this.lbErrorQty.TabIndex = 16;
      this.lbErrorQty.Text = "lbErrorQty";
      // 
      // lbErrorLocation
      // 
      this.lbErrorLocation.AutoSize = true;
      this.lbErrorLocation.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbErrorLocation.ForeColor = System.Drawing.Color.Red;
      this.lbErrorLocation.Location = new System.Drawing.Point(7, 98);
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
      this.lbMinStock.Location = new System.Drawing.Point(347, 51);
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
      this.numMinStock.ForeColor = System.Drawing.Color.Transparent;
      this.numMinStock.Location = new System.Drawing.Point(345, 70);
      this.numMinStock.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
      this.numMinStock.Name = "numMinStock";
      this.numMinStock.Size = new System.Drawing.Size(141, 24);
      this.numMinStock.TabIndex = 2;
      this.numMinStock.ThousandsSeparator = true;
      // 
      // lbQty
      // 
      this.lbQty.AutoSize = true;
      this.lbQty.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold);
      this.lbQty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(118)))), ((int)(((byte)(185)))));
      this.lbQty.Location = new System.Drawing.Point(192, 51);
      this.lbQty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lbQty.Name = "lbQty";
      this.lbQty.Size = new System.Drawing.Size(48, 16);
      this.lbQty.TabIndex = 3;
      this.lbQty.Text = "lbQty";
      // 
      // numQty
      // 
      this.numQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.numQty.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.numQty.ForeColor = System.Drawing.Color.Transparent;
      this.numQty.Location = new System.Drawing.Point(189, 69);
      this.numQty.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
      this.numQty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.numQty.Name = "numQty";
      this.numQty.Size = new System.Drawing.Size(141, 24);
      this.numQty.TabIndex = 1;
      this.numQty.ThousandsSeparator = true;
      this.numQty.Value = new decimal(new int[] {
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
      this.lbLocation.Location = new System.Drawing.Point(7, 51);
      this.lbLocation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lbLocation.Name = "lbLocation";
      this.lbLocation.Size = new System.Drawing.Size(88, 16);
      this.lbLocation.TabIndex = 2;
      this.lbLocation.Text = "lbLocation";
      // 
      // pnlFormHeader
      // 
      this.pnlFormHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.pnlFormHeader.BackColor = System.Drawing.SystemColors.Control;
      this.pnlFormHeader.Controls.Add(this.lbFormTitle);
      this.pnlFormHeader.Location = new System.Drawing.Point(-1, -2);
      this.pnlFormHeader.Name = "pnlFormHeader";
      this.pnlFormHeader.Size = new System.Drawing.Size(854, 36);
      this.pnlFormHeader.TabIndex = 17;
      // 
      // lbFormTitle
      // 
      this.lbFormTitle.AutoSize = true;
      this.lbFormTitle.BackColor = System.Drawing.Color.Transparent;
      this.lbFormTitle.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbFormTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
      this.lbFormTitle.Location = new System.Drawing.Point(4, 8);
      this.lbFormTitle.Name = "lbFormTitle";
      this.lbFormTitle.Size = new System.Drawing.Size(131, 22);
      this.lbFormTitle.TabIndex = 1;
      this.lbFormTitle.Text = "lbFormTitle";
      // 
      // pnProductLocations
      // 
      this.pnProductLocations.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.pnProductLocations.Controls.Add(this.dgvProductLocations);
      this.pnProductLocations.Controls.Add(this.pnlProductLocationsHeader);
      this.pnProductLocations.Location = new System.Drawing.Point(4, 187);
      this.pnProductLocations.Name = "pnProductLocations";
      this.pnProductLocations.Size = new System.Drawing.Size(852, 312);
      this.pnProductLocations.TabIndex = 2;
      // 
      // pnlProductLocationsHeader
      // 
      this.pnlProductLocationsHeader.BackColor = System.Drawing.SystemColors.Control;
      this.pnlProductLocationsHeader.Controls.Add(this.lbProductLocationsTitle);
      this.pnlProductLocationsHeader.Dock = System.Windows.Forms.DockStyle.Top;
      this.pnlProductLocationsHeader.Location = new System.Drawing.Point(0, 0);
      this.pnlProductLocationsHeader.Name = "pnlProductLocationsHeader";
      this.pnlProductLocationsHeader.Size = new System.Drawing.Size(852, 35);
      this.pnlProductLocationsHeader.TabIndex = 17;
      // 
      // lbProductLocationsTitle
      // 
      this.lbProductLocationsTitle.AutoSize = true;
      this.lbProductLocationsTitle.BackColor = System.Drawing.Color.Transparent;
      this.lbProductLocationsTitle.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbProductLocationsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
      this.lbProductLocationsTitle.Location = new System.Drawing.Point(5, 6);
      this.lbProductLocationsTitle.Name = "lbProductLocationsTitle";
      this.lbProductLocationsTitle.Size = new System.Drawing.Size(263, 22);
      this.lbProductLocationsTitle.TabIndex = 1;
      this.lbProductLocationsTitle.Text = "lbProductLocationsTitle";
      // 
      // dgvProductLocations
      // 
      this.dgvProductLocations.AllowUserToAddRows = false;
      this.dgvProductLocations.AllowUserToDeleteRows = false;
      this.dgvProductLocations.AllowUserToOrderColumns = true;
      dataGridViewCellStyle16.BackColor = System.Drawing.Color.LightGray;
      dataGridViewCellStyle16.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Black;
      dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(118)))), ((int)(((byte)(185)))));
      dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.White;
      this.dgvProductLocations.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
      this.dgvProductLocations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dgvProductLocations.BackgroundColor = System.Drawing.SystemColors.Control;
      this.dgvProductLocations.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
      dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
      dataGridViewCellStyle17.Font = new System.Drawing.Font("Courier New", 9.75F);
      dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
      dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
      dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.White;
      dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dgvProductLocations.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
      this.dgvProductLocations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvProductLocations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnProductLocationId,
            this.columnLocation,
            this.ColumnStock,
            this.columnMinStock});
      dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle18.Font = new System.Drawing.Font("Courier New", 9.75F);
      dataGridViewCellStyle18.ForeColor = System.Drawing.Color.White;
      dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.Black;
      dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.dgvProductLocations.DefaultCellStyle = dataGridViewCellStyle18;
      this.dgvProductLocations.EnableHeadersVisualStyles = false;
      this.dgvProductLocations.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
      this.dgvProductLocations.Location = new System.Drawing.Point(0, 34);
      this.dgvProductLocations.Name = "dgvProductLocations";
      this.dgvProductLocations.ReadOnly = true;
      dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle19.Font = new System.Drawing.Font("Courier New", 9.75F);
      dataGridViewCellStyle19.ForeColor = System.Drawing.Color.Black;
      dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.Black;
      dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dgvProductLocations.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
      this.dgvProductLocations.RowHeadersWidth = 25;
      dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle20.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle20.ForeColor = System.Drawing.Color.Black;
      dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(118)))), ((int)(((byte)(185)))));
      dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.White;
      this.dgvProductLocations.RowsDefaultCellStyle = dataGridViewCellStyle20;
      this.dgvProductLocations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgvProductLocations.Size = new System.Drawing.Size(852, 278);
      this.dgvProductLocations.TabIndex = 18;
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
      // pnbSearchBox
      // 
      this.pnbSearchBox.Controls.Add(pbSearchIcon);
      this.pnbSearchBox.Controls.Add(this.btnClearSearchValue);
      this.pnbSearchBox.Controls.Add(this.tbSeachText);
      this.pnbSearchBox.Location = new System.Drawing.Point(5, 4);
      this.pnbSearchBox.Name = "pnbSearchBox";
      this.pnbSearchBox.Size = new System.Drawing.Size(324, 33);
      this.pnbSearchBox.TabIndex = 16;
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
      // 
      // pnlActions
      // 
      this.pnlActions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.pnlActions.Controls.Add(this.btnAddLocation);
      this.pnlActions.Controls.Add(this.btnViewMovements);
      this.pnlActions.Controls.Add(this.btnback);
      this.pnlActions.Location = new System.Drawing.Point(555, 5);
      this.pnlActions.Name = "pnlActions";
      this.pnlActions.Size = new System.Drawing.Size(300, 34);
      this.pnlActions.TabIndex = 19;
      // 
      // btnAddLocation
      // 
      this.btnAddLocation.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.btnAddLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
      this.btnAddLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnAddLocation.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnAddLocation.ForeColor = System.Drawing.Color.White;
      this.btnAddLocation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnAddLocation.Location = new System.Drawing.Point(105, 3);
      this.btnAddLocation.Name = "btnAddLocation";
      this.btnAddLocation.Size = new System.Drawing.Size(93, 27);
      this.btnAddLocation.TabIndex = 9;
      this.btnAddLocation.Text = "btnAddLocation";
      this.btnAddLocation.UseVisualStyleBackColor = false;
      // 
      // btnViewMovements
      // 
      this.btnViewMovements.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.btnViewMovements.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(173)))), ((int)(((byte)(78)))));
      this.btnViewMovements.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnViewMovements.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnViewMovements.ForeColor = System.Drawing.Color.White;
      this.btnViewMovements.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnViewMovements.Location = new System.Drawing.Point(204, 3);
      this.btnViewMovements.Name = "btnViewMovements";
      this.btnViewMovements.Size = new System.Drawing.Size(93, 27);
      this.btnViewMovements.TabIndex = 8;
      this.btnViewMovements.Text = "btnViewMovements";
      this.btnViewMovements.UseVisualStyleBackColor = false;
      // 
      // btnback
      // 
      this.btnback.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.btnback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
      this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnback.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnback.ForeColor = System.Drawing.Color.White;
      this.btnback.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnback.Location = new System.Drawing.Point(5, 3);
      this.btnback.Name = "btnback";
      this.btnback.Size = new System.Drawing.Size(93, 27);
      this.btnback.TabIndex = 7;
      this.btnback.Text = "btnback";
      this.btnback.UseVisualStyleBackColor = false;
      // 
      // InventoryProductAddToLocationUserControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.pnlActions);
      this.Controls.Add(this.pnbSearchBox);
      this.Controls.Add(this.pnProductLocations);
      this.Controls.Add(this.pnlForm);
      this.Font = new System.Drawing.Font("Courier New", 9.75F);
      this.ForeColor = System.Drawing.Color.White;
      this.Margin = new System.Windows.Forms.Padding(4);
      this.Name = "InventoryProductAddToLocationUserControl";
      this.Size = new System.Drawing.Size(860, 506);
      this.pnlForm.ResumeLayout(false);
      this.pnlForm.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numMinStock)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numQty)).EndInit();
      this.pnlFormHeader.ResumeLayout(false);
      this.pnlFormHeader.PerformLayout();
      this.pnProductLocations.ResumeLayout(false);
      this.pnlProductLocationsHeader.ResumeLayout(false);
      this.pnlProductLocationsHeader.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvProductLocations)).EndInit();
      this.pnbSearchBox.ResumeLayout(false);
      this.pnbSearchBox.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(pbSearchIcon)).EndInit();
      this.pnlActions.ResumeLayout(false);
      this.ResumeLayout(false);

    }

        #endregion

        private System.Windows.Forms.ComboBox cbLocations;
        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.Label lbLocation;
        private System.Windows.Forms.NumericUpDown numQty;
        private System.Windows.Forms.Label lbMinStock;
        private System.Windows.Forms.NumericUpDown numMinStock;
        private System.Windows.Forms.Label lbQty;
        private System.Windows.Forms.Label lbErrorMinStock;
        private System.Windows.Forms.Label lbErrorQty;
        private System.Windows.Forms.Label lbErrorLocation;
        private System.Windows.Forms.Panel pnlFormHeader;
        private System.Windows.Forms.Label lbFormTitle;
        private System.Windows.Forms.Panel pnProductLocations;
        private System.Windows.Forms.Panel pnlProductLocationsHeader;
        private System.Windows.Forms.Label lbProductLocationsTitle;
        private System.Windows.Forms.DataGridView dgvProductLocations;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnProductLocationId;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnMinStock;
        private System.Windows.Forms.Panel pnbSearchBox;
        private System.Windows.Forms.Button btnClearSearchValue;
        private System.Windows.Forms.TextBox tbSeachText;
        private System.Windows.Forms.Panel pnlActions;
        private System.Windows.Forms.Button btnAddLocation;
        private System.Windows.Forms.Button btnViewMovements;
        private System.Windows.Forms.Button btnback;
    }
}
