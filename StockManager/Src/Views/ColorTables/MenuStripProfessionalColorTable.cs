using System.Drawing;
using System.Windows.Forms;

namespace StockManager.Src.Views.ColorTables
{
    internal class MenuStripProfessionalColorTable : ProfessionalColorTable
    {
        public override Color MenuItemPressedGradientBegin => Color.Transparent;

        public override Color MenuItemPressedGradientEnd => Color.Transparent;

        public override Color MenuItemPressedGradientMiddle => Color.Transparent;

        public override Color MenuItemSelected => AppConstants.ColorBlue;

        public override Color MenuItemSelectedGradientBegin => Color.Transparent;

        public override Color MenuItemSelectedGradientEnd => Color.Transparent;
    }
}
