using StockManager.Core.Source;
using StockManager.Core.Source.Services;
using StockManager.Services.Source.Services;

namespace StockManager.Services.Source
{
    public static class AppServices
    {
        public static ILocationService LocationService { get; private set; }
        public static IProductLocationService ProductLocationService { get; private set; }
        public static IProductService ProductService { get; private set; }
        public static IRoleService RoleService { get; private set; }
        public static IAppSettingsService SettingsService { get; private set; }
        public static IStockMovementService StockMovementService { get; private set; }
        public static IUserService UserService { get; private set; }

        public static void ConfigureServices(IAppRepository repository)
        {
            // Instantiate our services
            SettingsService = new AppSettingsService(repository);
            UserService = new UserService(repository);
            RoleService = new RoleService(repository);
            LocationService = new LocationService(repository);
            ProductService = new ProductService(repository);
            ProductLocationService = new ProductLocationService(repository);
            StockMovementService = new StockMovementService(repository);
        }
    }
}
