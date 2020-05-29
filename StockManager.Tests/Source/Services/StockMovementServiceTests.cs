using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StockManager.Database.Source.Models;
using StockManager.Services.Source;

namespace StockManager.Tests.Source.Services {
  /// <summary>
  /// Stock movement service tests
  /// </summary>
  [TestClass]
  public class StockMovementServiceTests {
    private TestsConfig _config;
    private Product _mockProduct;
    private Location _mockLocation;
    private User _mockUser;

    [TestInitialize]
    public async Task BeforeEach() {
      _config = new TestsConfig();

      _mockProduct = new Product() {
        Reference = "mockProduct",
        Name = "Mock product"
      };

      _mockLocation = await AppServices.LocationService.GetLocationByIdAsync(1);
      _mockUser = await AppServices.UserService.GetUserByIdAsync(1);

      await AppServices.ProductService.CreateProductAsync(_mockProduct);
      await AppServices.ProductLocationService
        .AddProductLocationAsync(new ProductLocation() {
          ProductId = _mockProduct.ProductId,
          LocationId = _mockLocation.LocationId,
          Stock = 10,
          MinStock = 0
        },
        _mockUser.UserId
      );
    }

    [TestCleanup]
    public void AfterEach() {
      _config.CloseConnection();
    }

    [TestMethod]
    public async Task ShouldInsertStockMovement_Entry() {
      // Arrange
      StockMovement stockMovement = new StockMovement() {
        UserId = _mockUser.UserId,
        ProductId = _mockProduct.ProductId,
        ToLocationId = _mockLocation.LocationId,
        Qty = 10,
      };

      // Act
      await AppServices.StockMovementService.AddStockMovementAsync(stockMovement, true);

      // Assert
      Assert.AreEqual(stockMovement.Qty, 10);
      Assert.AreEqual(stockMovement.Stock, 20);
      Assert.AreEqual(stockMovement.ToLocationId, _mockLocation.LocationId);
      Assert.AreEqual(stockMovement.ProductId, _mockProduct.ProductId);
      Assert.AreEqual(stockMovement.UserId, _mockUser.UserId);
      Assert.IsNull(stockMovement.FromLocationId);
      Assert.IsNotNull(stockMovement.CreatedAt);
      Assert.IsNotNull(stockMovement.UpdatedAt);
    }

    [TestMethod]
    public async Task ShouldInsertStockMovement_Exit() {
      // Arrange
      StockMovement stockMovement = new StockMovement() {
        UserId = _mockUser.UserId,
        ProductId = _mockProduct.ProductId,
        FromLocationId = _mockLocation.LocationId,
        Qty = -10,
      };

      // Act
      await AppServices.StockMovementService.AddStockMovementAsync(stockMovement, true);

      // Assert
      Assert.AreEqual(stockMovement.Qty, -10);
      Assert.AreEqual(stockMovement.Stock, 0);
      Assert.AreEqual(stockMovement.FromLocationId, _mockLocation.LocationId);
      Assert.AreEqual(stockMovement.ProductId, _mockProduct.ProductId);
      Assert.AreEqual(stockMovement.UserId, _mockUser.UserId);
      Assert.IsNull(stockMovement.ToLocationId);
      Assert.IsNotNull(stockMovement.CreatedAt);
      Assert.IsNotNull(stockMovement.UpdatedAt);
    }
  }
}
