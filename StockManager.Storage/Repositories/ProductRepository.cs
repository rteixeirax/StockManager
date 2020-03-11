﻿using Microsoft.EntityFrameworkCore;
using StockManager.Storage.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockManager.Storage.Repositories {
  public class ProductRepository : IProductRepository {
    private readonly StorageContext db;

    public ProductRepository(StorageContext db) {
      this.db = db;
    }

    /// <summary>
    /// Save DB changes async
    /// </summary>
    public async Task SaveDbChangesAsync() {
      await this.db.SaveChangesAsync();
    }

    /// <summary>
    /// Add new product async
    /// </summary>
    public async Task AddProductAsync(Product product) {
      await this.db.Products.AddAsync(product);
    }

    /// <summary>
    /// Remove product async
    /// </summary>
    public void RemoveProduct(Product product) {
      this.db.Products.Remove(product);
    }

    /// <summary>
    /// Find all products async
    /// </summary>
    public async Task<IEnumerable<Product>> FindAllProductsAsync(string searchValue) {
      if (!string.IsNullOrEmpty(searchValue)) {
        return await this.db.Products
          .Include(x => x.ProductLocations)
          .Where(product => product.Reference.ToLower().Contains(searchValue.ToLower())
            || product.Name.ToLower().Contains(searchValue.ToLower()))
          .ToListAsync();
      }

      return await this.db.Products.Include(x => x.ProductLocations).ToListAsync();
    }

    /// <summary>
    /// Find product by id async
    /// </summary>
    public async Task<Product> FindProductByIdAsync(int productId) {
      return await this.db.Products
        .Include(x => x.ProductLocations)
        .Where(product => product.ProductId == productId)
        .FirstOrDefaultAsync();
    }

    /// <summary>
    /// Find user by reference async
    /// </summary>
    public async Task<Product> FindProductByReferenceAsync(string reference) {
      return await this.db.Products
        .Where(product => product.Reference.ToLower() == reference.ToLower())
        .FirstOrDefaultAsync();
    }
  }
}
