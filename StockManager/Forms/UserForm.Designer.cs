namespace StockManager.Forms
{
  partial class UserForm
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

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
      this.pnlUserFormBody = new System.Windows.Forms.Panel();
      this.btnSave = new System.Windows.Forms.Button();
      this.lbTitle = new System.Windows.Forms.Label();
      this.tbPassword = new System.Windows.Forms.TextBox();
      this.lbPassword = new System.Windows.Forms.Label();
      this.lbRole = new System.Windows.Forms.Label();
      this.tbUsername = new System.Windows.Forms.TextBox();
      this.cbRoles = new System.Windows.Forms.ComboBox();
      this.lbFirstName = new System.Windows.Forms.Label();
      this.lbErrorFirstName = new System.Windows.Forms.Label();
      this.lbErrorPassword = new System.Windows.Forms.Label();
      this.lbErrorRole = new System.Windows.Forms.Label();
      this.pnlUserFormBody.SuspendLayout();
      this.SuspendLayout();
      // 
      // pnlUserFormBody
      // 
      this.pnlUserFormBody.Controls.Add(this.lbErrorRole);
      this.pnlUserFormBody.Controls.Add(this.lbErrorPassword);
      this.pnlUserFormBody.Controls.Add(this.lbErrorFirstName);
      this.pnlUserFormBody.Controls.Add(this.btnSave);
      this.pnlUserFormBody.Controls.Add(this.lbTitle);
      this.pnlUserFormBody.Controls.Add(this.tbPassword);
      this.pnlUserFormBody.Controls.Add(this.lbPassword);
      this.pnlUserFormBody.Controls.Add(this.lbRole);
      this.pnlUserFormBody.Controls.Add(this.tbUsername);
      this.pnlUserFormBody.Controls.Add(this.cbRoles);
      this.pnlUserFormBody.Controls.Add(this.lbFirstName);
      this.pnlUserFormBody.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pnlUserFormBody.Location = new System.Drawing.Point(0, 0);
      this.pnlUserFormBody.Name = "pnlUserFormBody";
      this.pnlUserFormBody.Size = new System.Drawing.Size(416, 314);
      this.pnlUserFormBody.TabIndex = 7;
      // 
      // btnSave
      // 
      this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(232)))), ((int)(((byte)(166)))));
      this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.btnSave.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
      this.btnSave.Location = new System.Drawing.Point(234, 255);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(136, 32);
      this.btnSave.TabIndex = 12;
      this.btnSave.Text = "Save";
      this.btnSave.UseVisualStyleBackColor = false;
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // lbTitle
      // 
      this.lbTitle.AutoSize = true;
      this.lbTitle.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbTitle.Location = new System.Drawing.Point(40, 22);
      this.lbTitle.Name = "lbTitle";
      this.lbTitle.Size = new System.Drawing.Size(98, 18);
      this.lbTitle.TabIndex = 11;
      this.lbTitle.Text = "User data";
      // 
      // tbPassword
      // 
      this.tbPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
      this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.tbPassword.ForeColor = System.Drawing.Color.White;
      this.tbPassword.Location = new System.Drawing.Point(118, 122);
      this.tbPassword.Name = "tbPassword";
      this.tbPassword.PasswordChar = '*';
      this.tbPassword.Size = new System.Drawing.Size(252, 22);
      this.tbPassword.TabIndex = 10;
      this.tbPassword.UseSystemPasswordChar = true;
      // 
      // lbPassword
      // 
      this.lbPassword.AutoSize = true;
      this.lbPassword.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(232)))), ((int)(((byte)(166)))));
      this.lbPassword.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.lbPassword.Location = new System.Drawing.Point(40, 124);
      this.lbPassword.Name = "lbPassword";
      this.lbPassword.Size = new System.Drawing.Size(72, 16);
      this.lbPassword.TabIndex = 9;
      this.lbPassword.Text = "Password";
      // 
      // lbRole
      // 
      this.lbRole.AutoSize = true;
      this.lbRole.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(232)))), ((int)(((byte)(166)))));
      this.lbRole.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.lbRole.Location = new System.Drawing.Point(72, 180);
      this.lbRole.Name = "lbRole";
      this.lbRole.Size = new System.Drawing.Size(40, 16);
      this.lbRole.TabIndex = 8;
      this.lbRole.Text = "Role";
      // 
      // tbUsername
      // 
      this.tbUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
      this.tbUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.tbUsername.ForeColor = System.Drawing.Color.White;
      this.tbUsername.Location = new System.Drawing.Point(118, 68);
      this.tbUsername.Name = "tbUsername";
      this.tbUsername.Size = new System.Drawing.Size(252, 22);
      this.tbUsername.TabIndex = 3;
      // 
      // cbRoles
      // 
      this.cbRoles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
      this.cbRoles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.cbRoles.ForeColor = System.Drawing.Color.White;
      this.cbRoles.FormattingEnabled = true;
      this.cbRoles.Items.AddRange(new object[] {
            "Admin",
            "User"});
      this.cbRoles.Location = new System.Drawing.Point(118, 177);
      this.cbRoles.Name = "cbRoles";
      this.cbRoles.Size = new System.Drawing.Size(252, 24);
      this.cbRoles.TabIndex = 7;
      // 
      // lbFirstName
      // 
      this.lbFirstName.AutoSize = true;
      this.lbFirstName.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(232)))), ((int)(((byte)(166)))));
      this.lbFirstName.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.lbFirstName.Location = new System.Drawing.Point(40, 70);
      this.lbFirstName.Name = "lbFirstName";
      this.lbFirstName.Size = new System.Drawing.Size(72, 16);
      this.lbFirstName.TabIndex = 2;
      this.lbFirstName.Text = "Username";
      // 
      // lbErrorFirstName
      // 
      this.lbErrorFirstName.AutoSize = true;
      this.lbErrorFirstName.ForeColor = System.Drawing.Color.Red;
      this.lbErrorFirstName.Location = new System.Drawing.Point(121, 93);
      this.lbErrorFirstName.Name = "lbErrorFirstName";
      this.lbErrorFirstName.Size = new System.Drawing.Size(184, 16);
      this.lbErrorFirstName.TabIndex = 14;
      this.lbErrorFirstName.Text = "This field is required";
      // 
      // lbErrorPassword
      // 
      this.lbErrorPassword.AutoSize = true;
      this.lbErrorPassword.ForeColor = System.Drawing.Color.Red;
      this.lbErrorPassword.Location = new System.Drawing.Point(121, 147);
      this.lbErrorPassword.Name = "lbErrorPassword";
      this.lbErrorPassword.Size = new System.Drawing.Size(184, 16);
      this.lbErrorPassword.TabIndex = 15;
      this.lbErrorPassword.Text = "This field is required";
      // 
      // lbErrorRole
      // 
      this.lbErrorRole.AutoSize = true;
      this.lbErrorRole.ForeColor = System.Drawing.Color.Red;
      this.lbErrorRole.Location = new System.Drawing.Point(121, 204);
      this.lbErrorRole.Name = "lbErrorRole";
      this.lbErrorRole.Size = new System.Drawing.Size(184, 16);
      this.lbErrorRole.TabIndex = 16;
      this.lbErrorRole.Text = "This field is required";
      // 
      // UserForm
      // 
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
      this.ClientSize = new System.Drawing.Size(416, 314);
      this.Controls.Add(this.pnlUserFormBody);
      this.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ForeColor = System.Drawing.Color.White;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Margin = new System.Windows.Forms.Padding(4);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "UserForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Create new user";
      this.pnlUserFormBody.ResumeLayout(false);
      this.pnlUserFormBody.PerformLayout();
      this.ResumeLayout(false);

    }

        #endregion

        private System.Windows.Forms.Panel pnlUserFormBody;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbRole;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.ComboBox cbRoles;
        private System.Windows.Forms.Label lbFirstName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lbErrorRole;
        private System.Windows.Forms.Label lbErrorPassword;
        private System.Windows.Forms.Label lbErrorFirstName;
    }
}