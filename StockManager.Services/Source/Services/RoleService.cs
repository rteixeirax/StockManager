using StockManager.Services.Source.Contracts;
using StockManager.Storage.Source.Contracts;
using StockManager.Storage.Source.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StockManager.Services.Source.Services {
  public class RoleService : IRoleService {
    private readonly IRoleRepository _roleRepo;

    public RoleService(IRoleRepository roleRepo) {
      _roleRepo = roleRepo;
    }

    /// <summary>
    /// Get all roles async
    /// </summary>
    public async Task<IEnumerable<Role>> GetRolesAsync() {
      return await _roleRepo.FindAllRolesAsync();
    }
  }
}
