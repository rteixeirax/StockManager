
using StockManager.Database.Source.Contracts;
using StockManager.Database.Source.Models;

namespace StockManager.Database.Source.Repositories
{
    public class AppSettingsRepository : BaseRepository<AppSettings>, IAppSettingsRepository
    {
        private readonly DatabaseContext _db;

        public AppSettingsRepository(DatabaseContext db) : base(db)
        {
            _db = db;
        }
    }
}
