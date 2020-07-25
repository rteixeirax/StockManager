using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

using StockManager.Core.Source.Models;

namespace StockManager.Core.Source.Repositories
{
    public interface IStockMovementRepository : IBaseRepository<StockMovement>
    {
        /// <summary>
        /// Find all movements with product and user included that satisfy the given lambda expression
        /// </summary>
        Task<IEnumerable<StockMovement>> FindAllWithProductAndUserAsync(Expression<Func<StockMovement, bool>> expression);

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
