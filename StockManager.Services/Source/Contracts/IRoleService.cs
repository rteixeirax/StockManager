using System.Collections.Generic;
using System.Threading.Tasks;

using StockManager.Database.Source.Models;

namespace StockManager.Services.Source.Contracts
{
    public interface IRoleService
    {
        /// <summary>
        /// Get all roles
        /// </summary>
        Task<IEnumerable<Role>> GetRolesAsync();
    }
}
