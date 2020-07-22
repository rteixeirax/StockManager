
using StockManager.Database.Source.Contracts;
using StockManager.Database.Source.Models;

namespace StockManager.Database.Source.Repositories
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
