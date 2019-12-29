using Microsoft.EntityFrameworkCore;
using StockManager.Database;
using StockManager.Database.Models;
using StockManager.Database.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace StockManager.Services
{
  public class UserServices : IUserRepository
  {
    private readonly AppDbContext db;

    public UserServices()
    {
      this.db = new AppDbContext();
    }

    public IEnumerable<User> GetUsers() => this.db.Users.Include(x => x.Role).ToList();

    public bool CreateUser(User user)
    {
      if (string.IsNullOrEmpty(user.Username) || string.IsNullOrEmpty(user.Password))
      {
        return false;
      }

      this.db.Add(user);
      this.db.SaveChanges();

      return true;
    }
  }
}
