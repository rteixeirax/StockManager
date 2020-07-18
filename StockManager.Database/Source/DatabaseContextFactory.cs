using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

using StockManager.Utilities.Source;

namespace StockManager.Database.Source
{
    internal class DatabaseContextFactory : IDesignTimeDbContextFactory<DatabaseContext>
    {
        /// <summary>
        /// https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.design.idesigntimedbcontextfactory-1?view=efcore-3.1
        /// This is only used by the design time tooling CLI i.e Migrations
        /// </summary>
        public DatabaseContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<DatabaseContext> builder = new DbContextOptionsBuilder<DatabaseContext>();
            builder.UseSqlite(AppConstants.connectionString);

            //Console.WriteLine(connectionString);
            return new DatabaseContext(builder.Options);
        }
    }
}
