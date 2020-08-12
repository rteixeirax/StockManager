
using StockManager.Core.Source.Models;
using StockManager.Core.Source.Repositories;

namespace StockManager.Database.Source.Repositories
{
    public class NotificationRepository : BaseRepository<Notification>, INotificationRepository
    {
        private readonly DatabaseContext _db;

        public NotificationRepository(DatabaseContext db) : base(db)
        {
            _db = db;
        }
    }
}
