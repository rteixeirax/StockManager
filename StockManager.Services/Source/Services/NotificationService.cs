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

        public async Task CreateAsync(int productLocationId)
        {
            await _repository.Notifications
                .AddAsync(new Notification() { ProductLocationId = productLocationId });

            await _repository.SaveChangesAsync();
        }

        public async Task<IEnumerable<Notification>> GetAllAsync()
        {
            return await _repository.Notifications.GetAllAsync();
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
    }
}
