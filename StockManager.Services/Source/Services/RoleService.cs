using System.Collections.Generic;
using System.Threading.Tasks;

using StockManager.Core.Source;
using StockManager.Core.Source.Models;
using StockManager.Core.Source.Services;

namespace StockManager.Services.Source.Services
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
