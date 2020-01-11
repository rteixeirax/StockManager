using System;
using System.Collections.Generic;
using System.Windows.Forms;
using StockManager.Database.Models;
using StockManager.Forms;

namespace StockManager.UserControls
{
  public partial class UsersUserControl : UserControl
  {
    public UsersUserControl()
    {
      InitializeComponent();
      this.LoadUsers();
    }

    public void LoadUsers()
    {
      // Spinner
      Cursor.Current = Cursors.WaitCursor;

      dgvUsers.Rows.Clear();
      IEnumerable<User> users = Program.userServices.GetUsers();

      foreach (var user in users)
      {
        dgvUsers.Rows.Add(
          user.UserId,
          user.Username,
          user.Role.Code,
          user.LastLogin?.ToString("MM/dd/yyyy HH:mm:ss"),
          user.CreatedAt?.ToString("MM/dd/yyyy HH:mm:ss")
        );
      }
    }

    private void btnCreateUser_Click(object sender, EventArgs e)
    {
      UserForm userForm = new UserForm(this);
      userForm.ShowUserForm();
    }

    private void btnEditUser_Click(object sender, EventArgs e)
    {
      // Spinner
      Cursor.Current = Cursors.WaitCursor;

      User user = Program.userServices
        .GetUserById(int.Parse(dgvUsers.SelectedRows[0].Cells[0].Value.ToString()));

      UserForm userForm = new UserForm(this);
      userForm.ShowUserForm(user);
    }

    private void btnDeleteUser_Click(object sender, EventArgs e)
    {
      DataGridViewSelectedRowCollection selectedUsers = dgvUsers.SelectedRows;

      if (MessageBox.Show(
        $"Delete {selectedUsers.Count} user(s)?",
        "Are you sure?",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes
      )
      {
        // Spinner
        Cursor.Current = Cursors.WaitCursor;

        int[] userIds = new int[selectedUsers.Count];

        for (int i = 0; i < selectedUsers.Count; i++)
        {
          userIds[i] = int.Parse(selectedUsers[i].Cells[0].Value.ToString());
        }

        if (Program.userServices.DeleteUsers(userIds))
        {
          this.LoadUsers();
        }
      }
    }
  }
}
