using System.Collections.Generic;
using System.Threading.Tasks;

using StockManager.Src.Data.Entities;

namespace StockManager.Src.Services
{
    public interface IProductLocationService
    {
        /// <summary>
        /// Associate a product to a location
        /// </summary>
        /// <param name="productLocation"></param>
        /// <param name="userId"></param>
        /// <param name="applyDbChanges">Set to false to skip the db save changes</param>
        /// <param name="createStockMovement">Set to false to skip the creation of the stock movement</param>
        Task CreateAsync(ProductLocation productLocation, int userId, bool applyDbChanges = true, bool createStockMovement = true);

        /// <summary>
        /// Remove the association product-location
        /// </summary>
        Task DeleteAsyn(int productLocationId, int userId);

        /// <summary>
        /// Create a PDF with the given data
        /// </summary>
        Task ExportProductLocationsFromLocationToPDFAsync(IEnumerable<ProductLocation> productLocations);

        /// <summary>
        /// Create a PDF with the given data
        /// </summary>
        Task ExportProductLocationsFromProductToPDFAsync(IEnumerable<ProductLocation> productLocations);

        /// <summary>
        /// Find all ProductLocations that belongs to the given locationId
        /// </summary>
        Task<IEnumerable<ProductLocation>> FindAllByLocationIdAsync(int locationId, string searchValue = null);

        /// <summary>
        /// Get the ProductLocation by id
        /// </summary>
        Task<ProductLocation> GetByIdAsync(int productLocationId);

        /// <summary>
        /// Get the ProductLocation relation for the given productId and locationId
        /// </summary>
        Task<ProductLocation> GetOneAsync(int productId, int locationId);

        /// <summary>
        /// Update the product location min stock
        /// </summary>
        Task UpdateMinStock(int productLocation, float minStock);
    }
}
