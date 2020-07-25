using System.Collections.Generic;
using System.Threading.Tasks;

using StockManager.Core.Source.Models;

namespace StockManager.Core.Source.Services
{
    public interface IRoleService
    {
        /// <summary>
        /// Get all roles
        /// </summary>
        Task<IEnumerable<Role>> GetAllAsync();
    }
}
