using Microsoft.EntityFrameworkCore;
using StockManager.Storage.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StockManager.Storage.Brokers
{
  public class RoleBroker : IRoleBroker
  {
    private readonly StorageContext db;

    public RoleBroker(StorageContext db)
    {
      this.db = db;
    }

    /// <summary>
    /// Find all roles async
    /// </summary>
    public async Task<IEnumerable<Role>> FindAllRolesAsync()
    {
      return await this.db.Roles.ToListAsync();
    }
  }
}
