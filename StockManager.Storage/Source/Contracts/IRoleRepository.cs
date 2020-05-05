using StockManager.Storage.Source.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StockManager.Storage.Source.Contracts {
  public interface IRoleRepository {
    Task<IEnumerable<Role>> FindAllRolesAsync();
  }
}
