using StockManager.Database.Source.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StockManager.Services.Source.Contracts
{
    public interface IStockMovementService
    {
        /// <summary>
        /// Add a product stock movement
        /// </summary>
        /// <param name="data">StockMovement data</param>
        /// <param name="applyDbChanges">
        /// Set it to true if you want to call "SaveDbChangesAsync" immediately after create the
        /// stock movement
        /// </param>
        Task AddStockMovementAsync(StockMovement data, bool applyDbChanges = false);

    /// <summary>
    /// Add a entry/exit stock movement inside the main location and update the LocationProductStock
    /// </summary>
    Task AddStockMovementInsideMainLocationAsync(int productId, float qty, bool isEntry, int userId);

    /// <summary>
    /// Move the stock back to the main location
    /// </summary>
    /// <param name="applyDbChanges">
    /// Set it to true if you want to call "SaveDbChangesAsync" immediately after finished the stock movement
    /// </param>
    Task MoveStockToMainLocationAsync(ProductLocation data, int userId, bool applyDbChanges = false);
        /// <summary>
        /// Get all stock movements
        /// </summary>
        Task<IEnumerable<StockMovement>> GetAllAsync(string searchValue);

        /// <summary>
        /// Get the product last stock movement
        /// </summary>
        Task<StockMovement> GetProductLastStockMovementAsync(int productId);

        /// <summary>
        /// Move the stock from one location to another.
        /// </summary>
        Task MoveStockBetweenLocationsAsync(int fromLocationId, int toLocationId, int productId, float qty, int userId);

        /// <summary>
        /// Move the stock back to the main location
        /// </summary>
        /// <param name="applyDbChanges">
        /// Set it to true if you want to call "SaveDbChangesAsync" immediately after finished the
        /// stock movement
        /// </param>
        Task MoveStockToMainLocationAsync(ProductLocation data, int userId, bool applyDbChanges = false);
    }
}