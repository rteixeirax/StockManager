using StockManager.Storage.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StockManager.Storage.Contracts {
  public interface IRoleRepository {
    Task<IEnumerable<Role>> FindAllRolesAsync();
  }
}
