using StockManager.Storage.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StockManager.Services
{
  public interface IRoleService
  {
    Task<IEnumerable<Role>> GetRolesAsync();
  }
}
