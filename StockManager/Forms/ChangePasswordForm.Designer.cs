namespace StockManager.Forms
{
  partial class ChangePasswordForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePasswordForm));
      this.pnlUserFormBody = new System.Windows.Forms.Panel();
      this.btnCancel = new System.Windows.Forms.Button();
      this.pnlTopBar = new System.Windows.Forms.Panel();
      this.lbTitle = new System.Windows.Forms.Label();
      this.lbErrorNewPassword = new System.Windows.Forms.Label();
      this.lbErrorOldPassword = new System.Windows.Forms.Label();
      this.btnSave = new System.Windows.Forms.Button();
      this.tbPassword = new System.Windows.Forms.TextBox();
      this.lbPassword = new System.Windows.Forms.Label();
      this.tbUsername = new System.Windows.Forms.TextBox();
      this.lbFirstName = new System.Windows.Forms.Label();
      this.pnlUserFormBody.SuspendLayout();
      this.pnlTopBar.SuspendLayout();
      this.SuspendLayout();
      // 
      // pnlUserFormBody
      // 
      this.pnlUserFormBody.BackColor = System.Drawing.SystemColors.Control;
      this.pnlUserFormBody.Controls.Add(this.btnCancel);
      this.pnlUserFormBody.Controls.Add(this.pnlTopBar);
      this.pnlUserFormBody.Controls.Add(this.lbErrorNewPassword);
      this.pnlUserFormBody.Controls.Add(this.lbErrorOldPassword);
      this.pnlUserFormBody.Controls.Add(this.btnSave);
      this.pnlUserFormBody.Controls.Add(this.tbPassword);
      this.pnlUserFormBody.Controls.Add(this.lbPassword);
      this.pnlUserFormBody.Controls.Add(this.tbUsername);
      this.pnlUserFormBody.Controls.Add(this.lbFirstName);
      this.pnlUserFormBody.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pnlUserFormBody.Location = new System.Drawing.Point(0, 0);
      this.pnlUserFormBody.Name = "pnlUserFormBody";
      this.pnlUserFormBody.Size = new System.Drawing.Size(291, 286);
      this.pnlUserFormBody.TabIndex = 8;
      // 
      // btnCancel
      // 
      this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
      this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnCancel.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnCancel.ForeColor = System.Drawing.Color.White;
      this.btnCancel.Location = new System.Drawing.Point(17, 229);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(120, 32);
      this.btnCancel.TabIndex = 17;
      this.btnCancel.Text = "Cancel";
      this.btnCancel.UseVisualStyleBackColor = false;
      this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
      // 
      // pnlTopBar
      // 
      this.pnlTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
      this.pnlTopBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.pnlTopBar.Controls.Add(this.lbTitle);
      this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
      this.pnlTopBar.Location = new System.Drawing.Point(0, 0);
      this.pnlTopBar.Name = "pnlTopBar";
      this.pnlTopBar.Size = new System.Drawing.Size(291, 44);
      this.pnlTopBar.TabIndex = 16;
      // 
      // lbTitle
      // 
      this.lbTitle.AutoSize = true;
      this.lbTitle.BackColor = System.Drawing.Color.Transparent;
      this.lbTitle.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbTitle.ForeColor = System.Drawing.Color.White;
      this.lbTitle.Location = new System.Drawing.Point(12, 11);
      this.lbTitle.Name = "lbTitle";
      this.lbTitle.Size = new System.Drawing.Size(230, 22);
      this.lbTitle.TabIndex = 1;
      this.lbTitle.Text = "Change your password";
      // 
      // lbErrorNewPassword
      // 
      this.lbErrorNewPassword.AutoSize = true;
      this.lbErrorNewPassword.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbErrorNewPassword.ForeColor = System.Drawing.Color.Red;
      this.lbErrorNewPassword.Location = new System.Drawing.Point(26, 178);
      this.lbErrorNewPassword.Name = "lbErrorNewPassword";
      this.lbErrorNewPassword.Size = new System.Drawing.Size(141, 16);
      this.lbErrorNewPassword.TabIndex = 15;
      this.lbErrorNewPassword.Text = "New password errors";
      // 
      // lbErrorOldPassword
      // 
      this.lbErrorOldPassword.AutoSize = true;
      this.lbErrorOldPassword.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbErrorOldPassword.ForeColor = System.Drawing.Color.Red;
      this.lbErrorOldPassword.Location = new System.Drawing.Point(26, 108);
      this.lbErrorOldPassword.Name = "lbErrorOldPassword";
      this.lbErrorOldPassword.Size = new System.Drawing.Size(141, 16);
      this.lbErrorOldPassword.TabIndex = 14;
      this.lbErrorOldPassword.Text = "Old password errors";
      // 
      // btnSave
      // 
      this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
      this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnSave.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnSave.ForeColor = System.Drawing.Color.White;
      this.btnSave.Location = new System.Drawing.Point(149, 229);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(120, 32);
      this.btnSave.TabIndex = 4;
      this.btnSave.Text = "Save";
      this.btnSave.UseVisualStyleBackColor = false;
      // 
      // tbPassword
      // 
      this.tbPassword.BackColor = System.Drawing.Color.White;
      this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.tbPassword.ForeColor = System.Drawing.Color.Black;
      this.tbPassword.Location = new System.Drawing.Point(17, 155);
      this.tbPassword.Name = "tbPassword";
      this.tbPassword.PasswordChar = '*';
      this.tbPassword.Size = new System.Drawing.Size(252, 20);
      this.tbPassword.TabIndex = 2;
      this.tbPassword.UseSystemPasswordChar = true;
      // 
      // lbPassword
      // 
      this.lbPassword.AutoSize = true;
      this.lbPassword.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
      this.lbPassword.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.lbPassword.Location = new System.Drawing.Point(14, 136);
      this.lbPassword.Name = "lbPassword";
      this.lbPassword.Size = new System.Drawing.Size(104, 16);
      this.lbPassword.TabIndex = 9;
      this.lbPassword.Text = "New password";
      // 
      // tbUsername
      // 
      this.tbUsername.BackColor = System.Drawing.Color.White;
      this.tbUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.tbUsername.ForeColor = System.Drawing.Color.Black;
      this.tbUsername.Location = new System.Drawing.Point(17, 85);
      this.tbUsername.Name = "tbUsername";
      this.tbUsername.PasswordChar = '*';
      this.tbUsername.Size = new System.Drawing.Size(252, 20);
      this.tbUsername.TabIndex = 1;
      this.tbUsername.UseSystemPasswordChar = true;
      // 
      // lbFirstName
      // 
      this.lbFirstName.AutoSize = true;
      this.lbFirstName.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
      this.lbFirstName.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.lbFirstName.Location = new System.Drawing.Point(14, 66);
      this.lbFirstName.Name = "lbFirstName";
      this.lbFirstName.Size = new System.Drawing.Size(104, 16);
      this.lbFirstName.TabIndex = 2;
      this.lbFirstName.Text = "Old password";
      // 
      // ChangePasswordForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(291, 286);
      this.Controls.Add(this.pnlUserFormBody);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "ChangePasswordForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Stock Manager | Change password";
      this.pnlUserFormBody.ResumeLayout(false);
      this.pnlUserFormBody.PerformLayout();
      this.pnlTopBar.ResumeLayout(false);
      this.pnlTopBar.PerformLayout();
      this.ResumeLayout(false);

    }

        #endregion

        private System.Windows.Forms.Panel pnlUserFormBody;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbErrorNewPassword;
        private System.Windows.Forms.Label lbErrorOldPassword;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label lbFirstName;
    }
}