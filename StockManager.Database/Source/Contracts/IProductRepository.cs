using StockManager.Database.Source.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StockManager.Database.Source.Contracts {
  public interface IProductRepository {
    Task SaveDbChangesAsync();

    Task AddProductAsync(Product product);

    void RemoveProduct(Product product);

    Task<IEnumerable<Product>> FindAllProductsAsync(string searchValue = null);

    Task<Product> FindProductByIdAsync(int productId, bool includeRelations = true);

    Task<Product> FindProductByReferenceAsync(string reference);
  }
}
