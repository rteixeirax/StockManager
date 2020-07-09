using StockManager.Database.Source.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StockManager.Database.Source.Contracts
{
    public interface IStockMovementRepository
    {
        /// <summary>
        /// Find all movements
        /// </summary>
        Task<IEnumerable<StockMovement>> FindAllMovementsAsync(string searchValue);

        /// <summary>
        /// Find the product last stock movement
        /// </summary>
        Task<StockMovement> FindProductLastStockMovementAsync(int productId);

        /// <summary>
        /// Find the product last stock movement for the given location
        /// </summary>
        Task<StockMovement> FindProductLocationLastStockMovementAsync(int productId, int locationId);

        /// <summary>
        /// Insert a new product stock movement
        /// </summary>
        Task InsertStockMovementAsync(StockMovement data);

        /// <summary>
        /// Save DB changes
        /// </summary>
        Task SaveDbChangesAsync();
    }
}