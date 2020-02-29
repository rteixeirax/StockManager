using StockManager.Storage.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace StockManager.Services
{
  public interface ILocationService
  {
    Task CreateLocationAsync(Location location);

    Task EditLocationAsync(Location location);

    Task DeleteLocationAsync(int[] locationIds);

    Task<IEnumerable<Location>> GetLocationsAsync(string searchValue = null);

    Task<Location> GetLocationByIdAsync(int locationId);
  }
}
