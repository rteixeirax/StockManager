using StockManager.Src.Data.Entities;

namespace StockManager.Src.Data.Repositories
{
    public class RoleRepository : BaseRepository<Role>, IRoleRepository
    {
        private readonly DatabaseContext _db;

        public RoleRepository(DatabaseContext db) : base(db)
        {
            _db = db;
        }
    }
}
