using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using StockManager.Storage;

namespace StockManager.Tests {
  public class StorageConfiguration {
    private SqliteConnection connection = new SqliteConnection("DataSource=:memory:");
    public readonly StorageContext StorageContext;

    public StorageConfiguration() {
      // Open database connection
      this.connection.Open();

      var options = new DbContextOptionsBuilder<StorageContext>()
        .UseSqlite(connection)
        .Options;

      this.StorageContext = new StorageContext(options);
    }

    /// <summary>
    /// Close database connection
    /// </summary>
    ~StorageConfiguration() {
      this.connection.Close();
    }
  }
}
