using Microsoft.EntityFrameworkCore;
using StockManager.Storage.Source.Contracts;
using StockManager.Storage.Source.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockManager.Storage.Source.Repositories {
  public class UserRepository : IUserRepository {
    private readonly DatabaseContext _db;

    public UserRepository(DatabaseContext db) {
      _db = db;
    }

    /// <summary>
    /// Save DB changes async
    /// </summary>
    public async Task SaveDbChangesAsync() {
      await _db.SaveChangesAsync();
    }

    /// <summary>
    /// Add new user async
    /// </summary>
    public async Task AddUserAsync(User user) {
      await _db.Users.AddAsync(user);
    }

    /// <summary>
    /// Remove user async
    /// </summary>
    public void RemoveUser(User user) {
      _db.Users.Remove(user);
    }

    /// <summary>
    /// Find all users async
    /// </summary>
    public async Task<IEnumerable<User>> FindAllUsersAsync(string searchValue = null) {
      if (!string.IsNullOrEmpty(searchValue)) {
        return await _db.Users
          .Include(x => x.Role)
          .Where(user => user.Username.ToLower().Contains(searchValue.ToLower()))
          .ToListAsync();
      }

      return await _db.Users.Include(x => x.Role).ToListAsync();
    }

    /// <summary>
    /// Find user by id async
    /// </summary>
    public async Task<User> FindUserByIdAsync(int userId) {
      return await _db.Users
        .Include(x => x.Role)
        .Where(user => user.UserId == userId)
        .FirstOrDefaultAsync();
    }

    /// <summary>
    /// Find user by username async
    /// </summary>
    public async Task<User> FindUserByUsernameAsync(string username) {
      return await _db.Users
        .Include(x => x.Role)
        .Where(user => user.Username.ToLower() == username.ToLower())
        .FirstOrDefaultAsync();
    }
  }
}
