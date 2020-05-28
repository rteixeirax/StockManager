using StockManager.Database.Source.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StockManager.Database.Source.Contracts {
  public interface IRoleRepository {
    Task<IEnumerable<Role>> FindAllRolesAsync();
  }
}
