using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using StockManager.Src.Data.Entities;
using StockManager.Src.Models;
using StockManager.Src.Services;
using StockManager.Src.Translations;

namespace StockManager.Tests.Src.Services
{
    /// <summary>
    /// Location service tests
    /// </summary>
    [TestClass]
    public class LocationServiceTests
    {
        private Config _config;
        private Location _mockLocation;

        [TestCleanup]
        public void AfterEach()
        {
            _config.CloseConnection();
        }

        [TestInitialize]
        public void BeforeEachAsync()
        {
            _config = new Config();
            _mockLocation = new Location() { Name = "new Location" };
        }

        /// <summary>
        /// Should create location
        /// </summary>
        [TestMethod]
        public async Task ShouldCreateLocation()
        {
            // Arrange
            Location location = _mockLocation;

            // Act
            await AppServices.LocationService.CreateAsync(location);

            // Assert
            Assert.AreEqual(location.Name, "new Location");
            Assert.IsNotNull(location.CreatedAt);
            Assert.IsNotNull(location.UpdatedAt);
        }

        /// <summary>
        /// Should delete location
        /// </summary>
        [TestMethod]
        public async Task ShouldDeleteLocation()
        {
            // Arrange
            Location mockLocation = _mockLocation;
            await AppServices.LocationService.CreateAsync(mockLocation);

            // Act
            await AppServices.LocationService.DeleteAsync(new int[] { mockLocation.LocationId }, 1);

            Location dbLocation = await AppServices.LocationService
              .GetByIdAsync(mockLocation.LocationId);

            // Assert
            Assert.IsNull(dbLocation);
        }

        /// <summary>
        /// Should delete location
        /// </summary>
        [TestMethod]
        public async Task ShouldDeleteLocationWithProducts_TheProductsStockShouldBeMovedToMainLocation()
        {
            // Arrange
            User admin = await AppServices.UserService.GetByIdAsync(1);
            Location mainLocation = await AppServices.LocationService.GetMainAsync();

            await AppServices.LocationService.CreateAsync(_mockLocation);

            Product product = new Product() { Reference = "mockProduct", Name = "Mock product" };
            await AppServices.ProductService.CreateAsync(product, admin.UserId);
            // Add product stock to the main location
            await AppServices.StockMovementService.CreateMovementInsideMainLocationAsync(product.ProductId, 20, true, admin.UserId);

            // Act
            // Move stock to the mock location
            await AppServices.StockMovementService.MoveStockBetweenLocationsAsync(
                mainLocation.LocationId,
                _mockLocation.LocationId,
                product.ProductId, 10,
                admin.UserId
            );

            StockMovement smToMockLocation = await AppServices.StockMovementService.GetProductLastMovementAsync(product.ProductId);

            // Assert
            Assert.AreEqual(smToMockLocation.FromLocationId, mainLocation.LocationId);
            Assert.AreEqual(smToMockLocation.FromLocationName, mainLocation.Name);
            Assert.AreEqual(smToMockLocation.ToLocationId, _mockLocation.LocationId);
            Assert.AreEqual(smToMockLocation.ProductId, product.ProductId);
            Assert.AreEqual(smToMockLocation.Qty, 10);
            Assert.AreEqual(smToMockLocation.Stock, 10);

            // Act
            await AppServices.LocationService.DeleteAsync(new int[] { _mockLocation.LocationId }, 1);
            Location dbLocation = await AppServices.LocationService.GetByIdAsync(_mockLocation.LocationId);

            StockMovement smBackToMainLocation = await AppServices.StockMovementService.GetProductLastMovementAsync(product.ProductId);

            // Assert
            Assert.IsNull(dbLocation);
            Assert.IsNull(smBackToMainLocation.FromLocationId);
            Assert.AreEqual(smBackToMainLocation.FromLocationName, _mockLocation.Name);
            Assert.AreEqual(smBackToMainLocation.ToLocationId, mainLocation.LocationId);
            Assert.AreEqual(smBackToMainLocation.ProductId, product.ProductId);
            Assert.AreEqual(smBackToMainLocation.Qty, 10);
            Assert.AreEqual(smBackToMainLocation.Stock, 20);
        }

        /// <summary>
        /// Should edit location
        /// </summary>
        [TestMethod]
        public async Task ShouldEditLocation()
        {
            // Arrange
            Location defaultLocation = await AppServices.LocationService.GetByIdAsync(1); // warehouse

            // Act
            Location updatedLocation = new Location()
            {
                LocationId = defaultLocation.LocationId,
                Name = "Updated location"
            };

            await AppServices.LocationService.EditAsync(updatedLocation);
            Location dbLocation = await AppServices.LocationService.GetByIdAsync(updatedLocation.LocationId);

            // Assert
            Assert.AreEqual(dbLocation.LocationId, updatedLocation.LocationId);
            Assert.AreEqual(dbLocation.Name, "Updated location");
        }

        /// <summary>
        /// Should fail create location with a existing name
        /// </summary>
        [TestMethod]
        public async Task ShouldFailCreateLocation_ExistingName()
        {
            // Arrange
            Location location = _mockLocation;

            try
            {
                // Act
                location.Name = "Warehouse"; // default
                await AppServices.LocationService.CreateAsync(location);

                Assert.Fail("It should have thrown an OperationErrorExeption");
            }
            catch (OperationErrorException ex)
            {
                // Assert
                Assert.AreEqual(ex.Errors.Count, 1);
                Assert.AreEqual(ex.Errors[0].Field, "Name");
                Assert.AreEqual(ex.Errors[0].Error, Phrases.LocationErrorName);
            }
        }

        /// <summary>
        /// Should fail delete location - Main location
        /// </summary>
        [TestMethod]
        public async Task ShouldFailDeleteLocation_MainLocation()
        {
            // Arrange
            Location defaultLocation = await AppServices.LocationService.GetByIdAsync(1); // warehouse

            try
            {
                // Act
                await AppServices.LocationService.DeleteAsync(new int[] { defaultLocation.LocationId }, 1);

                Assert.Fail("It should have thrown an OperationErrorExeption");
            }
            catch (OperationErrorException ex)
            {
                // Assert
                Assert.AreEqual(ex.Errors.Count, 1);
                Assert.AreEqual(ex.Errors[0].Field, "MainLocation");
                Assert.AreEqual(ex.Errors[0].Error, Phrases.LocationErrorMainLocation);
            }
        }

        /// <summary>
        /// Should fail edit location - existing name
        /// </summary>
        [TestMethod]
        public async Task ShouldFailEditLocation_ExistingLocationName()
        {
            // Arrange
            Location defaultLocation = await AppServices.LocationService.GetByIdAsync(1); // warehouse
            Location defaultLocation2 = await AppServices.LocationService.GetByIdAsync(2); // Vehicle#1

            try
            {
                // Act
                Location updatedLocation = new Location()
                {
                    LocationId = defaultLocation.LocationId,
                    Name = defaultLocation2.Name,
                };

                await AppServices.LocationService.EditAsync(updatedLocation);

                Assert.Fail("It should have thrown an OperationErrorExeption");
            }
            catch (OperationErrorException ex)
            {
                // Assert
                Assert.AreEqual(ex.Errors.Count, 1);
                Assert.AreEqual(ex.Errors[0].Field, "Name");
                Assert.AreEqual(ex.Errors[0].Error, Phrases.LocationErrorName);
            }
        }

        /// <summary>
        /// Should get all locations
        /// </summary>
        [TestMethod]
        public async Task ShouldGetAllLocations()
        {
            // Arrange
            Location default1 = await AppServices.LocationService.GetByIdAsync(1); // Warehouse
            Location default2 = await AppServices.LocationService.GetByIdAsync(2); // Vehicle #1

            // Act
            IEnumerable<Location> locations = await AppServices.LocationService.GetAllAsync();

            // Assert
            Assert.AreEqual(locations.Count(), 2);
            Assert.AreEqual(locations.ElementAt(0).Name, default1.Name);
            Assert.AreEqual(locations.ElementAt(1).Name, default2.Name);
        }

        /// <summary>
        /// Should search locations by name
        /// </summary>
        [TestMethod]
        public async Task ShouldSearchLocationByName()
        {
            // Arrange
            Location default1 = await AppServices.LocationService.GetByIdAsync(1); // Warehouse

            // Act
            IEnumerable<Location> locations = await AppServices.LocationService.GetAllAsync(default1.Name);

            // Assert
            Assert.AreEqual(locations.Count(), 1);
            Assert.AreEqual(locations.ElementAt(0).Name, default1.Name);
        }

        /// <summary>
        /// Should fail create location - no name sent
        /// </summary>
        [TestMethod]
        public async Task ShoulFailCreateLocation_NoNameSent()
        {
            // Arrange
            Location newLocation = new Location() { Name = "" };

            try
            {
                // Act
                await AppServices.LocationService.CreateAsync(newLocation);

                Assert.Fail("It should have thrown an OperationErrorExeption");
            }
            catch (OperationErrorException ex)
            {
                // Assert
                Assert.AreEqual(ex.Errors.Count, 1);
                Assert.AreEqual(ex.Errors[0].Field, "Name");
                Assert.AreEqual(ex.Errors[0].Error, Phrases.GlobalRequiredField);
            }
        }
    }
}
