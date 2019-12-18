using StockManager.Forms;
using StockManager.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManager
{
  static class Program
  {
    // FORMS
    public static MainForm mainForm { get; private set; }
    public static UserForm userForm { get; private set; }

    // USER CONTROLS
    public static UsersUserControl usersUserControl { get; private set; }

    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);

      // FORMS
      mainForm = new MainForm();
      userForm = new UserForm();

      // USER CONTROLS
      usersUserControl = new UsersUserControl();

      Application.Run(mainForm);
    }
  }
}
