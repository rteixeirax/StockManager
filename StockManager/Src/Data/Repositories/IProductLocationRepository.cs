using StockManager.Src.Data.Entities;

namespace StockManager.Src.Data.Repositories
{
    public interface IProductLocationRepository : IBaseRepository<ProductLocation>
    {
        // We only need the methods that already exists in the BaseRepository
    }
}
