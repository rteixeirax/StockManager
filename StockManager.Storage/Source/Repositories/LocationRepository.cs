using Microsoft.EntityFrameworkCore;
using StockManager.Storage.Source.Contracts;
using StockManager.Storage.Source.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockManager.Storage.Source.Repositories {
  public class LocationRepository : ILocationRepository {
    private readonly StorageContext _db;

    public LocationRepository(StorageContext db) {
      _db = db;
    }

    /// <summary>
    /// Save DB changes async
    /// </summary>
    public async Task SaveDbChangesAsync() {
      await _db.SaveChangesAsync();
    }

    /// <summary>
    /// Add new location async
    /// </summary>
    public async Task AddLocationAsync(Location location) {
      await _db.Locations.AddAsync(location);
    }

    /// <summary>
    /// Remove location async
    /// </summary>
    public void RemoveLocation(Location location) {
      _db.Locations.Remove(location);
    }

    /// <summary>
    /// Find all locations async
    /// </summary>
    public async Task<IEnumerable<Location>> FindAllLocationsAsync(string searchValue) {
      if (!string.IsNullOrEmpty(searchValue)) {
        return await _db.Locations
          .Include(x => x.ProductLocations)
          .Where(location => location.Name.ToLower().Contains(searchValue.ToLower()))
          .ToListAsync();
      }

      return await _db.Locations.Include(x => x.ProductLocations).ToListAsync();
    }

    /// <summary>
    /// Find location by id async
    /// </summary>
    public async Task<Location> FindLocationByIdAsync(int locationId) {
      return await _db.Locations
        .Include(x => x.ProductLocations)
        .Where(location => location.LocationId == locationId)
        .FirstOrDefaultAsync();
    }

    /// <summary>
    /// Find user by name async
    /// </summary>
    public async Task<Location> FindLocationByNameAsync(string name) {
      return await _db.Locations
        .Where(location => location.Name.ToLower() == name.ToLower())
        .FirstOrDefaultAsync();
    }

    /// <summary>
    /// Count async all the locations in the DB
    /// </summary>
    public async Task<int> CountLocationsAsync() {
      return await _db.Locations.CountAsync();
    }
  }
}
