using StockManager.Src.Data.Entities;

namespace StockManager.Src.Data.Repositories
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
