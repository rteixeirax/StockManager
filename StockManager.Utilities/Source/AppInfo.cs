namespace StockManager.Utilities.Source {
  public static class AppInfo {
    public static string Title = "Stock Manager";
    public static string Version = "v.0.0.1";
    public static string DevName = "Ricardo Teixeira";
    public static string TwitterUrl = "https://twitter.com/ricardotx86";

    public static string GetViewTitle(string viewName) {
      return $"{Title} | {viewName}";
    }
  }
}
