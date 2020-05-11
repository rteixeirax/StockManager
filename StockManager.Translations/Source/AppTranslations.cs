using System.Globalization;
using System.Threading;

namespace StockManager.Translations.Source {
  public static class AppTranslations {
    public static void ConfigureLanguage(string appLanguageCode) {
      try {
        // Set the app language.
        // If the language code is invalid the default language (EN) is set instead.
        Thread.CurrentThread.CurrentUICulture = new CultureInfo(appLanguageCode);
      } catch {
        // Set default app default language (EN)
        Thread.CurrentThread.CurrentUICulture = new CultureInfo("");
      }
    }
  }
}
