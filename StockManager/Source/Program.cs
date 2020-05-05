using Microsoft.EntityFrameworkCore;
using StockManager.Source.Forms;
using StockManager.Services.Source;
using StockManager.Storage.Source;
using StockManager.Storage.Source.Models;
using StockManager.Translations.Source;
using StockManager.Utilities.Source;
using System;
using System.Windows.Forms;

namespace StockManager.Source {
  static class Program {
    /// <summary>
    /// Logged in user
    /// </summary>
    public static User LoggedInUser { get; private set; }

    /// <summary>
    /// Set the user after authentication
    /// </summary>
    public static void SetLoggedInUser(User user) {
      LoggedInUser = user;
    }

    /// <summary>
    /// Kill the "Session"
    /// </summary>
    public static void Logout() {
      LoggedInUser = null;
    }

    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main() {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);

      // Set the options builder for our storage context
      var builder = new DbContextOptionsBuilder<StorageContext>();
      builder.UseSqlite(AppConstants.connectionString);

      // Instantiate our storage
      StorageContext StorageContext = new StorageContext(builder.Options);

      // Instantiate our services
      AppServices.ConfigureServices(StorageContext);

      // Set the application language
      AppTranslations.ConfigureLanguage();

      Application.Run(new MainForm());
    }
  }
}