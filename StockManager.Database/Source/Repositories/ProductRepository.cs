using Microsoft.EntityFrameworkCore;
using StockManager.Database.Source.Contracts;
using StockManager.Database.Source.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockManager.Database.Source.Repositories
{
  public class ProductRepository : IProductRepository
  {
    private readonly DatabaseContext _db;

    public ProductRepository(DatabaseContext db)
    {
      _db = db;
    }

    public async Task SaveDbChangesAsync()
    {
      await _db.SaveChangesAsync();
    }

    public async Task AddProductAsync(Product product)
    {
      await _db.Products.AddAsync(product);
    }

    public void RemoveProduct(Product product)
    {
      _db.Products.Remove(product);
    }

    public async Task<IEnumerable<Product>> FindAllProductsAsync(string searchValue)
    {
      if (!string.IsNullOrEmpty(searchValue))
      {
        return await _db.Products
          .Include(x => x.ProductLocations)
          .Where(product => product.Reference.ToLower().Contains(searchValue.ToLower())
            || product.Name.ToLower().Contains(searchValue.ToLower()))
          .ToListAsync();
      }

      return await _db.Products.Include(x => x.ProductLocations).ToListAsync();
    }

    public async Task<Product> FindProductByIdAsync(int productId, bool includeRelations = true)
    {
      if (includeRelations)
      {
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

    public async Task<Product> FindProductByReferenceAsync(string reference)
    {
      return await _db.Products
        .Where(product => product.Reference.ToLower() == reference.ToLower())
        .FirstOrDefaultAsync();
    }
  }
}
