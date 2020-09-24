using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

using StockManager.Core.Source.Models;
using StockManager.Core.Source.Types;

namespace StockManager.Core.Source.Repositories
{
    public interface IProductRepository : IBaseRepository<Product>
    {
        /// <summary>
        /// Find all products with productLocations included that satisfy the given lambda expression
        /// </summary>
        Task<IEnumerable<Product>> FindAllWithProductLocationsAsync(Expression<Func<Product, bool>> expression);

        /// <summary>
        /// Find all products with productLocations included  without lamba expression
        /// </summary>
        Task<IEnumerable<Product>> FindAllWithProductLocationsAsync();

        /// <summary>
        /// Find all products with productLocations included that satisfy the given ProductOptions
        /// </summary>
        Task<IEnumerable<Product>> FindAllWithProductLocationsAsync(ProductOptions options);

        /// <summary>
        /// Get user by id with productLocations and stockMovements included
        /// </summary>
        Task<Product> GetByIdWithProductLocationsAndStockMovementsAsync(int id);
    }
}
