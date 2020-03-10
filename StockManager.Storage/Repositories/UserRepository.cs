using Microsoft.EntityFrameworkCore;
using StockManager.Storage.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockManager.Storage.Repositories {
  public class UserRepository : IUserRepository {
    private readonly StorageContext db;

    public UserRepository(StorageContext db) {
      this.db = db;
    }

    /// <summary>
    /// Save DB changes async
    /// </summary>
    public async Task SaveDbChangesAsync() {
      await this.db.SaveChangesAsync();
    }

    /// <summary>
    /// Add new user async
    /// </summary>
    public async Task AddUserAsync(User user) {
      await this.db.Users.AddAsync(user);
    }

    /// <summary>
    /// Remove user async
    /// </summary>
    public void RemoveUser(User user) {
      this.db.Users.Remove(user);
    }

    /// <summary>
    /// Find all users async
    /// </summary>
    public async Task<IEnumerable<User>> FindAllUsersAsync(string searchValue = null) {
      if (!string.IsNullOrEmpty(searchValue)) {
        return await this.db.Users
          .Include(x => x.Role)
          .Where(user => user.Username.ToLower().Contains(searchValue.ToLower()))
          .ToListAsync();
      }

      return await this.db.Users.Include(x => x.Role).ToListAsync();
    }

    /// <summary>
    /// Find user by id async
    /// </summary>
    public async Task<User> FindUserByIdAsync(int userId) {
      return await this.db.Users
        .Include(x => x.Role)
        .Where(user => user.UserId == userId)
        .FirstOrDefaultAsync();
    }

    /// <summary>
    /// Find user by username async
    /// </summary>
    public async Task<User> FindUserByUsernameAsync(string username) {
      return await this.db.Users
        .Include(x => x.Role)
        .Where(user => user.Username.ToLower() == username.ToLower())
        .FirstOrDefaultAsync();
    }
  }
}
