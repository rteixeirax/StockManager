using StockManager.Database.Source.Models;
using StockManager.Services.Source;
using StockManager.Source.Components;
using StockManager.Source.Forms;
using StockManager.Translations.Source;
using StockManager.Types.Source;
using StockManager.Utilities.Source;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManager.Source.UserControls
{
  public partial class UsersUc : UserControl
  {
    private bool _hasBeenSearching = false; // Flags if the user has been searching

    public UsersUc()
    {
      InitializeComponent();

      // Hide the X button on the search textbox
      btnClearSearchValue.Visible = false;

      this.SetTranslatedPhrases();
      this.LoadUsersAsync().Wait();
    }

    /// <summary>
    /// Set the content strings for the correct app language
    /// </summary>
    private void SetTranslatedPhrases()
    {
      btnCreateUser.Text = Phrases.GlobalCreate;
      btnDeleteUser.Text = Phrases.GlobalDelete;
      dgvUsers.Columns[1].HeaderText = Phrases.GlobalUsername;
      dgvUsers.Columns[2].HeaderText = Phrases.UserRole;
      dgvUsers.Columns[3].HeaderText = Phrases.UserLastLogin;
      dgvUsers.Columns[4].HeaderText = Phrases.GlobalCreatedAt;
      // Actions
      dgvUsers.Columns[5].CellTemplate.ToolTipText = Phrases.GlobalEdit; // Action edit
      dgvUsers.Columns[6].CellTemplate.ToolTipText = Phrases.GlobalDelete; // Action delete
    }

    /// <summary>
    /// Fill the Data Grid View
    /// </summary>
    public async Task LoadUsersAsync(string searchValue = null)
    {
      Spinner.InitSpinner();
      dgvUsers.Rows.Clear();

      IEnumerable<User> users = await AppServices.UserService.GetUsersAsync(searchValue);

      foreach (User user in users)
      {
        dgvUsers.Rows.Add(
          user.UserId,
          user.Username,
          user.Role.Code,
          Format.DateTimeFormat(user.LastLogin),
          Format.DateTimeFormat(user.CreatedAt)
        );
      }

      Spinner.StopSpinner();
    }

    /// <summary>
    /// Create user button click
    /// </summary>
    private async void btnCreateUser_Click(object sender, EventArgs e)
    {
      UserForm userForm = new UserForm(this);
      await userForm.ShowUserFormAsync();
    }

    /// <summary>
    /// Delete multiple products button click
    /// </summary>
    private async void btnDeleteUser_Click(object sender, EventArgs e)
    {
      DataGridViewSelectedRowCollection selectedItems = dgvUsers.SelectedRows;

      if (selectedItems.Count > 0)
      {
        int[] arrayOfIds = new int[selectedItems.Count];

        for (int i = 0; i < selectedItems.Count; i++)
        {
          arrayOfIds[i] = int.Parse(selectedItems[i].Cells[0].Value.ToString());
        }

        await this.ActionDeleteClickAsync(arrayOfIds);
      }
    }

    /// <summary>
    /// Handle with table actions click
    /// </summary>
    private async void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
      if ((dgvUsers.SelectedRows.Count > 0) && (e.RowIndex >= 0))
      {
        int userId = int.Parse(dgvUsers.Rows[e.RowIndex].Cells[0].Value.ToString());

        switch (e.ColumnIndex)
        {
          case 5:
            await this.ActionEditClickAsync(userId);
            break;
          case 6:
            await this.ActionDeleteClickAsync(new int[] { userId });
            break;
          default:
            break;
        }
      }
    }

    /// <summary>
    /// Edit product button click
    /// </summary>
    private async Task ActionEditClickAsync(int userId)
    {
      Spinner.InitSpinner();
      User user = await AppServices.UserService.GetUserByIdAsync(userId);
      Spinner.StopSpinner();

      UserForm userForm = new UserForm(this);
      await userForm.ShowUserFormAsync(user);
    }

    /// <summary>
    /// Delete button click
    /// </summary>
    private async Task ActionDeleteClickAsync(int[] selectedIds)
    {
      if ((selectedIds.Length > 0) && MessageBox.Show(
      string.Format(Phrases.UserDialogDeleteBody, selectedIds.Length),
      Phrases.GlobalDialogDeleteTitle,
      MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes
    )
      {
        try
        {
          Spinner.InitSpinner();
          await AppServices.UserService.DeleteUserAsync(selectedIds, Program.LoggedInUser.UserId);
          Spinner.StopSpinner();

          await this.LoadUsersAsync();
        }
        catch (OperationErrorException ex)
        {
          Spinner.StopSpinner();

          MessageBox.Show(
            $"{ex.Errors[0].Error}",
            Phrases.GlobalDialogWarningTitle,
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning
          );

        }
        catch (ServiceErrorException ex)
        {
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
    private async void pbSearchIcon_Click(object sender, EventArgs e)
    {
      string searchValue = tbSeachText.Text;

      if (!string.IsNullOrEmpty(searchValue))
      {
        // sets the flag has been searching
        _hasBeenSearching = true;
        await this.LoadUsersAsync(searchValue);
      }
    }

    /// <summary>
    /// Clear search value picture box click
    /// </summary>
    private async void btnClearSearchValue_Click(object sender, EventArgs e)
    {
      tbSeachText.Text = "";
      _hasBeenSearching = false;
      await this.LoadUsersAsync();
    }

    /// <summary>
    /// Show/Hide the X button on the search textbox
    /// </summary>
    private async void tbSeachText_TextChanged(object sender, EventArgs e)
    {
      btnClearSearchValue.Visible = (tbSeachText.Text.Length > 0);

      if (tbSeachText.Text.Length > 0)
      {
        btnClearSearchValue.Visible = true;

        // If the user clear all the search box text after doing some search,
        // i need to query the DB without any search param to show all table data.
      }
      else if ((tbSeachText.Text.Length == 0) && _hasBeenSearching)
      {
        _hasBeenSearching = false;
        btnClearSearchValue.Visible = false;
        await this.LoadUsersAsync();
      }
    }

    /// <summary>
    /// Call search button click when pressed enter in the textbox
    /// </summary>
    private void tbSeachText_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (e.KeyChar == ( char )Keys.Enter)
      {
        this.pbSearchIcon_Click(sender, e);
        // Remove the annoying beep
        e.Handled = true;
      }
      else if (e.KeyChar == ( char )Keys.Escape)
      {
        this.btnClearSearchValue_Click(sender, e);
        // Remove the annoying beep
        e.Handled = true;
      }
    }
  }
}
