namespace StockManager.Source.Forms
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
            this.lbErrorCurrentPassword = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbNewPassword = new System.Windows.Forms.TextBox();
            this.lbNewPassword = new System.Windows.Forms.Label();
            this.tbCurrentPassword = new System.Windows.Forms.TextBox();
            this.lbCurrentPassword = new System.Windows.Forms.Label();
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
            this.pnlBody.Controls.Add(this.lbErrorCurrentPassword);
            this.pnlBody.Controls.Add(this.btnSave);
            this.pnlBody.Controls.Add(this.tbNewPassword);
            this.pnlBody.Controls.Add(this.lbNewPassword);
            this.pnlBody.Controls.Add(this.tbCurrentPassword);
            this.pnlBody.Controls.Add(this.lbCurrentPassword);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 0);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(451, 277);
            this.pnlBody.TabIndex = 8;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(99, 219);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 32);
            this.btnCancel.TabIndex = 4;
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
            this.pnlTopBar.Size = new System.Drawing.Size(451, 44);
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
            this.lbErrorNewPassword.Location = new System.Drawing.Point(108, 173);
            this.lbErrorNewPassword.Name = "lbErrorNewPassword";
            this.lbErrorNewPassword.Size = new System.Drawing.Size(141, 16);
            this.lbErrorNewPassword.TabIndex = 15;
            this.lbErrorNewPassword.Text = "New password errors";
            // 
            // lbErrorCurrentPassword
            // 
            this.lbErrorCurrentPassword.AutoSize = true;
            this.lbErrorCurrentPassword.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErrorCurrentPassword.ForeColor = System.Drawing.Color.Red;
            this.lbErrorCurrentPassword.Location = new System.Drawing.Point(108, 105);
            this.lbErrorCurrentPassword.Name = "lbErrorCurrentPassword";
            this.lbErrorCurrentPassword.Size = new System.Drawing.Size(169, 16);
            this.lbErrorCurrentPassword.TabIndex = 14;
            this.lbErrorCurrentPassword.Text = "Current password errors";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(231, 219);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 32);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbNewPassword
            // 
            this.tbNewPassword.BackColor = System.Drawing.Color.White;
            this.tbNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNewPassword.ForeColor = System.Drawing.Color.Black;
            this.tbNewPassword.Location = new System.Drawing.Point(99, 150);
            this.tbNewPassword.Name = "tbNewPassword";
            this.tbNewPassword.PasswordChar = '*';
            this.tbNewPassword.Size = new System.Drawing.Size(252, 20);
            this.tbNewPassword.TabIndex = 2;
            this.tbNewPassword.UseSystemPasswordChar = true;
            this.tbNewPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDown);
            // 
            // lbNewPassword
            // 
            this.lbNewPassword.AutoSize = true;
            this.lbNewPassword.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNewPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(118)))), ((int)(((byte)(185)))));
            this.lbNewPassword.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbNewPassword.Location = new System.Drawing.Point(96, 131);
            this.lbNewPassword.Name = "lbNewPassword";
            this.lbNewPassword.Size = new System.Drawing.Size(104, 16);
            this.lbNewPassword.TabIndex = 9;
            this.lbNewPassword.Text = "New password";
            // 
            // tbCurrentPassword
            // 
            this.tbCurrentPassword.BackColor = System.Drawing.Color.White;
            this.tbCurrentPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCurrentPassword.ForeColor = System.Drawing.Color.Black;
            this.tbCurrentPassword.Location = new System.Drawing.Point(99, 82);
            this.tbCurrentPassword.Name = "tbCurrentPassword";
            this.tbCurrentPassword.PasswordChar = '*';
            this.tbCurrentPassword.Size = new System.Drawing.Size(252, 20);
            this.tbCurrentPassword.TabIndex = 1;
            this.tbCurrentPassword.UseSystemPasswordChar = true;
            this.tbCurrentPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDown);
            // 
            // lbCurrentPassword
            // 
            this.lbCurrentPassword.AutoSize = true;
            this.lbCurrentPassword.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCurrentPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(118)))), ((int)(((byte)(185)))));
            this.lbCurrentPassword.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbCurrentPassword.Location = new System.Drawing.Point(96, 63);
            this.lbCurrentPassword.Name = "lbCurrentPassword";
            this.lbCurrentPassword.Size = new System.Drawing.Size(136, 16);
            this.lbCurrentPassword.TabIndex = 2;
            this.lbCurrentPassword.Text = "Current password";
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 277);
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
        private System.Windows.Forms.Label lbErrorCurrentPassword;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbNewPassword;
        private System.Windows.Forms.Label lbNewPassword;
        private System.Windows.Forms.TextBox tbCurrentPassword;
        private System.Windows.Forms.Label lbCurrentPassword;
    }
}