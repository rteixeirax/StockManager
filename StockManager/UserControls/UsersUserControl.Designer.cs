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
      System.Windows.Forms.PictureBox pbSearchIcon;
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersUserControl));
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
      this.pnlActions = new System.Windows.Forms.Panel();
      this.btnDeleteUser = new System.Windows.Forms.Button();
      this.btnEditUser = new System.Windows.Forms.Button();
      this.btnCreateUser = new System.Windows.Forms.Button();
      this.dgvUsers = new System.Windows.Forms.DataGridView();
      this.columnUserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.columnUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.columnRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.columnLastLogIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ColumnCreatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.tbSeachText = new System.Windows.Forms.TextBox();
      this.pnbSearchBox = new System.Windows.Forms.Panel();
      pbSearchIcon = new System.Windows.Forms.PictureBox();
      ((System.ComponentModel.ISupportInitialize)(pbSearchIcon)).BeginInit();
      this.pnlActions.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
      this.pnbSearchBox.SuspendLayout();
      this.SuspendLayout();
      // 
      // pbSearchIcon
      // 
      pbSearchIcon.BackColor = System.Drawing.Color.LightGray;
      pbSearchIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
      this.pnlActions.Controls.Add(this.btnDeleteUser);
      this.pnlActions.Controls.Add(this.btnEditUser);
      this.pnlActions.Controls.Add(this.btnCreateUser);
      this.pnlActions.Location = new System.Drawing.Point(557, 6);
      this.pnlActions.Name = "pnlActions";
      this.pnlActions.Size = new System.Drawing.Size(300, 34);
      this.pnlActions.TabIndex = 3;
      // 
      // btnDeleteUser
      // 
      this.btnDeleteUser.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.btnDeleteUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
      this.btnDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnDeleteUser.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnDeleteUser.ForeColor = System.Drawing.Color.White;
      this.btnDeleteUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnDeleteUser.Location = new System.Drawing.Point(203, 4);
      this.btnDeleteUser.Name = "btnDeleteUser";
      this.btnDeleteUser.Size = new System.Drawing.Size(93, 27);
      this.btnDeleteUser.TabIndex = 9;
      this.btnDeleteUser.Text = "Delete";
      this.btnDeleteUser.UseVisualStyleBackColor = false;
      this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
      // 
      // btnEditUser
      // 
      this.btnEditUser.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.btnEditUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(173)))), ((int)(((byte)(78)))));
      this.btnEditUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnEditUser.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnEditUser.ForeColor = System.Drawing.Color.White;
      this.btnEditUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnEditUser.Location = new System.Drawing.Point(104, 3);
      this.btnEditUser.Name = "btnEditUser";
      this.btnEditUser.Size = new System.Drawing.Size(93, 27);
      this.btnEditUser.TabIndex = 8;
      this.btnEditUser.Text = "Edit";
      this.btnEditUser.UseVisualStyleBackColor = false;
      this.btnEditUser.Click += new System.EventHandler(this.btnEditUser_Click);
      // 
      // btnCreateUser
      // 
      this.btnCreateUser.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.btnCreateUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
      this.btnCreateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnCreateUser.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnCreateUser.ForeColor = System.Drawing.Color.White;
      this.btnCreateUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnCreateUser.Location = new System.Drawing.Point(5, 3);
      this.btnCreateUser.Name = "btnCreateUser";
      this.btnCreateUser.Size = new System.Drawing.Size(93, 27);
      this.btnCreateUser.TabIndex = 7;
      this.btnCreateUser.Text = "Add new";
      this.btnCreateUser.UseVisualStyleBackColor = false;
      this.btnCreateUser.Click += new System.EventHandler(this.btnCreateUser_Click);
      // 
      // dgvUsers
      // 
      this.dgvUsers.AllowUserToAddRows = false;
      this.dgvUsers.AllowUserToDeleteRows = false;
      this.dgvUsers.AllowUserToOrderColumns = true;
      dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
      dataGridViewCellStyle1.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
      dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(118)))), ((int)(((byte)(185)))));
      dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
      this.dgvUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
      this.dgvUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dgvUsers.BackgroundColor = System.Drawing.SystemColors.Control;
      this.dgvUsers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
      dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
      dataGridViewCellStyle2.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
      dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
      dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
      dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dgvUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
      this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnUserId,
            this.columnUsername,
            this.columnRole,
            this.columnLastLogIn,
            this.ColumnCreatedAt});
      dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle3.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
      dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
      dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.dgvUsers.DefaultCellStyle = dataGridViewCellStyle3;
      this.dgvUsers.EnableHeadersVisualStyles = false;
      this.dgvUsers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
      this.dgvUsers.Location = new System.Drawing.Point(8, 46);
      this.dgvUsers.Name = "dgvUsers";
      this.dgvUsers.ReadOnly = true;
      dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle4.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
      dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
      dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dgvUsers.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
      this.dgvUsers.RowHeadersWidth = 25;
      dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle5.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
      dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(118)))), ((int)(((byte)(185)))));
      dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
      this.dgvUsers.RowsDefaultCellStyle = dataGridViewCellStyle5;
      this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgvUsers.Size = new System.Drawing.Size(845, 371);
      this.dgvUsers.TabIndex = 0;
      // 
      // columnUserId
      // 
      this.columnUserId.HeaderText = "UserId";
      this.columnUserId.Name = "columnUserId";
      this.columnUserId.ReadOnly = true;
      this.columnUserId.Visible = false;
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
      this.tbSeachText.Size = new System.Drawing.Size(291, 22);
      this.tbSeachText.TabIndex = 4;
      // 
      // pnbSearchBox
      // 
      this.pnbSearchBox.Controls.Add(pbSearchIcon);
      this.pnbSearchBox.Controls.Add(this.tbSeachText);
      this.pnbSearchBox.Location = new System.Drawing.Point(3, 7);
      this.pnbSearchBox.Name = "pnbSearchBox";
      this.pnbSearchBox.Size = new System.Drawing.Size(324, 33);
      this.pnbSearchBox.TabIndex = 9;
      // 
      // UsersUserControl
      // 
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
      this.BackColor = System.Drawing.SystemColors.Control;
      this.Controls.Add(this.pnbSearchBox);
      this.Controls.Add(this.pnlActions);
      this.Controls.Add(this.dgvUsers);
      this.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ForeColor = System.Drawing.Color.White;
      this.Margin = new System.Windows.Forms.Padding(4);
      this.Name = "UsersUserControl";
      this.Size = new System.Drawing.Size(860, 420);
      ((System.ComponentModel.ISupportInitialize)(pbSearchIcon)).EndInit();
      this.pnlActions.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
      this.pnbSearchBox.ResumeLayout(false);
      this.pnbSearchBox.PerformLayout();
      this.ResumeLayout(false);

    }

        #endregion
        private System.Windows.Forms.Panel pnlActions;
        private System.Windows.Forms.Button btnCreateUser;
    private System.Windows.Forms.DataGridView dgvUsers;
    private System.Windows.Forms.Button btnEditUser;
    private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.TextBox tbSeachText;
        private System.Windows.Forms.Panel pnbSearchBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnUserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnLastLogIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCreatedAt;
    }
}
