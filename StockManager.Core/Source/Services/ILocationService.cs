using System.Collections.Generic;
using System.Threading.Tasks;

using StockManager.Core.Source.Models;

namespace StockManager.Core.Source.Services
{
    public interface ILocationService
    {
        /// <summary>
        /// Count and return the total of the locations in the app
        /// </summary>
        Task<int> CountAsync();

        /// <summary>
        /// Create new location
        /// </summary>
        Task CreateAsync(Location location);

        /// <summary>
        /// Delete locations
        /// </summary>
        Task DeleteAsync(int[] locationIds, int userId);

        /// <summary>
        /// Edit location
        /// </summary>
        Task EditAsync(Location location);

        /// <summary>
        /// Get location by id
        /// </summary>
        Task<Location> GetByIdAsync(int locationId);

        /// <summary>
        /// Get all locations
        /// </summary>
        Task<IEnumerable<Location>> GetAllAsync(string searchValue = null);

        /// <summary>
        /// Get all the stock movements for the given location id
        /// </summary>
        Task<IEnumerable<StockMovement>> GetAllStockMovements(int locationId);

        /// <summary>
        /// Get the main location
        /// </summary>
        Task<Location> GetMainAsync(bool includeProducts = false);
    }
}
