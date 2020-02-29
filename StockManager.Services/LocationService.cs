using StockManager.Storage.Brokers;
using StockManager.Storage.Models;
using StockManager.Types;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace StockManager.Services
{
  public class LocationService : ILocationService
  {
    private readonly ILocationBroker locationBroker;

    public LocationService(ILocationBroker locationBroker)
    {
      this.locationBroker = locationBroker;
    }

    /// <summary>
    /// Create new location async
    /// </summary>
    public async Task CreateLocationAsync(Location location)
    {
      try
      {
        this.ValidateLocationFormData(location);

        await this.locationBroker.AddLocationAsync(location);
        await this.locationBroker.SaveDbChangesAsync();
      }
      catch (OperationErrorException operationErrorException)
      {
        throw operationErrorException;
      }
    }

    /// <summary>
    /// Edit location async
    /// </summary>
    public async Task EditLocationAsync(Location location)
    {
      try
      {
        Location dbLocation = await this.locationBroker
          .FindLocationByIdAsync(location.LocationId);

        this.ValidateLocationFormData(location, dbLocation);

        dbLocation.Name = location.Name;

        await this.locationBroker.SaveDbChangesAsync();
      }
      catch (OperationErrorException operationErrorException)
      {
        throw operationErrorException;
      }
    }

    /// <summary>
    /// Delete locations async
    /// </summary>
    public async Task DeleteLocationAsync(int[] locationIds)
    {
      try
      {
        for (int i = 0; i < locationIds.Length; i += 1)
        {
          int locationId = locationIds[i];

          //TODO:
          // Change this verification to check if after delete
          // the app still have at least one location

          // You can't delete the main location
          if (locationId != 1)
          {
            Location location = await this.locationBroker
            .FindLocationByIdAsync(locationId);

            this.locationBroker.RemoveLocation(location);
          }
        }

        await this.locationBroker.SaveDbChangesAsync();
      }
      catch
      {
        OperationErrorsList errorsList = new OperationErrorsList();
        errorsList.AddError(new ErrorType
        {
          Field = "delete-location-db-error",
          Error = "Oops.. something went wrong. Try it again!"
        });

        throw new OperationErrorException(errorsList);
      }
    }

    /// <summary>
    /// Get all locations async
    /// </summary>
    public async Task<IEnumerable<Location>> GetLocationsAsync(string searchValue = null)
    {
      return await this.locationBroker.FindAllLocationsAsync(searchValue);
    }

    /// <summary>
    /// Get location by id async
    /// </summary>
    public async Task<Location> GetLocationByIdAsync(int locationId)
    {
      return await this.locationBroker.FindLocationByIdAsync(locationId);
    }

    /// <summary>
    /// Validate Location form data
    /// </summary>
    private void ValidateLocationFormData(Location location, Location dbLocation = null)
    {
      OperationErrorsList errorsList = new OperationErrorsList();

      if (string.IsNullOrEmpty(location.Name))
      {
        errorsList.AddError(new ErrorType
        {
          Field = "Name",
          Error = "This field is required."
        });
      }

      // TODO:
      // Add verification for unique name

      if (errorsList.HasErrors())
      {
        throw new OperationErrorException(errorsList);
      }
    }
  }
}
