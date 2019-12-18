using StockManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManager.Database.Repositories
{
  public interface IUserRepository
  {
    bool CreateUser(User user);
  }
}
