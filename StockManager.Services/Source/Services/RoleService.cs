using System.Collections.Generic;
using System.Threading.Tasks;

using StockManager.Database.Source.Contracts;
using StockManager.Database.Source.Models;
using StockManager.Services.Source.Contracts;

namespace StockManager.Services.Source.Services
{
    public class RoleService : IRoleService
    {
        private readonly IRepository _repository;

        public RoleService(IRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Role>> GetRolesAsync()
        {
            return await _repository.Roles.FindAllRolesAsync();
        }
    }
}
