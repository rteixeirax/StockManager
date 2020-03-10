using StockManager.Storage.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StockManager.Storage.Repositories {
  public interface IRoleRepository {
    Task<IEnumerable<Role>> FindAllRolesAsync();
  }
}
