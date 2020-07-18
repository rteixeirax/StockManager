using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

using StockManager.Database.Source;
using StockManager.Services.Source;
using StockManager.Utilities.Source;

namespace StockManager.Tests.Source
{
    public class TestsConfig
    {
        private readonly SqliteConnection _connection;
        private readonly DatabaseContext _databaseContext;

        public TestsConfig()
        {
            // Set the Sqlite in memory database connection
            _connection = new SqliteConnection(AppConstants.connectionStringTestDB);

            // Open database connection
            _connection.Open();

            // Set the options builder for our test database context
            DbContextOptionsBuilder<DatabaseContext> builder = new DbContextOptionsBuilder<DatabaseContext>();
            builder.UseSqlite(_connection);

            // Instantiate our test database context
            _databaseContext = new DatabaseContext(builder.Options);

            // Instantiate our services
            AppServices.ConfigureServices(_databaseContext);
        }

        /// <summary>
        /// Close database connection
        /// </summary>
        public void CloseConnection()
        {
            _connection.Close();
        }

        /// <summary>
        /// Get the test database context
        /// </summary>
        /// <returns>DatabaseContext</returns>
        public DatabaseContext GetDatabaseContext()
        {
            return _databaseContext;
        }
    }
}
