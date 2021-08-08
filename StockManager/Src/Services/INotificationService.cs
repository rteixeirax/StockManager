using System.Collections.Generic;
using System.Threading.Tasks;

using StockManager.Src.Data.Entities;

namespace StockManager.Src.Services
{
    public interface INotificationService
    {
        /// <summary>
        /// Create a notification for the given product location id
        /// </summary>
        Task CreateAsync(int productLocationId, bool applyDbChanges = true);

        /// <summary>
        /// Create a PDF with the given data
        /// </summary>
        Task ExportNotificationsToPDFAsync(IEnumerable<Notification> notifications);

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
        /// Remove the notification with the given notification id
        /// </summary>
        Task RemoveAsync(int id);

        /// <summary>
        /// Create or remove stock alerts for the given ProductLocation
        /// </summary>
        Task ToggleStockAlertsAsync(ProductLocation plocation, float newStock);
    }
}
