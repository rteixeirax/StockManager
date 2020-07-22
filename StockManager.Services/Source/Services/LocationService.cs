﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using StockManager.Database.Source.Contracts;
using StockManager.Database.Source.Models;
using StockManager.Services.Source.Contracts;
using StockManager.Translations.Source;
using StockManager.Types.Source;

namespace StockManager.Services.Source.Services
{
    public class LocationService : ILocationService
    {
        private readonly IRepository _repository;

        public LocationService(IRepository repository)
        {
            _repository = repository;
        }

        public async Task<int> CountAsync()
        {
            return await _repository.Locations.CountAsync();
        }

        public async Task CreateLocationAsync(Location location)
        {
            try
            {
                await ValidateLocationFormData(location);

                await _repository.Locations.AddAsync(location);
                await _repository.SaveChangesAsync();
            }
            catch (OperationErrorException operationErrorException)
            {
                throw operationErrorException;
            }
        }

        public async Task DeleteLocationAsync(int[] locationIds, int userId)
        {
            OperationErrorsList errorsList = new OperationErrorsList();

            try
            {
                for (int i = 0; i < locationIds.Length; i += 1)
                {
                    int locationId = locationIds[i];

                    Location location = await _repository.Locations.GetByIdAsync(locationId);

                    if (location != null)
                    {
                        // If it is the main location cannot be deleted
                        if (location.IsMain)
                        {
                            errorsList.AddError(
                              "MainLocation",
                              Phrases.LocationErrorMainLocation
                           );

                            throw new OperationErrorException(errorsList);
                        }

                        // Iterate through the productLocations and move the stock to the main
                        // location before remove the location
                        if (location.ProductLocations.Any())
                        {
                            while (location.ProductLocations.Any())
                            {
                                ProductLocation producLocation = location.ProductLocations.ElementAt(0);

                                // Remove the ProductLocation association and move the stock
                                await AppServices.ProductLocationService
                                  .DeleteProductLocationAsyn(producLocation.ProductLocationId, userId);
                            }
                        }

                        _repository.Locations.Remove(location);
                    }
                }

                await _repository.SaveChangesAsync();
            }
            catch (OperationErrorException operationErrorException)
            {
                // Catch operation errors
                throw operationErrorException;
            }
            catch
            {
                // catch other errors and send a Service Error Exception
                errorsList.AddError("delete-location-db-error", Phrases.GlobalErrorOperationDB);

                throw new ServiceErrorException(errorsList);
            }
        }

        public async Task EditLocationAsync(Location location)
        {
            try
            {
                Location dbLocation = await _repository.Locations.GetByIdWithProductLocationsAsync(location.LocationId);

                await ValidateLocationFormData(location, dbLocation);

                dbLocation.Name = location.Name;

                await _repository.SaveChangesAsync();
            }
            catch (OperationErrorException operationErrorException)
            {
                throw operationErrorException;
            }
        }

        public async Task<Location> GetLocationByIdAsync(int locationId)
        {
            return await _repository.Locations.GetByIdWithProductLocationsAsync(locationId);
        }

        public async Task<IEnumerable<Location>> GetLocationsAsync(string searchValue = null)
        {
            if (!string.IsNullOrEmpty(searchValue))
            {
                return await _repository.Locations
                    .FindAllWithProductLocationsAsync(location => location.Name.ToLower().Contains(searchValue.ToLower()));
            }

            return await _repository.Locations.FindAllWithProductLocationsAsync();
        }

        public async Task<IEnumerable<StockMovement>> GetLocationStockMovements(int locationId)
        {
            return await _repository.StockMovements
                .FindAllWithOrderByDescendingAsync(x => (x.FromLocationId == locationId) || (x.ToLocationId == locationId));
        }

        public async Task<Location> GetMainLocationAsync(bool includeProducts = false)
        {
            if (includeProducts)
            {
                return await _repository.Locations
                    .FindOneWithProductLocationsAsync(location => location.IsMain == true);
            }

            return await _repository.Locations.FindOneAsync(location => location.IsMain == true);
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

            // Check if the name already exist This validation only occurs when all form fields have
            // no errors And only if is a create or an update and the name has changed
            Location nameCheck = ((dbLocation == null) || (dbLocation.Name != location.Name))
              ? await _repository.Locations.FindOneAsync(x => x.Name.ToLower() == location.Name.ToLower())
              : null;

            if (nameCheck != null)
            {
                errorsList.AddError("Name", Phrases.LocationErrorName);

                throw new OperationErrorException(errorsList);
            }
        }
    }
}
