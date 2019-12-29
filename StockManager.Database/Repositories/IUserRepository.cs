using StockManager.Database.Models;
using System.Collections.Generic;

namespace StockManager.Database.Repositories
{
  public interface IUserRepository
  {
    bool CreateUser(User user);
    IEnumerable<User> GetUsers();
  }
}
