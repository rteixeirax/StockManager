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
      this.pnlDivider = new System.Windows.Forms.Panel();
      this.lbTitle = new System.Windows.Forms.Label();
      this.pnlTopBar = new System.Windows.Forms.Panel();
      this.pnlLoginForm = new System.Windows.Forms.Panel();
      this.btnCancel = new System.Windows.Forms.Button();
      this.lbErrorPassword = new System.Windows.Forms.Label();
      this.lbErrorUsername = new System.Windows.Forms.Label();
      this.btnSave = new System.Windows.Forms.Button();
      this.tbPassword = new System.Windows.Forms.TextBox();
      this.lbPassword = new System.Windows.Forms.Label();
      this.tbUsername = new System.Windows.Forms.TextBox();
      this.lbFirstName = new System.Windows.Forms.Label();
      this.lbLoginFormTitle = new System.Windows.Forms.Label();
      this.lbErrorGeneric = new System.Windows.Forms.Label();
      this.pnlTopBar.SuspendLayout();
      this.pnlLoginForm.SuspendLayout();
      this.SuspendLayout();
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
      this.lbTitle.Size = new System.Drawing.Size(87, 22);
      this.lbTitle.TabIndex = 1;
      this.lbTitle.Text = "Welcome";
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
      this.pnlTopBar.TabIndex = 4;
      // 
      // pnlLoginForm
      // 
      this.pnlLoginForm.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.pnlLoginForm.BackColor = System.Drawing.SystemColors.ControlLight;
      this.pnlLoginForm.Controls.Add(this.lbErrorGeneric);
      this.pnlLoginForm.Controls.Add(this.lbLoginFormTitle);
      this.pnlLoginForm.Controls.Add(this.btnCancel);
      this.pnlLoginForm.Controls.Add(this.lbErrorPassword);
      this.pnlLoginForm.Controls.Add(this.lbErrorUsername);
      this.pnlLoginForm.Controls.Add(this.btnSave);
      this.pnlLoginForm.Controls.Add(this.tbPassword);
      this.pnlLoginForm.Controls.Add(this.lbPassword);
      this.pnlLoginForm.Controls.Add(this.tbUsername);
      this.pnlLoginForm.Controls.Add(this.lbFirstName);
      this.pnlLoginForm.Location = new System.Drawing.Point(290, 68);
      this.pnlLoginForm.Name = "pnlLoginForm";
      this.pnlLoginForm.Size = new System.Drawing.Size(277, 275);
      this.pnlLoginForm.TabIndex = 28;
      // 
      // btnCancel
      // 
      this.btnCancel.BackColor = System.Drawing.Color.DarkGray;
      this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnCancel.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnCancel.ForeColor = System.Drawing.Color.White;
      this.btnCancel.Location = new System.Drawing.Point(13, 223);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(120, 32);
      this.btnCancel.TabIndex = 35;
      this.btnCancel.Text = "Clear";
      this.btnCancel.UseVisualStyleBackColor = false;
      this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
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
      // btnSave
      // 
      this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
      this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnSave.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnSave.ForeColor = System.Drawing.Color.White;
      this.btnSave.Location = new System.Drawing.Point(145, 223);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(120, 32);
      this.btnSave.TabIndex = 31;
      this.btnSave.Text = "Login";
      this.btnSave.UseVisualStyleBackColor = false;
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
      // LoginUserControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.pnlLoginForm);
      this.Controls.Add(this.pnlTopBar);
      this.Name = "LoginUserControl";
      this.Size = new System.Drawing.Size(860, 420);
      this.pnlTopBar.ResumeLayout(false);
      this.pnlTopBar.PerformLayout();
      this.pnlLoginForm.ResumeLayout(false);
      this.pnlLoginForm.PerformLayout();
      this.ResumeLayout(false);

    }

        #endregion

        private System.Windows.Forms.Panel pnlDivider;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Panel pnlLoginForm;
        private System.Windows.Forms.Label lbLoginFormTitle;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lbErrorPassword;
        private System.Windows.Forms.Label lbErrorUsername;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label lbFirstName;
        private System.Windows.Forms.Label lbErrorGeneric;
    }
}
