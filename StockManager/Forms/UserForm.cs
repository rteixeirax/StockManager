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
    private readonly UserServices services;

    public UserForm()
    {
      InitializeComponent();
      this.services = new UserServices();
    }

    public void ShowUserForm()
    {
      // hide the error labels
      lbErrorFirstName.Visible = false;
      lbErrorPassword.Visible = false;
      lbErrorRole.Visible = false;

      this.ShowDialog();
    }

    private void ShowFormErrors(User user)
    {
      lbErrorFirstName.Visible = String.IsNullOrEmpty(user.username) ? true : false;
      lbErrorPassword.Visible = String.IsNullOrEmpty(user.password) ? true : false;
      lbErrorRole.Visible = String.IsNullOrEmpty(user.role) ? true : false;
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
      User user = new User();
      user.username = tbUsername.Text;
      user.password = tbPassword.Text;
      user.role = (cbRoles.SelectedItem != null) ? cbRoles.SelectedItem.ToString() : null;

      if (this.services.CreateUser(user))
      {
        this.Close();
      }
      else
      {
        this.ShowFormErrors(user);
      }
    }
  }
}
