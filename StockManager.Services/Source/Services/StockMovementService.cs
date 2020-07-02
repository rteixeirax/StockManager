using StockManager.Database.Source.Contracts;
using StockManager.Database.Source.Models;
using StockManager.Services.Source.Contracts;
using StockManager.Translations.Source;
using StockManager.Types.Source;
using System.Threading.Tasks;

namespace StockManager.Services.Source.Services
{
  public class StockMovementService : IStockMovementService
  {
    private readonly IStockMovementRepository _stockMovementRepo;

    public StockMovementService(IStockMovementRepository stockMovementRepo)
    {
      _stockMovementRepo = stockMovementRepo;
    }

    public async Task AddStockMovementAsync(StockMovement data, bool applyDbChanges = false)
    {
      try
      {
        int locationId = ( int )((data.ToLocationId != null)
          ? data.ToLocationId
          : data.FromLocationId);

        ProductLocation productLocation = await AppServices.ProductLocationService
          .GetProductLocationAsync(data.ProductId, locationId);

        // Calculate the new accumulated stock
        if (productLocation != null)
        {
          data.Stock = (productLocation.Stock + data.Qty);
        }
        else
        {
          // Set the accumulated if it is the first movement
          data.Stock = data.Qty;
        }

        await _stockMovementRepo.InsertStockMovementAsync(data);

        // Normally this service is called inside other services 
        // and the call of the SaveChangesAsync method it will be
        // the responsibility of the other service.
        // In some circumstances we want the apply the 
        // db changes after create the stock movement, 
        // for that we need to sent the applyDbChanges setted to true.
        if (applyDbChanges)
        {
          await _stockMovementRepo.SaveDbChangesAsync();
        }
      }
      catch
      {
        OperationErrorsList errorsList = new OperationErrorsList();
        errorsList.AddError("add-stock-movement-db-error", Phrases.GlobalErrorOperationDB);

        throw new ServiceErrorException(errorsList);
      }
    }

    public async Task MoveStockToMainLocationAsync(ProductLocation data, int userId, bool applyDbChanges = false)
    {
      // Get the main location
      Location mainLocation = await AppServices.LocationService.GetMainLocationAsync();

      // Only create the stock movement if it has stock and the fromLocation is not the main location.
      if ((data.Stock > 0) && (mainLocation.LocationId != data.LocationId))
      {
        // Create a stock movement between locations
        StockMovement stockMovement = new StockMovement() {
          UserId = userId,
          ProductId = data.ProductId,
          FromLocationId = data.LocationId,
          FromLocationName = data.Location.Name,
          ToLocationId = mainLocation.LocationId,
          ToLocationName = mainLocation.Name,
          Qty = data.Stock,
        };

        await this.AddStockMovementAsync(stockMovement);

        // Get the relation between the product and the main location to be updated
        ProductLocation mainLocationRelation = await AppServices.ProductLocationService
          .GetProductLocationAsync(data.ProductId, mainLocation.LocationId);

        // Update the relation stock
        mainLocationRelation.Stock += data.Stock;

        if (applyDbChanges)
        {
          await _stockMovementRepo.SaveDbChangesAsync();
        }
      }
    }

    public async Task MoveStockBetweenLocationsAsync(int fromLocationId, int toLocationId, int productId, float qty, int userId)
    {
      OperationErrorsList errorsList = new OperationErrorsList();

      try
      {
        // Get the relation productId > fromLocationId to check if the qty can be accepted
        ProductLocation fromLocationRelation = await AppServices.ProductLocationService
           .GetProductLocationAsync(productId, fromLocationId);

        if (fromLocationRelation.Stock < qty)
        {
          errorsList.AddError("qty", Phrases.StockMovementErrorQty);
          throw new OperationErrorException(errorsList);
        }

        Location fromLocation = await AppServices.LocationService.GetLocationByIdAsync(fromLocationId);
        Location toLocation = await AppServices.LocationService.GetLocationByIdAsync(toLocationId);

        // Set the stock movement between locations
        StockMovement stockMovement = new StockMovement() {
          UserId = userId,
          ProductId = productId,
          FromLocationId = fromLocation.LocationId,
          FromLocationName = fromLocation.Name,
          ToLocationId = toLocation.LocationId,
          ToLocationName = toLocation.Name,
          Qty = qty,
        };

        // Create the stock movement
        await this.AddStockMovementAsync(stockMovement);

        // Update the stock in the From location
        fromLocationRelation.Stock -= qty;

        // Update the stock in the To location
        ProductLocation toLocationRelation = await AppServices.ProductLocationService
           .GetProductLocationAsync(productId, toLocationId);

        // If the product is associated to the location, update the stock
        if (toLocationRelation != null)
        {
          toLocationRelation.Stock += qty;
        }
        else
        {
          // If not, create the relation
          await AppServices.ProductLocationService.AddProductLocationAsync(
            new ProductLocation {
              LocationId = toLocationId,
              ProductId = productId,
              Stock = qty,
            },
            userId,
            false,
            false
          );
        }

        await _stockMovementRepo.SaveDbChangesAsync();
      }
      catch (OperationErrorException operationErrorException)
      {
        throw operationErrorException;
      }
    }

    public async Task<StockMovement> GetProductLastStockMovementAsync(int productId)
    {
      return await _stockMovementRepo
        .FindProductLastStockMovementAsync(productId);
    }
  }
}
