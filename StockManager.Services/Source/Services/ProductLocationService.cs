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

    public async Task AddProductLocationAsync(ProductLocation data, int userId)
    {
      try
      {
        await this.ValidateProductLocationDataAsync(data);
        await _productLocationRepo.InsertProductLocationAsync(data);

        StockMovement stockMovement = new StockMovement() {
          UserId = userId,
          ProductId = data.ProductId,
          ToLocationId = data.LocationId,
          ToLocationName = data.Location.Name,
          Qty = data.Stock,
        };

        await AppServices.StockMovementService.AddStockMovementAsync(stockMovement);
        await _productLocationRepo.SaveDbChangesAsync();

        // catch operations errors
      }
      catch (OperationErrorException operationErrorException)
      {
        throw operationErrorException;

        // catch service errors
      }
      catch (ServiceErrorException serviceErrorException)
      {
        throw serviceErrorException;
      }
    }

    public async Task DeleteProductLocationAsyn(int productLocationId, int userId)
    {
      try
      {
        ProductLocation productLocation = await _productLocationRepo
          .FindProductLocationByIdAsync(productLocationId);

        if (productLocation != null)
        {
          StockMovement stockMovement = new StockMovement() {
            UserId = userId,
            ProductId = productLocation.ProductId,
            FromLocationId = productLocation.LocationId,
            FromLocationName = productLocation.Location.Name,
            Qty = (productLocation.Stock * (-1)), // To remove stock
          };

          await AppServices.StockMovementService.AddStockMovementAsync(stockMovement);
          _productLocationRepo.RemoveProductLocation(productLocation);
          await _productLocationRepo.SaveDbChangesAsync();
        }
      }
      catch
      {
        OperationErrorsList errorsList = new OperationErrorsList();
        errorsList.AddError("remove-product-location-db-error", Phrases.GlobalErrorOperationDB);

        throw new ServiceErrorException(errorsList);
      }
    }

    private async Task ValidateProductLocationDataAsync(ProductLocation data)
    {
      OperationErrorsList errorsList = new OperationErrorsList();

      if (data.LocationId <= 0)
      {
        errorsList.AddError("LocationId", Phrases.GlobalRequiredField);
      }

      if (errorsList.HasErrors())
      {
        throw new OperationErrorException(errorsList);
      }

      // check if the product is already associated with the location
      ProductLocation pLocationCheck = await _productLocationRepo
        .FindProductLocationAsync(data.ProductId, data.LocationId);

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
