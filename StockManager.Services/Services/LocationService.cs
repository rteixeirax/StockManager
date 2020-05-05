using StockManager.Services.Contracts;
using StockManager.Storage.Source.Contracts;
using StockManager.Storage.Source.Models;
using StockManager.Translations.Source;
using StockManager.Types.Source;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StockManager.Services.Services {
  public class LocationService : ILocationService {
    private readonly ILocationRepository locationRepo;

    public LocationService(ILocationRepository locationRepo) {
      this.locationRepo = locationRepo;
    }

    /// <summary>
    /// Create new location async
    /// </summary>
    public async Task CreateLocationAsync(Location location) {
      try {
        await this.ValidateLocationFormData(location);

        await this.locationRepo.AddLocationAsync(location);
        await this.locationRepo.SaveDbChangesAsync();
      } catch (OperationErrorException operationErrorException) {
        throw operationErrorException;
      }
    }

    /// <summary>
    /// Edit location async
    /// </summary>
    public async Task EditLocationAsync(Location location) {
      try {
        Location dbLocation = await this.locationRepo
          .FindLocationByIdAsync(location.LocationId);

        await this.ValidateLocationFormData(location, dbLocation);

        dbLocation.Name = location.Name;

        await this.locationRepo.SaveDbChangesAsync();
      } catch (OperationErrorException operationErrorException) {
        throw operationErrorException;
      }
    }

    /// <summary>
    /// Delete locations async
    /// </summary>
    public async Task DeleteLocationAsync(int[] locationIds) {
      OperationErrorsList errorsList = new OperationErrorsList();

      try {
        int locationsCount = await this.locationRepo.CountLocationsAsync();

        // Must have at least one location, can't delete all
        if (locationIds.Length >= locationsCount) {
          errorsList.AddError(
            "LocationsCount",
             Phrases.LocationErrorCount
          );

          throw new OperationErrorException(errorsList);
        }

        for (int i = 0; i < locationIds.Length; i += 1) {
          int locationId = locationIds[i];

          Location location = await this.locationRepo
            .FindLocationByIdAsync(locationId);

          if (location != null) {
            // If have Products, it can't be deleted.
            if (location.ProductLocations.Count > 0) {
              errorsList.AddError(
                "LocationWithProducts",
                Phrases.LocationErrorWithProducts
             );

              throw new OperationErrorException(errorsList);
            }

            this.locationRepo.RemoveLocation(location);
          }
        }

        await this.locationRepo.SaveDbChangesAsync();

        // Catch operation errors
      } catch (OperationErrorException operationErrorException) {
        throw operationErrorException;

        // catch other errors and send a Service Error Exception
      } catch {
        errorsList.AddError("delete-location-db-error", Phrases.GlobalErrorOperationDB);

        throw new ServiceErrorException(errorsList);
      }
    }

    /// <summary>
    /// Get all locations async
    /// </summary>
    public async Task<IEnumerable<Location>> GetLocationsAsync(string searchValue = null) {
      return await this.locationRepo.FindAllLocationsAsync(searchValue);
    }

    /// <summary>
    /// Get location by id async
    /// </summary>
    public async Task<Location> GetLocationByIdAsync(int locationId) {
      return await this.locationRepo.FindLocationByIdAsync(locationId);
    }

    /// <summary>
    /// Validate Location form data
    /// </summary>
    private async Task ValidateLocationFormData(Location location, Location dbLocation = null) {
      OperationErrorsList errorsList = new OperationErrorsList();

      if (string.IsNullOrEmpty(location.Name)) {
        errorsList.AddError("Name", Phrases.GlobalRequiredField);
      }

      if (errorsList.HasErrors()) {
        throw new OperationErrorException(errorsList);
      }

      // Check if the name already exist
      // This validation only occurs when all form fields have no errors
      // And only if is a create or an update and the name has changed
      Location nameCheck = ((dbLocation == null) || (dbLocation.Name != location.Name))
        ? await this.locationRepo.FindLocationByNameAsync(location.Name)
        : null;

      if (nameCheck != null) {
        errorsList.AddError("Name", Phrases.LocationErrorName);

        throw new OperationErrorException(errorsList);
      }
    }
  }
}
