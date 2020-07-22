using System;
using System.Threading.Tasks;

namespace StockManager.Database.Source.Contracts
{
    public interface IRepository : IDisposable
    {
        IAppSettingsRepository AppSettings { get; }

        ILocationRepository Locations { get; }

        IProductLocationRepository ProductLocations { get; }

        IProductRepository Products { get; }

        IRoleRepository Roles { get; }

        IStockMovementRepository StockMovements { get; }

        IUserRepository Users { get; }

        Task SaveChangesAsync();
    }
}
