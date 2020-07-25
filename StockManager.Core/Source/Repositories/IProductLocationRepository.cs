
using StockManager.Core.Source.Models;

namespace StockManager.Core.Source.Repositories
{
    public interface IProductLocationRepository : IBaseRepository<ProductLocation>
    {
        // We only need the methods that already exists in the BaseRepository 
    }
}
