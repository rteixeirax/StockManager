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
        await this.ValidateLocationFormData(location);

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

        await this.ValidateLocationFormData(location, dbLocation);

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

          //TODO: Change this verification to check if after delete
          // the app still have at least one location

          // TODO: If have Products, can't be deleted

          // You can't delete the main location
          if (locationId != 1)
          {
            Location location = await this.locationBroker
              .FindLocationByIdAsync(locationId);

            if (location != null)
            {
              this.locationBroker.RemoveLocation(location);
            }
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
    private async Task ValidateLocationFormData(Location location, Location dbLocation = null)
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

      if (errorsList.HasErrors())
      {
        throw new OperationErrorException(errorsList);
      }

      // Check if the name already exist
      // This validation only occurs when all form fields have no errors
      // And only if is a create or an update and the name has changed
      Location nameCheck = ((dbLocation == null) || (dbLocation.Name != location.Name))
        ? await this.locationBroker.FindLocationByNameAsync(location.Name)
        : null;

      if (nameCheck != null)
      {
        errorsList.AddError(new ErrorType
        {
          Field = "Name",
          Error = "A location with this name already exist."
        });

        throw new OperationErrorException(errorsList);
      }
    }
  }
}
