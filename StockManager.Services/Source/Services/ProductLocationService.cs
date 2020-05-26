using StockManager.Services.Source.Contracts;
using StockManager.Storage.Source.Contracts;
using StockManager.Storage.Source.Models;
using StockManager.Translations.Source;
using StockManager.Types.Source;
using System.Threading.Tasks;

namespace StockManager.Services.Source.Services {
  public class ProductLocationService : IProductLocationService {
    private readonly IProductLocationRepository _productLocationRepo;

    public ProductLocationService(IProductLocationRepository productLocationRepo) {
      _productLocationRepo = productLocationRepo;
    }

    public async Task AddProductLocationAsync(ProductLocation data, int userId) {
      try {
        await this.ValidateProductLocationDataAsync(data);
        await _productLocationRepo.InsertProductLocationAsync(data);

        StockMovement stockMovement = new StockMovement() {
          UserId = userId,
          ProductId = data.ProductId,
          ToLocationId = data.LocationId,
          Qty = data.Stock,
        };

        await AppServices.StockMovementService.AddStockMovementAsync(stockMovement);
        await _productLocationRepo.SaveDbChangesAsync();

        // catch operations errors
      } catch (OperationErrorException operationErrorException) {
        throw operationErrorException;

        // catch service errors
      } catch (ServiceErrorException serviceErrorException) {
        throw serviceErrorException;
      }
    }

    private async Task ValidateProductLocationDataAsync(ProductLocation data) {
      OperationErrorsList errorsList = new OperationErrorsList();

      if (string.IsNullOrEmpty(data.LocationId.ToString())) {
        errorsList.AddError("LocationId", Phrases.GlobalRequiredField);
      }

      if (string.IsNullOrEmpty(data.Stock.ToString())) {
        errorsList.AddError("Stock", Phrases.GlobalRequiredField);
      }

      if (string.IsNullOrEmpty(data.MinStock.ToString())) {
        errorsList.AddError("MinStock", Phrases.GlobalRequiredField);
      }

      if (errorsList.HasErrors()) {
        throw new OperationErrorException(errorsList);
      }

      // check if the product is already associated with the location
      ProductLocation pLocationCheck = await _productLocationRepo
        .FindProductLocationAsync(data.ProductId, data.LocationId);

      if (pLocationCheck != null) {
        errorsList.AddError("LocationId", "Already associated"); // TODO: Add better phrase and create the translation
      }

      if (errorsList.HasErrors()) {
        throw new OperationErrorException(errorsList);
      }
    }
  }
}
