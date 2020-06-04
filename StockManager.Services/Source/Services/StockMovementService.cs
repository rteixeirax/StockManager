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
        StockMovement lastStockMovement = await this.GetProductLastStockMovementAsync(data.ProductId);

        // Calculate the new accumulated stock
        if (lastStockMovement != null)
        {
          data.Stock = (lastStockMovement.Stock + data.Qty);
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

    public async Task<StockMovement> GetProductLastStockMovementAsync(int productId)
    {
      return await _stockMovementRepo
        .FindProductLastStockMovementAsync(productId);
    }
  }
}
