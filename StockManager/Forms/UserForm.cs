using StockManager.Database.Models;
using StockManager.Services;
using StockManager.Types;
using StockManager.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace StockManager.Forms
{
  public partial class UserForm : Form
  {
    private int userId = 0;
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

    public void ShowUserForm(User user = null)
    {
      // Spinner
      Cursor.Current = Cursors.WaitCursor;

      // Set the userId. Means that is a edit
      this.userId = (user != null) ? user.UserId : 0;

      // Set the Form title
      this.Text = (this.userId != 0)
        ? "Stock Manager | Edit user"
        : "Stock Manager | Create new user";

      // hide the error labels
      lbErrorUsername.Visible = false;
      lbErrorPassword.Visible = false;

      // Populate the combo box
      var roles = this.roleServices.GetRoles();
      cbRoles.DataSource = roles;
      cbRoles.ValueMember = "RoleId";
      cbRoles.DisplayMember = "Code";

      // Edit
      if (user != null)
      {
        tbUsername.Text = user.Username;
        //tbPassword.Text = user.Password;
        cbRoles.SelectedItem = roles.First(x => x.RoleId == user.RoleId);
      }

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

      List<ErrorType> errors = (this.userId != 0)
        ? this.userServices.UpdateUser(this.userId, user)
        : this.userServices.CreateUser(user);

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
