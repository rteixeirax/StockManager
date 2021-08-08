using StockManager.Src.Data.Entities;

namespace StockManager.Src.Data.Repositories
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
