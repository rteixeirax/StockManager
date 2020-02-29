using StockManager.Storage.Models;
using System.Collections.Generic;

namespace StockManager.Storage.Repositories
{
  public interface IRoleRepository
  {
    IEnumerable<Role> GetRoles();
  }
}
