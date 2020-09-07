using System.Threading.Tasks;
using System.Windows.Forms;

using StockManager.Core.Source;
using StockManager.Services.Source;
using StockManager.Source.Components;
using StockManager.Translations.Source;

namespace StockManager.Source.UserControls
{
    public partial class SettingsUc : UserControl
    {
        public SettingsUc()
        {
            InitializeComponent();
            SetTranslatedPhrases();
            LoadSettingsAsync().Wait();
        }

        private void SetTranslatedPhrases()
        {
            lbLanguage.Text = Phrases.GlobalLanguage;
        }

        private async Task LoadSettingsAsync()
        {
            Spinner.InitSpinner();

            // Populate the language combo
            cbLanguage.DataSource = AppConstants.AppLanguages;
            cbLanguage.ValueMember = "Code";
            cbLanguage.DisplayMember = "Name";
            cbLanguage.SelectedItem = await AppServices.AppSettingsService.GetAppLanguageAsync();

            Spinner.StopSpinner();
        }
    }
}
