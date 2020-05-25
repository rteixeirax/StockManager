using StockManager.Services.Source.Contracts;
using StockManager.Storage.Source.Contracts;
using StockManager.Storage.Source.Models;
using System;
using System.Threading.Tasks;

namespace StockManager.Services.Source.Services {
  public class StockMovementService : IStockMovementService {
    private readonly IStockMovementRepository _stockMovementRepo;

    public StockMovementService(IStockMovementRepository stockMovementRepo) {
      _stockMovementRepo = stockMovementRepo;
    }

    public async Task AddStockMovementAsync(StockMovement data) {
      try {
        // TODO: Validate the given data
        // TODO: Get the last stock movement to get the stock acc
        // Do the maths to calculate the newer acc

        await _stockMovementRepo.InsertStockMovementAsync(data);
      } catch (Exception) {
        throw;
      }
    }
  }
}
