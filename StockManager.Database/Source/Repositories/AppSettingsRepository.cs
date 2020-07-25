
using StockManager.Core.Source.Models;
using StockManager.Core.Source.Repositories;

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
