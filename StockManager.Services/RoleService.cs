using StockManager.Storage.Brokers;
using StockManager.Storage.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StockManager.Services {
  public class RoleService : IRoleService {
    private readonly IRoleBroker roleBroker;

    public RoleService(IRoleBroker roleBroker) {
      this.roleBroker = roleBroker;
    }

    /// <summary>
    /// Get all roles async
    /// </summary>
    public async Task<IEnumerable<Role>> GetRolesAsync() {
      return await this.roleBroker.FindAllRolesAsync();
    }
  }
}
