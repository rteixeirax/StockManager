using System.Collections.Generic;
using System.Threading.Tasks;

using StockManager.Database.Source.Models;

namespace StockManager.Database.Source.Contracts
{
    public interface ILocationRepository
    {
        /// <summary>
        /// Add new location
        /// </summary>
        Task AddLocationAsync(Location location);

        /// <summary>
        /// Count async all the locations in the DB
        /// </summary>
        Task<int> CountLocationsAsync();

        /// <summary>
        /// Find all locations
        /// </summary>
        Task<IEnumerable<Location>> FindAllLocationsAsync(string searchValue = null);

        /// <summary>
        /// Find all stock movements for the given location Id
        /// </summary>
        Task<IEnumerable<StockMovement>> FindAllStockMovements(int locationId);

        /// <summary>
        /// Find location by id
        /// </summary>
        Task<Location> FindLocationByIdAsync(int locationId, bool includeRelations = true);

        /// <summary>
        /// Find user by name
        /// </summary>
        Task<Location> FindLocationByNameAsync(string name);

        /// <summary>
        /// Unset the main location
        /// </summary>
        Task<Location> FindMainLocationAsync(bool includeProducts = false);

        /// <summary>
        /// Remove location
        /// </summary>
        void RemoveLocation(Location location);

        /// <summary>
        /// Save DB changes
        /// </summary>
        Task SaveDbChangesAsync();

        /// <summary>
        /// Unset the main location
        /// </summary>
        Task UnsetMainLocationAsync(int newMainlocationId);
    }
}
