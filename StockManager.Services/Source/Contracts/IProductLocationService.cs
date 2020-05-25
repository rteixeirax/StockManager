using StockManager.Storage.Source.Models;
using System.Threading.Tasks;

namespace StockManager.Services.Source.Contracts {
  public interface IProductLocationService {
    Task AddProductLocationAsync(ProductLocation data, int userId);
  }
}
