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
    public class LocationRepository : BaseRepository<Location>, ILocationRepository
    {
        private readonly DatabaseContext _db;

        public LocationRepository(DatabaseContext db) : base(db)
        {
            _db = db;
        }

        public async Task<IEnumerable<Location>> FindAllWithProductLocationsAsync(Expression<Func<Location, bool>> expression)
        {
            return await _db.Locations
                .Include(x => x.ProductLocations)
                .Where(expression)
                .ToListAsync();
        }

        public async Task<IEnumerable<Location>> FindAllWithProductLocationsAsync()
        {
            return await _db.Locations
               .Include(x => x.ProductLocations)
               .ThenInclude(x => x.Product)
               .ToListAsync();
        }

        public async Task<Location> FindOneWithProductLocationsAsync(Expression<Func<Location, bool>> expression)
        {
            return await _db.Locations
                .Include(x => x.ProductLocations)
                .ThenInclude(x => x.Product)
                .Where(expression)
                .FirstOrDefaultAsync();
        }

        public async Task<Location> GetByIdWithProductLocationsAsync(int locationId)
        {
            return await _db.Locations
                .Include(x => x.ProductLocations)
                .ThenInclude(x => x.Product)
                .Where(location => location.LocationId == locationId)
                .FirstOrDefaultAsync();
        }
    }
}
