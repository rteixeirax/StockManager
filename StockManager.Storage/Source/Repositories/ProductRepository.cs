using Microsoft.EntityFrameworkCore;
using StockManager.Storage.Source.Contracts;
using StockManager.Storage.Source.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockManager.Storage.Source.Repositories {
  public class ProductRepository : IProductRepository {
    private readonly DatabaseContext _db;

    public ProductRepository(DatabaseContext db) {
      _db = db;
    }

    /// <summary>
    /// Save DB changes async
    /// </summary>
    public async Task SaveDbChangesAsync() {
      await _db.SaveChangesAsync();
    }

    /// <summary>
    /// Add new product async
    /// </summary>
    public async Task AddProductAsync(Product product) {
      await _db.Products.AddAsync(product);
    }

    /// <summary>
    /// Remove product async
    /// </summary>
    public void RemoveProduct(Product product) {
      _db.Products.Remove(product);
    }

    /// <summary>
    /// Find all products async
    /// </summary>
    public async Task<IEnumerable<Product>> FindAllProductsAsync(string searchValue) {
      if (!string.IsNullOrEmpty(searchValue)) {
        return await _db.Products
          .Include(x => x.ProductLocations)
          .Where(product => product.Reference.ToLower().Contains(searchValue.ToLower())
            || product.Name.ToLower().Contains(searchValue.ToLower()))
          .ToListAsync();
      }

      return await _db.Products.Include(x => x.ProductLocations).ToListAsync();
    }

    /// <summary>
    /// Find product by id async
    /// </summary>
    public async Task<Product> FindProductByIdAsync(int productId, bool includeRelations = true) {
      if (includeRelations) {
        return await _db.Products
          .Include(x => x.ProductLocations)
          .Include(x => x.StockMovements)
          .Where(product => product.ProductId == productId)
          .FirstOrDefaultAsync();
      }

      return await _db.Products
        .Where(p => p.ProductId == productId)
        .FirstOrDefaultAsync();
    }

    /// <summary>
    /// Find user by reference async
    /// </summary>
    public async Task<Product> FindProductByReferenceAsync(string reference) {
      return await _db.Products
        .Where(product => product.Reference.ToLower() == reference.ToLower())
        .FirstOrDefaultAsync();
    }
  }
}
