using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using StockManager.Services.Contracts;
using StockManager.Services.Services;
using StockManager.Storage;
using StockManager.Storage.Repositories;

namespace StockManager.Tests {
  public class Configuration {
    private readonly SqliteConnection connection;
    private readonly StorageContext StorageContext;

    public Configuration() {
      // Set the Sqlite in memory database connection
      this.connection = new SqliteConnection(Constants.connectionStringTestDB);

      // Open database connection 
      this.connection.Open();

      // Set the options builder for our test storage context
      var builder = new DbContextOptionsBuilder<StorageContext>();
      builder.UseSqlite(connection);

      // Instantiate our test storage context
      this.StorageContext = new StorageContext(builder.Options);
    }

    public IUserService SetUserService() => new UserService(new UserRepository(this.StorageContext));
    public IProductService SetProductService() => new ProductService(new ProductRepository(this.StorageContext));
    public IRoleService SetRoleService() => new RoleService(new RoleRepository(this.StorageContext));

    public StorageContext GetStorageContext() => this.StorageContext;
    public void CloseConnection() => this.connection.Close();
  }
}
