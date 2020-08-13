using System.Collections.Generic;
using System.Threading.Tasks;

using StockManager.Core.Source;
using StockManager.Core.Source.Models;
using StockManager.Core.Source.Services;

namespace StockManager.Services.Source.Services
{
    public class NotificationService : INotificationService
    {
        private readonly IAppRepository _repository;

        public NotificationService(IAppRepository repository)
        {
            _repository = repository;
        }

        public async Task CreateAsync(int productLocationId, bool applyDbChanges = true)
        {
            await _repository.Notifications
                .AddAsync(new Notification() { ProductLocationId = productLocationId });

            if (applyDbChanges)
            {
                await _repository.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Notification>> GetAllAsync()
        {
            return await _repository.Notifications.GetAllWithProductLocationAsync();
        }

        public async Task<Notification> GetByIdAsync(int id)
        {
            return await _repository.Notifications.GetByIdAsync(id);
        }

        public async Task<Notification> GetByProductLocationIdAsync(int productLocationId)
        {
            return await _repository.Notifications
                .FindOneAsync(x => x.ProductLocationId == productLocationId);
        }

        public async Task RemoveAsync(int id)
        {
            Notification notification = await _repository.Notifications.GetByIdAsync(id);
            _repository.Notifications.Remove(notification);
            await _repository.SaveChangesAsync();
        }

        public async Task ToggleStockAlertsAsync(ProductLocation plocation, float newStock)
        {
            Notification notification = await GetByProductLocationIdAsync(plocation.ProductLocationId);

            // If there is a notification for that productLocationId
            // and the new acc stock is greater than the min stock, we remove the existing notification.
            if ((notification != null) && (newStock > plocation.MinStock))
            {
                await RemoveAsync(notification.NotificationId);
            }
            else if ((notification == null) && (newStock <= plocation.MinStock))
            {
                // If no notification but the new acc stock is less or equal than the min stock,
                // we need to create a new notification to alert the admin
                await CreateAsync(plocation.ProductLocationId);
            }
        }
    }
}
