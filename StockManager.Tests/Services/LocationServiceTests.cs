using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StockManager.Services.Contracts;
using StockManager.Storage.Models;
using StockManager.Translations.Source;
using StockManager.Types.Types;

namespace StockManager.Tests.Services {
  /// <summary>
  /// Location service tests
  /// </summary>
  [TestClass]
  public class LocationServiceTests {
    private Configuration config;
    private ILocationService locationService;
    private Location mockLocation;

    [TestInitialize]
    public void BeforeEach() {
      this.config = new Configuration();
      this.locationService = this.config.SetLocationService();
      this.mockLocation = new Location() { Name = "new Location" };
    }

    [TestCleanup]
    public void AfterEach() {
      this.config.CloseConnection();
    }

    /// <summary>
    /// Should get all locations
    /// </summary>
    [TestMethod]
    public async Task ShouldGetAllLocations() {
      // Arrange 
      Location default1 = await this.locationService.GetLocationByIdAsync(1); // Warehouse
      Location default2 = await this.locationService.GetLocationByIdAsync(2); // Vehicle #1

      // Act 
      IEnumerable<Location> locations = await this.locationService.GetLocationsAsync();

      // Assert 
      Assert.AreEqual(locations.Count(), 2);
      Assert.AreEqual(locations.ElementAt(0).Name, default1.Name);
      Assert.AreEqual(locations.ElementAt(1).Name, default2.Name);
    }

    /// <summary>
    /// Should search locations by name
    /// </summary>
    [TestMethod]
    public async Task ShouldSearchLocationByName() {
      // Arrange 
      Location default1 = await this.locationService.GetLocationByIdAsync(1); // Warehouse

      // Act 
      IEnumerable<Location> locations = await this.locationService.GetLocationsAsync(default1.Name);

      // Assert 
      Assert.AreEqual(locations.Count(), 1);
      Assert.AreEqual(locations.ElementAt(0).Name, default1.Name);
    }

    /// <summary>
    /// Should create location
    /// </summary>
    [TestMethod]
    public async Task ShouldCreateLocation() {
      // Arrange 
      Location location = this.mockLocation;

      // Act 
      await this.locationService.CreateLocationAsync(location);

      // Assert 
      Assert.AreEqual(location.Name, "new Location");
      Assert.IsNotNull(location.CreatedAt);
      Assert.IsNotNull(location.UpdatedAt);
    }

    /// <summary>
    /// Should fail create location with a existing name
    /// </summary>
    [TestMethod]
    public async Task ShouldFailCreateLocation_ExistingName() {
      // Arrange 
      Location location = this.mockLocation;

      try {
        // Act 
        location.Name = "Warehouse"; // default
        await this.locationService.CreateLocationAsync(location);

        Assert.Fail("It should have thrown an OperationErrorExeption");
      } catch (OperationErrorException ex) {
        // Assert 
        Assert.AreEqual(ex.Errors.Count, 1);
        Assert.AreEqual(ex.Errors[0].Field, "Name");
        Assert.AreEqual(ex.Errors[0].Error, Phrases.LocationErrorName);
      }
    }

    /// <summary>
    /// Should fail create location - no name sent
    /// </summary>
    [TestMethod]
    public async Task ShoulFailCreateLocation_NoNameSent() {
      // Arrange 
      Location newLocation = new Location() { Name = "" };

      try {
        // Act 
        await this.locationService.CreateLocationAsync(newLocation);

        Assert.Fail("It should have thrown an OperationErrorExeption");
      } catch (OperationErrorException ex) {
        // Assert 
        Assert.AreEqual(ex.Errors.Count, 1);
        Assert.AreEqual(ex.Errors[0].Field, "Name");
        Assert.AreEqual(ex.Errors[0].Error, Phrases.GlobalRequiredField);
      }
    }

    /// <summary>
    /// Should edit location
    /// </summary>
    [TestMethod]
    public async Task ShouldEditLocation() {
      // Arrange 
      Location defaultLocation = await this.locationService.GetLocationByIdAsync(1); // warehouse 

      // Act
      Location updatedLocation = new Location() {
        LocationId = defaultLocation.LocationId,
        Name = "Updated location"
      };

      await this.locationService.EditLocationAsync(updatedLocation);
      Location dbLocation = await this.locationService.GetLocationByIdAsync(updatedLocation.LocationId);

      // Assert
      Assert.AreEqual(dbLocation.LocationId, updatedLocation.LocationId);
      Assert.AreEqual(dbLocation.Name, "Updated location");
    }

    /// <summary>
    /// Should fail edit location - existing name
    /// </summary>
    [TestMethod]
    public async Task ShouldFailEditLocation_ExistingLocationName() {
      // Arrange 
      Location defaultLocation = await this.locationService.GetLocationByIdAsync(1); // warehouse 
      Location defaultLocation2 = await this.locationService.GetLocationByIdAsync(2); // Vehicle#1

      try {
        // Act
        Location updatedLocation = new Location() {
          LocationId = defaultLocation.LocationId,
          Name = defaultLocation2.Name,
        };

        await this.locationService.EditLocationAsync(updatedLocation);

        Assert.Fail("It should have thrown an OperationErrorExeption");
      } catch (OperationErrorException ex) {
        // Assert 
        Assert.AreEqual(ex.Errors.Count, 1);
        Assert.AreEqual(ex.Errors[0].Field, "Name");
        Assert.AreEqual(ex.Errors[0].Error, Phrases.LocationErrorName);
      }
    }

    /// <summary>
    /// Should delete location
    /// </summary>
    [TestMethod]
    public async Task ShouldDeleteLocation() {
      // Arrange 
      Location mockLocation = this.mockLocation;
      await this.locationService.CreateLocationAsync(mockLocation);

      // Act
      await this.locationService.DeleteLocationAsync(new int[] { mockLocation.LocationId });
      Location dbLocation = await this.locationService.GetLocationByIdAsync(mockLocation.LocationId);

      // Assert
      Assert.IsNull(dbLocation);
    }

    /// <summary>
    /// Should fail delete location - must have al least one location
    /// </summary>
    [TestMethod]
    public async Task ShouldFailDeleteLocation_LastLocation() {
      // Arrange 
      Location defaultLocation = await this.locationService.GetLocationByIdAsync(1); // warehouse 
      Location defaultLocation2 = await this.locationService.GetLocationByIdAsync(2); // Vehicle#1
      await this.locationService.DeleteLocationAsync(new int[] { defaultLocation2.LocationId });

      try {
        // Act
        await this.locationService.DeleteLocationAsync(new int[] { defaultLocation.LocationId });

        Assert.Fail("It should have thrown an OperationErrorExeption");
      } catch (OperationErrorException ex) {
        // Assert 
        Assert.AreEqual(ex.Errors.Count, 1);
        Assert.AreEqual(ex.Errors[0].Field, "LocationsCount");
        Assert.AreEqual(ex.Errors[0].Error, Phrases.LocationErrorCount);
      }
    }

    /// <summary>
    /// Should fail delete location - location with products
    /// </summary>
    [TestMethod]
    public async Task ShouldFailDeleteLocation_LocationWithProducts() {
      // Arrange 
      IProductService productService = this.config.SetProductService();
      Storage.StorageContext db = this.config.GetStorageContext();

      await productService.CreateProductAsync(new Product() {
        Name = "mock product",
        Reference = "mockref",
      });

      Product product = await productService.GetProductByIdAsync(1);
      Location defaultLocation = await this.locationService.GetLocationByIdAsync(1); // warehouse 

      await db.ProductLocations.AddAsync(new ProductLocation() {
        ProductId = product.ProductId,
        LocationId = defaultLocation.LocationId,
      });

      try {
        // Act
        await this.locationService.DeleteLocationAsync(new int[] { defaultLocation.LocationId });

        Assert.Fail("It should have thrown an OperationErrorExeption");
      } catch (OperationErrorException ex) {
        // Assert 
        Assert.AreEqual(ex.Errors.Count, 1);
        Assert.AreEqual(ex.Errors[0].Field, "LocationWithProducts");
        Assert.AreEqual(ex.Errors[0].Error, Phrases.LocationErrorWithProducts);
      }
    }
  }
}
