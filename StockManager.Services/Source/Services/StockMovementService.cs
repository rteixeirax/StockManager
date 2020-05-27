using StockManager.Services.Source.Contracts;
using StockManager.Storage.Source.Contracts;
using StockManager.Storage.Source.Models;
using StockManager.Translations.Source;
using StockManager.Types.Source;
using System.Threading.Tasks;

namespace StockManager.Services.Source.Services {
  public class StockMovementService : IStockMovementService {
    private readonly IStockMovementRepository _stockMovementRepo;

    public StockMovementService(IStockMovementRepository stockMovementRepo) {
      _stockMovementRepo = stockMovementRepo;
    }

    public async Task AddStockMovementAsync(StockMovement data) {
      try {
        StockMovement lastStockMovement = await _stockMovementRepo
          .FindProductLastStockMovementAsync(data.ProductId);

        // Calculate the new accumulated stock
        if (lastStockMovement != null) {
          data.Stock = (lastStockMovement.Stock + data.Qty);

          // Set the accumulated if it is the first movement
        } else {
          data.Stock = data.Qty;
        }

        await _stockMovementRepo.InsertStockMovementAsync(data);
      } catch {
        OperationErrorsList errorsList = new OperationErrorsList();
        errorsList.AddError("add-stock-movement-db-error", Phrases.GlobalErrorOperationDB);

        throw new ServiceErrorException(errorsList);
      }
    }
  }
}
