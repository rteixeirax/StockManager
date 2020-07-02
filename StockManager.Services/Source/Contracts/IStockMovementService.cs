using StockManager.Database.Source.Models;
using System.Threading.Tasks;

namespace StockManager.Services.Source.Contracts
{
  public interface IStockMovementService
  {
    /// <summary>
    ///  Add a product stock movement
    /// </summary>
    /// <param name="data">StockMovement data</param>
    /// <param name="applyDbChanges">
    ///   Set it to true if you want to call "SaveDbChangesAsync" immediately after create the stock movement
    /// </param>
    Task AddStockMovementAsync(StockMovement data, bool applyDbChanges = false);

    /// <summary>
    /// Move the stock back to the main location
    /// </summary>
    /// <param name="applyDbChanges">
    ///   Set it to true if you want to call "SaveDbChangesAsync" immediately after finished the stock movement
    /// </param>
    Task MoveStockToMainLocationAsync(ProductLocation data, int userId, bool applyDbChanges = false);

    /// <summary>
    /// Move the stock from one location to another.
    /// </summary>
    Task MoveStockBetweenLocationsAsync(int fromLocationId, int toLocationId, int productId, float qty, int userId);

    /// <summary>
    /// Get the product last stock movement
    /// </summary>
    Task<StockMovement> GetProductLastStockMovementAsync(int productId);
  }
}
