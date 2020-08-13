
using System.Collections.Generic;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

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

        public async Task<IEnumerable<Notification>> GetAllWithProductLocationAsync()
        {
            return await _db.Notifications
                .AsNoTracking()
                .Include(x => x.ProductLocation).ThenInclude(x => x.Product)
                .Include(x => x.ProductLocation).ThenInclude(x => x.Location)
                .ToListAsync();
        }
    }
}
