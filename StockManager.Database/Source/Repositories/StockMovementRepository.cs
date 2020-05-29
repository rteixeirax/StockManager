using Microsoft.EntityFrameworkCore;
using StockManager.Database.Source.Contracts;
using StockManager.Database.Source.Models;
using System.Linq;
using System.Threading.Tasks;

namespace StockManager.Database.Source.Repositories
{
  public class StockMovementRepository : IStockMovementRepository
  {
    private readonly DatabaseContext _db;

    public StockMovementRepository(DatabaseContext db)
    {
      _db = db;
    }

    public async Task SaveDbChangesAsync()
    {
      await _db.SaveChangesAsync();
    }

    public async Task InsertStockMovementAsync(StockMovement data)
    {
      await _db.StockMovements.AddAsync(data);
    }

    public async Task<StockMovement> FindProductLastStockMovementAsync(int productId)
    {
      return await _db.StockMovements
        .Where(x => x.ProductId == productId)
        .OrderByDescending(x => x.CreatedAt).FirstOrDefaultAsync();
    }
  }
}
