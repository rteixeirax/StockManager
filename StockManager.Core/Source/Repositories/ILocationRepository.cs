using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

using StockManager.Core.Source.Models;

namespace StockManager.Core.Source.Repositories
{
    public interface ILocationRepository : IBaseRepository<Location>
    {
        /// <summary>
        /// Find all locations with productLocations included that satisfy the given lambda expression
        /// </summary>
        Task<IEnumerable<Location>> FindAllWithProductLocationsAsync(Expression<Func<Location, bool>> expression);

        /// <summary>
        ///  Find all locations with productLocations included without lamba expression
        /// </summary>
        Task<IEnumerable<Location>> FindAllWithProductLocationsAsync();

        /// <summary>
        ///  Find one location with productLocations included without lamba expression
        /// </summary>
        Task<Location> FindOneWithProductLocationsAsync(Expression<Func<Location, bool>> expression);

        /// <summary>
        /// Get location by Id with productLocations included
        /// </summary>
        Task<Location> GetByIdWithProductLocationsAsync(int locationId);
    }
}
