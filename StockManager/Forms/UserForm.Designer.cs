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
      this.pnlUserFormBody = new System.Windows.Forms.Panel();
      this.btnCancel = new System.Windows.Forms.Button();
      this.btnSave = new System.Windows.Forms.Button();
      this.lbTitle = new System.Windows.Forms.Label();
      this.tbPassword = new System.Windows.Forms.TextBox();
      this.lbPassword = new System.Windows.Forms.Label();
      this.lbRole = new System.Windows.Forms.Label();
      this.tbFirstName = new System.Windows.Forms.TextBox();
      this.cbRoles = new System.Windows.Forms.ComboBox();
      this.lbLastName = new System.Windows.Forms.Label();
      this.lbFirstName = new System.Windows.Forms.Label();
      this.tbLastName = new System.Windows.Forms.TextBox();
      this.pnlUserFormBody.SuspendLayout();
      this.SuspendLayout();
      // 
      // pnlUserFormBody
      // 
      this.pnlUserFormBody.Controls.Add(this.btnCancel);
      this.pnlUserFormBody.Controls.Add(this.btnSave);
      this.pnlUserFormBody.Controls.Add(this.lbTitle);
      this.pnlUserFormBody.Controls.Add(this.tbPassword);
      this.pnlUserFormBody.Controls.Add(this.lbPassword);
      this.pnlUserFormBody.Controls.Add(this.lbRole);
      this.pnlUserFormBody.Controls.Add(this.tbFirstName);
      this.pnlUserFormBody.Controls.Add(this.cbRoles);
      this.pnlUserFormBody.Controls.Add(this.lbLastName);
      this.pnlUserFormBody.Controls.Add(this.lbFirstName);
      this.pnlUserFormBody.Controls.Add(this.tbLastName);
      this.pnlUserFormBody.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pnlUserFormBody.Location = new System.Drawing.Point(0, 0);
      this.pnlUserFormBody.Name = "pnlUserFormBody";
      this.pnlUserFormBody.Size = new System.Drawing.Size(384, 305);
      this.pnlUserFormBody.TabIndex = 7;
      // 
      // btnCancel
      // 
      this.btnCancel.BackColor = System.Drawing.Color.IndianRed;
      this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.btnCancel.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
      this.btnCancel.Location = new System.Drawing.Point(94, 261);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(136, 32);
      this.btnCancel.TabIndex = 13;
      this.btnCancel.Text = "Cancel";
      this.btnCancel.UseVisualStyleBackColor = false;
      // 
      // btnSave
      // 
      this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(232)))), ((int)(((byte)(166)))));
      this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.btnSave.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
      this.btnSave.Location = new System.Drawing.Point(236, 261);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(136, 32);
      this.btnSave.TabIndex = 12;
      this.btnSave.Text = "Save";
      this.btnSave.UseVisualStyleBackColor = false;
      // 
      // lbTitle
      // 
      this.lbTitle.AutoSize = true;
      this.lbTitle.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbTitle.Location = new System.Drawing.Point(24, 24);
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
      this.tbPassword.Location = new System.Drawing.Point(118, 146);
      this.tbPassword.Name = "tbPassword";
      this.tbPassword.PasswordChar = '*';
      this.tbPassword.Size = new System.Drawing.Size(182, 22);
      this.tbPassword.TabIndex = 10;
      this.tbPassword.UseSystemPasswordChar = true;
      // 
      // lbPassword
      // 
      this.lbPassword.AutoSize = true;
      this.lbPassword.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(232)))), ((int)(((byte)(166)))));
      this.lbPassword.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.lbPassword.Location = new System.Drawing.Point(40, 148);
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
      this.lbRole.Location = new System.Drawing.Point(72, 191);
      this.lbRole.Name = "lbRole";
      this.lbRole.Size = new System.Drawing.Size(40, 16);
      this.lbRole.TabIndex = 8;
      this.lbRole.Text = "Role";
      // 
      // tbFirstName
      // 
      this.tbFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
      this.tbFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.tbFirstName.ForeColor = System.Drawing.Color.White;
      this.tbFirstName.Location = new System.Drawing.Point(118, 68);
      this.tbFirstName.Name = "tbFirstName";
      this.tbFirstName.Size = new System.Drawing.Size(182, 22);
      this.tbFirstName.TabIndex = 3;
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
      this.cbRoles.Location = new System.Drawing.Point(118, 188);
      this.cbRoles.Name = "cbRoles";
      this.cbRoles.Size = new System.Drawing.Size(182, 24);
      this.cbRoles.TabIndex = 7;
      // 
      // lbLastName
      // 
      this.lbLastName.AutoSize = true;
      this.lbLastName.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(232)))), ((int)(((byte)(166)))));
      this.lbLastName.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.lbLastName.Location = new System.Drawing.Point(32, 109);
      this.lbLastName.Name = "lbLastName";
      this.lbLastName.Size = new System.Drawing.Size(80, 16);
      this.lbLastName.TabIndex = 4;
      this.lbLastName.Text = "Last name";
      // 
      // lbFirstName
      // 
      this.lbFirstName.AutoSize = true;
      this.lbFirstName.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(232)))), ((int)(((byte)(166)))));
      this.lbFirstName.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.lbFirstName.Location = new System.Drawing.Point(24, 70);
      this.lbFirstName.Name = "lbFirstName";
      this.lbFirstName.Size = new System.Drawing.Size(88, 16);
      this.lbFirstName.TabIndex = 2;
      this.lbFirstName.Text = "First name";
      // 
      // tbLastName
      // 
      this.tbLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
      this.tbLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.tbLastName.ForeColor = System.Drawing.Color.White;
      this.tbLastName.Location = new System.Drawing.Point(118, 107);
      this.tbLastName.Name = "tbLastName";
      this.tbLastName.Size = new System.Drawing.Size(182, 22);
      this.tbLastName.TabIndex = 5;
      // 
      // UserForm
      // 
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
      this.ClientSize = new System.Drawing.Size(384, 305);
      this.Controls.Add(this.pnlUserFormBody);
      this.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ForeColor = System.Drawing.Color.White;
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
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.ComboBox cbRoles;
        private System.Windows.Forms.Label lbLastName;
        private System.Windows.Forms.Label lbFirstName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}