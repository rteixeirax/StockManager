using StockManager.Database.Models;
using StockManager.Services;
using StockManager.UserControls;
using System;
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

    private void ShowFormErrors(User user)
    {
      lbErrorUsername.Visible = string.IsNullOrEmpty(user.Username) ? true : false;
      lbErrorPassword.Visible = string.IsNullOrEmpty(user.Password) ? true : false;
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
      User user = new User();
      user.Username = tbUsername.Text;
      user.Password = tbPassword.Text;
      user.RoleId = int.Parse(cbRoles.SelectedValue.ToString());

      if (this.userServices.CreateUser(user))
      {
        this.usersUserControl.LoadUsers();
        this.Close();
      }
      else
      {
        this.ShowFormErrors(user);
      }
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}
