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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
      this.cbLocations = new System.Windows.Forms.ComboBox();
      this.pnlForm = new System.Windows.Forms.Panel();
      this.btnAddLocation = new System.Windows.Forms.Button();
      this.lbErrorMinStock = new System.Windows.Forms.Label();
      this.lbErrorQty = new System.Windows.Forms.Label();
      this.lbErrorLocation = new System.Windows.Forms.Label();
      this.lbMinStock = new System.Windows.Forms.Label();
      this.numMinStock = new System.Windows.Forms.NumericUpDown();
      this.lbQty = new System.Windows.Forms.Label();
      this.numQty = new System.Windows.Forms.NumericUpDown();
      this.lbLocation = new System.Windows.Forms.Label();
      this.dgvProductLocations = new System.Windows.Forms.DataGridView();
      this.columnProductLocationId = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.columnLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColumnStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.columnMinStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.lbProductLocationsTitle = new System.Windows.Forms.Label();
      this.btnback = new System.Windows.Forms.Button();
      this.pnlTop = new System.Windows.Forms.Panel();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.lbProductStockMovements = new System.Windows.Forms.Label();
      this.pnlForm.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numMinStock)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numQty)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgvProductLocations)).BeginInit();
      this.pnlTop.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.SuspendLayout();
      // 
      // cbLocations
      // 
      this.cbLocations.FormattingEnabled = true;
      this.cbLocations.Location = new System.Drawing.Point(4, 28);
      this.cbLocations.Margin = new System.Windows.Forms.Padding(4);
      this.cbLocations.Name = "cbLocations";
      this.cbLocations.Size = new System.Drawing.Size(167, 24);
      this.cbLocations.TabIndex = 0;
      // 
      // pnlForm
      // 
      this.pnlForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.pnlForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.pnlForm.Controls.Add(this.btnAddLocation);
      this.pnlForm.Controls.Add(this.lbErrorMinStock);
      this.pnlForm.Controls.Add(this.lbErrorQty);
      this.pnlForm.Controls.Add(this.lbErrorLocation);
      this.pnlForm.Controls.Add(this.lbMinStock);
      this.pnlForm.Controls.Add(this.numMinStock);
      this.pnlForm.Controls.Add(this.lbQty);
      this.pnlForm.Controls.Add(this.numQty);
      this.pnlForm.Controls.Add(this.cbLocations);
      this.pnlForm.Controls.Add(this.lbLocation);
      this.pnlForm.Location = new System.Drawing.Point(4, 4);
      this.pnlForm.Margin = new System.Windows.Forms.Padding(4);
      this.pnlForm.Name = "pnlForm";
      this.pnlForm.Size = new System.Drawing.Size(187, 281);
      this.pnlForm.TabIndex = 1;
      // 
      // btnAddLocation
      // 
      this.btnAddLocation.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.btnAddLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
      this.btnAddLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnAddLocation.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnAddLocation.ForeColor = System.Drawing.Color.White;
      this.btnAddLocation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnAddLocation.Location = new System.Drawing.Point(4, 234);
      this.btnAddLocation.Name = "btnAddLocation";
      this.btnAddLocation.Size = new System.Drawing.Size(141, 27);
      this.btnAddLocation.TabIndex = 9;
      this.btnAddLocation.Text = "btnAddLocation";
      this.btnAddLocation.UseVisualStyleBackColor = false;
      // 
      // lbErrorMinStock
      // 
      this.lbErrorMinStock.AutoSize = true;
      this.lbErrorMinStock.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbErrorMinStock.ForeColor = System.Drawing.Color.Red;
      this.lbErrorMinStock.Location = new System.Drawing.Point(7, 203);
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
      this.lbErrorQty.Location = new System.Drawing.Point(7, 130);
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
      this.lbErrorLocation.Location = new System.Drawing.Point(7, 56);
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
      this.lbMinStock.Location = new System.Drawing.Point(6, 157);
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
      this.numMinStock.Location = new System.Drawing.Point(4, 176);
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
      this.lbQty.Location = new System.Drawing.Point(7, 85);
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
      this.numQty.Location = new System.Drawing.Point(4, 103);
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
      this.lbLocation.Location = new System.Drawing.Point(7, 9);
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
      this.dgvProductLocations.AllowUserToOrderColumns = true;
      dataGridViewCellStyle11.BackColor = System.Drawing.Color.LightGray;
      dataGridViewCellStyle11.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
      dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(118)))), ((int)(((byte)(185)))));
      dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
      this.dgvProductLocations.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
      this.dgvProductLocations.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.columnLocation,
            this.ColumnStock,
            this.columnMinStock});
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
      this.dgvProductLocations.Location = new System.Drawing.Point(198, 4);
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
      this.dgvProductLocations.RowHeadersWidth = 25;
      dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle15.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
      dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(118)))), ((int)(((byte)(185)))));
      dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.White;
      this.dgvProductLocations.RowsDefaultCellStyle = dataGridViewCellStyle15;
      this.dgvProductLocations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgvProductLocations.Size = new System.Drawing.Size(659, 281);
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
      // lbProductLocationsTitle
      // 
      this.lbProductLocationsTitle.AutoSize = true;
      this.lbProductLocationsTitle.BackColor = System.Drawing.Color.Transparent;
      this.lbProductLocationsTitle.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbProductLocationsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
      this.lbProductLocationsTitle.Location = new System.Drawing.Point(10, 14);
      this.lbProductLocationsTitle.Name = "lbProductLocationsTitle";
      this.lbProductLocationsTitle.Size = new System.Drawing.Size(263, 22);
      this.lbProductLocationsTitle.TabIndex = 1;
      this.lbProductLocationsTitle.Text = "lbProductLocationsTitle";
      // 
      // btnback
      // 
      this.btnback.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
      this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnback.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnback.ForeColor = System.Drawing.Color.White;
      this.btnback.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnback.Location = new System.Drawing.Point(760, 9);
      this.btnback.Name = "btnback";
      this.btnback.Size = new System.Drawing.Size(93, 27);
      this.btnback.TabIndex = 7;
      this.btnback.Text = "btnback";
      this.btnback.UseVisualStyleBackColor = false;
      // 
      // pnlTop
      // 
      this.pnlTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.pnlTop.Controls.Add(this.dgvProductLocations);
      this.pnlTop.Controls.Add(this.pnlForm);
      this.pnlTop.Location = new System.Drawing.Point(0, 44);
      this.pnlTop.Name = "pnlTop";
      this.pnlTop.Size = new System.Drawing.Size(860, 289);
      this.pnlTop.TabIndex = 20;
      // 
      // dataGridView1
      // 
      this.dataGridView1.AllowUserToAddRows = false;
      this.dataGridView1.AllowUserToDeleteRows = false;
      this.dataGridView1.AllowUserToOrderColumns = true;
      dataGridViewCellStyle16.BackColor = System.Drawing.Color.LightGray;
      dataGridViewCellStyle16.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Black;
      dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(118)))), ((int)(((byte)(185)))));
      dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.White;
      this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
      this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
      this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
      dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
      dataGridViewCellStyle17.Font = new System.Drawing.Font("Courier New", 9.75F);
      dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
      dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
      dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.White;
      dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
      dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle18.Font = new System.Drawing.Font("Courier New", 9.75F);
      dataGridViewCellStyle18.ForeColor = System.Drawing.Color.White;
      dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.Black;
      dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle18;
      this.dataGridView1.EnableHeadersVisualStyles = false;
      this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
      this.dataGridView1.Location = new System.Drawing.Point(4, 387);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.ReadOnly = true;
      dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle19.Font = new System.Drawing.Font("Courier New", 9.75F);
      dataGridViewCellStyle19.ForeColor = System.Drawing.Color.Black;
      dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.Black;
      dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
      this.dataGridView1.RowHeadersWidth = 25;
      dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle20.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle20.ForeColor = System.Drawing.Color.Black;
      dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(118)))), ((int)(((byte)(185)))));
      dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.White;
      this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle20;
      this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dataGridView1.Size = new System.Drawing.Size(853, 271);
      this.dataGridView1.TabIndex = 19;
      // 
      // dataGridViewTextBoxColumn1
      // 
      this.dataGridViewTextBoxColumn1.HeaderText = "columnProductLocationId";
      this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
      this.dataGridViewTextBoxColumn1.ReadOnly = true;
      this.dataGridViewTextBoxColumn1.Visible = false;
      // 
      // dataGridViewTextBoxColumn2
      // 
      this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.dataGridViewTextBoxColumn2.HeaderText = "columnLocation";
      this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
      this.dataGridViewTextBoxColumn2.ReadOnly = true;
      this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
      // 
      // dataGridViewTextBoxColumn3
      // 
      this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.dataGridViewTextBoxColumn3.HeaderText = "ColumnStock";
      this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
      this.dataGridViewTextBoxColumn3.ReadOnly = true;
      // 
      // dataGridViewTextBoxColumn4
      // 
      this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.dataGridViewTextBoxColumn4.HeaderText = "columnMinStock";
      this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
      this.dataGridViewTextBoxColumn4.ReadOnly = true;
      // 
      // lbProductStockMovements
      // 
      this.lbProductStockMovements.AutoSize = true;
      this.lbProductStockMovements.BackColor = System.Drawing.Color.Transparent;
      this.lbProductStockMovements.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbProductStockMovements.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
      this.lbProductStockMovements.Location = new System.Drawing.Point(10, 350);
      this.lbProductStockMovements.Name = "lbProductStockMovements";
      this.lbProductStockMovements.Size = new System.Drawing.Size(263, 22);
      this.lbProductStockMovements.TabIndex = 21;
      this.lbProductStockMovements.Text = "lbProductStockMovements";
      // 
      // InventoryProductAddToLocationUserControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.lbProductStockMovements);
      this.Controls.Add(this.dataGridView1);
      this.Controls.Add(this.pnlTop);
      this.Controls.Add(this.lbProductLocationsTitle);
      this.Controls.Add(this.btnback);
      this.Font = new System.Drawing.Font("Courier New", 9.75F);
      this.ForeColor = System.Drawing.Color.White;
      this.Margin = new System.Windows.Forms.Padding(4);
      this.Name = "InventoryProductAddToLocationUserControl";
      this.Size = new System.Drawing.Size(860, 661);
      this.pnlForm.ResumeLayout(false);
      this.pnlForm.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numMinStock)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numQty)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgvProductLocations)).EndInit();
      this.pnlTop.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

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
        private System.Windows.Forms.Label lbProductLocationsTitle;
        private System.Windows.Forms.DataGridView dgvProductLocations;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnProductLocationId;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnMinStock;
        private System.Windows.Forms.Button btnAddLocation;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Panel pnlTop;
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    private System.Windows.Forms.Label lbProductStockMovements;
  }
}
