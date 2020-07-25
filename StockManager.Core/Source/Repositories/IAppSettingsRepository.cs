
using StockManager.Core.Source.Models;

namespace StockManager.Core.Source.Repositories
{
    public interface IAppSettingsRepository : IBaseRepository<AppSettings>
    {
        // We only need a method that already exists in the BaseRepository
    }
}
