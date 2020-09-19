using System.Collections.Generic;

using StockManager.Core.Source.Models;
using StockManager.Core.Source.Types;

namespace StockManager.Core.Source.Services
{
    public interface IPdfService
    {
        void ExportStockMovementsToPdfAsync(ExportData<IEnumerable<StockMovement>, StockMovementOptions> data);
    }
}
