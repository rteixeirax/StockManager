using StockManager.Database.Source.Contracts;
using StockManager.Database.Source.Models;
using StockManager.Services.Source.Contracts;
using StockManager.Translations.Source;
using StockManager.Types.Source;
using System.Threading.Tasks;

namespace StockManager.Services.Source.Services
{
    public class ProductLocationService : IProductLocationService
    {
        private readonly IProductLocationRepository _productLocationRepo;

        public ProductLocationService(IProductLocationRepository productLocationRepo)
        {
            _productLocationRepo = productLocationRepo;
        }

        public async Task AddProductLocationAsync(ProductLocation productLocation, int userId, bool applyDbChanges = true, bool createStockMovement = true)
        {
            try
            {
                await this.ValidateProductLocationDataAsync(productLocation);
                await _productLocationRepo.InsertProductLocationAsync(productLocation);

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
                    await _productLocationRepo.SaveDbChangesAsync();
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
                ProductLocation productLocation = await _productLocationRepo
                  .FindProductLocationByIdAsync(productLocationId);

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
                    _productLocationRepo.RemoveProductLocation(productLocation);
                    await _productLocationRepo.SaveDbChangesAsync();
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
            return await _productLocationRepo.FindProductLocationAsync(productId, locationId);
        }

        public async Task<ProductLocation> GetProductLocationByIdAsync(int productLocationId)
        {
            return await _productLocationRepo.FindProductLocationByIdAsync(productLocationId);
        }

        public async Task UpdateProductLocationMinStock(int productLocation, float minStock)
        {
            try
            {
                ProductLocation dbProductLocation = await _productLocationRepo
                  .FindProductLocationByIdAsync(productLocation);

                dbProductLocation.MinStock = minStock;

                await _productLocationRepo.SaveDbChangesAsync();
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
            ProductLocation pLocationCheck = await _productLocationRepo
              .FindProductLocationAsync(productLocation.ProductId, productLocation.LocationId);

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
