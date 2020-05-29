using StockManager.Database.Source.Models;
using System.Threading.Tasks;

namespace StockManager.Database.Source.Contracts {
  public interface IStockMovementRepository {
    /// <summary>
    /// Save DB changes
    /// </summary>
    Task SaveDbChangesAsync();

    /// <summary>
    /// Insert a new product stock movement
    /// </summary>
    Task InsertStockMovementAsync(StockMovement data);

    /// <summary>
    /// Find the product last stock movement
    /// </summary>
    Task<StockMovement> FindProductLastStockMovementAsync(int productId);
  }
}
