using StockManager.Storage.Source.Contracts;
using StockManager.Storage.Source.Models;
using System.Threading.Tasks;

namespace StockManager.Storage.Source.Repositories {
  public class StockMovementRepository : IStockMovementRepository {
    private readonly StorageContext _db;

    public StockMovementRepository(StorageContext db) {
      _db = db;
    }

    public async Task SaveDbChangesAsync() {
      await _db.SaveChangesAsync();
    }

    public async Task InsertStockMovementAsync(StockMovement data) {
      await _db.StockMovements.AddAsync(data);
    }
  }
}
