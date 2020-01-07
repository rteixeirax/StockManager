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
      this.pnlBody = new System.Windows.Forms.Panel();
      this.btnCancel = new System.Windows.Forms.Button();
      this.pnlTopBar = new System.Windows.Forms.Panel();
      this.lbTitle = new System.Windows.Forms.Label();
      this.lbErrorNewPassword = new System.Windows.Forms.Label();
      this.lbErrorOldPassword = new System.Windows.Forms.Label();
      this.btnSave = new System.Windows.Forms.Button();
      this.tbNewPassword = new System.Windows.Forms.TextBox();
      this.lbNewPassword = new System.Windows.Forms.Label();
      this.tbOldPassword = new System.Windows.Forms.TextBox();
      this.lbOldPassword = new System.Windows.Forms.Label();
      this.pnlBody.SuspendLayout();
      this.pnlTopBar.SuspendLayout();
      this.SuspendLayout();
      // 
      // pnlBody
      // 
      this.pnlBody.BackColor = System.Drawing.SystemColors.Control;
      this.pnlBody.Controls.Add(this.btnCancel);
      this.pnlBody.Controls.Add(this.pnlTopBar);
      this.pnlBody.Controls.Add(this.lbErrorNewPassword);
      this.pnlBody.Controls.Add(this.lbErrorOldPassword);
      this.pnlBody.Controls.Add(this.btnSave);
      this.pnlBody.Controls.Add(this.tbNewPassword);
      this.pnlBody.Controls.Add(this.lbNewPassword);
      this.pnlBody.Controls.Add(this.tbOldPassword);
      this.pnlBody.Controls.Add(this.lbOldPassword);
      this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pnlBody.Location = new System.Drawing.Point(0, 0);
      this.pnlBody.Name = "pnlBody";
      this.pnlBody.Size = new System.Drawing.Size(291, 266);
      this.pnlBody.TabIndex = 8;
      // 
      // btnCancel
      // 
      this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
      this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnCancel.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnCancel.ForeColor = System.Drawing.Color.White;
      this.btnCancel.Location = new System.Drawing.Point(17, 215);
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
      this.lbErrorNewPassword.Location = new System.Drawing.Point(26, 169);
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
      this.lbErrorOldPassword.Location = new System.Drawing.Point(26, 101);
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
      this.btnSave.Location = new System.Drawing.Point(149, 215);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(120, 32);
      this.btnSave.TabIndex = 4;
      this.btnSave.Text = "Save";
      this.btnSave.UseVisualStyleBackColor = false;
      // 
      // tbNewPassword
      // 
      this.tbNewPassword.BackColor = System.Drawing.Color.White;
      this.tbNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.tbNewPassword.ForeColor = System.Drawing.Color.Black;
      this.tbNewPassword.Location = new System.Drawing.Point(17, 146);
      this.tbNewPassword.Name = "tbNewPassword";
      this.tbNewPassword.PasswordChar = '*';
      this.tbNewPassword.Size = new System.Drawing.Size(252, 20);
      this.tbNewPassword.TabIndex = 2;
      this.tbNewPassword.UseSystemPasswordChar = true;
      // 
      // lbNewPassword
      // 
      this.lbNewPassword.AutoSize = true;
      this.lbNewPassword.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbNewPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(118)))), ((int)(((byte)(185)))));
      this.lbNewPassword.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.lbNewPassword.Location = new System.Drawing.Point(14, 127);
      this.lbNewPassword.Name = "lbNewPassword";
      this.lbNewPassword.Size = new System.Drawing.Size(104, 16);
      this.lbNewPassword.TabIndex = 9;
      this.lbNewPassword.Text = "New password";
      // 
      // tbOldPassword
      // 
      this.tbOldPassword.BackColor = System.Drawing.Color.White;
      this.tbOldPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.tbOldPassword.ForeColor = System.Drawing.Color.Black;
      this.tbOldPassword.Location = new System.Drawing.Point(17, 78);
      this.tbOldPassword.Name = "tbOldPassword";
      this.tbOldPassword.PasswordChar = '*';
      this.tbOldPassword.Size = new System.Drawing.Size(252, 20);
      this.tbOldPassword.TabIndex = 1;
      this.tbOldPassword.UseSystemPasswordChar = true;
      // 
      // lbOldPassword
      // 
      this.lbOldPassword.AutoSize = true;
      this.lbOldPassword.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbOldPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(118)))), ((int)(((byte)(185)))));
      this.lbOldPassword.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.lbOldPassword.Location = new System.Drawing.Point(14, 59);
      this.lbOldPassword.Name = "lbOldPassword";
      this.lbOldPassword.Size = new System.Drawing.Size(104, 16);
      this.lbOldPassword.TabIndex = 2;
      this.lbOldPassword.Text = "Old password";
      // 
      // ChangePasswordForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(291, 266);
      this.Controls.Add(this.pnlBody);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "ChangePasswordForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Stock Manager | Change password";
      this.pnlBody.ResumeLayout(false);
      this.pnlBody.PerformLayout();
      this.pnlTopBar.ResumeLayout(false);
      this.pnlTopBar.PerformLayout();
      this.ResumeLayout(false);

    }

        #endregion

        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbErrorNewPassword;
        private System.Windows.Forms.Label lbErrorOldPassword;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbNewPassword;
        private System.Windows.Forms.Label lbNewPassword;
        private System.Windows.Forms.TextBox tbOldPassword;
        private System.Windows.Forms.Label lbOldPassword;
    }
}