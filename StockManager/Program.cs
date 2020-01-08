using StockManager.Database;
using StockManager.Database.Repositories;
using StockManager.Forms;
using StockManager.Services;
using System;
using System.Windows.Forms;

namespace StockManager
{
  static class Program
  {
    // Application DB context
    private static AppDbContext appDbContext { get; set; }

    // Application repositories
    public static IUserRepository userServices { get; private set; }
    public static IRoleRepository roleServices { get; private set; }
    

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

      // Instantiate our services
      userServices = new UserServices(appDbContext);
      roleServices = new RoleServices(appDbContext);

      Application.Run(new MainForm());
    }
  }
}
