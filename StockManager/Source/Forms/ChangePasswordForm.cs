using System;
using System.Collections.Generic;
using System.Windows.Forms;

using StockManager.Core.Source;
using StockManager.Core.Source.Types;
using StockManager.Services.Source;
using StockManager.Source.Components;
using StockManager.Translations.Source;

namespace StockManager.Source.Forms
{
    public partial class ChangePasswordForm : Form
    {
        public ChangePasswordForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Show the Change Password Form and set the initial values
        /// </summary>
        public void ShowChangePasswordForm()
        {
            // hide the error labels
            lbErrorCurrentPassword.Visible = false;
            lbErrorNewPassword.Visible = false;
            SetTranslatedPhrases();

            ShowDialog();
        }

        /// <summary>
        /// Close button click
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Update button click
        /// </summary>
        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Spinner.InitSpinner();

                await AppServices.UserService.ChangePasswordAsync(
                  Program.LoggedInUser.UserId,
                  tbCurrentPassword.Text,
                  tbNewPassword.Text
                );

                Spinner.StopSpinner();
                btnCancel_Click(sender, e);
            }
            catch (OperationErrorException ex)
            {
                Spinner.StopSpinner();
                SetFormErrors(ex.Errors);
            }
        }

        /// <summary>
        /// Show form errors
        /// </summary>
        private void SetFormErrors(List<ErrorType> errors)
        {
            lbErrorCurrentPassword.Visible = false;
            lbErrorNewPassword.Visible = false;

            foreach (ErrorType err in errors)
            {
                if (err.Field == "CurrentPassword")
                {
                    lbErrorCurrentPassword.Text = err.Error;
                    lbErrorCurrentPassword.Visible = true;
                }

                if (err.Field == "NewPassword")
                {
                    lbErrorNewPassword.Text = err.Error;
                    lbErrorNewPassword.Visible = true;
                }
            }
        }

        /// <summary>
        /// Set the content string for the correct app language
        /// </summary>
        private void SetTranslatedPhrases()
        {
            Text = AppConstants.GetViewTitle(Phrases.UserChangePassword);
            lbTitle.Text = Phrases.UserChangePassword;
            lbCurrentPassword.Text = Phrases.UserCurrentPassword;
            lbNewPassword.Text = Phrases.UserNewPassword;
            btnCancel.Text = Phrases.GlobalCancel;
            btnSave.Text = Phrases.GlobalSave;
        }
    }
}
