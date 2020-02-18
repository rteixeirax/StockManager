using StockManager.Database.Models;
using StockManager.Types;
using System.Collections.Generic;

namespace StockManager.Database.Repositories
{
  public interface ILocationRepository
  {
    List<ErrorType> CreateLocation(Location data);

    List<ErrorType> UpdateLocation(int locationId, Location data);
    
    IEnumerable<Location> GetLocations(string searchValue = null);

    Location GetLocationById(int locationId);

    bool DeleteLocations(int[] locationIds);
  }
}
