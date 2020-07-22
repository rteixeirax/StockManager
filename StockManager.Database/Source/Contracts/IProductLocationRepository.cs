
using StockManager.Database.Source.Models;

namespace StockManager.Database.Source.Contracts
{
    public interface IProductLocationRepository : IBaseRepository<ProductLocation>
    {
        // We only need the methods that already exists in the BaseRepository 
    }
}
