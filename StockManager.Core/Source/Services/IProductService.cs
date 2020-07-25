using System.Collections.Generic;
using System.Threading.Tasks;

using StockManager.Core.Source.Models;

namespace StockManager.Core.Source.Services
{
    public interface IProductService
    {
        /// <summary>
        /// Count and return the total of the products in the app
        /// </summary>
        Task<int> CountAsync();

        /// <summary>
        /// Create new product
        /// </summary>
        Task CreateAsync(Product product, int userId);

        /// <summary>
        /// Delete products
        /// </summary>
        Task DeleteAsync(int[] productIds);

        /// <summary>
        /// Edit product
        /// </summary>
        Task EditAsync(Product product);

        /// <summary>
        /// Get product by id
        /// </summary>
        Task<Product> GetByIdAsync(int productId);

        /// <summary>
        /// Get all products
        /// </summary>
        Task<IEnumerable<Product>> GetAllAsync(string searchValue = null);
    }
}
