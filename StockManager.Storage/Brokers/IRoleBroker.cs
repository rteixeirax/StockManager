using StockManager.Storage.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StockManager.Storage.Brokers {
  public interface IRoleBroker {
    Task<IEnumerable<Role>> FindAllRolesAsync();
  }
}
