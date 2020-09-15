using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

using StockManager.Core.Source.Models;
using StockManager.Core.Source.Types;

namespace StockManager.Core.Source.Repositories
{
    public interface IStockMovementRepository : IBaseRepository<StockMovement>
    {
        /// <summary>
        /// Find all movements, ordered by descending, with product and user included.
        /// </summary>
        Task<IEnumerable<StockMovement>> FindAllOrderedByDescendingWithProductAndUserAsync();

        /// <summary>
        /// Find all movements, ordered by descending, with product and user included that satisfy the given StockMovementOptions
        /// </summary>
        Task<IEnumerable<StockMovement>> FindAllOrderedByDescendingWithProductAndUserAsync(StockMovementOptions options);

        /// <summary>
        /// Find all stock movements, order by descending, that satisfy the given lambda expression
        /// </summary>
        Task<IEnumerable<StockMovement>> FindAllWithOrderByDescendingAsync(Expression<Func<StockMovement, bool>> expression);

        /// <summary>
        /// Find the last stock movement that satisfy the given lambda expression
        /// </summary>
        Task<StockMovement> FindLastStockMovementAsync(Expression<Func<StockMovement, bool>> expression);
    }
}
