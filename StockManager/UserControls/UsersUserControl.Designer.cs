﻿namespace StockManager.UserControls
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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.PictureBox pbSearchIcon;
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersUserControl));
      this.pnlTopBar = new System.Windows.Forms.Panel();
      this.pnlDivider = new System.Windows.Forms.Panel();
      this.lbTitle = new System.Windows.Forms.Label();
      this.pnlActions = new System.Windows.Forms.Panel();
      this.btnDeleteUser = new System.Windows.Forms.Button();
      this.btnEditUser = new System.Windows.Forms.Button();
      this.btnCreateUser = new System.Windows.Forms.Button();
      this.dgvUsers = new System.Windows.Forms.DataGridView();
      this.columnUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.columnRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.columnLastLogIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.tbSeachText = new System.Windows.Forms.TextBox();
      this.pnbSearchBox = new System.Windows.Forms.Panel();
      pbSearchIcon = new System.Windows.Forms.PictureBox();
      this.pnlTopBar.SuspendLayout();
      this.pnlActions.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
      this.pnbSearchBox.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(pbSearchIcon)).BeginInit();
      this.SuspendLayout();
      // 
      // pnlTopBar
      // 
      this.pnlTopBar.BackColor = System.Drawing.SystemColors.Control;
      this.pnlTopBar.Controls.Add(this.pnlDivider);
      this.pnlTopBar.Controls.Add(this.lbTitle);
      this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
      this.pnlTopBar.Location = new System.Drawing.Point(0, 0);
      this.pnlTopBar.Name = "pnlTopBar";
      this.pnlTopBar.Size = new System.Drawing.Size(860, 44);
      this.pnlTopBar.TabIndex = 2;
      // 
      // pnlDivider
      // 
      this.pnlDivider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
      this.pnlDivider.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.pnlDivider.Location = new System.Drawing.Point(0, 43);
      this.pnlDivider.Name = "pnlDivider";
      this.pnlDivider.Size = new System.Drawing.Size(860, 1);
      this.pnlDivider.TabIndex = 4;
      // 
      // lbTitle
      // 
      this.lbTitle.AutoSize = true;
      this.lbTitle.BackColor = System.Drawing.Color.Transparent;
      this.lbTitle.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbTitle.ForeColor = System.Drawing.Color.Black;
      this.lbTitle.Location = new System.Drawing.Point(4, 12);
      this.lbTitle.Name = "lbTitle";
      this.lbTitle.Size = new System.Drawing.Size(65, 22);
      this.lbTitle.TabIndex = 1;
      this.lbTitle.Text = "Users";
      // 
      // pnlActions
      // 
      this.pnlActions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.pnlActions.Controls.Add(this.btnDeleteUser);
      this.pnlActions.Controls.Add(this.btnEditUser);
      this.pnlActions.Controls.Add(this.btnCreateUser);
      this.pnlActions.Location = new System.Drawing.Point(557, 47);
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
      dataGridViewCellStyle26.BackColor = System.Drawing.Color.LightGray;
      dataGridViewCellStyle26.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle26.ForeColor = System.Drawing.Color.Black;
      dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(118)))), ((int)(((byte)(185)))));
      dataGridViewCellStyle26.SelectionForeColor = System.Drawing.Color.White;
      this.dgvUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle26;
      this.dgvUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dgvUsers.BackgroundColor = System.Drawing.SystemColors.Control;
      this.dgvUsers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
      dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
      dataGridViewCellStyle27.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle27.ForeColor = System.Drawing.Color.White;
      dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
      dataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.White;
      dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dgvUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle27;
      this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnUsername,
            this.columnRole,
            this.columnLastLogIn});
      dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle28.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle28.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle28.ForeColor = System.Drawing.Color.White;
      dataGridViewCellStyle28.SelectionBackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle28.SelectionForeColor = System.Drawing.Color.Black;
      dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.dgvUsers.DefaultCellStyle = dataGridViewCellStyle28;
      this.dgvUsers.EnableHeadersVisualStyles = false;
      this.dgvUsers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
      this.dgvUsers.Location = new System.Drawing.Point(8, 87);
      this.dgvUsers.Name = "dgvUsers";
      this.dgvUsers.ReadOnly = true;
      dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle29.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle29.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle29.ForeColor = System.Drawing.Color.Black;
      dataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle29.SelectionForeColor = System.Drawing.Color.Black;
      dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dgvUsers.RowHeadersDefaultCellStyle = dataGridViewCellStyle29;
      this.dgvUsers.RowHeadersWidth = 25;
      dataGridViewCellStyle30.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle30.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle30.ForeColor = System.Drawing.Color.Black;
      dataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(118)))), ((int)(((byte)(185)))));
      dataGridViewCellStyle30.SelectionForeColor = System.Drawing.Color.White;
      this.dgvUsers.RowsDefaultCellStyle = dataGridViewCellStyle30;
      this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgvUsers.Size = new System.Drawing.Size(845, 325);
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
      this.pnbSearchBox.Location = new System.Drawing.Point(3, 48);
      this.pnbSearchBox.Name = "pnbSearchBox";
      this.pnbSearchBox.Size = new System.Drawing.Size(324, 33);
      this.pnbSearchBox.TabIndex = 9;
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
      // 
      // UsersUserControl
      // 
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
      this.BackColor = System.Drawing.SystemColors.Control;
      this.Controls.Add(this.pnbSearchBox);
      this.Controls.Add(this.pnlActions);
      this.Controls.Add(this.dgvUsers);
      this.Controls.Add(this.pnlTopBar);
      this.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ForeColor = System.Drawing.Color.White;
      this.Margin = new System.Windows.Forms.Padding(4);
      this.Name = "UsersUserControl";
      this.Size = new System.Drawing.Size(860, 420);
      this.pnlTopBar.ResumeLayout(false);
      this.pnlTopBar.PerformLayout();
      this.pnlActions.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
      this.pnbSearchBox.ResumeLayout(false);
      this.pnbSearchBox.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(pbSearchIcon)).EndInit();
      this.ResumeLayout(false);

    }

        #endregion

        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Panel pnlActions;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button btnCreateUser;
    private System.Windows.Forms.DataGridView dgvUsers;
    private System.Windows.Forms.DataGridViewTextBoxColumn columnUsername;
    private System.Windows.Forms.DataGridViewTextBoxColumn columnRole;
    private System.Windows.Forms.DataGridViewTextBoxColumn columnLastLogIn;
    private System.Windows.Forms.Button btnEditUser;
    private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Panel pnlDivider;
        private System.Windows.Forms.TextBox tbSeachText;
        private System.Windows.Forms.Panel pnbSearchBox;
    }
}
