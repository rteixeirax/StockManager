using StockManager.Database.Models;
using StockManager.Types;
using System.Collections.Generic;

namespace StockManager.Database.Repositories
{
  public interface IUserRepository
  {
    List<ErrorType> CreateUser(User data);

    List<ErrorType> UpdateUser(int userId, User data);

    IEnumerable<User> GetUsers();

    User GetUserById(int userId);

    User GetUserByUsername(string username);

    bool DeleteUsers(int[] userIds);

    List<ErrorType> Login(string username, string password);
  }
}
