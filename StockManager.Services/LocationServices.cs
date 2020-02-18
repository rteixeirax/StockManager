using Microsoft.EntityFrameworkCore;
using StockManager.Database;
using StockManager.Database.Models;
using StockManager.Database.Repositories;
using StockManager.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockManager.Services
{
  public class LocationServices : ILocationRepository
  {
    private readonly AppDbContext db;

    public LocationServices(AppDbContext db)
    {
      this.db = db;
    }

    public List<ErrorType> CreateLocation(Location data)
    {
      throw new NotImplementedException();
    }

    /// <summary>
    /// Delete Locations
    /// </summary>
    public bool DeleteLocations(int[] locationIds)
    {
      foreach (int locationId in locationIds)
      {
        // You can't delete the main location
        if (locationId != 1)
        {
          Location location = this.GetLocationById(locationId);
          this.db.Locations.Remove(location);
        }
      }

      this.db.SaveChanges();

      return true;
    }

    /// <summary>
    /// Get Location by Id 
    /// </summary>
    public Location GetLocationById(int locationId) => this.db.Locations
      .FirstOrDefault(x => x.LocationId == locationId);

    /// <summary>
    /// Get All locations
    /// </summary>
    public IEnumerable<Location> GetLocations(string searchValue = null)
    {
      if (!string.IsNullOrEmpty(searchValue))
      {
        return this.db.Locations
          .Where(x => x.Name.ToLower().Contains(searchValue.ToLower()))
          .ToList();
      }

      return this.db.Locations.ToList();
    }

    public List<ErrorType> UpdateLocation(int locationId, Location data)
    {
      throw new NotImplementedException();
    }
  }
}
