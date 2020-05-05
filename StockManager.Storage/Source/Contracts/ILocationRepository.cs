using StockManager.Storage.Source.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StockManager.Storage.Source.Contracts {
  public interface ILocationRepository {
    Task SaveDbChangesAsync();

    Task AddLocationAsync(Location location);

    void RemoveLocation(Location location);

    Task<IEnumerable<Location>> FindAllLocationsAsync(string searchValue = null);

    Task<Location> FindLocationByIdAsync(int locationId);

    Task<Location> FindLocationByNameAsync(string name);

    Task<int> CountLocationsAsync();
  }
}
