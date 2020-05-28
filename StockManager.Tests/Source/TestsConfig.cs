using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using StockManager.Services.Source;
using StockManager.Storage.Source;
using StockManager.Utilities.Source;

namespace StockManager.Tests.Source {
  public class TestsConfig {
    private readonly SqliteConnection _connection;
    private readonly DatabaseContext _storageContext;

    public TestsConfig() {
      // Set the Sqlite in memory database connection
      _connection = new SqliteConnection(AppConstants.connectionStringTestDB);

      // Open database connection
      _connection.Open();

      // Set the options builder for our test storage context
      var builder = new DbContextOptionsBuilder<DatabaseContext>();
      builder.UseSqlite(_connection);

      // Instantiate our test storage context
      _storageContext = new DatabaseContext(builder.Options);

      // Instantiate our services
      AppServices.ConfigureServices(_storageContext);
    }

    /// <summary>
    /// Get the test storage context
    /// </summary>
    /// <returns>StorageContext</returns>
    public DatabaseContext GetStorageContext() => _storageContext;

    /// <summary>
    ///  Close storage connection
    /// </summary>
    public void CloseConnection() => _connection.Close();
  }
}
