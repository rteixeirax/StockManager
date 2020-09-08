using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using StockManager.Core.Source;
using StockManager.Core.Source.Models;
using StockManager.Core.Source.Types;
using StockManager.Services.Source;
using StockManager.Source.Components;
using StockManager.Translations.Source;

namespace StockManager.Source.UserControls
{
    public partial class SettingsUc : UserControl
    {
        private AppSettings _appSettings;
        private bool _flagIsRestartRequired;

        public SettingsUc()
        {
            InitializeComponent();

            _flagIsRestartRequired = false;

            SetTranslatedPhrases();
            LoadSettingsAsync().Wait();

        }

        private void SetTranslatedPhrases()
        {
            btnSave.Text = Phrases.GlobalSave;
            btnCancel.Text = Phrases.GlobalCancel;

            lbLanguage.Text = Phrases.GlobalLanguage;
            lbLanguageWarning.Text = "Restart is required to take effect"; // TODO: add phrase

            lbDefaultGlobalMinStock.Text = "Default global min stock"; // TODO: add phrase
        }

        private async Task LoadSettingsAsync()
        {
            Spinner.InitSpinner();

            _appSettings = await AppServices.AppSettingsService.GetAppSettingsAsync();

            // Populate the language combo
            cbLanguage.DataSource = AppConstants.AppLanguages;
            cbLanguage.ValueMember = "Code";
            cbLanguage.DisplayMember = "Name";
            cbLanguage.SelectedItem = AppConstants.AppLanguages.FirstOrDefault(x => x.Code == _appSettings.Language);
            lbLanguageWarning.Visible = false;

            numDefaultGlobalMinStock.Value = 0; // TODO: change this

            Spinner.StopSpinner();
        }

        private void cbLanguage_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string selectedLanguage = cbLanguage.SelectedValue.ToString();
            bool hasChange = (selectedLanguage != _appSettings.Language);

            // Show label to alert the user that app restart is needed for the changes take effect.
            lbLanguageWarning.Visible = hasChange;
            _flagIsRestartRequired = hasChange;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Spinner.InitSpinner();

                AppSettings appSettings = new AppSettings
                {
                    AppSettingsId = _appSettings.AppSettingsId,
                    Language = cbLanguage.SelectedValue.ToString()
                };

                await AppServices.AppSettingsService.UpdateAppSettingsAsync(appSettings);

                Spinner.StopSpinner();

                // Show msg box to the user asking if he want to restart de app for the changes take effect
                if (_flagIsRestartRequired && MessageBox.Show(
                    "Restart now?",
                    "Apply changes",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes
                )
                {
                    Application.Restart();
                    Environment.Exit(0);
                }
                else if (!_flagIsRestartRequired)
                {
                    // Reload the settings
                    await LoadSettingsAsync();

                    // Show success msg box
                    MessageBox.Show(
                      "Settings updated", // TODO: Add phrase
                      "Success",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Information
                    );
                }
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

        private async void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "Are you sure?", // TODO: Add phrase
                "Drop changes",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes
            )
            {
                await LoadSettingsAsync();
            }
        }
    }
}
