using StockManager.Storage.Source.Models;
using System.Threading.Tasks;

namespace StockManager.Storage.Source.Contracts {
  public interface IProductLocationRepository {
    Task SaveDbChangesAsync();

    Task InsertProductLocationAsync(ProductLocation data);

    Task<ProductLocation> FindProductLocationAsync(int productId, int locationId);
  }
}
