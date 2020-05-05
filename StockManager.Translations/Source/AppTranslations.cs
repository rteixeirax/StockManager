using System.Globalization;
using System.Threading;

namespace StockManager.Translations.Source {
  public static class AppTranslations {
    public static void ConfigureLanguage() {
      try {
        // Set the user language.
        Thread.CurrentThread.CurrentUICulture = new CultureInfo("pt-PT");
      } catch {
        // Set default app default language (EN)
        Thread.CurrentThread.CurrentUICulture = new CultureInfo("");
      }
    }
  }
}
