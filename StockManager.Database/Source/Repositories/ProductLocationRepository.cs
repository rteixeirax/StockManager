using StockManager.Core.Source.Models;
using StockManager.Core.Source.Repositories;

namespace StockManager.Database.Source.Repositories
{
    public class ProductLocationRepository : BaseRepository<ProductLocation>, IProductLocationRepository
    {
        private readonly DatabaseContext _db;

        public ProductLocationRepository(DatabaseContext db) : base(db)
        {
            _db = db;
        }
    }
}
