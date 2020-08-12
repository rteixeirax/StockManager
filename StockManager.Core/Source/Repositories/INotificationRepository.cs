
using StockManager.Core.Source.Models;

namespace StockManager.Core.Source.Repositories
{
    public interface INotificationRepository : IBaseRepository<Notification>
    {
        // We only need a method that already exists in the BaseRepository
    }
}
