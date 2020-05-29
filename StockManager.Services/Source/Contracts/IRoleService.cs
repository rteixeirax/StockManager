using StockManager.Database.Source.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

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
