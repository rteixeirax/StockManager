using StockManager.Database.Source.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StockManager.Database.Source.Contracts
{
  public interface ILocationRepository
  {
    /// <summary>
    /// Save DB changes
    /// </summary>
    Task SaveDbChangesAsync();

    /// <summary>
    /// Add new location
    /// </summary>
    Task AddLocationAsync(Location location);

    /// <summary>
    /// Remove location
    /// </summary>
    void RemoveLocation(Location location);

    /// <summary>
    /// Find all locations
    /// </summary>
    Task<IEnumerable<Location>> FindAllLocationsAsync(string searchValue = null);

    /// <summary>
    /// Find location by id
    /// </summary>
    Task<Location> FindLocationByIdAsync(int locationId);

    /// <summary>
    /// Find user by name
    /// </summary>
    Task<Location> FindLocationByNameAsync(string name);

    /// <summary>
    /// Unset the main location
    /// </summary>
    Task UnsetMainLocation(int newMainlocationId);

    /// <summary>
    /// Count async all the locations in the DB
    /// </summary>
    Task<int> CountLocationsAsync();
  }
}
