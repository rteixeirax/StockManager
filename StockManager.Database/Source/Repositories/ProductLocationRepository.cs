using Microsoft.EntityFrameworkCore;
using StockManager.Database.Source.Contracts;
using StockManager.Database.Source.Models;
using System.Linq;
using System.Threading.Tasks;

namespace StockManager.Database.Source.Repositories {
  public class ProductLocationRepository : IProductLocationRepository {
    private readonly DatabaseContext _db;

    public ProductLocationRepository(DatabaseContext db) {
      _db = db;
    }

    public async Task SaveDbChangesAsync() {
      await _db.SaveChangesAsync();
    }

    public async Task InsertProductLocationAsync(ProductLocation data) {
      await _db.ProductLocations.AddAsync(data);
    }

    public async Task<ProductLocation> FindProductLocationAsync(int productId, int locationId) {
      return await _db.ProductLocations
        .Where(pl => pl.ProductId == productId && pl.LocationId == locationId)
        .FirstOrDefaultAsync();
    }

    public async Task<ProductLocation> FindProductLocationByIdAsync(int productLocationId) {
      return await _db.ProductLocations
        .Where(x => x.ProductLocationId == productLocationId)
        .FirstOrDefaultAsync();
    }

    public void RemoveProductLocation(ProductLocation productLocation) {
      _db.ProductLocations.Remove(productLocation);
    }
  }
}
