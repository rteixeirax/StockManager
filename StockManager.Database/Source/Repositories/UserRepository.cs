using Microsoft.EntityFrameworkCore;
using StockManager.Database.Source.Contracts;
using StockManager.Database.Source.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockManager.Database.Source.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DatabaseContext _db;

        public UserRepository(DatabaseContext db)
        {
            _db = db;
        }

        public async Task AddUserAsync(User user)
        {
            await _db.Users.AddAsync(user);
        }

        public async Task<int> CountAsync()
        {
            return await _db.Users.CountAsync();
        }

        public async Task<IEnumerable<User>> FindAllUsersAsync(string searchValue = null)
        {
            if (!string.IsNullOrEmpty(searchValue))
            {
                return await _db.Users
                  .Include(x => x.Role)
                  .Where(user => user.Username.ToLower().Contains(searchValue.ToLower()))
                  .ToListAsync();
            }

            return await _db.Users.Include(x => x.Role).ToListAsync();
        }

        public async Task<User> FindUserByIdAsync(int userId)
        {
            return await _db.Users
              .Include(x => x.Role)
              .Where(user => user.UserId == userId)
              .FirstOrDefaultAsync();
        }

        public async Task<User> FindUserByUsernameAsync(string username)
        {
            return await _db.Users
              .Include(x => x.Role)
              .Where(user => user.Username.ToLower() == username.ToLower())
              .FirstOrDefaultAsync();
        }

        public void RemoveUser(User user)
        {
            _db.Users.Remove(user);
        }

        public async Task SaveDbChangesAsync()
        {
            await _db.SaveChangesAsync();
        }
    }
}
