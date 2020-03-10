using StockManager.Storage.Brokers;
using StockManager.Storage.Models;
using StockManager.Types;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StockManager.Services {
  public class UserService : IUserService {
    private readonly IUserBroker userBroker;

    public UserService(IUserBroker userBroker) {
      this.userBroker = userBroker;
    }

    /// <summary>
    /// Create new user async
    /// </summary>
    public async Task CreateUserAsync(User user) {
      try {
        await this.ValidateUserFormDataAsync(user);
        await this.userBroker.AddUserAsync(user);
        await this.userBroker.SaveDbChangesAsync();
      } catch (OperationErrorException operationErrorException) {
        throw operationErrorException;
      }
    }

    /// <summary>
    /// Edit user async
    /// </summary>
    public async Task EditUserAsync(User user) {
      try {
        User dbUser = await this.userBroker.FindUserByIdAsync(user.UserId);
        await this.ValidateUserFormDataAsync(user, dbUser);

        dbUser.Username = user.Username;
        dbUser.RoleId = user.RoleId;

        // If change password, encrypt it
        dbUser.Password = string.IsNullOrEmpty(user.Password)
          ? dbUser.Password
          : BCrypt.Net.BCrypt.HashPassword(user.Password);

        await this.userBroker.SaveDbChangesAsync();
      } catch (OperationErrorException operationErrorException) {
        throw operationErrorException;
      }
    }

    /// <summary>
    /// Change Password
    /// </summary>
    public async Task ChangePasswordAsync(int userId, string currentPassword, string newPassword) {
      OperationErrorsList errorsList = new OperationErrorsList();

      // Validate data
      if (string.IsNullOrEmpty(currentPassword)) {
        errorsList.AddError(new ErrorType {
          Field = "CurrentPassword",
          Error = "This field is required."
        });
      }

      if (string.IsNullOrEmpty(newPassword)) {
        errorsList.AddError(new ErrorType {
          Field = "NewPassword",
          Error = "This field is required."
        });
      }

      if (errorsList.HasErrors()) {
        throw new OperationErrorException(errorsList);
      }

      // Get the user to verify the current password
      User dbUser = await this.userBroker.FindUserByIdAsync(userId);

      if ((dbUser != null) && BCrypt.Net.BCrypt.Verify(currentPassword, dbUser.Password)) {
        // Encrypt password
        dbUser.Password = BCrypt.Net.BCrypt.HashPassword(newPassword);
        await this.userBroker.SaveDbChangesAsync();
      } else {
        errorsList.AddError(new ErrorType {
          Field = "CurrentPassword",
          Error = "Invalid password."
        });

        throw new OperationErrorException(errorsList);
      }
    }

    /// <summary>
    /// Authentication the user
    /// </summary>
    public async Task<User> AuthenticateAsync(string username, string password) {
      OperationErrorsList errorsList = new OperationErrorsList();

      // Validate data
      if (string.IsNullOrEmpty(username)) {
        errorsList.AddError(new ErrorType {
          Field = "Username",
          Error = "This field is required."
        });
      }

      if (string.IsNullOrEmpty(password)) {
        errorsList.AddError(new ErrorType {
          Field = "Password",
          Error = "This field is required."
        });
      }

      if (errorsList.HasErrors()) {
        throw new OperationErrorException(errorsList);
      }

      // get the user from the DB
      User user = await this.userBroker.FindUserByUsernameAsync(username);

      // If the user exist and the password are match, it's all good.
      if (user != null && BCrypt.Net.BCrypt.Verify(password, user.Password)) {
        // Set the last login data
        user.LastLogin = DateTime.UtcNow;
        await this.userBroker.SaveDbChangesAsync();
      } else {
        errorsList.AddError(new ErrorType {
          Field = "Generic",
          Error = "Invalid username and password combination."
        });

        throw new OperationErrorException(errorsList);
      }

      return user;
    }

    /// <summary>
    /// Delete users async
    /// </summary>
    public async Task DeleteUserAsync(int[] userIds, int loggedInUserId) {
      try {
        for (int i = 0; i < userIds.Length; i += 1) {
          int userId = userIds[i];

          // You can't delete yourself
          if (userId != loggedInUserId) {
            User user = await this.userBroker.FindUserByIdAsync(userId);

            if (user != null) {
              this.userBroker.RemoveUser(user);
            }
          }
        }

        await this.userBroker.SaveDbChangesAsync();
      } catch {
        OperationErrorsList errorsList = new OperationErrorsList();
        errorsList.AddError(new ErrorType {
          Field = "delete-user-db-error",
          Error = "Oops.. something went wrong. Try it again!"
        });

        throw new OperationErrorException(errorsList);
      }
    }

    /// <summary>
    /// Get all users async
    /// </summary>
    public async Task<IEnumerable<User>> GetUsersAsync(string searchValue = null) {
      return await this.userBroker.FindAllUsersAsync(searchValue);
    }

    /// <summary>
    /// Get user by id async
    /// </summary>
    public async Task<User> GetUserByIdAsync(int userId) {
      return await this.userBroker.FindUserByIdAsync(userId);
    }

    /// <summary>
    /// Validate User form data
    /// </summary>
    private async Task ValidateUserFormDataAsync(User user, User dbUser = null) {
      OperationErrorsList errorsList = new OperationErrorsList();

      if (string.IsNullOrEmpty(user.Username)) {
        errorsList.AddError(new ErrorType {
          Field = "Username",
          Error = "This field is required."
        });
      }

      if ((dbUser == null) && string.IsNullOrEmpty(user.Password)) {
        errorsList.AddError(new ErrorType {
          Field = "Password",
          Error = "This field is required."
        });
      }

      // Validate the form values
      if (errorsList.HasErrors()) {
        throw new OperationErrorException(errorsList);
      }

      // Check if the username already exist
      // This validation only occurs when all form fields have no errors
      // And only if is a create or an update and the username has changed
      User usernameCheck = ((dbUser == null) || (dbUser.Username != user.Username))
        ? await this.userBroker.FindUserByUsernameAsync(user.Username)
        : null;

      if (usernameCheck != null) {
        errorsList.AddError(new ErrorType {
          Field = "Username",
          Error = "This username already exist."
        });

        throw new OperationErrorException(errorsList);
      }
    }
  }
}
