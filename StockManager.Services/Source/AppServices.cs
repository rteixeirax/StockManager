using StockManager.Services.Source.Contracts;
using StockManager.Services.Source.Services;
using StockManager.Storage.Source;
using StockManager.Storage.Source.Repositories;

namespace StockManager.Services.Source {
  public static class AppServices {
    public static IUserService UserService { get; private set; }
    public static IRoleService RoleService { get; private set; }
    public static ILocationService LocationService { get; private set; }
    public static IProductService ProductService { get; private set; }

    public static void ConfigureServices(StorageContext storageContext) {
      // Instantiate our services
      UserService = new UserService(new UserRepository(storageContext));
      RoleService = new RoleService(new RoleRepository(storageContext));
      LocationService = new LocationService(new LocationRepository(storageContext));
      ProductService = new ProductService(new ProductRepository(storageContext));
    }
  }
}
