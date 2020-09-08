using System.Collections.Generic;
using System.Threading.Tasks;

using StockManager.Core.Source;
using StockManager.Core.Source.Models;
using StockManager.Core.Source.Services;
using StockManager.Core.Source.Types;
using StockManager.Translations.Source;

namespace StockManager.Services.Source.Services
{
    public class ProductLocationService : IProductLocationService
    {
        private readonly IAppRepository _repository;

        public ProductLocationService(IAppRepository repository)
        {
            _repository = repository;
        }

        public async Task CreateAsync(ProductLocation productLocation, int userId, bool applyDbChanges = true, bool createStockMovement = true)
        {
            try
            {
                await ValidateProductLocationDataAsync(productLocation);

                // Get the app settings to set the min stock
                AppSettings appSettings = await AppServices.AppSettingsService.GetAppSettingsAsync();
                productLocation.MinStock = appSettings.DefaultGlobalMinStock;

                await _repository.ProductLocations.AddAsync(productLocation);

                StockMovement stockMovement = new StockMovement()
                {
                    UserId = userId,
                    ProductId = productLocation.ProductId,
                    ToLocationId = productLocation.LocationId,
                    ToLocationName = productLocation.Location.Name,
                    Qty = productLocation.Stock,
                };

                if (createStockMovement)
                {
                    await AppServices.StockMovementService.CreateAsync(stockMovement);
                }

                if (applyDbChanges)
                {
                    await _repository.SaveChangesAsync();
                }
            }
            catch (OperationErrorException operationErrorException)
            {
                // catch operations errors
                throw operationErrorException;
            }
            catch (ServiceErrorException serviceErrorException)
            {
                // catch service errors
                throw serviceErrorException;
            }
        }

        public async Task DeleteAsyn(int productLocationId, int userId)
        {
            OperationErrorsList errorsList = new OperationErrorsList();

            try
            {
                ProductLocation productLocation = await _repository.ProductLocations.GetByIdAsync(productLocationId);

                if (productLocation != null)
                {
                    // Cannot remove the association with the main location
                    if (productLocation.Location.IsMain)
                    {
                        errorsList.AddError("LocationId", Phrases.ProductLocationDeleteErrorMainLocation);
                        throw new OperationErrorException(errorsList);
                    }

                    // Move the stock back to the main location, if any.
                    await AppServices.StockMovementService.MoveStockToMainLocationAsync(productLocation, userId);

                    // Remove the location
                    _repository.ProductLocations.Remove(productLocation);
                    await _repository.SaveChangesAsync();
                }
            }
            catch (OperationErrorException operationErrorException)
            {
                // catch operations errors
                throw operationErrorException;
            }
            catch
            {
                // catch service errors
                errorsList.AddError("remove-product-location-db-error", Phrases.GlobalErrorOperationDB);
                throw new ServiceErrorException(errorsList);
            }
        }

        public async Task<IEnumerable<ProductLocation>> FindAllByLocationIdAsync(int locationId, string searchValue = null)
        {
            if (!string.IsNullOrEmpty(searchValue))
            {
                string searchValueToLower = searchValue.ToLower();

                return await _repository.ProductLocations
                    .FindAllAsync(x => (x.LocationId == locationId)
                    && (x.Product.Name.ToLower().Contains(searchValueToLower) || x.Product.Reference.ToLower().Contains(searchValueToLower)));
            }

            return await _repository.ProductLocations.FindAllAsync(x => x.LocationId == locationId);
        }

        public async Task<ProductLocation> GetOneAsync(int productId, int locationId)
        {
            return await _repository.ProductLocations
                .FindOneAsync(pl => pl.ProductId == productId && pl.LocationId == locationId);
        }

        public async Task<ProductLocation> GetByIdAsync(int productLocationId)
        {
            return await _repository.ProductLocations.GetByIdAsync(productLocationId);
        }

        public async Task UpdateMinStock(int productLocation, float minStock)
        {
            try
            {
                ProductLocation dbProductLocation = await _repository.ProductLocations.GetByIdAsync(productLocation);
                dbProductLocation.MinStock = minStock;

                await AppServices.NotificationService.ToggleStockAlertsAsync(dbProductLocation, dbProductLocation.Stock);
                await _repository.SaveChangesAsync();
            }
            catch
            {
                // catch service errors
                OperationErrorsList errorsList = new OperationErrorsList();
                errorsList.AddError("remove-product-location-db-error", Phrases.GlobalErrorOperationDB);
                throw new ServiceErrorException(errorsList);
            }
        }

        private async Task ValidateProductLocationDataAsync(ProductLocation productLocation)
        {
            OperationErrorsList errorsList = new OperationErrorsList();

            if (productLocation.LocationId <= 0)
            {
                errorsList.AddError("LocationId", Phrases.GlobalRequiredField);
            }

            if (errorsList.HasErrors())
            {
                throw new OperationErrorException(errorsList);
            }

            // check if the product is already associated with the location
            ProductLocation pLocationCheck = await _repository.ProductLocations
                .FindOneAsync(pl => pl.ProductId == productLocation.ProductId && pl.LocationId == productLocation.LocationId);

            if (pLocationCheck != null)
            {
                errorsList.AddError("LocationId", Phrases.ProductLocationErrorAlreadyAssociated);
            }

            if (errorsList.HasErrors())
            {
                throw new OperationErrorException(errorsList);
            }
        }
    }
}
