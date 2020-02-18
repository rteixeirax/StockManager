using Microsoft.EntityFrameworkCore;
using StockManager.Database;
using StockManager.Database.Models;
using StockManager.Database.Repositories;
using StockManager.Forms;
using StockManager.Services;
using System;
using System.Windows.Forms;

namespace StockManager
{
  static class Program
  {
    /// <summary>
    /// Application DB context
    /// </summary>
    private static AppDbContext appDbContext { get; set; }

    /// <summary>
    /// Application repositories
    /// </summary>
    public static IUserRepository UserServices { get; private set; }
    public static IRoleRepository RoleServices { get; private set; }
    public static ILocationRepository LocationServices { get; private set; }

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
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);

      // Instantiate our DB
      appDbContext = new AppDbContext();
      appDbContext.Database.Migrate();

      // Instantiate our services
      UserServices = new UserServices(appDbContext);
      RoleServices = new RoleServices(appDbContext);
      LocationServices = new LocationServices(appDbContext);

      Application.Run(new MainForm());
    }
  }
}
