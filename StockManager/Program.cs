using StockManager.Forms;
using StockManager.Services;
using StockManager.Storage;
using StockManager.Storage.Brokers;
using StockManager.Storage.Models;
using System;
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
    /// Application DB context and brokers
    /// </summary>
    private static StorageContext StorageContext { get; set; }
    public static IUserBroker UserBroker { get; private set; }
    public static IRoleBroker RoleBroker { get; private set; }
    public static ILocationBroker LocationBroker { get; private set; }

    /// <summary>
    /// Application services
    /// </summary>
    /// 
    public static IUserService UserService { get; private set; }
    public static IRoleService RoleService { get; private set; }
    public static ILocationService LocationService { get; private set; }

    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main() {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);

      // Instantiate our storage
      StorageContext = new StorageContext();
      UserBroker = new UserBroker(StorageContext);
      RoleBroker = new RoleBroker(StorageContext);
      LocationBroker = new LocationBroker(StorageContext);

      // Instantiate our services
      UserService = new UserService(UserBroker);
      RoleService = new RoleService(RoleBroker);
      LocationService = new LocationService(LocationBroker);

      Application.Run(new MainForm());
    }
  }
}
