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
      // Spinner
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
          user.UserId,
          user.Username,
          user.Role.Code,
          user.LastLogin?.ToString("MM/dd/yyyy")
        );
      }
    }

    private void btnCreateUser_Click(object sender, EventArgs e)
    {
      var userForm = new UserForm(this);
      userForm.ShowUserForm();
    }

    private void btnEditUser_Click(object sender, EventArgs e)
    {
      // Spinner
      Cursor.Current = Cursors.WaitCursor;

      var selectedUserId = dgvUsers.SelectedRows[0].Cells[0].Value.ToString();
      var user = this.userServices.GetUserById(int.Parse(selectedUserId));

      var userForm = new UserForm(this);
      userForm.ShowUserForm(user);
    }

    private void btnDeleteUser_Click(object sender, EventArgs e)
    {
      // Spinner
      Cursor.Current = Cursors.WaitCursor;

      var selectedUsers = dgvUsers.SelectedRows;

      if (MessageBox.Show(
        $"Delete {selectedUsers.Count} user(s)?",
        "Are you sure?",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes
      )
      {
        int[] userIds = new int[selectedUsers.Count];

        for (int i = 0; i < selectedUsers.Count; i++)
        {
          var userId = selectedUsers[i].Cells[0].Value.ToString();
          userIds[i] = int.Parse(userId);
        }

        if (this.userServices.DeleteUsers(userIds))
        {
          this.LoadUsers();
        }
      }
    }
  }
}
