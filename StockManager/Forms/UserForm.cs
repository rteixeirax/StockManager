using StockManager.Database.Models;
using StockManager.Services;
using System;
using System.Windows.Forms;

namespace StockManager.Forms
{
  public partial class UserForm : Form
  {
    private readonly UserServices userServices;
    private readonly RoleServices roleServices;

    public UserForm()
    {
      InitializeComponent();
      this.userServices = new UserServices();
      this.roleServices = new RoleServices();
    }

    public void ShowUserForm()
    {
      // hide the error labels
      lbErrorUsername.Visible = false;
      lbErrorPassword.Visible = false;
      lbErrorRole.Visible = false;

      // Populate the combo box
      var roles = this.roleServices.GetRoles();
      cbRoles.DisplayMember = "Select user role";
      cbRoles.ValueMember = "RoleId";
      cbRoles.DataSource = roles;
      
      this.ShowDialog();
    }

    private void ShowFormErrors(User user)
    {
      lbErrorUsername.Visible = string.IsNullOrEmpty(user.Username) ? true : false;
      lbErrorPassword.Visible = string.IsNullOrEmpty(user.Password) ? true : false;
      lbErrorRole.Visible = (user.RoleId == 0) ? true : false;
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
      User user = new User();
      user.Username = tbUsername.Text;
      user.Password = tbPassword.Text;
      user.RoleId = int.Parse(cbRoles.SelectedItem?.ToString());

      if (this.userServices.CreateUser(user))
      {
        Program.usersUserControl.LoadUsers();
        this.Close();
      }
      else
      {
        this.ShowFormErrors(user);
      }
    }
  }
}
