using System.Collections.Generic;
using System.Threading.Tasks;

using StockManager.Database.Source.Models;

namespace StockManager.Database.Source.Contracts
{
    public interface IRoleRepository
    {
        /// <summary>
        /// Find all roles
        /// </summary>
        Task<IEnumerable<Role>> FindAllRolesAsync();
    }
}
