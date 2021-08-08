using StockManager.Src.Data.Entities;

namespace StockManager.Src.Data.Repositories
{
    public interface IAppSettingsRepository : IBaseRepository<AppSettings>
    {
        // We only need a method that already exists in the BaseRepository
    }
}
