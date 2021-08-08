using StockManager.Src.Data.Repositories;
using StockManager.Src.Services.Services;

namespace StockManager.Src.Services
{
    public static class AppServices
    {
        public static IAppSettingsService AppSettingsService { get; private set; }
        public static ILocationService LocationService { get; private set; }
        public static INotificationService NotificationService { get; private set; }
        public static IProductLocationService ProductLocationService { get; private set; }
        public static IProductService ProductService { get; private set; }
        public static IRoleService RoleService { get; private set; }
        public static IStockMovementService StockMovementService { get; private set; }
        public static IUserService UserService { get; private set; }

        public static void ConfigureServices(IAppRepository repository)
        {
            // Instantiate our services
            AppSettingsService = new AppSettingsService(repository);
            LocationService = new LocationService(repository);
            NotificationService = new NotificationService(repository);
            ProductLocationService = new ProductLocationService(repository);
            ProductService = new ProductService(repository);
            RoleService = new RoleService(repository);
            StockMovementService = new StockMovementService(repository);
            UserService = new UserService(repository);
        }
    }
}
