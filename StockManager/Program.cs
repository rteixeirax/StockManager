using Microsoft.EntityFrameworkCore;
using StockManager.Forms;
using StockManager.Services.Contracts;
using StockManager.Services.Services;
using StockManager.Storage;
using StockManager.Storage.Contracts;
using StockManager.Storage.Models;
using StockManager.Storage.Repositories;
using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace StockManager {
  static class Program {
    /// <summary>
    /// Logged in user
    /// </summary>
    public static User LoggedInUser { get; private set; }

    /// <summary>
    /// Set the user after authentication
    /// </summary>
    public static void SetLoggedInUser(User user) {
      LoggedInUser = user;
    }

    /// <summary>
    /// Kill the "Session"
    /// </summary>
    public static void Logout() {
      LoggedInUser = null;
    }

    /// <summary>
    /// Application DB context and repositories
    /// </summary>
    private static StorageContext StorageContext { get; set; }
    public static IUserRepository UserRepository { get; private set; }
    public static IRoleRepository RoleRepository { get; private set; }
    public static ILocationRepository LocationRepository { get; private set; }
    public static IProductRepository ProductRepository { get; private set; }

    /// <summary>
    /// Application services
    /// </summary>
    ///
    public static IUserService UserService { get; private set; }
    public static IRoleService RoleService { get; private set; }
    public static ILocationService LocationService { get; private set; }
    public static IProductService ProductService { get; private set; }

    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main() {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);

      try {
        // Set the user language.
        Thread.CurrentThread.CurrentUICulture = new CultureInfo("pt-PT");
      } catch {
        // Set default app default language (EN)
        Thread.CurrentThread.CurrentUICulture = new CultureInfo("");
      }

      // Set the options builder for our storage context
      var builder = new DbContextOptionsBuilder<StorageContext>();
      builder.UseSqlite(Constants.connectionString);

      // Instantiate our storage
      StorageContext = new StorageContext(builder.Options);
      UserRepository = new UserRepository(StorageContext);
      RoleRepository = new RoleRepository(StorageContext);
      LocationRepository = new LocationRepository(StorageContext);
      ProductRepository = new ProductRepository(StorageContext);

      // Instantiate our services
      UserService = new UserService(UserRepository);
      RoleService = new RoleService(RoleRepository);
      LocationService = new LocationService(LocationRepository);
      ProductService = new ProductService(ProductRepository);

      Application.Run(new MainForm());
    }
  }
}
