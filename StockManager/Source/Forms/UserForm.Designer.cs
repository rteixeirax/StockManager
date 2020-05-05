namespace StockManager.Source.Forms
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
      this.pnlBody = new System.Windows.Forms.Panel();
      this.btnCancel = new System.Windows.Forms.Button();
      this.pnlTopBar = new System.Windows.Forms.Panel();
      this.lbTitle = new System.Windows.Forms.Label();
      this.lbErrorPassword = new System.Windows.Forms.Label();
      this.lbErrorUsername = new System.Windows.Forms.Label();
      this.btnSave = new System.Windows.Forms.Button();
      this.tbPassword = new System.Windows.Forms.TextBox();
      this.lbPassword = new System.Windows.Forms.Label();
      this.lbRole = new System.Windows.Forms.Label();
      this.tbUsername = new System.Windows.Forms.TextBox();
      this.cbRoles = new System.Windows.Forms.ComboBox();
      this.lbFirstName = new System.Windows.Forms.Label();
      this.pnlBody.SuspendLayout();
      this.pnlTopBar.SuspendLayout();
      this.SuspendLayout();
      //
      // pnlBody
      //
      this.pnlBody.BackColor = System.Drawing.SystemColors.Control;
      this.pnlBody.Controls.Add(this.btnCancel);
      this.pnlBody.Controls.Add(this.pnlTopBar);
      this.pnlBody.Controls.Add(this.lbErrorPassword);
      this.pnlBody.Controls.Add(this.lbErrorUsername);
      this.pnlBody.Controls.Add(this.btnSave);
      this.pnlBody.Controls.Add(this.tbPassword);
      this.pnlBody.Controls.Add(this.lbPassword);
      this.pnlBody.Controls.Add(this.lbRole);
      this.pnlBody.Controls.Add(this.tbUsername);
      this.pnlBody.Controls.Add(this.cbRoles);
      this.pnlBody.Controls.Add(this.lbFirstName);
      this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pnlBody.Location = new System.Drawing.Point(0, 0);
      this.pnlBody.Name = "pnlBody";
      this.pnlBody.Size = new System.Drawing.Size(451, 341);
      this.pnlBody.TabIndex = 7;
      //
      // btnCancel
      //
      this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
      this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnCancel.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnCancel.ForeColor = System.Drawing.Color.White;
      this.btnCancel.Location = new System.Drawing.Point(103, 286);
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
      this.lbTitle.Size = new System.Drawing.Size(109, 22);
      this.lbTitle.TabIndex = 1;
      this.lbTitle.Text = "User info";
      //
      // lbErrorPassword
      //
      this.lbErrorPassword.AutoSize = true;
      this.lbErrorPassword.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbErrorPassword.ForeColor = System.Drawing.Color.Red;
      this.lbErrorPassword.Location = new System.Drawing.Point(106, 174);
      this.lbErrorPassword.Name = "lbErrorPassword";
      this.lbErrorPassword.Size = new System.Drawing.Size(113, 16);
      this.lbErrorPassword.TabIndex = 15;
      this.lbErrorPassword.Text = "Password errors";
      //
      // lbErrorUsername
      //
      this.lbErrorUsername.AutoSize = true;
      this.lbErrorUsername.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbErrorUsername.ForeColor = System.Drawing.Color.Red;
      this.lbErrorUsername.Location = new System.Drawing.Point(106, 108);
      this.lbErrorUsername.Name = "lbErrorUsername";
      this.lbErrorUsername.Size = new System.Drawing.Size(113, 16);
      this.lbErrorUsername.TabIndex = 14;
      this.lbErrorUsername.Text = "Username errors";
      //
      // btnSave
      //
      this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
      this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnSave.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnSave.ForeColor = System.Drawing.Color.White;
      this.btnSave.Location = new System.Drawing.Point(235, 286);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(120, 32);
      this.btnSave.TabIndex = 4;
      this.btnSave.Text = "Save";
      this.btnSave.UseVisualStyleBackColor = false;
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      //
      // tbPassword
      //
      this.tbPassword.BackColor = System.Drawing.Color.White;
      this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.tbPassword.ForeColor = System.Drawing.Color.Black;
      this.tbPassword.Location = new System.Drawing.Point(103, 149);
      this.tbPassword.Name = "tbPassword";
      this.tbPassword.PasswordChar = '*';
      this.tbPassword.Size = new System.Drawing.Size(252, 22);
      this.tbPassword.TabIndex = 2;
      this.tbPassword.UseSystemPasswordChar = true;
      //
      // lbPassword
      //
      this.lbPassword.AutoSize = true;
      this.lbPassword.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(118)))), ((int)(((byte)(185)))));
      this.lbPassword.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.lbPassword.Location = new System.Drawing.Point(100, 130);
      this.lbPassword.Name = "lbPassword";
      this.lbPassword.Size = new System.Drawing.Size(72, 16);
      this.lbPassword.TabIndex = 9;
      this.lbPassword.Text = "Password";
      //
      // lbRole
      //
      this.lbRole.AutoSize = true;
      this.lbRole.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(118)))), ((int)(((byte)(185)))));
      this.lbRole.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.lbRole.Location = new System.Drawing.Point(100, 201);
      this.lbRole.Name = "lbRole";
      this.lbRole.Size = new System.Drawing.Size(40, 16);
      this.lbRole.TabIndex = 8;
      this.lbRole.Text = "Role";
      //
      // tbUsername
      //
      this.tbUsername.BackColor = System.Drawing.Color.White;
      this.tbUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.tbUsername.ForeColor = System.Drawing.Color.Black;
      this.tbUsername.Location = new System.Drawing.Point(103, 83);
      this.tbUsername.Name = "tbUsername";
      this.tbUsername.Size = new System.Drawing.Size(252, 22);
      this.tbUsername.TabIndex = 1;
      //
      // cbRoles
      //
      this.cbRoles.BackColor = System.Drawing.Color.White;
      this.cbRoles.Cursor = System.Windows.Forms.Cursors.Hand;
      this.cbRoles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbRoles.ForeColor = System.Drawing.Color.Black;
      this.cbRoles.FormattingEnabled = true;
      this.cbRoles.Location = new System.Drawing.Point(103, 220);
      this.cbRoles.Name = "cbRoles";
      this.cbRoles.Size = new System.Drawing.Size(252, 24);
      this.cbRoles.TabIndex = 3;
      //
      // lbFirstName
      //
      this.lbFirstName.AutoSize = true;
      this.lbFirstName.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(118)))), ((int)(((byte)(185)))));
      this.lbFirstName.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.lbFirstName.Location = new System.Drawing.Point(100, 64);
      this.lbFirstName.Name = "lbFirstName";
      this.lbFirstName.Size = new System.Drawing.Size(72, 16);
      this.lbFirstName.TabIndex = 2;
      this.lbFirstName.Text = "Username";
      //
      // UserForm
      //
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
      this.BackColor = System.Drawing.SystemColors.Control;
      this.ClientSize = new System.Drawing.Size(451, 341);
      this.Controls.Add(this.pnlBody);
      this.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ForeColor = System.Drawing.Color.White;
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Margin = new System.Windows.Forms.Padding(4);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "UserForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Stock Manager | Create new user";
      this.pnlBody.ResumeLayout(false);
      this.pnlBody.PerformLayout();
      this.pnlTopBar.ResumeLayout(false);
      this.pnlTopBar.PerformLayout();
      this.ResumeLayout(false);

    }

        #endregion

        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbRole;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.ComboBox cbRoles;
        private System.Windows.Forms.Label lbFirstName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lbErrorPassword;
        private System.Windows.Forms.Label lbErrorUsername;
        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button btnCancel;
    }
}