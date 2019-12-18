using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockManager.Entities;
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
          user.username,
          user.role,
          user.lastLogin.ToString("MM/dd/yyyy")
        );
      }
    }

    private void btnCreateUser_Click(object sender, EventArgs e)
    {
      Program.userForm.ShowUserForm();
    }
  }
}
