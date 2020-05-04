using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace StockManager.Storage {
  class StorageContextFactory : IDesignTimeDbContextFactory<StorageContext> {
    /// <summary>
    /// https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.design.idesigntimedbcontextfactory-1?view=efcore-3.1
    /// This is only used by the design time tooling CLI
    /// i.e Migrations
    /// </summary>
    public StorageContext CreateDbContext(string[] args) {
      var builder = new DbContextOptionsBuilder<StorageContext>();
      builder.UseSqlite(Constants.connectionString);

      //Console.WriteLine(connectionString);
      return new StorageContext(builder.Options);
    }
  }
}
