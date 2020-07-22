using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using StockManager.Database.Source.Contracts;
using StockManager.Database.Source.Models;
using StockManager.Services.Source.Contracts;
using StockManager.Translations.Source;
using StockManager.Types.Source;

namespace StockManager.Services.Source.Services
{
    public class UserService : IUserService
    {
        private readonly IRepository _repository;

        public UserService(IRepository repository)
        {
            _repository = repository;
        }

        public async Task<User> AuthenticateAsync(string username, string password)
        {
            OperationErrorsList errorsList = new OperationErrorsList();

            // Validate data
            if (string.IsNullOrEmpty(username))
            {
                errorsList.AddError("Username", Phrases.GlobalRequiredField);
            }

            if (string.IsNullOrEmpty(password))
            {
                errorsList.AddError("Password", Phrases.GlobalRequiredField);
            }

            if (errorsList.HasErrors())
            {
                throw new OperationErrorException(errorsList);
            }

            // get the user from the DB
            User user = await _repository.Users.FindOneWithRoleAsync(u => u.Username.ToLower() == username.ToLower());

            // If the user exist and the password are match, it's all good.
            if (user != null && BCrypt.Net.BCrypt.Verify(password, user.Password))
            {
                // Set the last login data
                user.LastLogin = DateTime.UtcNow;
                await _repository.SaveChangesAsync();
            }
            else
            {
                errorsList.AddError("Generic", Phrases.UserErrorLogin);

                throw new OperationErrorException(errorsList);
            }

            return user;
        }

        public async Task ChangePasswordAsync(int userId, string currentPassword, string newPassword)
        {
            OperationErrorsList errorsList = new OperationErrorsList();

            // Validate data
            if (string.IsNullOrEmpty(currentPassword))
            {
                errorsList.AddError("CurrentPassword", Phrases.GlobalRequiredField);
            }

            if (string.IsNullOrEmpty(newPassword))
            {
                errorsList.AddError("NewPassword", Phrases.GlobalRequiredField);
            }

            if (errorsList.HasErrors())
            {
                throw new OperationErrorException(errorsList);
            }

            // Get the user to verify the current password
            User dbUser = await _repository.Users.GetByIdWithRoleAsync(userId);

            if ((dbUser != null) && BCrypt.Net.BCrypt.Verify(currentPassword, dbUser.Password))
            {
                // Encrypt password
                dbUser.Password = BCrypt.Net.BCrypt.HashPassword(newPassword);
                await _repository.SaveChangesAsync();
            }
            else
            {
                errorsList.AddError("CurrentPassword", Phrases.UserErrorInvalidPassword);

                throw new OperationErrorException(errorsList);
            }
        }

        public async Task<int> CountAsync()
        {
            return await _repository.Users.CountAsync();
        }

        public async Task CreateUserAsync(User user)
        {
            try
            {
                await ValidateUserFormDataAsync(user);

                // Encrypt password
                user.Password = BCrypt.Net.BCrypt.HashPassword(user.Password);

                await _repository.Users.AddUserAsync(user);
                await _repository.SaveChangesAsync();
            }
            catch (OperationErrorException operationErrorException)
            {
                throw operationErrorException;
            }
        }

        public async Task DeleteUserAsync(int[] userIds, int loggedInUserId)
        {
            OperationErrorsList errorsList = new OperationErrorsList();

            try
            {
                // You can't delete yourself
                if (userIds.Contains(loggedInUserId))
                {
                    errorsList.AddError("LoggedInUserId", Phrases.UserErrorDeleteYourself);

                    throw new OperationErrorException(errorsList);
                }

                for (int i = 0; i < userIds.Length; i += 1)
                {
                    int userId = userIds[i];

                    User user = await _repository.Users.GetByIdWithRoleAsync(userId);

                    if (user != null)
                    {
                        _repository.Users.Remove(user);
                    }
                }

                await _repository.SaveChangesAsync();

                // Catch operation errors
            }
            catch (OperationErrorException operationErrorException)
            {
                throw operationErrorException;

                // catch other errors and send a Service Error Exception
            }
            catch
            {
                errorsList.AddError("delete-user-db-error", Phrases.GlobalErrorOperationDB);

                throw new ServiceErrorException(errorsList);
            }
        }

        public async Task EditUserAsync(User user)
        {
            try
            {
                User dbUser = await _repository.Users.GetByIdWithRoleAsync(user.UserId);
                await ValidateUserFormDataAsync(user, dbUser);

                dbUser.Username = user.Username;
                dbUser.RoleId = user.RoleId;

                // If change password, encrypt it
                dbUser.Password = string.IsNullOrEmpty(user.Password)
                  ? dbUser.Password
                  : BCrypt.Net.BCrypt.HashPassword(user.Password);

                await _repository.SaveChangesAsync();
            }
            catch (OperationErrorException operationErrorException)
            {
                throw operationErrorException;
            }
        }

        public async Task<User> GetUserByIdAsync(int userId)
        {
            return await _repository.Users.GetByIdWithRoleAsync(userId);
        }

        public async Task<IEnumerable<User>> GetUsersAsync(string searchValue = null)
        {
            if (!string.IsNullOrEmpty(searchValue))
            {
                return await _repository.Users
                    .FindAllWithRoleAsync(user => user.Username.ToLower().Contains(searchValue.ToLower()));
            }

            return await _repository.Users.FindAllWithRoleAsync();

            //return await _repository.Users.FindAllUsersAsync(searchValue);
        }

        /// <summary>
        /// Validate User form data
        /// </summary>
        private async Task ValidateUserFormDataAsync(User user, User dbUser = null)
        {
            OperationErrorsList errorsList = new OperationErrorsList();

            if (string.IsNullOrEmpty(user.Username))
            {
                errorsList.AddError("Username", Phrases.GlobalRequiredField);
            }

            if ((dbUser == null) && string.IsNullOrEmpty(user.Password))
            {
                errorsList.AddError("Password", Phrases.GlobalRequiredField);
            }

            // Validate the form values
            if (errorsList.HasErrors())
            {
                throw new OperationErrorException(errorsList);
            }

            // Check if the username already exist This validation only occurs when all form fields
            // have no errors And only if is a create or an update and the username has changed
            User usernameCheck = ((dbUser == null) || (dbUser.Username != user.Username))
              ? await _repository.Users.FindOneWithRoleAsync(u => u.Username.ToLower().Contains(user.Username.ToLower()))
              : null;

            if (usernameCheck != null)
            {
                errorsList.AddError("Username", Phrases.UserErrorUsername);

                throw new OperationErrorException(errorsList);
            }
        }
    }
}
