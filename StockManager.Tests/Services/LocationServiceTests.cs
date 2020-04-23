using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StockManager.Services.Contracts;
using StockManager.Storage.Models;

namespace StockManager.Tests.Services {
  /// <summary>
  /// Location service tests
  /// </summary>
  [TestClass]
  public class LocationServiceTests {
    private Configuration config;
    private ILocationService locationService;

    [TestInitialize]
    public void BeforeEach() {
      this.config = new Configuration();
      this.locationService = this.config.SetLocationService();
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
  }
}
