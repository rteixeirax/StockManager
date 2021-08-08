﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

using StockManager.Src.Data.Entities;
using StockManager.Src.Models;
using StockManager.Src.Services;
using StockManager.Src.Translations;
using StockManager.Src.Views.Components;
using StockManager.Src.Views.Forms;

namespace StockManager.Src.Views.UserControls
{
    public partial class LoginUc : UserControl
    {
        private readonly MainForm _mainForm;

        public LoginUc(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;

            // hide the error labels
            lbErrorGeneric.Visible = false;
            lbErrorUsername.Visible = false;
            lbErrorPassword.Visible = false;
            SetTranslatedPhrases();
        }

        /// <summary>
        /// Clean all the form content
        /// </summary>
        private void btnClean_Click(object sender, EventArgs e)
        {
            lbErrorUsername.Visible = false;
            lbErrorPassword.Visible = false;
            tbUsername.Text = "";
            tbPassword.Text = "";
        }

        /// <summary>
        /// Login button click
        /// </summary>
        private async void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                Spinner.InitSpinner();

                User user = await AppServices.UserService
                  .AuthenticateAsync(tbUsername.Text, tbPassword.Text);

                Spinner.StopSpinner();

                Program.SetLoggedInUser(user);
                _mainForm.SetUi();
            }
            catch (OperationErrorException ex)
            {
                SetFormErrors(ex.Errors);
            }
        }

        /// <summary>
        /// Call Login button click when pressed enter in the password textbox
        /// </summary>
        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Remove the annoying beep
                e.Handled = true;
                e.SuppressKeyPress = true;

                btnLogin.PerformClick();
            }
        }

        /// <summary>
        /// Set the form errors
        /// </summary>
        private void SetFormErrors(List<ErrorType> errors)
        {
            lbErrorGeneric.Visible = false;
            lbErrorUsername.Visible = false;
            lbErrorPassword.Visible = false;

            foreach (ErrorType err in errors)
            {
                if (err.Field == "Generic")
                {
                    lbErrorGeneric.Text = err.Error;
                    lbErrorGeneric.Visible = true;
                }

                if (err.Field == "Username")
                {
                    lbErrorUsername.Text = err.Error;
                    lbErrorUsername.Visible = true;
                }

                if (err.Field == "Password")
                {
                    lbErrorPassword.Text = err.Error;
                    lbErrorPassword.Visible = true;
                }
            }
        }

        /// <summary>
        /// Set the content string for the correct app language
        /// </summary>
        private void SetTranslatedPhrases()
        {
            lbLoginFormTitle.Text = Phrases.LoginFormTitle;
            lbFirstName.Text = Phrases.GlobalUsername;
            lbPassword.Text = Phrases.GlobalPassword;
            btnClean.Text = Phrases.GlobalClean;
            btnLogin.Text = Phrases.LoginLogin;
        }
    }
}
