using StockManager.Database.Models;
using System.Collections.Generic;

namespace StockManager.Database.Repositories
{
  public interface IRoleRepository
  {
    IEnumerable<Role> GetRoles();
  }
}
