using StockManager.Database.Models;
using StockManager.Types;
using System.Collections.Generic;

namespace StockManager.Database.Repositories
{
  public interface IUserRepository
  {
    List<ErrorType> CreateUser(User user);

    IEnumerable<User> GetUsers();
  }
}
