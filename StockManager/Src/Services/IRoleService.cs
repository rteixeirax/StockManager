using System.Collections.Generic;
using System.Threading.Tasks;

using StockManager.Src.Data.Entities;

namespace StockManager.Src.Services
{
    public interface IRoleService
    {
        /// <summary>
        /// Get all roles
        /// </summary>
        Task<IEnumerable<Role>> GetAllAsync();
    }
}
