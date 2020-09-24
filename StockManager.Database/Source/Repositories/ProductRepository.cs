using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

using StockManager.Core.Source.Models;
using StockManager.Core.Source.Repositories;
using StockManager.Core.Source.Types;

namespace StockManager.Database.Source.Repositories
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        private readonly DatabaseContext _db;

        public ProductRepository(DatabaseContext db) : base(db)
        {
            _db = db;
        }

        public async Task<IEnumerable<Product>> FindAllWithProductLocationsAsync(Expression<Func<Product, bool>> expression)
        {
            return await _db.Products.Include(x => x.ProductLocations).Where(expression).ToListAsync();
        }

        public async Task<IEnumerable<Product>> FindAllWithProductLocationsAsync(ProductOptions options)
        {
            /*
              * Dynamically Composing Expression Predicates
              * http://www.albahari.com/nutshell/predicatebuilder.aspx
              */

            IQueryable<Product> queryable = _db.Products.AsNoTracking().Include(x => x.ProductLocations);

            if (!string.IsNullOrEmpty(options.SearchValue))
            {
                string searchValue = options.SearchValue.ToLower();

                queryable = queryable
                    .Where(x => x.Reference.ToLower().Contains(searchValue) || x.Name.ToLower().Contains(searchValue));
            }

            return await queryable.ToListAsync();
        }

        public async Task<IEnumerable<Product>> FindAllWithProductLocationsAsync()
        {
            return await _db.Products.Include(x => x.ProductLocations).ToListAsync();
        }

        public async Task<Product> GetByIdWithProductLocationsAndStockMovementsAsync(int id)
        {
            return await _db.Products
                 .Include(x => x.ProductLocations)
                 .ThenInclude(x => x.Location)
                 .Include(x => x.StockMovements)
                 .ThenInclude(x => x.User)
                 .Where(product => product.ProductId == id)
                 .FirstOrDefaultAsync();
        }
    }
}
