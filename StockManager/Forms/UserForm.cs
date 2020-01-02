using StockManager.Database.Models;
using StockManager.Services;
using StockManager.Types;
using StockManager.UserControls;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace StockManager.Forms
{
  public partial class UserForm : Form
  {
    private readonly UsersUserControl usersUserControl;
    private readonly UserServices userServices;
    private readonly RoleServices roleServices;

    public UserForm(UsersUserControl usersUserControl)
    {
      InitializeComponent();
      this.usersUserControl = usersUserControl;
      this.userServices = new UserServices();
      this.roleServices = new RoleServices();
    }

    public void ShowUserForm()
    {
      // Spinner
      Cursor.Current = Cursors.WaitCursor;

      // hide the error labels
      lbErrorUsername.Visible = false;
      lbErrorPassword.Visible = false;

      // Populate the combo box
      cbRoles.DataSource = this.roleServices.GetRoles();
      cbRoles.ValueMember = "RoleId";
      cbRoles.DisplayMember = "Code";

      this.ShowDialog();
    }

    private void ShowFormErrors(List<ErrorType> errors)
    {
      lbErrorUsername.Visible = false;
      lbErrorPassword.Visible = false;

      foreach (var err in errors)
      {
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

    private void btnSave_Click(object sender, EventArgs e)
    {
      User user = new User();
      user.Username = tbUsername.Text;
      user.Password = tbPassword.Text;
      user.RoleId = int.Parse(cbRoles.SelectedValue.ToString());

      List<ErrorType> errors = this.userServices.CreateUser(user);

      if (errors.Count == 0)
      {
        this.usersUserControl.LoadUsers();
        this.Close();
      }
      else
      {
        this.ShowFormErrors(errors);
      }
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}
