using StockManager.Database.Source.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

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
