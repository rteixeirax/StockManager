using StockManager.Database.Source.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StockManager.Services.Source.Contracts
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
        Task CreateLocationAsync(Location location);

        /// <summary>
        /// Delete locations
        /// </summary>
        Task DeleteLocationAsync(int[] locationIds, int userId);

        /// <summary>
        /// Edit location
        /// </summary>
        Task EditLocationAsync(Location location);

        /// <summary>
        /// Get location by id
        /// </summary>
        Task<Location> GetLocationByIdAsync(int locationId);

        /// <summary>
        /// Get all locations
        /// </summary>
        Task<IEnumerable<Location>> GetLocationsAsync(string searchValue = null);

        /// <summary>
        /// Get all the stock movements for the given location id
        /// </summary>
        Task<IEnumerable<StockMovement>> GetLocationStockMovements(int locationId);

        /// <summary>
        /// Get the main location
        /// </summary>
        Task<Location> GetMainLocationAsync(bool includeProducts = false);
    }
}
