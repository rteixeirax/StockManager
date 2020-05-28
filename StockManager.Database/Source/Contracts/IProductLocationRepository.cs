using StockManager.Database.Source.Models;
using System.Threading.Tasks;

namespace StockManager.Database.Source.Contracts {
  public interface IProductLocationRepository {
    Task SaveDbChangesAsync();

    Task InsertProductLocationAsync(ProductLocation data);

    Task<ProductLocation> FindProductLocationAsync(int productId, int locationId);

    Task<ProductLocation> FindProductLocationByIdAsync(int productLocationId);

    void RemoveProductLocation(ProductLocation productLocation);
  }
}
