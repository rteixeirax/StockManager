using StockManager.Database.Source.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StockManager.Database.Source.Contracts
{
  public interface IProductRepository
  {
    /// <summary>
    /// Save DB changes
    /// </summary>
    Task SaveDbChangesAsync();

    /// <summary>
    /// Add new product
    /// </summary>
    Task AddProductAsync(Product product);

    /// <summary>
    /// Remove product
    /// </summary>
    void RemoveProduct(Product product);

    /// <summary>
    /// Find all products
    /// </summary>
    Task<IEnumerable<Product>> FindAllProductsAsync(string searchValue = null);

    /// <summary>
    /// Find product by id
    /// </summary>
    Task<Product> FindProductByIdAsync(int productId, bool includeRelations = true);

    /// <summary>
    /// Find user by reference
    /// </summary>
    Task<Product> FindProductByReferenceAsync(string reference);
  }
}
