using System.Windows.Forms;

namespace StockManager {
  public static class Spinner {
    /// <summary>
    /// Init the loading spinner
    /// </summary>
    public static void InitSpinner() { Cursor.Current = Cursors.WaitCursor; }

    /// <summary>
    /// Stop the loading spinner
    /// </summary>
    public static void StopSpinner() { Cursor.Current = Cursors.Default; }
  }
}
