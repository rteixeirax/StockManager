using Microsoft.EntityFrameworkCore;
using StockManager.Database;
using StockManager.Database.Models;
using StockManager.Database.Repositories;
using StockManager.Types;
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

    private List<ErrorType> ValidateUser(User user)
    {
      List<ErrorType> errors = new List<ErrorType>();

      if (string.IsNullOrEmpty(user.Username))
      {
        errors.Add(new ErrorType { Field = "Username", Error = "This field is required." });
      }

      if (string.IsNullOrEmpty(user.Password))
      {
        errors.Add(new ErrorType { Field = "Password", Error = "This field is required." });
      }

      // Validate the form values
      if (errors.Count > 0)
      {
        return errors;
      }

      // Check if the username already exist
      // This validation only occurs when all form fields have no errors
      int userNameCount = this.db.Users.Where(x => x.Username == user.Username).Count();

      if (userNameCount > 0)
      {
        errors.Add(new ErrorType { Field = "Username", Error = "This username already exist." });
        return errors;
      }

      // no errors (count == 0)
      return errors;
    }

    public IEnumerable<User> GetUsers() => this.db.Users.Include(x => x.Role).ToList();

    public List<ErrorType> CreateUser(User user)
    {
      List<ErrorType> errors = this.ValidateUser(user);

      if (errors.Count > 0)
      {
        return errors;
      }

      this.db.Add(user);
      this.db.SaveChanges();

      return errors;
    }
  }
}
