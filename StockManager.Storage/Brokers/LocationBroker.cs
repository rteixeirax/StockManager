using Microsoft.EntityFrameworkCore;
using StockManager.Storage.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockManager.Storage.Brokers {
  public class LocationBroker : ILocationBroker {
    private readonly StorageContext db;

    public LocationBroker(StorageContext db) {
      this.db = db;
    }

    /// <summary>
    /// Save DB changes async
    /// </summary>
    public async Task SaveDbChangesAsync() {
      await this.db.SaveChangesAsync();
    }

    /// <summary>
    /// Add new location async
    /// </summary>
    public async Task AddLocationAsync(Location location) {
      await this.db.Locations.AddAsync(location);
    }

    /// <summary>
    /// Remove location async
    /// </summary>
    public void RemoveLocation(Location location) {
      this.db.Locations.Remove(location);
    }

    /// <summary>
    /// Find all locations async
    /// </summary>
    public async Task<IEnumerable<Location>> FindAllLocationsAsync(string searchValue) {
      if (!string.IsNullOrEmpty(searchValue)) {
        return await this.db.Locations
          .Include(x => x.ProductLocations)
          .Where(location => location.Name.ToLower().Contains(searchValue.ToLower()))
          .ToListAsync();
      }

      return await this.db.Locations.Include(x => x.ProductLocations).ToListAsync();
    }

    /// <summary>
    /// Find location by id async
    /// </summary>
    public async Task<Location> FindLocationByIdAsync(int locationId) {
      return await this.db.Locations
        .Where(location => location.LocationId == locationId)
        .FirstOrDefaultAsync();
    }

    /// <summary>
    /// Find user by name async
    /// </summary>
    public async Task<Location> FindLocationByNameAsync(string name) {
      return await this.db.Locations
        .Where(location => location.Name.ToLower() == name.ToLower())
        .FirstOrDefaultAsync();
    }
  }
}
