using System.Threading.Tasks;

using StockManager.Database.Source.Contracts;
using StockManager.Database.Source.Models;
using StockManager.Services.Source.Contracts;
using StockManager.Translations.Source;
using StockManager.Types.Source;

namespace StockManager.Services.Source.Services
{
    public class ProductLocationService : IProductLocationService
    {
        private readonly IRepository _repository;

        public ProductLocationService(IRepository repository)
        {
            _repository = repository;
        }

        public async Task AddProductLocationAsync(ProductLocation productLocation, int userId, bool applyDbChanges = true, bool createStockMovement = true)
        {
            try
            {
                await ValidateProductLocationDataAsync(productLocation);
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
                    await AppServices.StockMovementService.AddStockMovementAsync(stockMovement);
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

        public async Task DeleteProductLocationAsyn(int productLocationId, int userId)
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

        public async Task<ProductLocation> GetProductLocationAsync(int productId, int locationId)
        {
            return await _repository.ProductLocations
                .FindOneAsync(pl => pl.ProductId == productId && pl.LocationId == locationId);
        }

        public async Task<ProductLocation> GetProductLocationByIdAsync(int productLocationId)
        {
            return await _repository.ProductLocations.GetByIdAsync(productLocationId);
        }

        public async Task UpdateProductLocationMinStock(int productLocation, float minStock)
        {
            try
            {
                ProductLocation dbProductLocation = await _repository.ProductLocations.GetByIdAsync(productLocation);
                dbProductLocation.MinStock = minStock;
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
