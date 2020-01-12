namespace StockManager.UserControls
{
  partial class LoginUserControl
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
      this.pnlLoginForm = new System.Windows.Forms.Panel();
      this.lbErrorGeneric = new System.Windows.Forms.Label();
      this.lbLoginFormTitle = new System.Windows.Forms.Label();
      this.btnClean = new System.Windows.Forms.Button();
      this.lbErrorPassword = new System.Windows.Forms.Label();
      this.lbErrorUsername = new System.Windows.Forms.Label();
      this.btnLogin = new System.Windows.Forms.Button();
      this.tbPassword = new System.Windows.Forms.TextBox();
      this.lbPassword = new System.Windows.Forms.Label();
      this.tbUsername = new System.Windows.Forms.TextBox();
      this.lbFirstName = new System.Windows.Forms.Label();
      this.pnlLoginForm.SuspendLayout();
      this.SuspendLayout();
      // 
      // pnlLoginForm
      // 
      this.pnlLoginForm.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.pnlLoginForm.BackColor = System.Drawing.SystemColors.ControlLight;
      this.pnlLoginForm.Controls.Add(this.lbErrorGeneric);
      this.pnlLoginForm.Controls.Add(this.lbLoginFormTitle);
      this.pnlLoginForm.Controls.Add(this.btnClean);
      this.pnlLoginForm.Controls.Add(this.lbErrorPassword);
      this.pnlLoginForm.Controls.Add(this.lbErrorUsername);
      this.pnlLoginForm.Controls.Add(this.btnLogin);
      this.pnlLoginForm.Controls.Add(this.tbPassword);
      this.pnlLoginForm.Controls.Add(this.lbPassword);
      this.pnlLoginForm.Controls.Add(this.tbUsername);
      this.pnlLoginForm.Controls.Add(this.lbFirstName);
      this.pnlLoginForm.Location = new System.Drawing.Point(290, 62);
      this.pnlLoginForm.Name = "pnlLoginForm";
      this.pnlLoginForm.Size = new System.Drawing.Size(277, 275);
      this.pnlLoginForm.TabIndex = 28;
      // 
      // lbErrorGeneric
      // 
      this.lbErrorGeneric.AutoSize = true;
      this.lbErrorGeneric.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbErrorGeneric.ForeColor = System.Drawing.Color.Red;
      this.lbErrorGeneric.Location = new System.Drawing.Point(10, 43);
      this.lbErrorGeneric.Name = "lbErrorGeneric";
      this.lbErrorGeneric.Size = new System.Drawing.Size(120, 16);
      this.lbErrorGeneric.TabIndex = 37;
      this.lbErrorGeneric.Text = "Generic errors";
      // 
      // lbLoginFormTitle
      // 
      this.lbLoginFormTitle.AutoSize = true;
      this.lbLoginFormTitle.BackColor = System.Drawing.Color.Transparent;
      this.lbLoginFormTitle.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold);
      this.lbLoginFormTitle.ForeColor = System.Drawing.Color.Black;
      this.lbLoginFormTitle.Location = new System.Drawing.Point(9, 13);
      this.lbLoginFormTitle.Name = "lbLoginFormTitle";
      this.lbLoginFormTitle.Size = new System.Drawing.Size(87, 22);
      this.lbLoginFormTitle.TabIndex = 36;
      this.lbLoginFormTitle.Text = "Sign in";
      // 
      // btnClean
      // 
      this.btnClean.BackColor = System.Drawing.Color.DarkGray;
      this.btnClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnClean.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnClean.ForeColor = System.Drawing.Color.White;
      this.btnClean.Location = new System.Drawing.Point(13, 223);
      this.btnClean.Name = "btnClean";
      this.btnClean.Size = new System.Drawing.Size(120, 32);
      this.btnClean.TabIndex = 35;
      this.btnClean.Text = "Clear";
      this.btnClean.UseVisualStyleBackColor = false;
      this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
      // 
      // lbErrorPassword
      // 
      this.lbErrorPassword.AutoSize = true;
      this.lbErrorPassword.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbErrorPassword.ForeColor = System.Drawing.Color.Red;
      this.lbErrorPassword.Location = new System.Drawing.Point(16, 182);
      this.lbErrorPassword.Name = "lbErrorPassword";
      this.lbErrorPassword.Size = new System.Drawing.Size(113, 16);
      this.lbErrorPassword.TabIndex = 34;
      this.lbErrorPassword.Text = "Password errors";
      // 
      // lbErrorUsername
      // 
      this.lbErrorUsername.AutoSize = true;
      this.lbErrorUsername.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbErrorUsername.ForeColor = System.Drawing.Color.Red;
      this.lbErrorUsername.Location = new System.Drawing.Point(16, 115);
      this.lbErrorUsername.Name = "lbErrorUsername";
      this.lbErrorUsername.Size = new System.Drawing.Size(113, 16);
      this.lbErrorUsername.TabIndex = 33;
      this.lbErrorUsername.Text = "Username errors";
      // 
      // btnLogin
      // 
      this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
      this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnLogin.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnLogin.ForeColor = System.Drawing.Color.White;
      this.btnLogin.Location = new System.Drawing.Point(145, 223);
      this.btnLogin.Name = "btnLogin";
      this.btnLogin.Size = new System.Drawing.Size(120, 32);
      this.btnLogin.TabIndex = 31;
      this.btnLogin.Text = "Login";
      this.btnLogin.UseVisualStyleBackColor = false;
      this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
      // 
      // tbPassword
      // 
      this.tbPassword.BackColor = System.Drawing.Color.White;
      this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.tbPassword.ForeColor = System.Drawing.Color.Black;
      this.tbPassword.Location = new System.Drawing.Point(13, 157);
      this.tbPassword.Name = "tbPassword";
      this.tbPassword.PasswordChar = '*';
      this.tbPassword.Size = new System.Drawing.Size(252, 20);
      this.tbPassword.TabIndex = 29;
      this.tbPassword.UseSystemPasswordChar = true;
      // 
      // lbPassword
      // 
      this.lbPassword.AutoSize = true;
      this.lbPassword.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(118)))), ((int)(((byte)(185)))));
      this.lbPassword.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.lbPassword.Location = new System.Drawing.Point(10, 138);
      this.lbPassword.Name = "lbPassword";
      this.lbPassword.Size = new System.Drawing.Size(72, 16);
      this.lbPassword.TabIndex = 32;
      this.lbPassword.Text = "Password";
      // 
      // tbUsername
      // 
      this.tbUsername.BackColor = System.Drawing.Color.White;
      this.tbUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.tbUsername.ForeColor = System.Drawing.Color.Black;
      this.tbUsername.Location = new System.Drawing.Point(13, 90);
      this.tbUsername.Name = "tbUsername";
      this.tbUsername.Size = new System.Drawing.Size(252, 20);
      this.tbUsername.TabIndex = 28;
      // 
      // lbFirstName
      // 
      this.lbFirstName.AutoSize = true;
      this.lbFirstName.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(118)))), ((int)(((byte)(185)))));
      this.lbFirstName.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.lbFirstName.Location = new System.Drawing.Point(10, 71);
      this.lbFirstName.Name = "lbFirstName";
      this.lbFirstName.Size = new System.Drawing.Size(72, 16);
      this.lbFirstName.TabIndex = 30;
      this.lbFirstName.Text = "Username";
      // 
      // LoginUserControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.pnlLoginForm);
      this.Name = "LoginUserControl";
      this.Size = new System.Drawing.Size(860, 420);
      this.pnlLoginForm.ResumeLayout(false);
      this.pnlLoginForm.PerformLayout();
      this.ResumeLayout(false);

    }

        #endregion
        private System.Windows.Forms.Panel pnlLoginForm;
        private System.Windows.Forms.Label lbLoginFormTitle;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Label lbErrorPassword;
        private System.Windows.Forms.Label lbErrorUsername;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label lbFirstName;
        private System.Windows.Forms.Label lbErrorGeneric;
    }
}
