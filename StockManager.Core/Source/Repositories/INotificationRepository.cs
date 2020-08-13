
using System.Collections.Generic;
using System.Threading.Tasks;

using StockManager.Core.Source.Models;

namespace StockManager.Core.Source.Repositories
{
    public interface INotificationRepository : IBaseRepository<Notification>
    {
        Task<IEnumerable<Notification>> GetAllWithProductLocationAsync();
    }
}
