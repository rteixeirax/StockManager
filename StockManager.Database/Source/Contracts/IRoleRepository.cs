
using StockManager.Database.Source.Models;

namespace StockManager.Database.Source.Contracts
{
    public interface IRoleRepository : IBaseRepository<Role>
    {
        // We only need a method that already exists in the BaseRepository
    }
}
