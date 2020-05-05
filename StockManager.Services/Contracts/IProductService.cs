using StockManager.Storage.Source.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StockManager.Services.Contracts {
  public interface IProductService {
    Task CreateProductAsync(Product product);

    Task EditProductAsync(Product product);

    Task DeleteProductAsync(int[] productIds);

    Task<IEnumerable<Product>> GetProductsAsync(string searchValue = null);

    Task<Product> GetProductByIdAsync(int productId);
  }
}
