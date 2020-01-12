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

    public UserServices(AppDbContext db)
    {
      this.db = db;
    }

    /* 
     * Validate User form data 
     */
    private List<ErrorType> ValidateUserData(User user, User dbUser = null)
    {
      List<ErrorType> errors = new List<ErrorType>();

      if (string.IsNullOrEmpty(user.Username))
      {
        errors.Add(new ErrorType { Field = "Username", Error = "This field is required." });
      }

      if ((dbUser == null) && string.IsNullOrEmpty(user.Password))
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

    /* 
     * Create User 
     */
    public List<ErrorType> CreateUser(User data)
    {
      List<ErrorType> errors = this.ValidateUserData(data);

      if (errors.Count > 0)
      {
        return errors;
      }

      // Encrypt password
      data.Password = BCrypt.Net.BCrypt.HashPassword(data.Password);

      this.db.Add(data);
      this.db.SaveChanges();

      return errors;
    }

    /* 
     * Update User 
     */
    public List<ErrorType> UpdateUser(int userId, User user)
    {
      User dbUser = this.GetUserById(userId);
      List<ErrorType> errors = this.ValidateUserData(user, dbUser);

      if (errors.Count > 0)
      {
        return errors;
      }

      dbUser.Username = user.Username;
      dbUser.RoleId = user.RoleId;
      // If change password, encrypt it
      dbUser.Password = string.IsNullOrEmpty(user.Password)
        ? dbUser.Password
        : BCrypt.Net.BCrypt.HashPassword(user.Password);

      this.db.SaveChanges();

      return errors;
    }

    /* 
     * Get All Users 
     */
    public IEnumerable<User> GetUsers() => this.db.Users.Include(x => x.Role).ToList();

    /* 
     * Get User by Id 
     */
    public User GetUserById(int userId) => this.db.Users.FirstOrDefault(x => x.UserId == userId);

    /* 
     * Get User by Username 
     */
    public User GetUserByUsername(string username) => this.db.Users.Include(x => x.Role)
      .FirstOrDefault(x => x.Username == username);

    /* 
     * Delete Users 
     */
    public bool DeleteUsers(int[] userIds, int loggedInUserId)
    {
      foreach (int userId in userIds)
      {
        // You can't delete yourself
        if (userId != loggedInUserId)
        {
          User user = this.GetUserById(userId);
          this.db.Users.Remove(user);
        }
      }

      this.db.SaveChanges();

      return true;
    }

    /* 
     * Login 
     */
    public List<ErrorType> Login(string username, string password)
    {
      List<ErrorType> errors = new List<ErrorType>();

      // Validate login data
      if (string.IsNullOrEmpty(username))
      {
        errors.Add(new ErrorType { Field = "Username", Error = "This field is required." });
      }

      if (string.IsNullOrEmpty(password))
      {
        errors.Add(new ErrorType { Field = "Password", Error = "This field is required." });
      }

      if (errors.Count > 0)
      {
        return errors;
      }

      // get the user from the DB
      User user = this.GetUserByUsername(username);

      // If the user exist and the password are match, return zero errors
      if (user != null && BCrypt.Net.BCrypt.Verify(password, user.Password))
      {
        return errors;
      }
      else
      {
        errors.Add(new ErrorType { Field = "Generic", Error = "Invalid username and password combination." });
      }

      return errors;
    }

    /* 
   * Change Password 
   */
    public List<ErrorType> ChangePassword(int userId, string currentPassword, string newPassword)
    {
      List<ErrorType> errors = new List<ErrorType>();

      // Validate data
      if (string.IsNullOrEmpty(currentPassword))
      {
        errors.Add(new ErrorType { Field = "CurrentPassword", Error = "This field is required." });
      }

      if (string.IsNullOrEmpty(newPassword))
      {
        errors.Add(new ErrorType { Field = "NewPassword", Error = "This field is required." });
      }

      if (errors.Count > 0)
      {
        return errors;
      }

      // Get the user to verify the current password
      User dbUser = this.GetUserById(userId);

      if ((dbUser != null) && BCrypt.Net.BCrypt.Verify(currentPassword, dbUser.Password))
      {
        // Encrypt password
        dbUser.Password = BCrypt.Net.BCrypt.HashPassword(newPassword);
        this.db.SaveChanges();
      }
      else
      {
        errors.Add(new ErrorType { Field = "CurrentPassword", Error = "Invalid password." });
      }

      return errors;
    }
  }
}
