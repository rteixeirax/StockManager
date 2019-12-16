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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersUserControl));
      this.panelTopBar = new System.Windows.Forms.Panel();
      this.panelSearch = new System.Windows.Forms.Panel();
      this.buttonSearch = new System.Windows.Forms.Button();
      this.textBoxSearch = new System.Windows.Forms.TextBox();
      this.panelTitle = new System.Windows.Forms.Panel();
      this.labelTitle = new System.Windows.Forms.Label();
      this.textBoxFirstName = new System.Windows.Forms.TextBox();
      this.labelFirstName = new System.Windows.Forms.Label();
      this.labelLastName = new System.Windows.Forms.Label();
      this.textBoxLastName = new System.Windows.Forms.TextBox();
      this.panel1 = new System.Windows.Forms.Panel();
      this.label5 = new System.Windows.Forms.Label();
      this.textBoxPassword = new System.Windows.Forms.TextBox();
      this.labelPassword = new System.Windows.Forms.Label();
      this.labelRole = new System.Windows.Forms.Label();
      this.comboBoxRoles = new System.Windows.Forms.ComboBox();
      this.buttonCreateUser = new System.Windows.Forms.Button();
      this.panelTopBar.SuspendLayout();
      this.panelSearch.SuspendLayout();
      this.panelTitle.SuspendLayout();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // panelTopBar
      // 
      this.panelTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
      this.panelTopBar.Controls.Add(this.panelSearch);
      this.panelTopBar.Controls.Add(this.panelTitle);
      this.panelTopBar.Dock = System.Windows.Forms.DockStyle.Top;
      this.panelTopBar.Location = new System.Drawing.Point(0, 0);
      this.panelTopBar.Name = "panelTopBar";
      this.panelTopBar.Size = new System.Drawing.Size(860, 43);
      this.panelTopBar.TabIndex = 2;
      // 
      // panelSearch
      // 
      this.panelSearch.Controls.Add(this.buttonSearch);
      this.panelSearch.Controls.Add(this.textBoxSearch);
      this.panelSearch.Dock = System.Windows.Forms.DockStyle.Right;
      this.panelSearch.Location = new System.Drawing.Point(620, 0);
      this.panelSearch.Name = "panelSearch";
      this.panelSearch.Size = new System.Drawing.Size(240, 43);
      this.panelSearch.TabIndex = 3;
      // 
      // buttonSearch
      // 
      this.buttonSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
      this.buttonSearch.FlatAppearance.BorderSize = 0;
      this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.buttonSearch.Image = ((System.Drawing.Image)(resources.GetObject("buttonSearch.Image")));
      this.buttonSearch.Location = new System.Drawing.Point(197, 11);
      this.buttonSearch.Name = "buttonSearch";
      this.buttonSearch.Size = new System.Drawing.Size(26, 21);
      this.buttonSearch.TabIndex = 2;
      this.buttonSearch.UseVisualStyleBackColor = true;
      // 
      // textBoxSearch
      // 
      this.textBoxSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
      this.textBoxSearch.ForeColor = System.Drawing.Color.White;
      this.textBoxSearch.Location = new System.Drawing.Point(15, 11);
      this.textBoxSearch.Name = "textBoxSearch";
      this.textBoxSearch.Size = new System.Drawing.Size(179, 22);
      this.textBoxSearch.TabIndex = 0;
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
      this.labelTitle.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelTitle.Location = new System.Drawing.Point(11, 11);
      this.labelTitle.Name = "labelTitle";
      this.labelTitle.Size = new System.Drawing.Size(178, 18);
      this.labelTitle.TabIndex = 1;
      this.labelTitle.Text = "Application users";
      // 
      // textBoxFirstName
      // 
      this.textBoxFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
      this.textBoxFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.textBoxFirstName.ForeColor = System.Drawing.Color.White;
      this.textBoxFirstName.Location = new System.Drawing.Point(99, 63);
      this.textBoxFirstName.Name = "textBoxFirstName";
      this.textBoxFirstName.Size = new System.Drawing.Size(182, 22);
      this.textBoxFirstName.TabIndex = 3;
      // 
      // labelFirstName
      // 
      this.labelFirstName.AutoSize = true;
      this.labelFirstName.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(232)))), ((int)(((byte)(166)))));
      this.labelFirstName.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.labelFirstName.Location = new System.Drawing.Point(5, 65);
      this.labelFirstName.Name = "labelFirstName";
      this.labelFirstName.Size = new System.Drawing.Size(88, 16);
      this.labelFirstName.TabIndex = 2;
      this.labelFirstName.Text = "First name";
      // 
      // labelLastName
      // 
      this.labelLastName.AutoSize = true;
      this.labelLastName.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(232)))), ((int)(((byte)(166)))));
      this.labelLastName.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.labelLastName.Location = new System.Drawing.Point(13, 104);
      this.labelLastName.Name = "labelLastName";
      this.labelLastName.Size = new System.Drawing.Size(80, 16);
      this.labelLastName.TabIndex = 4;
      this.labelLastName.Text = "Last name";
      // 
      // textBoxLastName
      // 
      this.textBoxLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
      this.textBoxLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.textBoxLastName.ForeColor = System.Drawing.Color.White;
      this.textBoxLastName.Location = new System.Drawing.Point(99, 102);
      this.textBoxLastName.Name = "textBoxLastName";
      this.textBoxLastName.Size = new System.Drawing.Size(182, 22);
      this.textBoxLastName.TabIndex = 5;
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.label5);
      this.panel1.Controls.Add(this.textBoxPassword);
      this.panel1.Controls.Add(this.labelPassword);
      this.panel1.Controls.Add(this.labelRole);
      this.panel1.Controls.Add(this.textBoxFirstName);
      this.panel1.Controls.Add(this.comboBoxRoles);
      this.panel1.Controls.Add(this.labelLastName);
      this.panel1.Controls.Add(this.labelFirstName);
      this.panel1.Controls.Add(this.textBoxLastName);
      this.panel1.Location = new System.Drawing.Point(14, 112);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(314, 242);
      this.panel1.TabIndex = 6;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.Location = new System.Drawing.Point(5, 16);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(98, 18);
      this.label5.TabIndex = 11;
      this.label5.Text = "User info";
      // 
      // textBoxPassword
      // 
      this.textBoxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
      this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.textBoxPassword.ForeColor = System.Drawing.Color.White;
      this.textBoxPassword.Location = new System.Drawing.Point(99, 141);
      this.textBoxPassword.Name = "textBoxPassword";
      this.textBoxPassword.PasswordChar = '*';
      this.textBoxPassword.Size = new System.Drawing.Size(182, 22);
      this.textBoxPassword.TabIndex = 10;
      this.textBoxPassword.UseSystemPasswordChar = true;
      // 
      // labelPassword
      // 
      this.labelPassword.AutoSize = true;
      this.labelPassword.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(232)))), ((int)(((byte)(166)))));
      this.labelPassword.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.labelPassword.Location = new System.Drawing.Point(21, 143);
      this.labelPassword.Name = "labelPassword";
      this.labelPassword.Size = new System.Drawing.Size(72, 16);
      this.labelPassword.TabIndex = 9;
      this.labelPassword.Text = "Password";
      // 
      // labelRole
      // 
      this.labelRole.AutoSize = true;
      this.labelRole.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(232)))), ((int)(((byte)(166)))));
      this.labelRole.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.labelRole.Location = new System.Drawing.Point(53, 186);
      this.labelRole.Name = "labelRole";
      this.labelRole.Size = new System.Drawing.Size(40, 16);
      this.labelRole.TabIndex = 8;
      this.labelRole.Text = "Role";
      // 
      // comboBoxRoles
      // 
      this.comboBoxRoles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
      this.comboBoxRoles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.comboBoxRoles.ForeColor = System.Drawing.Color.White;
      this.comboBoxRoles.FormattingEnabled = true;
      this.comboBoxRoles.Items.AddRange(new object[] {
            "Admin",
            "User"});
      this.comboBoxRoles.Location = new System.Drawing.Point(99, 183);
      this.comboBoxRoles.Name = "comboBoxRoles";
      this.comboBoxRoles.Size = new System.Drawing.Size(182, 24);
      this.comboBoxRoles.TabIndex = 7;
      // 
      // buttonCreateUser
      // 
      this.buttonCreateUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(232)))), ((int)(((byte)(166)))));
      this.buttonCreateUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.buttonCreateUser.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.buttonCreateUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
      this.buttonCreateUser.Location = new System.Drawing.Point(14, 58);
      this.buttonCreateUser.Name = "buttonCreateUser";
      this.buttonCreateUser.Size = new System.Drawing.Size(136, 32);
      this.buttonCreateUser.TabIndex = 7;
      this.buttonCreateUser.Text = "Add new";
      this.buttonCreateUser.UseVisualStyleBackColor = false;
      // 
      // UsersUserControl
      // 
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
      this.Controls.Add(this.buttonCreateUser);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.panelTopBar);
      this.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ForeColor = System.Drawing.Color.White;
      this.Margin = new System.Windows.Forms.Padding(4);
      this.Name = "UsersUserControl";
      this.Size = new System.Drawing.Size(860, 420);
      this.panelTopBar.ResumeLayout(false);
      this.panelSearch.ResumeLayout(false);
      this.panelSearch.PerformLayout();
      this.panelTitle.ResumeLayout(false);
      this.panelTitle.PerformLayout();
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ResumeLayout(false);

    }

        #endregion

        private System.Windows.Forms.Panel panelTopBar;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.ComboBox comboBoxRoles;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonCreateUser;
    }
}
