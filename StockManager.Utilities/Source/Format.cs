using System;

namespace StockManager.Utilities.Source
{
  /// <summary>
  /// Static class used to keep all app formats in sync
  /// </summary>
  public static class Format
  {
    /// <summary>
    /// Format the given DateTime and return the string
    /// </summary>
    public static string DateTimeFormat(DateTime? date)
    {
      return date?.ToString("dd MMM yyyy, HH:mm:ss");
    }
  }
}
