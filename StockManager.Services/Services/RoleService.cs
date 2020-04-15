using StockManager.Services.Contracts;
using StockManager.Storage.Contracts;
using StockManager.Storage.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StockManager.Services.Services {
  public class RoleService : IRoleService {
    private readonly IRoleRepository roleRepo;

    public RoleService(IRoleRepository roleRepo) {
      this.roleRepo = roleRepo;
    }

    /// <summary>
    /// Get all roles async
    /// </summary>
    public async Task<IEnumerable<Role>> GetRolesAsync() {
      return await this.roleRepo.FindAllRolesAsync();
    }
  }
}
