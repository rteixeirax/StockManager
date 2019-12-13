using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManager.Forms
{
  public partial class MainForm : Form
  {
    public MainForm()
    {
      InitializeComponent();
      this.MoveSideMarker(btnDashboard);
    }

    private void MoveSideMarker(Control control)
    {
      sideMarker.Height = control.Height;
      sideMarker.Top = control.Top;
    }
      
    private void btnDashboard_Click(object sender, EventArgs e)
    {
      this.MoveSideMarker(btnDashboard);
    }

    private void btnStocks_Click(object sender, EventArgs e)
    {
      this.MoveSideMarker(btnStocks);
    }

    private void btnUsers_Click(object sender, EventArgs e)
    {
      this.MoveSideMarker(btnUsers);
    }

    private void btnSettings_Click(object sender, EventArgs e)
    {
      this.MoveSideMarker(btnSettings);
    }
  }
}
