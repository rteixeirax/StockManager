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
    /// Get the product last stock movement
    /// </summary>
    Task<StockMovement> GetProductLastStockMovementAsync(int productId);
  }
}
