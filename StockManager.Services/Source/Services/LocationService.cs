using StockManager.Database.Source.Contracts;
using StockManager.Database.Source.Models;
using StockManager.Services.Source.Contracts;
using StockManager.Translations.Source;
using StockManager.Types.Source;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StockManager.Services.Source.Services
{
  public class LocationService : ILocationService
  {
    private readonly ILocationRepository _locationRepo;

    public LocationService(ILocationRepository locationRepo)
    {
      _locationRepo = locationRepo;
    }

    public async Task CreateLocationAsync(Location location)
    {
      try
      {
        await this.ValidateLocationFormData(location);

        await _locationRepo.AddLocationAsync(location);
        await _locationRepo.SaveDbChangesAsync();
      }
      catch (OperationErrorException operationErrorException)
      {
        throw operationErrorException;
      }
    }

    public async Task EditLocationAsync(Location location)
    {
      try
      {
        Location dbLocation = await _locationRepo
          .FindLocationByIdAsync(location.LocationId);

        await this.ValidateLocationFormData(location, dbLocation);

        dbLocation.Name = location.Name;

        await _locationRepo.SaveDbChangesAsync();
      }
      catch (OperationErrorException operationErrorException)
      {
        throw operationErrorException;
      }
    }


    public async Task DeleteLocationAsync(int[] locationIds)
    {
      OperationErrorsList errorsList = new OperationErrorsList();

      try
      {
        int locationsCount = await _locationRepo.CountLocationsAsync();

        // Must have at least one location, can't delete all
        if (locationIds.Length >= locationsCount)
        {
          errorsList.AddError(
            "LocationsCount",
             Phrases.LocationErrorCount
          );

          throw new OperationErrorException(errorsList);
        }

        for (int i = 0; i < locationIds.Length; i += 1)
        {
          int locationId = locationIds[i];

          Location location = await _locationRepo
            .FindLocationByIdAsync(locationId);

          if (location != null)
          {
            // If have Products, it can't be deleted.
            if (location.ProductLocations.Count > 0)
            {
              errorsList.AddError(
                "LocationWithProducts",
                Phrases.LocationErrorWithProducts
             );

              throw new OperationErrorException(errorsList);
            }

            _locationRepo.RemoveLocation(location);
          }
        }

        await _locationRepo.SaveDbChangesAsync();

        // Catch operation errors
      }
      catch (OperationErrorException operationErrorException)
      {
        throw operationErrorException;

        // catch other errors and send a Service Error Exception
      }
      catch
      {
        errorsList.AddError("delete-location-db-error", Phrases.GlobalErrorOperationDB);

        throw new ServiceErrorException(errorsList);
      }
    }

    public async Task SetMainLocation(int newMainlocationId)
    {
      Location location = await this.GetLocationByIdAsync(newMainlocationId);

      if (location != null)
      {
        // Set as main location
        location.IsMain = true;

        // Unset the previous main location
        await _locationRepo.UnsetMainLocation(newMainlocationId);
        await _locationRepo.SaveDbChangesAsync();
      }
    }

    public async Task<IEnumerable<Location>> GetLocationsAsync(string searchValue = null)
    {
      return await _locationRepo.FindAllLocationsAsync(searchValue);
    }

    public async Task<Location> GetLocationByIdAsync(int locationId)
    {
      return await _locationRepo.FindLocationByIdAsync(locationId);
    }

    /// <summary>
    /// Validate Location form data
    /// </summary>
    private async Task ValidateLocationFormData(Location location, Location dbLocation = null)
    {
      OperationErrorsList errorsList = new OperationErrorsList();

      if (string.IsNullOrEmpty(location.Name))
      {
        errorsList.AddError("Name", Phrases.GlobalRequiredField);
      }

      if (errorsList.HasErrors())
      {
        throw new OperationErrorException(errorsList);
      }

      // Check if the name already exist
      // This validation only occurs when all form fields have no errors
      // And only if is a create or an update and the name has changed
      Location nameCheck = ((dbLocation == null) || (dbLocation.Name != location.Name))
        ? await _locationRepo.FindLocationByNameAsync(location.Name)
        : null;

      if (nameCheck != null)
      {
        errorsList.AddError("Name", Phrases.LocationErrorName);

        throw new OperationErrorException(errorsList);
      }
    }
  }
}
