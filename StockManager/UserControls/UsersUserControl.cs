using System;
using System.Collections.Generic;
using System.Windows.Forms;
using StockManager.Database.Models;
using StockManager.Services;

namespace StockManager.UserControls
{
  public partial class UsersUserControl : UserControl
  {
    private readonly UserServices services;

    public UsersUserControl()
    {
      InitializeComponent();
      this.services = new UserServices();
      this.LoadUsers();
    }

    public void LoadUsers()
    {
      List<User> users = this.services.GetAllUsers();

      foreach (User user in users)
      {
        dgvUsers.Rows.Add(
          user.Username,
          "user.Role.Code",
          user.LastLogin.ToString("MM/dd/yyyy")
        );
      }
    }

    private void btnCreateUser_Click(object sender, EventArgs e)
    {
      Program.userForm.ShowUserForm();
    }
  }
}
