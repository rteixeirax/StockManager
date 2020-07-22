using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

using StockManager.Database.Source.Contracts;
using StockManager.Database.Source.Models;

namespace StockManager.Database.Source.Repositories
{
    public class StockMovementRepository : BaseRepository<StockMovement>, IStockMovementRepository
    {
        private readonly DatabaseContext _db;

        public StockMovementRepository(DatabaseContext db) : base(db)
        {
            _db = db;
        }

        public async Task<IEnumerable<StockMovement>> FindAllWithProductAndUserAsync(Expression<Func<StockMovement, bool>> expression)
        {
            return await _db.StockMovements
                .AsNoTracking()
                .Include(x => x.Product)
                .Include(x => x.User)
                .Where(expression)
                .OrderByDescending(x => x.CreatedAt)
                .ToListAsync();
        }

        public async Task<StockMovement> FindLastStockMovementAsync(Expression<Func<StockMovement, bool>> expression)
        {
            return await _db.StockMovements
              .Where(expression)
              .OrderByDescending(x => x.CreatedAt)
              .FirstOrDefaultAsync();
        }
    }
}
