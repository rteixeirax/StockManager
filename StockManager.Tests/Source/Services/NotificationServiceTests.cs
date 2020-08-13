using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using StockManager.Core.Source.Models;
using StockManager.Services.Source;

namespace StockManager.Tests.Source.Services
{
    [TestClass]
    public class NotificationServiceTests
    {
        private User _admin;
        private TestsConfig _config;
        private Location _mainLocation;
        private readonly List<Product> _mockProducts = new List<Product>();

        [TestCleanup]
        public void AfterEach()
        {
            _config.CloseConnection();
        }

        [TestInitialize]
        public async Task BeforeEachAsync()
        {
            _config = new TestsConfig();

            _admin = await AppServices.UserService.GetByIdAsync(1); // admin
            _mainLocation = await AppServices.LocationService.GetMainAsync();

            _mockProducts.AddRange(new Product[] {
                new Product() { Reference = "001", Name = "product#1" },
                new Product() { Reference = "002", Name = "product#2" },
            });
        }

        [TestMethod]
        public async Task ShouldCreateNotification()
        {
            // Arrange
            await AppServices.ProductService.CreateAsync(_mockProducts[0], _admin.UserId);

            ProductLocation plocation = await AppServices.ProductLocationService
                .GetOneAsync(_mockProducts[0].ProductId, _mainLocation.LocationId);

            // Act
            Notification notification = await AppServices.NotificationService
                .GetByProductLocationIdAsync(plocation.ProductLocationId);

            // Assert
            Assert.AreEqual(notification.ProductLocationId, plocation.ProductLocationId);
            Assert.IsNotNull(notification.NotificationId);
            Assert.IsNotNull(notification.CreatedAt);
            Assert.IsNotNull(notification.UpdatedAt);
        }

        [TestMethod]
        public async Task ShouldGetAllNotifications()
        {
            // Arrange
            await AppServices.ProductService.CreateAsync(_mockProducts[0], _admin.UserId);
            await AppServices.ProductService.CreateAsync(_mockProducts[1], _admin.UserId);

            ProductLocation plocation1 = await AppServices.ProductLocationService
                .GetOneAsync(_mockProducts[0].ProductId, _mainLocation.LocationId);

            ProductLocation plocation2 = await AppServices.ProductLocationService
                .GetOneAsync(_mockProducts[1].ProductId, _mainLocation.LocationId);

            // Act
            IEnumerable<Notification> notifications = await AppServices.NotificationService.GetAllAsync();

            // Assert
            Assert.AreEqual(notifications.Count(), 2);
            Assert.AreEqual(notifications.ElementAt(0).ProductLocationId, plocation1.ProductLocationId);
            Assert.AreEqual(notifications.ElementAt(0).ProductLocation.ProductId, _mockProducts[0].ProductId);
            Assert.AreEqual(notifications.ElementAt(1).ProductLocationId, plocation2.ProductLocationId);
            Assert.AreEqual(notifications.ElementAt(1).ProductLocation.ProductId, _mockProducts[1].ProductId);
        }

        [TestMethod]
        public async Task ShouldRemoveNotification()
        {
            // Arrange
            await AppServices.ProductService.CreateAsync(_mockProducts[0], _admin.UserId);

            ProductLocation plocation = await AppServices.ProductLocationService
                .GetOneAsync(_mockProducts[0].ProductId, _mainLocation.LocationId);

            Notification notification = await AppServices.NotificationService
                .GetByProductLocationIdAsync(plocation.ProductLocationId);

            // Act
            await AppServices.NotificationService.RemoveAsync(notification.NotificationId);

            Notification deletedNotification = await AppServices.NotificationService.GetByIdAsync(notification.NotificationId);

            // Assert
            Assert.AreEqual(deletedNotification, null);
        }

        [TestMethod]
        public async Task ShouldToggleStockAlert_StockEqualMinStock()
        {
            // Arrange
            await AppServices.ProductService.CreateAsync(_mockProducts[0], _admin.UserId);

            ProductLocation plocation = await AppServices.ProductLocationService
                .GetOneAsync(_mockProducts[0].ProductId, _mainLocation.LocationId);

            // Act
            Notification notification = await AppServices.NotificationService
                .GetByProductLocationIdAsync(plocation.ProductLocationId);

            // Assert
            Assert.AreEqual(notification.ProductLocationId, plocation.ProductLocationId);
            Assert.AreEqual(notification.ProductLocation.Stock, 0);
            Assert.AreEqual(notification.ProductLocation.MinStock, 0);
        }

        [TestMethod]
        public async Task ShouldToggleStockAlert_StockBelowMinStock()
        {
            // Arrange
            await AppServices.ProductService.CreateAsync(_mockProducts[0], _admin.UserId);

            ProductLocation plocation = await AppServices.ProductLocationService
                .GetOneAsync(_mockProducts[0].ProductId, _mainLocation.LocationId);

            // Act
            await AppServices.StockMovementService
                .CreateMovementInsideMainLocationAsync(_mockProducts[0].ProductId, 10, false, _admin.UserId);

            Notification notification = await AppServices.NotificationService
                .GetByProductLocationIdAsync(plocation.ProductLocationId);

            // Asset
            Assert.AreEqual(notification.ProductLocationId, plocation.ProductLocationId);
            Assert.AreEqual(notification.ProductLocation.Stock, -10);
            Assert.IsTrue(notification.ProductLocation.Stock < notification.ProductLocation.MinStock);
        }

        [TestMethod]
        public async Task ShouldToggleStockAlert_StockAboveMinStock()
        {
            // Arrange
            await AppServices.ProductService.CreateAsync(_mockProducts[0], _admin.UserId);

            ProductLocation plocation = await AppServices.ProductLocationService
                .GetOneAsync(_mockProducts[0].ProductId, _mainLocation.LocationId);

            // Act
            await AppServices.StockMovementService
                .CreateMovementInsideMainLocationAsync(_mockProducts[0].ProductId, 10, true, _admin.UserId);

            Notification notification = await AppServices.NotificationService
                .GetByProductLocationIdAsync(plocation.ProductLocationId);

            // Asset
            Assert.IsNull(notification);
            Assert.IsTrue(plocation.Stock > plocation.MinStock);
        }
    }
}
