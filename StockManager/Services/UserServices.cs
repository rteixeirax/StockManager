using StockManager.Database.Repositories;
using StockManager.Entities;
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
      if (String.IsNullOrEmpty(user.username)
        || String.IsNullOrEmpty(user.password)
        || String.IsNullOrEmpty(user.role))
      {
        return false;
      }
      
      return true;
    }

    public List<User> GetAllUsers()
    {
      List<User> users = new List<User>();
      User user = new User();

      user.username = "Manel";
      user.password = "123";
      user.role = "Admin";
      user.lastLogin = DateTime.Now;

      users.Add(user);

      return users;
    }
  }
}
