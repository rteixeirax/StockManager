using System.Threading.Tasks;

using StockManager.Core.Source.Types;

namespace StockManager.Core.Source.Services
{
    public interface IPdfService
    {
        Task ExportStockMovementsToPdfAsync(StockMovementOptions options = null);
    }
}
