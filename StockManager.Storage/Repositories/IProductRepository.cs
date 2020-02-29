using StockManager.Storage.Models;
using StockManager.Types;
using System.Collections.Generic;

namespace StockManager.Storage.Repositories
{
  public interface IProductRepository
  {
    List<ErrorType> CreateProduct(Product data);

    List<ErrorType> UpdateProduct(int productId, Product data);

    IEnumerable<User> GetProducts(string searchValue = null);

    User GetProductById(int productId);

    bool DeleteProducts(int[] productIds);
  }
}
