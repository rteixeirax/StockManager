using StockManager.Entities;
using StockManager.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManager.Forms
{
  public partial class UserForm : Form
  {
    public UserForm()
    {
      InitializeComponent();
    }

    public void ShowUserForm()
    {
      this.ShowDialog();
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
      User user = new User();
      user.lastName = tbLastName.Text;
      user.firstName = tbFirstName.Text;
      user.password = tbPassword.Text;
      user.role = cbRoles.SelectedItem.ToString();

      UserServices.CreateUser(user);
      this.Close();
    }
  }
}
