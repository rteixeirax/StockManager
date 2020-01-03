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

    /* Validate User form data */
    private List<ErrorType> ValidateUserData(User user, User dbUser = null)
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
      // And only if is a create or an update and the username has changed
      int usernameCount = ((dbUser == null) || (dbUser.Username != user.Username))
        ? this.db.Users.Where(x => x.Username == user.Username).Count()
        : 0;

      if (usernameCount > 0)
      {
        errors.Add(new ErrorType { Field = "Username", Error = "This username already exist." });
        return errors;
      }

      // no errors (count == 0)
      return errors;
    }

    /* Create User */
    public List<ErrorType> CreateUser(User data)
    {
      List<ErrorType> errors = this.ValidateUserData(data);

      if (errors.Count > 0)
      {
        return errors;
      }

      this.db.Add(data);
      this.db.SaveChanges();

      return errors;
    }

    /* Update User */
    public List<ErrorType> UpdateUser(int userId, User user)
    {
      User dbUser = this.GetUserById(userId);
      List<ErrorType> errors = this.ValidateUserData(user, dbUser);

      if (errors.Count > 0)
      {
        return errors;
      }

      dbUser.Username = user.Username;
      dbUser.Password = user.Password;
      dbUser.RoleId = user.RoleId;

      this.db.SaveChanges();

      return errors;
    }

    /* Get All Users */
    public IEnumerable<User> GetUsers() => this.db.Users.Include(x => x.Role).ToList();

    /* Get User by Id */
    public User GetUserById(int userId) => this.db.Users.FirstOrDefault(x => x.UserId == userId);

    /* Delete Users */
    public bool DeleteUsers(int[] userIds)
    {
      foreach (int userId in userIds)
      {
        User user = this.GetUserById(userId);
        this.db.Users.Remove(user);
      }

      this.db.SaveChanges();

      return true;
    }
  }
}
