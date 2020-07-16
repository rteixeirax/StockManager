using StockManager.Database.Source.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StockManager.Services.Source.Contracts
{
    public interface IUserService
    {
        /// <summary>
        /// Authentication the user
        /// </summary>
        Task<User> AuthenticateAsync(string username, string password);

        /// <summary>
        /// Change Password
        /// </summary>
        Task ChangePasswordAsync(int userId, string currentPassword, string newPassword);

        /// <summary>
        /// Create new user async
        /// </summary>
        Task CreateUserAsync(User user);

        /// <summary>
        /// Delete users
        /// </summary>
        Task DeleteUserAsync(int[] userIds, int loggedInUserId);

        /// <summary>
        /// Edit user
        /// </summary>
        Task EditUserAsync(User user);

        /// <summary>
        /// Get user by id
        /// </summary>
        Task<User> GetUserByIdAsync(int userId);

        /// <summary>
        /// Get all users
        /// </summary>
        Task<IEnumerable<User>> GetUsersAsync(string searchValue = null);
    }
}
