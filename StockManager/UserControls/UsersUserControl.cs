using StockManager.Forms;
using StockManager.Storage.Models;
using StockManager.Types;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManager.UserControls {
  public partial class UsersUserControl : UserControl {
    public UsersUserControl() {
      InitializeComponent();

      // Hide the X button on the search textbox
      btnClearSearchValue.Visible = false;
      this.LoadUsersAsync().Wait();
    }

    /// <summary>  
    /// Init the loading spinner  
    /// </summary>  
    private void InitSpinner() { Cursor.Current = Cursors.WaitCursor; }
    /// <summary>  
    /// Stop the loading spinner  
    /// </summary>  
    private void StopSpinner() { Cursor.Current = Cursors.Default; }

    /// <summary>
    /// Fill the Data Grid View
    /// </summary>
    public async Task LoadUsersAsync(string searchValue = null) {
      this.InitSpinner();
      dgvUsers.Rows.Clear();

      IEnumerable<User> users = await Program.UserService.GetUsersAsync(searchValue);

      foreach (User user in users) {
        dgvUsers.Rows.Add(
          user.UserId,
          user.Username,
          user.Role.Code,
          user.LastLogin?.ToString("MM/dd/yyyy HH:mm:ss"),
          user.CreatedAt?.ToString("MM/dd/yyyy HH:mm:ss")
        );
      }

      this.StopSpinner();
    }

    /// <summary>
    /// Create user button click
    /// </summary>
    private async void btnCreateUser_Click(object sender, EventArgs e) {
      UserForm userForm = new UserForm(this);
      await userForm.ShowUserFormAsync();
    }

    /// <summary>
    /// Edit user button click
    /// </summary>
    private async void btnEditUser_Click(object sender, EventArgs e) {
      if (dgvUsers.SelectedRows.Count > 0) {
        this.InitSpinner();

        User user = await Program.UserService
          .GetUserByIdAsync(int.Parse(dgvUsers.SelectedRows[0].Cells[0].Value.ToString()));

        this.StopSpinner();

        UserForm userForm = new UserForm(this);
        await userForm.ShowUserFormAsync(user);
      }
    }

    /// <summary>
    /// Delete user button click
    /// </summary>
    private async void btnDeleteUser_Click(object sender, EventArgs e) {
      DataGridViewSelectedRowCollection selectedUsers = dgvUsers.SelectedRows;

      if ((selectedUsers.Count > 0)
        && MessageBox.Show(
        $"Delete {selectedUsers.Count} user(s)?",
        "Are you sure?",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes
      ) {
        try {
          this.InitSpinner();

          int[] userIds = new int[selectedUsers.Count];

          for (int i = 0; i < selectedUsers.Count; i++) {
            userIds[i] = int.Parse(selectedUsers[i].Cells[0].Value.ToString());
          }

          await Program.UserService.DeleteUserAsync(userIds, Program.LoggedInUser.UserId);

          this.StopSpinner();
          await this.LoadUsersAsync();
        } catch (OperationErrorException ex) {
          this.StopSpinner();

          MessageBox.Show(
          $"{ex.Errors[0].Error}",
          "Operation error",
          MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
      }
    }

    /// <summary>
    /// Search button click
    /// </summary>
    private async void pbSearchIcon_Click(object sender, EventArgs e) {
      string searchValue = tbSeachText.Text;

      if (!string.IsNullOrEmpty(searchValue)) {
        await this.LoadUsersAsync(searchValue);
      }
    }

    /// <summary>
    /// Clear search value picture box click
    /// </summary>
    private async void btnClearSearchValue_Click(object sender, EventArgs e) {
      tbSeachText.Text = "";
      await this.LoadUsersAsync();
    }

    /// <summary>
    /// Call search button click when pressed enter in the textbox
    /// </summary>
    private void tbSeachText_KeyPress(object sender, KeyPressEventArgs e) {
      if (e.KeyChar == (char)Keys.Enter) {
        this.pbSearchIcon_Click(sender, e);
        // Remove the annoying beep
        e.Handled = true;
      } else if (e.KeyChar == (char)Keys.Escape) {
        this.btnClearSearchValue_Click(sender, e);
        // Remove the annoying beep
        e.Handled = true;
      }
    }

    /// <summary>
    /// Show/Hide the X button on the search textbox
    /// </summary>
    private void tbSeachText_TextChanged(object sender, EventArgs e) {
      btnClearSearchValue.Visible = (tbSeachText.Text.Length > 0);
    }
  }
}
