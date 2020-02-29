using StockManager.Forms;
using StockManager.Services;
using StockManager.Storage;
using StockManager.Storage.Brokers;
using StockManager.Storage.Models;
using StockManager.Storage.Repositories;
using System;
using System.Windows.Forms;

namespace StockManager
{
  static class Program
  {
    /// <summary>
    /// Logged in user
    /// </summary>
    public static User LoggedInUser { get; private set; }

    /// <summary>
    /// Set the user after login validation
    /// </summary>
    public static void SetLoggedInUser(string username)
    {
      LoggedInUser = UserServices.GetUserByUsername(username);
    }

    /// <summary>
    /// Kill the "Session"
    /// </summary>
    public static void Logout()
    {
      LoggedInUser = null;
    }

    /// <summary>
    /// Application DB context and brokers
    /// </summary>
    private static StorageContext StorageContext { get; set; }
    public static IUserRepository UserServices { get; private set; }
    public static IRoleBroker RoleBroker { get; private set; }
    public static ILocationBroker LocationBroker { get; private set; }

    /// <summary>
    /// Application services
    /// </summary>
    public static ILocationService LocationService { get; private set; }
    public static IRoleService RoleService { get; private set; }

    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);

      // Instantiate our DB and brokers
      StorageContext = new StorageContext();
      RoleBroker = new RoleBroker(StorageContext);
      LocationBroker = new LocationBroker(StorageContext);

      // Instantiate our services
      UserServices = new UserServices(StorageContext);
      RoleService = new RoleService(RoleBroker);
      LocationService = new LocationService(LocationBroker);

      Application.Run(new MainForm());
    }
  }
}
