using StockManager.Core.Source.Models;
using StockManager.Core.Source.Repositories;

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
