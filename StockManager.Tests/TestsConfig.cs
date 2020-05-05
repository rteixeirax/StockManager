using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using StockManager.Services;
using StockManager.Storage;
using StockManager.Utilities.Source;

namespace StockManager.Tests {
  public class TestsConfig {
    private readonly SqliteConnection connection;
    private readonly StorageContext StorageContext;

    public TestsConfig() {
      // Set the Sqlite in memory database connection
      this.connection = new SqliteConnection(AppConstants.connectionStringTestDB);

      // Open database connection 
      this.connection.Open();

      // Set the options builder for our test storage context
      var builder = new DbContextOptionsBuilder<StorageContext>();
      builder.UseSqlite(connection);

      // Instantiate our test storage context
      this.StorageContext = new StorageContext(builder.Options);

      // Instantiate our services
      AppServices.ConfigureServices(StorageContext);
    }

    /// <summary> 
    /// Get the test storage context 
    /// </summary> 
    /// <returns>StorageContext</returns>
    public StorageContext GetStorageContext() => this.StorageContext;

    /// <summary> 
    ///  Close storage connection
    /// </summary> 
    public void CloseConnection() => this.connection.Close();
  }
}
