using System;
using System.Threading.Tasks;

using StockManager.Core.Source.Repositories;

namespace StockManager.Core.Source
{
    public interface IAppRepository : IDisposable
    {
        IAppSettingsRepository AppSettings { get; }

        ILocationRepository Locations { get; }

        INotificationRepository Notifications { get; }

        IProductLocationRepository ProductLocations { get; }

        IProductRepository Products { get; }

        IRoleRepository Roles { get; }

        IStockMovementRepository StockMovements { get; }

        IUserRepository Users { get; }

        Task SaveChangesAsync();
    }
}
