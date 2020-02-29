using StockManager.Storage.Models;
using StockManager.Types;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StockManager.Storage.Brokers
{
  public interface ILocationBroker
  {
    Task SaveDbChangesAsync();

    Task AddLocationAsync(Location location);
   
    void RemoveLocation(Location location);

    Task<IEnumerable<Location>> FindAllLocationsAsync(string searchValue = null);

    Task<Location> FindLocationByIdAsync(int locationId);

  }
}
