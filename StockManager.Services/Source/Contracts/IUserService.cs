using StockManager.Database.Source.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StockManager.Services.Source.Contracts
{
  public interface IUserService
  {
    /// <summary>
    /// Create new user async
    /// </summary>
    Task CreateUserAsync(User user);

    /// <summary>
    /// Edit user
    /// </summary>
    Task EditUserAsync(User user);

    /// <summary>
    /// Change Password
    /// </summary>
    Task ChangePasswordAsync(int userId, string currentPassword, string newPassword);

    /// <summary>
    /// Authentication the user
    /// </summary>
    Task<User> AuthenticateAsync(string username, string password);

    /// <summary>
    /// Delete users
    /// </summary>
    Task DeleteUserAsync(int[] userIds, int loggedInUserId);

    /// <summary>
    /// Get all users
    /// </summary>
    Task<IEnumerable<User>> GetUsersAsync(string searchValue = null);

    /// <summary>
    /// Get user by id
    /// </summary>
    Task<User> GetUserByIdAsync(int userId);
  }
}
