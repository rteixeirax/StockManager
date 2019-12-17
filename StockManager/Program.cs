using StockManager.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManager
{
  static class Program
  {
    public static MainForm mainForm { get; private set; }
    public static UserForm userForm { get; private set; }

    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);

      mainForm = new MainForm();
      userForm = new UserForm();

      Application.Run(mainForm);
    }
  }
}
