using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

using StockManager.Database.Source.Models;

namespace StockManager.Database.Source.Contracts
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
        /// Get user by id with productLocations and stockMovements included
        /// </summary>
        Task<Product> GetByIdWithProductLocationsAndStockMovementsAsync(int id);
    }
}
