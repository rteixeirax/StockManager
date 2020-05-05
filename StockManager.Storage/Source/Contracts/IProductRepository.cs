using StockManager.Storage.Source.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StockManager.Storage.Source.Contracts {
  public interface IProductRepository {
    Task SaveDbChangesAsync();

    Task AddProductAsync(Product product);

    void RemoveProduct(Product product);

    Task<IEnumerable<Product>> FindAllProductsAsync(string searchValue = null);

    Task<Product> FindProductByIdAsync(int productId);

    Task<Product> FindProductByReferenceAsync(string reference);
  }
}
