using System;
using System.Collections.Generic;
using System.Windows.Forms;
using StockManager.Forms;
using StockManager.Database.Models;
using StockManager.Services;

namespace StockManager.UserControls
{
  public partial class UsersUserControl : UserControl
  {
    private readonly UserServices userServices;

    public UsersUserControl()
    {
      InitializeComponent();
      this.userServices = new UserServices();
    }

    public void ShowUserControl()
    {
      Cursor.Current = Cursors.WaitCursor;
      this.LoadUsers();
      this.BringToFront();
    }

    public void LoadUsers()
    {
      dgvUsers.Rows.Clear();
      var users = this.userServices.GetUsers();

      foreach (var user in users)
      {
        dgvUsers.Rows.Add(
          user.Username,
          user.Role.Code,
          user.LastLogin.ToString("MM/dd/yyyy")
        );
      }
    }

    private void btnCreateUser_Click(object sender, EventArgs e)
    {
      var userForm = new UserForm(this);
      userForm.ShowDialog();
    }
  }
}
