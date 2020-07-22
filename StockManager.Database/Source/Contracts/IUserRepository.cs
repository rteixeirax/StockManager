using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

using StockManager.Database.Source.Models;

namespace StockManager.Database.Source.Contracts
{
    public interface IUserRepository : IBaseRepository<User>
    {
        /// <summary>
        /// Add new user
        /// </summary>
        Task AddUserAsync(User user);

        /// <summary>
        /// Find all users with role included
        /// </summary>
        Task<IEnumerable<User>> FindAllWithRoleAsync(Expression<Func<User, bool>> expression);

        /// <summary>
        /// Find all users with role included without lamba expression
        /// </summary>
        Task<IEnumerable<User>> FindAllWithRoleAsync();

        /// <summary>
        /// Find one user with role included
        /// </summary>
        Task<User> FindOneWithRoleAsync(Expression<Func<User, bool>> expression);

        /// <summary>
        /// Get user by id with role included
        /// </summary>
        Task<User> GetByIdWithRoleAsync(int id);
    }
}
