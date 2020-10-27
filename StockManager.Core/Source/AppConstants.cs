using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;

using StockManager.Core.Source.Types;
using StockManager.Translations.Source;

namespace StockManager.Core.Source
{
    public static class AppConstants
    {
        // Fetch the version from the AssemblyInfo.cs.
        public static readonly string Version = "v1.0.0.0";
        public static readonly string Title = "Stock Manager";
        public static readonly string DevName = "Ricardo Teixeira";
        public static readonly string TwitterUrl = "https://twitter.com/ricardotx86";
        public static readonly string AppName = Regex.Replace(Title, @"\s+", ""); // Same as the title but without the spaces.

        // Special folders paths
        public static readonly string AutoUpdaterXmlFileUrl = "https://raw.githubusercontent.com/ricardotx/StockManager/master/AutoUpdater.xml";
        public static readonly string DownloadsFolderPath = Path.Combine(Environment.GetEnvironmentVariable("USERPROFILE"), "Downloads");
        public static readonly string MyDocumentsFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        public static readonly string DesktopFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        public static readonly string DatabaseFolderPath = $@"{MyDocumentsFolderPath}\{AppName}\Data";

        // Connection strings
        public static readonly string connectionString = $@"Data Source={DatabaseFolderPath}\{AppName}DB.sqlite";
        public static readonly string connectionStringDev = @"Data Source=.\App.db.sqlite";
        public static readonly string connectionStringTestDB = "DataSource =:memory:";

        // Concat the app title with the form title
        public static string GetViewTitle(string viewName)
        {
            return $"{Title} | {viewName}";
        }

        // Available app export documents folders
        public static readonly List<DocumentsFolder> DocumentsFolders = new List<DocumentsFolder>()
        {
            new DocumentsFolder() {
                Code = "desktop",
                Name = Phrases.AppConstantsDesktopFolder,
                CreateFolder = false,
                Path = DesktopFolderPath
            },
            new DocumentsFolder() {
                Code = "myDocuments",
                Name = Phrases.AppConstantsDocumentsFolder,
                CreateFolder = true,
                Path = $@"{MyDocumentsFolderPath}\{AppName}"
            }
        };

        // Available app languages
        public static readonly List<AppLanguage> AppLanguages = new List<AppLanguage>()
        {
            new AppLanguage() {  Code = "pt-PT", Name = "Português"},
            new AppLanguage() {  Code = "en-EN", Name = "English"}
        };

        // App Colors
        public static readonly Color ColorBlue = Color.FromArgb(5, 118, 185); // #0576b9
        public static readonly Color ColorDarkBlue = Color.FromArgb(26, 29, 33); // #1a1d21
        public static readonly Color ColorGreen = Color.FromArgb(92, 184, 92); // #5cb85c
        public static readonly Color ColorOrange = Color.FromArgb(240, 173, 78); // #f0ad4e
        public static readonly Color ColorRed = Color.FromArgb(217, 83, 79); // #d9534f
    }
}