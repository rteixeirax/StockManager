using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

using StockManager.Src.Data.Entities;
using StockManager.Src.Extensions;
using StockManager.Src.Models;

namespace StockManager.Src.Data.Repositories
{
    public class StockMovementRepository : BaseRepository<StockMovement>, IStockMovementRepository
    {
        private readonly DatabaseContext _db;

        public StockMovementRepository(DatabaseContext db) : base(db)
        {
            _db = db;
        }

        public async Task<IEnumerable<StockMovement>> FindAllOrderedByDescendingWithProductAndUserAsync()
        {
            return await _db.StockMovements
                .AsNoTracking()
                .Include(x => x.Product)
                .Include(x => x.User)
                .OrderByDescending(x => x.CreatedAt)
                .ToListAsync();
        }

        public async Task<IEnumerable<StockMovement>> FindAllOrderedByDescendingWithProductAndUserAsync(StockMovementOptions options)
        {
            /*
             * Dynamically Composing Expression Predicates
             * http://www.albahari.com/nutshell/predicatebuilder.aspx
             */

            IQueryable<StockMovement> queryable = _db.StockMovements.AsNoTracking().Include(x => x.Product).Include(x => x.User);

            if (!string.IsNullOrEmpty(options.SearchValue))
            {
                string searchValue = options.SearchValue.ToLower();

                queryable = queryable
                    .Where(x => x.Product.Reference.ToLower().Contains(searchValue) || x.Product.Name.ToLower().Contains(searchValue));
            }

            if (options.LocationId != null)
            {
                queryable = queryable
                    .Where(x => (x.ToLocationId == options.LocationId) || (x.FromLocationId == options.LocationId));
            }

            if (options.UserId != null)
            {
                queryable = queryable.Where(x => x.UserId == options.UserId);
            }

            if (options.StartDate != default)
            {
                queryable = queryable.Where(x => x.CreatedAt >= options.StartDate.SetDateToBeginningOfTheDay());
            }

            if (options.EndDate != default)
            {
                queryable = queryable.Where(x => x.CreatedAt <= options.EndDate.SetDateToEndOfTheDay());
            }

            return await queryable.OrderByDescending(x => x.CreatedAt).ToListAsync();
        }

        public async Task<IEnumerable<StockMovement>> FindAllWithOrderByDescendingAsync(Expression<Func<StockMovement, bool>> expression)
        {
            return await _db.StockMovements
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
