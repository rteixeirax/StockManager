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
  }
}
