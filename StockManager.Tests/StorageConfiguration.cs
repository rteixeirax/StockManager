using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using StockManager.Storage;

namespace StockManager.Tests {
  public class StorageConfiguration {
    private SqliteConnection connection = new SqliteConnection("DataSource=:memory:");
    public readonly StorageContext StorageContext;

    public StorageConfiguration() {
      DbContextOptionsBuilder<StorageContext> builder = new DbContextOptionsBuilder<StorageContext>();
      builder.UseSqlite("DataSource=:memory:");

      this.StorageContext = new StorageContext(builder.Options);
      //this.StorageContext.Database.Migrate();

      // Open database connection
      //this.connection.Open();

      //var options = new DbContextOptionsBuilder<StorageContext>()
      //  .UseSqlite(connection)
      //  .Options;

      //this.StorageContext = new StorageContext(options);
    }

    /// <summary>
    /// Close database connection
    /// </summary>
    //~StorageConfiguration() {
    //  this.connection.Close();
    //}
  }
}
