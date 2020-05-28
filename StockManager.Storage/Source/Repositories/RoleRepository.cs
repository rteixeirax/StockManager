using Microsoft.EntityFrameworkCore;
using StockManager.Storage.Source.Contracts;
using StockManager.Storage.Source.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StockManager.Storage.Source.Repositories {
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
