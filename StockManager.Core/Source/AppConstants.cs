using System.Collections.Generic;
using System.Drawing;

using StockManager.Core.Source.Types;

namespace StockManager.Core.Source
{
    public static class AppConstants
    {
        public const string connectionString = @"Data Source=.\App.db.sqlite";
        public const string connectionStringTestDB = "DataSource =:memory:";

        // Available app languages
        public static readonly List<AppLanguage> AppLanguages = new List<AppLanguage>()
        {
            new AppLanguage() {  Code = "pt-PT", Name = "Português"},
            new AppLanguage() {  Code = "en-EN", Name = "English"}
        };

        // #0576b9
        public static readonly Color ColorBlue = Color.FromArgb(5, 118, 185);

        // #1a1d21
        public static readonly Color ColorDarkBlue = Color.FromArgb(26, 29, 33);

        // #5cb85c
        public static readonly Color ColorGreen = Color.FromArgb(92, 184, 92);

        // #f0ad4e
        public static readonly Color ColorOrange = Color.FromArgb(240, 173, 78);

        // #d9534f
        public static readonly Color ColorRed = Color.FromArgb(217, 83, 79);
    }
}