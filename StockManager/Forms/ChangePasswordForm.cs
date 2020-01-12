using StockManager.Database.Models;
using StockManager.Types;
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

    /*
     * Show the Change Password Form and set the initial values
     */
    public void ShowChangePasswordForm()
    {
      // hide the error labels
      lbErrorCurrentPassword.Visible = false;
      lbErrorNewPassword.Visible = false;

      this.ShowDialog();
    }

    /*
     * Show form errors
     */
    private void SetFormErrors(List<ErrorType> errors)
    {
      lbErrorCurrentPassword.Visible = false;
      lbErrorNewPassword.Visible = false;

      foreach (var err in errors)
      {
        if (err.Field == "CurrentPassword")
        {
          lbErrorCurrentPassword.Text = err.Error;
          lbErrorCurrentPassword.Visible = true;
        }

        if (err.Field == "NewPassword")
        {
          lbErrorNewPassword.Text = err.Error;
          lbErrorNewPassword.Visible = true;
        }
      }
    }

    /*
     * Update button click
     */
    private void btnSave_Click(object sender, EventArgs e)
    {
      // Spinner
      Cursor.Current = Cursors.WaitCursor;

      List<ErrorType> errors = Program.userServices.ChangePassword(
        Program.loggedInUser.UserId,
        tbCurrentPassword.Text,
        tbNewPassword.Text
      );

      if (errors.Count == 0)
      {
        this.Close();
      }
      else
      {
        this.SetFormErrors(errors);
      }
    }

    /*
     * Close button click
     */
    private void btnCancel_Click(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}
