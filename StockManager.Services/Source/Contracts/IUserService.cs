using System.Collections.Generic;
using System.Threading.Tasks;

using StockManager.Database.Source.Models;

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
        /// Count and return the total of the users in the app
        /// </summary>
        Task<int> CountAsync();

        /// <summary>
        /// Create new user async
        /// </summary>
        Task CreateAsync(User user);

        /// <summary>
        /// Delete users
        /// </summary>
        Task DeleteAsync(int[] userIds, int loggedInUserId);

        /// <summary>
        /// Edit user
        /// </summary>
        Task EditAsync(User user);

        /// <summary>
        /// Get user by id
        /// </summary>
        Task<User> GetByIdAsync(int userId);

        /// <summary>
        /// Get all users
        /// </summary>
        Task<IEnumerable<User>> GetAllAsync(string searchValue = null);
    }
}
