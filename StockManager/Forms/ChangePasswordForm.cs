using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManager.Forms
{
  public partial class ChangePasswordForm : Form
  {
    public ChangePasswordForm()
    {
      InitializeComponent();
    }

    public void ShowChangePasswordForm()
    {
      // hide the error labels
      lbErrorOldPassword.Visible = false;
      lbErrorNewPassword.Visible = false;

      this.ShowDialog();
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}
