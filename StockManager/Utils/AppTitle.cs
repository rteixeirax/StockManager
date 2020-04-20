namespace StockManager.Utils {
  public static class AppTitle {
    public static string Title = "Stock Manager";

    public static string GetViewTitle(string viewName) {
      return $"{Title} | {viewName}";
    }
  }
}
