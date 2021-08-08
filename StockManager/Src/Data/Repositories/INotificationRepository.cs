using System.Collections.Generic;
using System.Threading.Tasks;

using StockManager.Src.Data.Entities;

namespace StockManager.Src.Data.Repositories
{
    public interface INotificationRepository : IBaseRepository<Notification>
    {
        Task<IEnumerable<Notification>> GetAllWithProductLocationAsync();
    }
}
