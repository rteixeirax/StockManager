namespace StockManager.UserControls
{
  partial class UsersUserControl
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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
      this.panelTopBar = new System.Windows.Forms.Panel();
      this.panelActions = new System.Windows.Forms.Panel();
      this.btnDeleteUser = new System.Windows.Forms.Button();
      this.btnEditUser = new System.Windows.Forms.Button();
      this.btnCreateUser = new System.Windows.Forms.Button();
      this.panelTitle = new System.Windows.Forms.Panel();
      this.labelTitle = new System.Windows.Forms.Label();
      this.dgvUsers = new System.Windows.Forms.DataGridView();
      this.columnUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.columnRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.columnLastLogIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.panelTopBar.SuspendLayout();
      this.panelActions.SuspendLayout();
      this.panelTitle.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
      this.SuspendLayout();
      // 
      // panelTopBar
      // 
      this.panelTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
      this.panelTopBar.Controls.Add(this.panelActions);
      this.panelTopBar.Controls.Add(this.panelTitle);
      this.panelTopBar.Dock = System.Windows.Forms.DockStyle.Top;
      this.panelTopBar.Location = new System.Drawing.Point(0, 0);
      this.panelTopBar.Name = "panelTopBar";
      this.panelTopBar.Size = new System.Drawing.Size(860, 43);
      this.panelTopBar.TabIndex = 2;
      // 
      // panelActions
      // 
      this.panelActions.Controls.Add(this.btnDeleteUser);
      this.panelActions.Controls.Add(this.btnEditUser);
      this.panelActions.Controls.Add(this.btnCreateUser);
      this.panelActions.Dock = System.Windows.Forms.DockStyle.Right;
      this.panelActions.Location = new System.Drawing.Point(545, 0);
      this.panelActions.Name = "panelActions";
      this.panelActions.Size = new System.Drawing.Size(315, 43);
      this.panelActions.TabIndex = 3;
      // 
      // btnDeleteUser
      // 
      this.btnDeleteUser.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.btnDeleteUser.BackColor = System.Drawing.Color.Firebrick;
      this.btnDeleteUser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
      this.btnDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnDeleteUser.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnDeleteUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
      this.btnDeleteUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnDeleteUser.Location = new System.Drawing.Point(214, 7);
      this.btnDeleteUser.Name = "btnDeleteUser";
      this.btnDeleteUser.Size = new System.Drawing.Size(93, 27);
      this.btnDeleteUser.TabIndex = 9;
      this.btnDeleteUser.Text = "Delete";
      this.btnDeleteUser.UseVisualStyleBackColor = false;
      // 
      // btnEditUser
      // 
      this.btnEditUser.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.btnEditUser.BackColor = System.Drawing.Color.Goldenrod;
      this.btnEditUser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
      this.btnEditUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnEditUser.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnEditUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
      this.btnEditUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnEditUser.Location = new System.Drawing.Point(115, 7);
      this.btnEditUser.Name = "btnEditUser";
      this.btnEditUser.Size = new System.Drawing.Size(93, 27);
      this.btnEditUser.TabIndex = 8;
      this.btnEditUser.Text = "Edit";
      this.btnEditUser.UseVisualStyleBackColor = false;
      // 
      // btnCreateUser
      // 
      this.btnCreateUser.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.btnCreateUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(232)))), ((int)(((byte)(166)))));
      this.btnCreateUser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
      this.btnCreateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnCreateUser.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnCreateUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
      this.btnCreateUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnCreateUser.Location = new System.Drawing.Point(16, 7);
      this.btnCreateUser.Name = "btnCreateUser";
      this.btnCreateUser.Size = new System.Drawing.Size(93, 27);
      this.btnCreateUser.TabIndex = 7;
      this.btnCreateUser.Text = "Add new";
      this.btnCreateUser.UseVisualStyleBackColor = false;
      this.btnCreateUser.Click += new System.EventHandler(this.btnCreateUser_Click);
      // 
      // panelTitle
      // 
      this.panelTitle.Controls.Add(this.labelTitle);
      this.panelTitle.Dock = System.Windows.Forms.DockStyle.Left;
      this.panelTitle.Location = new System.Drawing.Point(0, 0);
      this.panelTitle.Name = "panelTitle";
      this.panelTitle.Size = new System.Drawing.Size(217, 43);
      this.panelTitle.TabIndex = 1;
      // 
      // labelTitle
      // 
      this.labelTitle.AutoSize = true;
      this.labelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
      this.labelTitle.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelTitle.ForeColor = System.Drawing.Color.White;
      this.labelTitle.Location = new System.Drawing.Point(11, 11);
      this.labelTitle.Name = "labelTitle";
      this.labelTitle.Size = new System.Drawing.Size(178, 18);
      this.labelTitle.TabIndex = 1;
      this.labelTitle.Text = "Application users";
      // 
      // dgvUsers
      // 
      this.dgvUsers.AllowUserToAddRows = false;
      this.dgvUsers.AllowUserToDeleteRows = false;
      this.dgvUsers.AllowUserToOrderColumns = true;
      dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
      dataGridViewCellStyle1.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
      dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(232)))), ((int)(((byte)(166)))));
      dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
      this.dgvUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
      this.dgvUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dgvUsers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
      this.dgvUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.dgvUsers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
      dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
      dataGridViewCellStyle2.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
      dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
      dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
      dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dgvUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
      this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnUsername,
            this.columnRole,
            this.columnLastLogIn});
      dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle3.BackColor = System.Drawing.Color.DimGray;
      dataGridViewCellStyle3.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
      dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DimGray;
      dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
      dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.dgvUsers.DefaultCellStyle = dataGridViewCellStyle3;
      this.dgvUsers.EnableHeadersVisualStyles = false;
      this.dgvUsers.GridColor = System.Drawing.Color.DarkGray;
      this.dgvUsers.Location = new System.Drawing.Point(0, 49);
      this.dgvUsers.Name = "dgvUsers";
      this.dgvUsers.ReadOnly = true;
      dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
      dataGridViewCellStyle4.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
      dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
      dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
      dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dgvUsers.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
      dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
      dataGridViewCellStyle5.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
      dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(232)))), ((int)(((byte)(166)))));
      dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
      this.dgvUsers.RowsDefaultCellStyle = dataGridViewCellStyle5;
      this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgvUsers.Size = new System.Drawing.Size(860, 371);
      this.dgvUsers.TabIndex = 0;
      // 
      // columnUsername
      // 
      this.columnUsername.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.columnUsername.HeaderText = "Username";
      this.columnUsername.Name = "columnUsername";
      this.columnUsername.ReadOnly = true;
      this.columnUsername.Resizable = System.Windows.Forms.DataGridViewTriState.True;
      // 
      // columnRole
      // 
      this.columnRole.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.columnRole.HeaderText = "Role";
      this.columnRole.Name = "columnRole";
      this.columnRole.ReadOnly = true;
      // 
      // columnLastLogIn
      // 
      this.columnLastLogIn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.columnLastLogIn.HeaderText = "Last login";
      this.columnLastLogIn.Name = "columnLastLogIn";
      this.columnLastLogIn.ReadOnly = true;
      // 
      // UsersUserControl
      // 
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
      this.Controls.Add(this.dgvUsers);
      this.Controls.Add(this.panelTopBar);
      this.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ForeColor = System.Drawing.Color.White;
      this.Margin = new System.Windows.Forms.Padding(4);
      this.Name = "UsersUserControl";
      this.Size = new System.Drawing.Size(860, 420);
      this.panelTopBar.ResumeLayout(false);
      this.panelActions.ResumeLayout(false);
      this.panelTitle.ResumeLayout(false);
      this.panelTitle.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
      this.ResumeLayout(false);

    }

        #endregion

        private System.Windows.Forms.Panel panelTopBar;
        private System.Windows.Forms.Panel panelActions;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button btnCreateUser;
    private System.Windows.Forms.DataGridView dgvUsers;
    private System.Windows.Forms.DataGridViewTextBoxColumn columnUsername;
    private System.Windows.Forms.DataGridViewTextBoxColumn columnRole;
    private System.Windows.Forms.DataGridViewTextBoxColumn columnLastLogIn;
    private System.Windows.Forms.Button btnEditUser;
    private System.Windows.Forms.Button btnDeleteUser;
  }
}
