using StockManager.Database.Models;
using StockManager.Services;
using System;
using System.Windows.Forms;

namespace StockManager.Forms
{
  public partial class UserForm : Form
  {
    private readonly UserServices services;

    public UserForm()
    {
      InitializeComponent();
      this.services = new UserServices();
    }

    public void ShowUserForm()
    {
      // hide the error labels
      lbErrorUsername.Visible = false;
      lbErrorPassword.Visible = false;
      lbErrorRole.Visible = false;

      this.ShowDialog();
    }

    private void ShowFormErrors(User user)
    {
      lbErrorUsername.Visible = string.IsNullOrEmpty(user.Username) ? true : false;
      lbErrorPassword.Visible = string.IsNullOrEmpty(user.Password) ? true : false;
      lbErrorRole.Visible = (user.RoleId == Guid.Empty) ? true : false;
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
      User user = new User();
      user.Username = tbUsername.Text;
      user.Password = tbPassword.Text;
      user.RoleId = Guid.Parse(cbRoles.SelectedItem?.ToString());

      if (this.services.CreateUser(user))
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
