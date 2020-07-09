using StockManager.Database.Source.Contracts;
using StockManager.Database.Source.Models;
using StockManager.Services.Source.Contracts;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StockManager.Services.Source.Services
{
    public class RoleService : IRoleService
    {
        private readonly IRoleRepository _roleRepo;

        public RoleService(IRoleRepository roleRepo)
        {
            _roleRepo = roleRepo;
        }

        public async Task<IEnumerable<Role>> GetRolesAsync()
        {
            return await _roleRepo.FindAllRolesAsync();
        }
    }
}
