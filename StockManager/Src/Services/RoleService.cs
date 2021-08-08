using System.Collections.Generic;
using System.Threading.Tasks;

using StockManager.Src.Data.Entities;
using StockManager.Src.Data.Repositories;

namespace StockManager.Src.Services.Services
{
    public class RoleService : IRoleService
    {
        private readonly IAppRepository _repository;

        public RoleService(IAppRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Role>> GetAllAsync()
        {
            return await _repository.Roles.GetAllAsync();
        }
    }
}
