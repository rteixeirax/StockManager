
using StockManager.Database.Source.Models;

namespace StockManager.Database.Source.Contracts
{
    public interface IAppSettingsRepository : IBaseRepository<AppSettings>
    {
        // We only need a method that already exists in the BaseRepository
    }
}
