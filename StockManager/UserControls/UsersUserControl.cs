using StockManager.Components;
using StockManager.Forms;
using StockManager.Services;
using StockManager.Storage.Models;
using StockManager.Translations.Source;
using StockManager.Types.Types;
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

      this.SetTranslatedPhrases();
      this.LoadUsersAsync().Wait();
    }

    /// <summary>
    /// Set the content strings for the correct app language
    /// </summary>
    private void SetTranslatedPhrases() {
      btnCreateUser.Text = Phrases.GlobalCreate;
      btnEditUser.Text = Phrases.GlobalEdit;
      btnDeleteUser.Text = Phrases.GlobalDelete;
      dgvUsers.Columns[1].HeaderText = Phrases.GlobalUsername;
      dgvUsers.Columns[2].HeaderText = Phrases.UserRole;
      dgvUsers.Columns[3].HeaderText = Phrases.UserLastLogin;
      dgvUsers.Columns[4].HeaderText = Phrases.GlobalCreatedAt;
    }

    /// <summary>
    /// Fill the Data Grid View
    /// </summary>
    public async Task LoadUsersAsync(string searchValue = null) {
      Spinner.InitSpinner();
      dgvUsers.Rows.Clear();

      IEnumerable<User> users = await AppServices.UserService.GetUsersAsync(searchValue);

      foreach (User user in users) {
        dgvUsers.Rows.Add(
          user.UserId,
          user.Username,
          user.Role.Code,
          user.LastLogin?.ToString("MM/dd/yyyy HH:mm:ss"),
          user.CreatedAt?.ToString("MM/dd/yyyy HH:mm:ss")
        );
      }

      Spinner.StopSpinner();
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
        Spinner.InitSpinner();

        User user = await AppServices.UserService
          .GetUserByIdAsync(int.Parse(dgvUsers.SelectedRows[0].Cells[0].Value.ToString()));

        Spinner.StopSpinner();

        UserForm userForm = new UserForm(this);
        await userForm.ShowUserFormAsync(user);
      }
    }

    /// <summary>
    /// Delete user button click
    /// </summary>
    private async void btnDeleteUser_Click(object sender, EventArgs e) {
      DataGridViewSelectedRowCollection selectedUsers = dgvUsers.SelectedRows;

      if ((selectedUsers.Count > 0) && MessageBox.Show(
        string.Format(Phrases.UserDialogDeleteBody, selectedUsers.Count),
        Phrases.GlobalDialogDeleteTitle,
        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes
      ) {
        try {
          Spinner.InitSpinner();

          int[] userIds = new int[selectedUsers.Count];

          for (int i = 0; i < selectedUsers.Count; i++) {
            userIds[i] = int.Parse(selectedUsers[i].Cells[0].Value.ToString());
          }

          await AppServices.UserService.DeleteUserAsync(userIds, Program.LoggedInUser.UserId);

          Spinner.StopSpinner();
          await this.LoadUsersAsync();

        } catch (OperationErrorException ex) {
          Spinner.StopSpinner();

          MessageBox.Show(
            $"{ex.Errors[0].Error}",
            Phrases.GlobalDialogWarningTitle,
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning
          );

        } catch (ServiceErrorException ex) {
          Spinner.StopSpinner();

          MessageBox.Show(
            $"{ex.Errors[0].Error}",
            Phrases.GlobalDialogErrorTitle,
            MessageBoxButtons.OK,
            MessageBoxIcon.Error
          );
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
