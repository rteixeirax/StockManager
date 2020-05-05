using StockManager.Components;
using StockManager.Forms;
using StockManager.Services;
using StockManager.Storage.Models;
using StockManager.Translations.Source;
using StockManager.Types.Types;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace StockManager.UserControls {
  public partial class LoginUserControl : UserControl {
    private readonly MainForm mainForm;

    public LoginUserControl(MainForm mainForm) {
      InitializeComponent();
      this.mainForm = mainForm;

      // hide the error labels
      lbErrorGeneric.Visible = false;
      lbErrorUsername.Visible = false;
      lbErrorPassword.Visible = false;
      this.SetTranslatedPhrases();
    }

    /// <summary>
    /// Set the content string for the correct app language
    /// </summary>
    private void SetTranslatedPhrases() {
      lbLoginFormTitle.Text = Phrases.LoginFormTitle;
      lbFirstName.Text = Phrases.GlobalUsername;
      lbPassword.Text = Phrases.GlobalPassword;
      btnClean.Text = Phrases.GlobalClean;
      btnLogin.Text = Phrases.LoginLogin;
    }

    /// <summary>
    /// Set the form errors
    /// </summary>
    private void SetFormErrors(List<ErrorType> errors) {
      lbErrorGeneric.Visible = false;
      lbErrorUsername.Visible = false;
      lbErrorPassword.Visible = false;

      foreach (var err in errors) {
        if (err.Field == "Generic") {
          lbErrorGeneric.Text = err.Error;
          lbErrorGeneric.Visible = true;
        }

        if (err.Field == "Username") {
          lbErrorUsername.Text = err.Error;
          lbErrorUsername.Visible = true;
        }

        if (err.Field == "Password") {
          lbErrorPassword.Text = err.Error;
          lbErrorPassword.Visible = true;
        }
      }
    }

    /// <summary>
    /// Clean all the form content
    /// </summary>
    private void btnClean_Click(object sender, EventArgs e) {
      lbErrorUsername.Visible = false;
      lbErrorPassword.Visible = false;
      tbUsername.Text = "";
      tbPassword.Text = "";
    }

    /// <summary>
    /// Login button click
    /// </summary>
    private async void btnLogin_Click(object sender, EventArgs e) {
      try {
        Spinner.InitSpinner();

        User user = await AppServices.UserService
          .AuthenticateAsync(tbUsername.Text, tbPassword.Text);

        Spinner.StopSpinner();

        Program.SetLoggedInUser(user);
        mainForm.SetUi();
      } catch (OperationErrorException ex) {
        this.SetFormErrors(ex.Errors);
      }
    }

    /// <summary>
    /// Call Login button click when pressed enter in the password textbox
    /// </summary>
    private void tbPassword_KeyPress(object sender, KeyPressEventArgs e) {
      if (e.KeyChar == (char)Keys.Enter) {
        this.btnLogin_Click(sender, e);
        // Remove the annoying beep
        e.Handled = true;
      }
    }
  }
}
