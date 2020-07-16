using StockManager.Database.Source.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StockManager.Database.Source.Contracts
{
    public interface IUserRepository
    {
        /// <summary>
        /// Add new user
        /// </summary>
        Task AddUserAsync(User user);

        /// <summary>
        /// Find all users
        /// </summary>
        Task<IEnumerable<User>> FindAllUsersAsync(string searchValue = null);

        /// <summary>
        /// Find user by id
        /// </summary>
        Task<User> FindUserByIdAsync(int userId);

        /// <summary>
        /// Find user by username
        /// </summary>
        Task<User> FindUserByUsernameAsync(string username);

        /// <summary>
        /// Remove user
        /// </summary>
        void RemoveUser(User user);

        /// <summary>
        /// Save DB changes
        /// </summary>
        Task SaveDbChangesAsync();
    }
}
