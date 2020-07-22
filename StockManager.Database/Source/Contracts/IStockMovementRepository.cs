using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

using StockManager.Database.Source.Models;

namespace StockManager.Database.Source.Contracts
{
    public interface IStockMovementRepository : IBaseRepository<StockMovement>
    {
        /// <summary>
        /// Find all movements with product and user included that satisfy the given lambda expression
        /// </summary>
        Task<IEnumerable<StockMovement>> FindAllWithProductAndUserAsync(Expression<Func<StockMovement, bool>> expression);

        /// <summary>
        /// Find the last stock movement that satisfy the given lambda expression
        /// </summary>
        Task<StockMovement> FindLastStockMovementAsync(Expression<Func<StockMovement, bool>> expression);
    }
}
