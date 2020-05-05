namespace StockManager.Source.Forms
{
  partial class LocationForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LocationForm));
      this.pnlTopBar = new System.Windows.Forms.Panel();
      this.lbTitle = new System.Windows.Forms.Label();
      this.pnlBody = new System.Windows.Forms.Panel();
      this.btnCancel = new System.Windows.Forms.Button();
      this.lbErrorName = new System.Windows.Forms.Label();
      this.btnSave = new System.Windows.Forms.Button();
      this.tbName = new System.Windows.Forms.TextBox();
      this.lbName = new System.Windows.Forms.Label();
      this.pnlTopBar.SuspendLayout();
      this.pnlBody.SuspendLayout();
      this.SuspendLayout();
      //
      // pnlTopBar
      //
      this.pnlTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
      this.pnlTopBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.pnlTopBar.Controls.Add(this.lbTitle);
      this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
      this.pnlTopBar.Location = new System.Drawing.Point(0, 0);
      this.pnlTopBar.Name = "pnlTopBar";
      this.pnlTopBar.Size = new System.Drawing.Size(438, 44);
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
      this.lbTitle.Size = new System.Drawing.Size(153, 22);
      this.lbTitle.TabIndex = 1;
      this.lbTitle.Text = "Location info";
      //
      // pnlBody
      //
      this.pnlBody.BackColor = System.Drawing.SystemColors.Control;
      this.pnlBody.Controls.Add(this.btnCancel);
      this.pnlBody.Controls.Add(this.pnlTopBar);
      this.pnlBody.Controls.Add(this.lbErrorName);
      this.pnlBody.Controls.Add(this.btnSave);
      this.pnlBody.Controls.Add(this.tbName);
      this.pnlBody.Controls.Add(this.lbName);
      this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pnlBody.Location = new System.Drawing.Point(0, 0);
      this.pnlBody.Name = "pnlBody";
      this.pnlBody.Size = new System.Drawing.Size(438, 234);
      this.pnlBody.TabIndex = 8;
      //
      // btnCancel
      //
      this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
      this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnCancel.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnCancel.ForeColor = System.Drawing.Color.White;
      this.btnCancel.Location = new System.Drawing.Point(96, 159);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(120, 32);
      this.btnCancel.TabIndex = 17;
      this.btnCancel.Text = "Cancel";
      this.btnCancel.UseVisualStyleBackColor = false;
      this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
      //
      // lbErrorName
      //
      this.lbErrorName.AutoSize = true;
      this.lbErrorName.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbErrorName.ForeColor = System.Drawing.Color.Red;
      this.lbErrorName.Location = new System.Drawing.Point(98, 108);
      this.lbErrorName.Name = "lbErrorName";
      this.lbErrorName.Size = new System.Drawing.Size(85, 16);
      this.lbErrorName.TabIndex = 14;
      this.lbErrorName.Text = "Name errors";
      //
      // btnSave
      //
      this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
      this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnSave.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnSave.ForeColor = System.Drawing.Color.White;
      this.btnSave.Location = new System.Drawing.Point(228, 159);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(120, 32);
      this.btnSave.TabIndex = 4;
      this.btnSave.Text = "Save";
      this.btnSave.UseVisualStyleBackColor = false;
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      //
      // tbName
      //
      this.tbName.BackColor = System.Drawing.Color.White;
      this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.tbName.ForeColor = System.Drawing.Color.Black;
      this.tbName.Location = new System.Drawing.Point(96, 83);
      this.tbName.Name = "tbName";
      this.tbName.Size = new System.Drawing.Size(252, 22);
      this.tbName.TabIndex = 1;
      //
      // lbName
      //
      this.lbName.AutoSize = true;
      this.lbName.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(118)))), ((int)(((byte)(185)))));
      this.lbName.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.lbName.Location = new System.Drawing.Point(93, 64);
      this.lbName.Name = "lbName";
      this.lbName.Size = new System.Drawing.Size(40, 16);
      this.lbName.TabIndex = 2;
      this.lbName.Text = "Name";
      //
      // LocationForm
      //
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
      this.ClientSize = new System.Drawing.Size(438, 234);
      this.Controls.Add(this.pnlBody);
      this.Font = new System.Drawing.Font("Courier New", 9.75F);
      this.ForeColor = System.Drawing.Color.White;
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Margin = new System.Windows.Forms.Padding(4);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "LocationForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Stock Manager | Create new location";
      this.pnlTopBar.ResumeLayout(false);
      this.pnlTopBar.PerformLayout();
      this.pnlBody.ResumeLayout(false);
      this.pnlBody.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel pnlTopBar;
    private System.Windows.Forms.Label lbTitle;
    private System.Windows.Forms.Panel pnlBody;
    private System.Windows.Forms.Button btnCancel;
    private System.Windows.Forms.Label lbErrorName;
    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.TextBox tbName;
    private System.Windows.Forms.Label lbName;
  }
}