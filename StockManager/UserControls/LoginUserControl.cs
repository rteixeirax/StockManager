using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockManager.Types;
using StockManager.Forms;

namespace StockManager.UserControls
{
  public partial class LoginUserControl : UserControl
  {
    private readonly MainForm mainForm;

    public LoginUserControl(MainForm mainForm)
    {
      InitializeComponent();
      this.mainForm = mainForm;

      // hide the error labels
      lbErrorGeneric.Visible = false;
      lbErrorUsername.Visible = false;
      lbErrorPassword.Visible = false;
    }

    /*
     * Set the form errors
     */
    private void SetFormErrors(List<ErrorType> errors)
    {
      lbErrorGeneric.Visible = false;
      lbErrorUsername.Visible = false;
      lbErrorPassword.Visible = false;

      foreach (var err in errors)
      {
        if (err.Field == "Generic")
        {
          lbErrorGeneric.Text = err.Error;
          lbErrorGeneric.Visible = true;
        }

        if (err.Field == "Username")
        {
          lbErrorUsername.Text = err.Error;
          lbErrorUsername.Visible = true;
        }

        if (err.Field == "Password")
        {
          lbErrorPassword.Text = err.Error;
          lbErrorPassword.Visible = true;
        }
      }
    }

    /*
     * Clean all the form content
     */
    private void btnClean_Click(object sender, EventArgs e)
    {
      lbErrorUsername.Visible = false;
      lbErrorPassword.Visible = false;
      tbUsername.Text = "";
      tbPassword.Text = "";
    }

    /*
     * Login button click
     */
    private void btnLogin_Click(object sender, EventArgs e)
    {
      // Spinner
      Cursor.Current = Cursors.WaitCursor;

      List<ErrorType> errors = Program.userServices.Login(
        tbUsername.Text,
        tbPassword.Text
      );

      if (errors.Count == 0)
      {
        Program.SetLoggedInUser(tbUsername.Text);
        mainForm.SetUi();
      }
      else
      {
        this.SetFormErrors(errors);
      }
    }

    /*
     * Call Login button click when pressed enter in the password textbox
     */
    private void tbPassword_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (e.KeyChar == (char)Keys.Enter)
      {
        this.btnLogin_Click(sender, e);
        // Remove the annoying beep
        e.Handled = true;
      }
    }
  }
}
