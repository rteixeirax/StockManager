using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

using StockManager.Core.Source.Models;

namespace StockManager.Core.Source.Repositories
{
    public interface IUserRepository : IBaseRepository<User>
    {
        /// <summary>
        /// Find all users with role included that satisfy the given lambda expression
        /// </summary>
        Task<IEnumerable<User>> FindAllWithRoleAsync(Expression<Func<User, bool>> expression);

        /// <summary>
        /// Find all users with role included without lamba expression
        /// </summary>
        Task<IEnumerable<User>> FindAllWithRoleAsync();

        /// <summary>
        /// Find one user with role included that satisfy the given lambda expression
        /// </summary>
        Task<User> FindOneWithRoleAsync(Expression<Func<User, bool>> expression);

        /// <summary>
        /// Get user by id with role included
        /// </summary>
        Task<User> GetByIdWithRoleAsync(int id);
    }
}
