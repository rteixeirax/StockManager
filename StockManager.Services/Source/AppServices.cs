using StockManager.Database.Source;
using StockManager.Database.Source.Repositories;
using StockManager.Services.Source.Contracts;
using StockManager.Services.Source.Services;

namespace StockManager.Services.Source
{
  public static class AppServices
  {
    public static IAppSettingsService SettingsService { get; private set; }
    public static IUserService UserService { get; private set; }
    public static IRoleService RoleService { get; private set; }
    public static ILocationService LocationService { get; private set; }
    public static IProductService ProductService { get; private set; }
    public static IProductLocationService ProductLocationService { get; private set; }
    public static IStockMovementService StockMovementService { get; private set; }

    public static void ConfigureServices(DatabaseContext databaseContext)
    {
      // Instantiate our services
      SettingsService = new AppSettingsService(new AppSettingsRepository(databaseContext));
      UserService = new UserService(new UserRepository(databaseContext));
      RoleService = new RoleService(new RoleRepository(databaseContext));
      LocationService = new LocationService(new LocationRepository(databaseContext));
      ProductService = new ProductService(new ProductRepository(databaseContext));
      ProductLocationService = new ProductLocationService(new ProductLocationRepository(databaseContext));
      StockMovementService = new StockMovementService(new StockMovementRepository(databaseContext));
    }
  }
}
