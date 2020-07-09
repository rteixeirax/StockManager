using StockManager.Utilities.Source;
using System.Drawing;
using System.Windows.Forms;

namespace StockManager.Source.ColorTables
{
    internal class MenuStripProfessionalColorTable : ProfessionalColorTable
    {
        public override Color MenuItemSelected
        {
            get { return AppConstants.ColorBlue; }
        }

        public override Color MenuItemSelectedGradientBegin
        {
            get { return Color.Transparent; }
        }

        public override Color MenuItemSelectedGradientEnd
        {
            get { return Color.Transparent; }
        }

        public override Color MenuItemPressedGradientBegin
        {
            get { return Color.Transparent; }
        }

        public override Color MenuItemPressedGradientMiddle
        {
            get { return Color.Transparent; }
        }

        public override Color MenuItemPressedGradientEnd
        {
            get { return Color.Transparent; }
        }
    }
}
