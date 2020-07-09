using System.Drawing;

namespace StockManager.Utilities.Source
{
    public static class AppConstants
    {
        public const string connectionString = @"Data Source=.\App.db.sqlite";
        public const string connectionStringTestDB = "DataSource =:memory:";

        public static readonly Color ColorRed = Color.FromArgb(217, 83, 79); // #D9534F
        public static readonly Color ColorBlue = Color.FromArgb(5, 118, 185); // #0576b9
        public static readonly Color ColorDarkBlue = Color.FromArgb(26, 29, 33); // #1A1D21
        public static readonly Color ColorGreen = Color.FromArgb(92, 184, 92); // #5CB85C
        public static readonly Color ColorOrange = Color.FromArgb(240, 173, 78); // #F0AD4E
    }
}
