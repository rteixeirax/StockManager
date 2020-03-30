using StockManager.Types.Types;
using StockManager.Utils;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace StockManager.Forms {
  public partial class ChangePasswordForm : Form {
    public ChangePasswordForm() {
      InitializeComponent();
    }

    /// <summary>
    /// Show the Change Password Form and set the initial values
    /// </summary>
    public void ShowChangePasswordForm() {
      // hide the error labels
      lbErrorCurrentPassword.Visible = false;
      lbErrorNewPassword.Visible = false;

      this.ShowDialog();
    }

    /// <summary>
    /// Show form errors
    /// </summary>
    private void SetFormErrors(List<ErrorType> errors) {
      lbErrorCurrentPassword.Visible = false;
      lbErrorNewPassword.Visible = false;

      foreach (var err in errors) {
        if (err.Field == "CurrentPassword") {
          lbErrorCurrentPassword.Text = err.Error;
          lbErrorCurrentPassword.Visible = true;
        }

        if (err.Field == "NewPassword") {
          lbErrorNewPassword.Text = err.Error;
          lbErrorNewPassword.Visible = true;
        }
      }
    }

    /// <summary>
    /// Update button click
    /// </summary>
    private async void btnSave_Click(object sender, EventArgs e) {
      try {
        Spinner.InitSpinner();

        await Program.UserService.ChangePasswordAsync(
          Program.LoggedInUser.UserId,
          tbCurrentPassword.Text,
          tbNewPassword.Text
        );

        Spinner.StopSpinner();
        this.btnCancel_Click(sender, e);
      } catch (OperationErrorException ex) {
        Spinner.StopSpinner();
        this.SetFormErrors(ex.Errors);
      }
    }

    /// <summary>
    /// Close button click
    /// </summary>
    private void btnCancel_Click(object sender, EventArgs e) {
      this.Close();
    }
  }
}
