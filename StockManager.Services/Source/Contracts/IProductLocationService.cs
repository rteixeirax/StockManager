using StockManager.Database.Source.Models;
using System.Threading.Tasks;

namespace StockManager.Services.Source.Contracts {
  public interface IProductLocationService {
    Task AddProductLocationAsync(ProductLocation data, int userId);

    Task DeleteProductLocationAsyn(int productLocationId, int userId);
  }
}
