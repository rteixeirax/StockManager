using System.Drawing;
using System.Windows.Forms;

namespace StockManager.ColorTables {
  class MenuStripProfessionalColorTable : ProfessionalColorTable {
    public override Color MenuItemSelected {
      get { return Color.FromArgb(5, 118, 185); }
    }

    public override Color MenuItemSelectedGradientBegin {
      get { return Color.Transparent; }
    }

    public override Color MenuItemSelectedGradientEnd {
      get { return Color.Transparent; }
    }

    public override Color MenuItemPressedGradientBegin {
      get { return Color.Transparent; }
    }

    public override Color MenuItemPressedGradientMiddle {
      get { return Color.Transparent; }
    }

    public override Color MenuItemPressedGradientEnd {
      get { return Color.Transparent; }
    }
  }
}
