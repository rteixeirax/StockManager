using Microsoft.EntityFrameworkCore;
using StockManager.Database.Source;
using StockManager.Database.Source.Models;
using StockManager.Services.Source;
using StockManager.Source.Forms;
using StockManager.Translations.Source;
using StockManager.Utilities.Source;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManager.Source
{
    internal static class Program
    {
        /// <summary>
        /// Logged in user
        /// </summary>
        public static User LoggedInUser { get; private set; }

        /// <summary>
        /// Kill the "Session"
        /// </summary>
        public static void Logout()
        {
            LoggedInUser = null;
        }

        /// <summary>
        /// Set the user after authentication
        /// </summary>
        public static void SetLoggedInUser(User user)
        {
            LoggedInUser = user;
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static async Task Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Set the options builder for our database context
            var builder = new DbContextOptionsBuilder<DatabaseContext>();
            builder.UseSqlite(AppConstants.connectionString);

            // Instantiate our database
            DatabaseContext DatabaseContext = new DatabaseContext(builder.Options);

            // Instantiate our services
            AppServices.ConfigureServices(DatabaseContext);

            // Set the application language
            AppTranslations.ConfigureLanguage(await AppServices.SettingsService.GetAppLanguageAsync());

            Application.Run(new MainForm());
        }
    }
}
