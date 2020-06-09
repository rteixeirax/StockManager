using StockManager.Database.Source.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StockManager.Services.Source.Contracts
{
  public interface ILocationService
  {
    /// <summary>
    /// Create new location
    /// </summary>
    Task CreateLocationAsync(Location location);

    /// <summary>
    /// Edit location
    /// </summary>
    Task EditLocationAsync(Location location);

    /// <summary>
    /// Delete locations
    /// </summary>
    Task DeleteLocationAsync(int[] locationIds, int userId);

    /// <summary>
    /// Set the new Main location
    /// </summary>
    Task SetMainLocationAsync(int newMainlocationId);

    /// <summary>
    /// Get the main location
    /// </summary>
    Task<Location> GetMainLocationAsync();

    /// <summary>
    /// Get all locations
    /// </summary>
    Task<IEnumerable<Location>> GetLocationsAsync(string searchValue = null);

    /// <summary>
    /// Get location by id
    /// </summary>
    Task<Location> GetLocationByIdAsync(int locationId);
  }
}
