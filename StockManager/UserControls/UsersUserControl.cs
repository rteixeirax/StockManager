using System;
using System.Collections.Generic;
using System.Windows.Forms;
using StockManager.Storage.Models;
using StockManager.Forms;

namespace StockManager.UserControls
{
  public partial class UsersUserControl : UserControl
  {
    public UsersUserControl()
    {
      InitializeComponent();

      // Hide the X button on the search textbox
      btnClearSearchValue.Visible = false;

      this.LoadUsers();
    }

    /// <summary>
    /// Fill the Data Grid View
    /// </summary>
    public void LoadUsers(string searchValue = null)
    {
      // Spinner
      Cursor.Current = Cursors.WaitCursor;

      dgvUsers.Rows.Clear();
      IEnumerable<User> users = Program.UserServices.GetUsers(searchValue);

      foreach (User user in users)
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

    /// <summary>
    /// Create user button click
    /// </summary>
    private async void btnCreateUser_Click(object sender, EventArgs e)
    {
      UserForm userForm = new UserForm(this);
      await userForm.ShowUserForm();
    }

    /// <summary>
    /// Edit user button click
    /// </summary>
    private async void btnEditUser_Click(object sender, EventArgs e)
    {
      if (dgvUsers.SelectedRows.Count > 0)
      {
        User user = Program.UserServices
          .GetUserById(int.Parse(dgvUsers.SelectedRows[0].Cells[0].Value.ToString()));

        UserForm userForm = new UserForm(this);
        await userForm.ShowUserForm(user);
      }
    }

    /// <summary>
    /// Delete user button click
    /// </summary>
    private void btnDeleteUser_Click(object sender, EventArgs e)
    {
      DataGridViewSelectedRowCollection selectedUsers = dgvUsers.SelectedRows;

      if ((selectedUsers.Count > 0)
        && MessageBox.Show(
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

        if (Program.UserServices.DeleteUsers(userIds, Program.LoggedInUser.UserId))
        {
          this.LoadUsers();
        }
      }
    }

    /// <summary>
    /// Search button click
    /// </summary>
    private void pbSearchIcon_Click(object sender, EventArgs e)
    {
      string searchValue = tbSeachText.Text;

      if (!string.IsNullOrEmpty(searchValue))
      {
        this.LoadUsers(searchValue);

        // Remove spinner
        Cursor.Current = Cursors.Default;
      }
    }

    /// <summary>
    /// Clear search value picture box click
    /// </summary>
    private void btnClearSearchValue_Click(object sender, EventArgs e)
    {
      tbSeachText.Text = "";
      this.LoadUsers();

      // Remove spinner
      Cursor.Current = Cursors.Default;
    }

    /// <summary>
    /// Call search button click when pressed enter in the textbox
    /// </summary>
    private void tbSeachText_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (e.KeyChar == (char)Keys.Enter)
      {
        this.pbSearchIcon_Click(sender, e);
        // Remove the annoying beep
        e.Handled = true;
      }
      else if (e.KeyChar == (char)Keys.Escape)
      {
        this.btnClearSearchValue_Click(sender, e);
        // Remove the annoying beep
        e.Handled = true;
      }
    }

    /// <summary>
    /// Show/Hide the X button on the search textbox
    /// </summary>
    private void tbSeachText_TextChanged(object sender, EventArgs e)
    {
      btnClearSearchValue.Visible = (tbSeachText.Text.Length > 0);
    }
  }
}
