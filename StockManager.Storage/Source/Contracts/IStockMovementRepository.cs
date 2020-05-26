using StockManager.Storage.Source.Models;
using System.Threading.Tasks;

namespace StockManager.Storage.Source.Contracts {
  public interface IStockMovementRepository {
    Task SaveDbChangesAsync();

    Task InsertStockMovementAsync(StockMovement data);

    Task<StockMovement> FindLastStockMovementAsync();
  }
}
