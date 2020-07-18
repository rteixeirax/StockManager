using System.Threading.Tasks;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using StockManager.Database.Source.Models;
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
            AppSettings settings = await AppServices.SettingsService.GetAppSettingsAsync();

            // Assert
            Assert.AreEqual(settings.Language, "pt-PT");
        }

        /// <summary>
        /// Should get app language
        /// </summary>
        [TestMethod]
        public async Task ShouldGetSettingsAsync()
        {
            // Arrange

            // Act
            string appLanguage = await AppServices.SettingsService.GetAppLanguageAsync();

            // Assert
            Assert.AreEqual(appLanguage, "pt-PT");
        }
    }
}
