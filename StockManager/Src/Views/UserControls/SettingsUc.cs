using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using StockManager.Src.Data.Entities;
using StockManager.Src.Models;
using StockManager.Src.Services;
using StockManager.Src.Translations;
using StockManager.Src.Views.Components;

namespace StockManager.Src.Views.UserControls
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

        private async void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                Phrases.GlobalDialogDeleteTitle,
                Phrases.AppSettingsDialogCancelChangesTitle,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes
            )
            {
                // Reset the flag
                _flagIsRestartRequired = false;

                await LoadSettingsAsync();
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Spinner.InitSpinner();

                AppSettings appSettings = new AppSettings
                {
                    AppSettingsId = _appSettings.AppSettingsId,
                    DocumentsFolder = cbDocumentsFolder.SelectedValue.ToString(),
                    Language = cbLanguage.SelectedValue.ToString(),
                    DefaultGlobalMinStock = float.Parse(numDefaultGlobalMinStock.Value.ToString())
                };

                await AppServices.AppSettingsService.UpdateAppSettingsAsync(appSettings);

                Spinner.StopSpinner();

                if (_flagIsRestartRequired)
                {
                    // Show msg box to the user asking if he want to restart de app for the changes take effect
                    if (MessageBox.Show(
                        Phrases.AppSettingsDialogRestartBody,
                        Phrases.AppSettingsDialogRestartTitle,
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes
                    )
                    {
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }

                // Reload the settings
                await LoadSettingsAsync();

                // Show success msg box
                MessageBox.Show(
                 Phrases.AppSettingsDialogSuccessBody,
                  Phrases.AppSettingsDialogSuccessTitle,
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Information
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

        private void cbDocumentsFolder_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DocumentsFolder selectedFolder = ( DocumentsFolder )cbDocumentsFolder.SelectedItem;
            lbDocumentsFolderPath.Text = $"*{AppConstants.DocumentsFolders.FirstOrDefault(x => x.Code == selectedFolder.Code).Path}";
        }

        private void cbLanguage_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string selectedLanguage = cbLanguage.SelectedValue.ToString();
            _flagIsRestartRequired = (selectedLanguage != _appSettings.Language);
        }

        private void linklbPoweredBy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(AppConstants.TwitterUrl);
        }

        private void linklbStockManager_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(AppConstants.AppReleaseUrl);
        }

        private async Task LoadSettingsAsync()
        {
            Spinner.InitSpinner();

            _appSettings = await AppServices.AppSettingsService.GetAppSettingsAsync();

            // Populate the export documents folder combo
            DocumentsFolder documentFolder = AppConstants.DocumentsFolders
                .FirstOrDefault(x => x.Code == _appSettings.DocumentsFolder);

            cbDocumentsFolder.DataSource = AppConstants.DocumentsFolders;
            cbDocumentsFolder.ValueMember = "Code";
            cbDocumentsFolder.DisplayMember = "Name";
            cbDocumentsFolder.SelectedItem = documentFolder;
            lbDocumentsFolderPath.Text = $"*{documentFolder.Path}";

            // Populate the language combo
            cbLanguage.DataSource = AppConstants.AppLanguages;
            cbLanguage.ValueMember = "Code";
            cbLanguage.DisplayMember = "Name";
            cbLanguage.SelectedItem = AppConstants.AppLanguages.FirstOrDefault(x => x.Code == _appSettings.Language);

            // Global default min stock
            numDefaultGlobalMinStock.Value = ( decimal )_appSettings.DefaultGlobalMinStock;

            Spinner.StopSpinner();
        }

        private void SetTranslatedPhrases()
        {
            linklbStockManager.Text = $"{AppConstants.AppName} {AppConstants.AppVersion}";
            linklbPoweredBy.Text = $"{Phrases.GlobalPoweredBy} {AppConstants.DevName}";

            btnSave.Text = Phrases.GlobalSave;
            btnCancel.Text = Phrases.GlobalCancel;

            lbDocumentsFolder.Text = Phrases.AppSettingsDocumentsFolder;

            lbLanguage.Text = Phrases.GlobalLanguage;
            lbLanguageWarning.Text = $"*{Phrases.AppSettingRestartRequired}";

            lbDefaultGlobalMinStock.Text = Phrases.AppSettingsDefaultGlobalMinStock;
            lbDefaultGlobalMinStockWarning.Text = $"*{Phrases.AppSettingsOnlyAppliedToNewProducts}";
        }
    }
}
