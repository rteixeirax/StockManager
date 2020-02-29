using Microsoft.EntityFrameworkCore;
using StockManager.Storage;
using StockManager.Storage.Models;
using StockManager.Storage.Repositories;
using StockManager.Types;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StockManager.Services
{
  public class UserServices : IUserRepository
  {
    private readonly StorageContext db;

    public UserServices(StorageContext db)
    {
      this.db = db;
    }

    /// <summary>
    /// Validate User form data
    /// </summary>
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
        ? this.db.Users.Where(x => x.Username.ToLower() == user.Username.ToLower()).Count()
        : 0;

      if (usernameCount > 0)
      {
        errors.Add(new ErrorType { Field = "Username", Error = "This username already exist." });
        return errors;
      }

      // no errors (count == 0)
      return errors;
    }

    /// <summary>
    /// Create User
    /// </summary>
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

    /// <summary>
    /// Update User
    /// </summary>
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

    /// <summary>
    /// Get All Users
    /// </summary>
    public IEnumerable<User> GetUsers(string searchValue = null)
    {
      if (!string.IsNullOrEmpty(searchValue))
      {
        return this.db.Users
          .Include(x => x.Role)
          .Where(x => x.Username.ToLower().Contains(searchValue.ToLower()))
          .ToList();
      }

      return this.db.Users.Include(x => x.Role).ToList();
    }

    /// <summary>
    /// Get User by Id
    /// </summary>
    public User GetUserById(int userId) => this.db.Users.FirstOrDefault(x => x.UserId == userId);

    /// <summary>
    /// Get User by Username
    /// </summary>
    public User GetUserByUsername(string username) => this.db.Users.Include(x => x.Role)
      .FirstOrDefault(x => (x.Username == username) || (x.Username.ToLower() == username.ToLower()));

    /// <summary>
    /// Delete Users
    /// </summary>
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

    /// <summary>
    /// Login
    /// </summary>
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
        // Set the last login data
        user.LastLogin = DateTime.UtcNow;
        this.db.SaveChanges();

        return errors;
      }
      else
      {
        errors.Add(new ErrorType { Field = "Generic", Error = "Invalid username and password combination." });
      }

      return errors;
    }

    /// <summary>
    /// Change Password
    /// </summary>
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
