using StockManager.Database.Models;
using StockManager.Database.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManager.Services
{
  public class UserServices : IUserRepository
  {
    public bool CreateUser(User user)
    {
      if (string.IsNullOrEmpty(user.Username)
        || string.IsNullOrEmpty(user.Password)
        || user.RoleId == 0)
      {
        return false;
      }

      return true;
    }

    public List<User> GetAllUsers()
    {
      List<User> users = new List<User>();
      User user = new User();
      User user2 = new User();

      user.Username = "Manel";
      user.Password = "123";
      user.RoleId = 1;
      user.LastLogin = DateTime.Now;

      users.Add(user);

      user2.Username = "Antonio";
      user2.Password = "123";
      user2.RoleId = 2;
      user2.LastLogin = DateTime.Now;

      users.Add(user2);

      return users;
    }
  }
}
