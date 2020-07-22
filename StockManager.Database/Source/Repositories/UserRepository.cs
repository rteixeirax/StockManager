using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

using StockManager.Database.Source.Contracts;
using StockManager.Database.Source.Models;

namespace StockManager.Database.Source.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        private readonly DatabaseContext _db;

        public UserRepository(DatabaseContext db) : base(db)
        {
            _db = db;
        }

        public async Task<IEnumerable<User>> FindAllWithRoleAsync(Expression<Func<User, bool>> expression)
        {
            return await _db.Users.Include(x => x.Role).Where(expression).ToListAsync();
        }

        public async Task<IEnumerable<User>> FindAllWithRoleAsync()
        {
            return await _db.Users.Include(x => x.Role).ToListAsync();
        }

        public async Task<User> FindOneWithRoleAsync(Expression<Func<User, bool>> expression)
        {
            return await _db.Users.Include(x => x.Role).SingleOrDefaultAsync(expression);
        }

        public async Task<User> GetByIdWithRoleAsync(int id)
        {
            return await _db.Users
                .Include(user => user.Role)
                .Where(user => user.UserId == id)
                .FirstOrDefaultAsync();
        }
    }
}
