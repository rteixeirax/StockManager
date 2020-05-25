﻿using StockManager.Storage.Source.Models;
using System.Threading.Tasks;

namespace StockManager.Services.Source.Contracts {
  public interface IStockMovementService {
    Task AddStockMovementAsync(StockMovement data);
  }
}
