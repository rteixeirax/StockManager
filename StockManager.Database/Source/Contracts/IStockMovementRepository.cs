using StockManager.Database.Source.Models;
using System.Threading.Tasks;

namespace StockManager.Database.Source.Contracts {
  public interface IStockMovementRepository {
    Task SaveDbChangesAsync();

    Task InsertStockMovementAsync(StockMovement data);

    Task<StockMovement> FindProductLastStockMovementAsync(int productId);
  }
}
