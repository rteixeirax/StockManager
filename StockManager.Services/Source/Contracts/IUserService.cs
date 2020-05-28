using StockManager.Database.Source.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StockManager.Services.Source.Contracts {
  public interface IUserService {
    Task CreateUserAsync(User user);

    Task EditUserAsync(User user);

    Task ChangePasswordAsync(int userId, string currentPassword, string newPassword);

    Task<User> AuthenticateAsync(string username, string password);

    Task DeleteUserAsync(int[] userIds, int loggedInUserId);

    Task<IEnumerable<User>> GetUsersAsync(string searchValue = null);

    Task<User> GetUserByIdAsync(int userId);
  }
}
