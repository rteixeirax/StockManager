using System.Collections.Generic;
using System.Threading.Tasks;

using StockManager.Core.Source.Models;

namespace StockManager.Core.Source.Services
{
    public interface INotificationService
    {
        /// <summary>
        /// Create a notification for the given product location id
        /// </summary>
        Task CreateAsync(int productLocationId);

        /// <summary>
        /// Get all notifications
        /// </summary>
        Task<IEnumerable<Notification>> GetAllAsync();

        /// <summary>
        /// Get notification by id
        /// </summary>
        Task<Notification> GetByIdAsync(int id);

        /// <summary>
        /// Get notification for the given product location id
        /// </summary>
        Task<Notification> GetByProductLocationIdAsync(int productLocationId);

        /// <summary>
        /// Remove the notification
        /// </summary>
        Task RemoveAsync(int id);
    }
}
