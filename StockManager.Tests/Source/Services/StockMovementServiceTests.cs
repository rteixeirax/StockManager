using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using StockManager.Core.Source.Models;
using StockManager.Core.Source.Types;
using StockManager.Services.Source;
using StockManager.Translations.Source;

namespace StockManager.Tests.Source.Services
{
    /// <summary>
    /// Stock movement service tests
    /// </summary>
    [TestClass]
    public class StockMovementServiceTests
    {
        private TestsConfig _config;
        private Location _mockLocation;
        private Product _mockProduct;
        private User _mockUser;

        [TestCleanup]
        public void AfterEach()
        {
            _config.CloseConnection();
        }

        [TestInitialize]
        public async Task BeforeEach()
        {
            _config = new TestsConfig();

            _mockProduct = new Product()
            {
                Reference = "mockProduct",
                Name = "Mock product"
            };

            _mockLocation = await AppServices.LocationService.GetByIdAsync(1);
            _mockUser = await AppServices.UserService.GetByIdAsync(1);

            await AppServices.ProductService.CreateAsync(_mockProduct, _mockUser.UserId);
        }

        [TestMethod]
        public async Task ShouldInsertStockMovement_Entry()
        {
            // Arrange
            StockMovement stockMovement = new StockMovement()
            {
                UserId = _mockUser.UserId,
                ProductId = _mockProduct.ProductId,
                ToLocationId = _mockLocation.LocationId,
                ToLocationName = _mockLocation.Name,
                Qty = 10,
            };

            // Act
            await AppServices.StockMovementService.CreateAsync(stockMovement, true);

            // Assert
            Assert.AreEqual(stockMovement.Qty, 10);
            Assert.AreEqual(stockMovement.Stock, 10);
            Assert.AreEqual(stockMovement.ToLocationId, _mockLocation.LocationId);
            Assert.AreEqual(stockMovement.ProductId, _mockProduct.ProductId);
            Assert.AreEqual(stockMovement.UserId, _mockUser.UserId);
            Assert.IsNull(stockMovement.FromLocationId);
            Assert.IsNotNull(stockMovement.CreatedAt);
            Assert.IsNotNull(stockMovement.UpdatedAt);
        }

        [TestMethod]
        public async Task ShouldInsertStockMovement_Exit()
        {
            // Arrange
            StockMovement stockMovement = new StockMovement()
            {
                UserId = _mockUser.UserId,
                ProductId = _mockProduct.ProductId,
                FromLocationId = _mockLocation.LocationId,
                Qty = -10,
            };

            // Act
            await AppServices.StockMovementService.CreateAsync(stockMovement, true);

            // Assert
            Assert.AreEqual(stockMovement.Qty, -10);
            Assert.AreEqual(stockMovement.Stock, -10);
            Assert.AreEqual(stockMovement.FromLocationId, _mockLocation.LocationId);
            Assert.AreEqual(stockMovement.ProductId, _mockProduct.ProductId);
            Assert.AreEqual(stockMovement.UserId, _mockUser.UserId);
            Assert.IsNull(stockMovement.ToLocationId);
            Assert.IsNotNull(stockMovement.CreatedAt);
            Assert.IsNotNull(stockMovement.UpdatedAt);
        }

        [TestMethod]
        public async Task ShouldRefillStock()
        {
            // Arrange
            int mainLocationStock = 10;
            int locationStock = 5;
            int currentStock = 3;
            int refilledStock = 1;
            int qtySpended = locationStock - currentStock;

            Location location = await AppServices.LocationService.GetByIdAsync(2); // non main location

            // Add stock to the main location
            await AppServices.StockMovementService.CreateMovementInsideMainLocationAsync(
                _mockProduct.ProductId,
                mainLocationStock,
                true,
                _mockUser.UserId
            );

            // Move stock from the main location to this location
            await AppServices.StockMovementService.MoveStockBetweenLocationsAsync(
                _mockLocation.LocationId,
                location.LocationId,
                _mockProduct.ProductId,
                locationStock,
                _mockUser.UserId
            );

            // Act
            await AppServices.StockMovementService.RefillStockAsync(
                location.LocationId,
                _mockProduct.ProductId,
                currentStock,
                refilledStock,
                _mockUser.UserId
            );

            // Assert
            ProductLocation plocation = await AppServices.ProductLocationService
                .GetOneAsync(_mockProduct.ProductId, location.LocationId);

            ProductLocation mainPlocation = await AppServices.ProductLocationService
                .GetOneAsync(_mockLocation.LocationId, _mockProduct.ProductId);

            // Get all product stock movements
            IEnumerable<StockMovement> movements = await AppServices
                .StockMovementService.GetAllAsync(_mockProduct.Reference);

            // Remove movement
            StockMovement removeMvm = movements.FirstOrDefault(x =>
                x.FromLocationId == location.LocationId
                && x.ProductId == _mockProduct.ProductId
                && x.Qty == (qtySpended * -1)
            );

            // Refill movement
            StockMovement refillMvm = movements.FirstOrDefault(x =>
                x.FromLocationId == _mockLocation.LocationId
                && x.ToLocationId == location.LocationId
                && x.ProductId == _mockProduct.ProductId
                && x.Qty == refilledStock
            );

            // Assert the remove stock movement
            Assert.IsNotNull(removeMvm);
            Assert.AreEqual(removeMvm.Stock, locationStock - qtySpended);

            // Assert the refill stock movment
            Assert.IsNotNull(refillMvm);
            Assert.AreEqual(refillMvm.Stock, plocation.Stock);

            // Assert the locations stock after the refill movements
            Assert.AreEqual(plocation.Stock, (locationStock - qtySpended) + refilledStock);
            Assert.AreEqual(mainPlocation.Stock, (mainLocationStock - locationStock) - refilledStock);
        }

        [TestMethod]
        public async Task ShouldFailRefillStock_NoStockAvailable()
        {
            try
            {
                // Arrange
                int mainLocationStock = 10;
                int locationStock = 10;
                int currentStock = 5;
                int refilledStock = 5;

                Location location = await AppServices.LocationService.GetByIdAsync(2); // non main location

                // Add stock to the main location
                await AppServices.StockMovementService.CreateMovementInsideMainLocationAsync(
                    _mockProduct.ProductId,
                    mainLocationStock,
                    true,
                    _mockUser.UserId
                );

                // Move stock from the main location to this location
                await AppServices.StockMovementService.MoveStockBetweenLocationsAsync(
                    _mockLocation.LocationId,
                    location.LocationId,
                    _mockProduct.ProductId,
                    locationStock,
                    _mockUser.UserId
                );

                // Act
                await AppServices.StockMovementService.RefillStockAsync(
                    location.LocationId,
                    _mockProduct.ProductId,
                    currentStock,
                    refilledStock,
                    _mockUser.UserId
                );

                Assert.Fail("It should have thrown an OperationErrorExeption");
            }
            catch (OperationErrorException ex)
            {
                // Assert
                Assert.AreEqual(ex.Errors.Count, 1);
                Assert.AreEqual(ex.Errors[0].Field, "RefillQty");
                Assert.AreEqual(ex.Errors[0].Error, Phrases.StockMovementErrorQty);
            }
        }
    }
}
