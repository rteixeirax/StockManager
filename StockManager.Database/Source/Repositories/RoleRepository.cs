using Microsoft.EntityFrameworkCore;
using StockManager.Database.Source.Contracts;
using StockManager.Database.Source.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StockManager.Database.Source.Repositories {
  public class RoleRepository : IRoleRepository {
    private readonly DatabaseContext _db;

    public RoleRepository(DatabaseContext db) {
      _db = db;
    }

    /// <summary>
    /// Find all roles async
    /// </summary>
    public async Task<IEnumerable<Role>> FindAllRolesAsync() {
      return await _db.Roles.ToListAsync();
    }
  }
}
