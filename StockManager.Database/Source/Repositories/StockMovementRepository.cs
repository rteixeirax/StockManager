using Microsoft.EntityFrameworkCore;
using StockManager.Database.Source.Contracts;
using StockManager.Database.Source.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockManager.Database.Source.Repositories
{
    public class StockMovementRepository : IStockMovementRepository
    {
        private readonly DatabaseContext _db;

        public StockMovementRepository(DatabaseContext db)
        {
            _db = db;
        }

        public async Task<IEnumerable<StockMovement>> FindAllMovementsAsync(string searchValue)
        {
            return await _db.StockMovements
                     .AsNoTracking()
                     .Where(x => x.Product.Reference.ToLower().Contains(searchValue.ToLower())
                        || x.Product.Name.ToLower().Contains(searchValue.ToLower()))
                     .Include(x => x.Product)
                     .Include(x => x.User)
                     .OrderByDescending(x => x.CreatedAt)
                     .ToListAsync();
        }

        public async Task<StockMovement> FindProductLastStockMovementAsync(int productId)
        {
            return await _db.StockMovements
              .Where(x => x.ProductId == productId)
              .OrderByDescending(x => x.CreatedAt).FirstOrDefaultAsync();
        }

        public async Task<StockMovement> FindProductLocationLastStockMovementAsync(int productId, int locationId)
        {
            return await _db.StockMovements
              .Where(x => (x.ProductId == productId) && (x.ToLocationId == locationId || x.FromLocationId == locationId))
              .OrderByDescending(x => x.CreatedAt).FirstOrDefaultAsync();
        }

        public async Task InsertStockMovementAsync(StockMovement data)
        {
            await _db.StockMovements.AddAsync(data);
        }

        public async Task SaveDbChangesAsync()
        {
            await _db.SaveChangesAsync();
        }
    }
}
