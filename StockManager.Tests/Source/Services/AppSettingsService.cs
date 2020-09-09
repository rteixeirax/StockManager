using System.Threading.Tasks;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using StockManager.Core.Source.Models;
using StockManager.Services.Source;

namespace StockManager.Tests.Source.Services
{
    /// <summary>
    /// App settings service tests
    /// </summary>
    [TestClass]
    public class SettingsServiceTests
    {
        private TestsConfig _config;

        [TestCleanup]
        public void AfterEach()
        {
            _config.CloseConnection();
        }

        [TestInitialize]
        public void BeforeEach()
        {
            _config = new TestsConfig();
        }

        /// <summary>
        /// Should get app settings
        /// </summary>
        [TestMethod]
        public async Task ShouldGetAppSettingsAsync()
        {
            // Arrange

            // Act
            AppSettings settings = await AppServices.AppSettingsService.GetAppSettingsAsync();

            // Assert
            Assert.AreEqual(settings.Language, "pt-PT");
            Assert.AreEqual(settings.DefaultGlobalMinStock, 0);
        }

        /// <summary>
        /// Should get app language
        /// </summary>
        [TestMethod]
        public async Task ShouldGetSettingsAsync()
        {
            // Arrange

            // Act
            string appLanguage = await AppServices.AppSettingsService.GetAppLanguageAsync();

            // Assert
            Assert.AreEqual(appLanguage, "pt-PT");
        }

        [TestMethod]
        public async Task ShouldUpdateSettings()
        {
            // Arrange
            AppSettings dbSettings = await AppServices.AppSettingsService.GetAppSettingsAsync();

            AppSettings updatedSettings = new AppSettings()
            {
                AppSettingsId = dbSettings.AppSettingsId,
                Language = "en-EN",
                DefaultGlobalMinStock = 10
            };

            // Act 
            await AppServices.AppSettingsService.UpdateAppSettingsAsync(updatedSettings);

            // Assert
            Assert.AreEqual(dbSettings.Language, "en-EN");
            Assert.AreEqual(dbSettings.DefaultGlobalMinStock, 10);
        }
    }
}
