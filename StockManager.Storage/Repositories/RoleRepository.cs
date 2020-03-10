using Microsoft.EntityFrameworkCore;
using StockManager.Storage.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StockManager.Storage.Repositories {
  public class RoleRepository : IRoleRepository {
    private readonly StorageContext db;

    public RoleRepository(StorageContext db) {
      this.db = db;
    }

    /// <summary>
    /// Find all roles async
    /// </summary>
    public async Task<IEnumerable<Role>> FindAllRolesAsync() {
      return await this.db.Roles.ToListAsync();
    }
  }
}
