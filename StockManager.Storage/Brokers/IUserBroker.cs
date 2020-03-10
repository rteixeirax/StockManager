using StockManager.Storage.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StockManager.Storage.Brokers {
  public interface IUserBroker {
    Task SaveDbChangesAsync();

    Task AddUserAsync(User user);

    void RemoveUser(User user);

    Task<IEnumerable<User>> FindAllUsersAsync(string searchValue = null);

    Task<User> FindUserByIdAsync(int userId);

    Task<User> FindUserByUsernameAsync(string username);
  }
}
