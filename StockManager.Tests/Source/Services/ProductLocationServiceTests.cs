using Microsoft.VisualStudio.TestTools.UnitTesting;
using StockManager.Database.Source.Models;
using StockManager.Services.Source;
using StockManager.Translations.Source;
using StockManager.Types.Source;
using System.Threading.Tasks;

namespace StockManager.Tests.Source.Services
{
  /// <summary>
  /// ProductLocation service tests
  /// </summary>
  [TestClass]
  public class ProductLocationServiceTests
  {
    private TestsConfig _config;
    private Product _mockProduct;
    private Location _mockLocation;
    private User _mockUser;

    [TestInitialize]
    public async Task BeforeEach()
    {
      _config = new TestsConfig();

      _mockProduct = new Product() {
        Reference = "mockProduct",
        Name = "Mock product"
      };

      _mockLocation = await AppServices.LocationService.GetLocationByIdAsync(1);
      _mockUser = await AppServices.UserService.GetUserByIdAsync(1);

      await AppServices.ProductService.CreateProductAsync(_mockProduct);
    }

    [TestCleanup]
    public void AfterEach()
    {
      _config.CloseConnection();
    }

    [TestMethod]
    public async Task ShouldCreateProductLocation()
    {
      // Arrange
      ProductLocation newProductLocation = new ProductLocation() {
        ProductId = _mockProduct.ProductId,
        LocationId = _mockLocation.LocationId,
        Stock = 10,
        MinStock = 0
      };

      // Act
      await AppServices.ProductLocationService
        .AddProductLocationAsync(newProductLocation, _mockUser.UserId);

      // Assert
      StockMovement stockMovement = await AppServices.StockMovementService
       .GetProductLastStockMovementAsync(newProductLocation.ProductId);

      Assert.IsNotNull(newProductLocation.ProductLocationId);
      Assert.IsNotNull(newProductLocation.CreatedAt);
      Assert.IsNotNull(newProductLocation.UpdatedAt);

      Assert.AreEqual(stockMovement.ToLocationId, newProductLocation.LocationId);
      Assert.IsNull(stockMovement.FromLocationId);
      Assert.AreEqual(stockMovement.UserId, _mockUser.UserId);
      Assert.AreEqual(stockMovement.Qty, newProductLocation.Stock);
      Assert.AreEqual(stockMovement.Stock, newProductLocation.Stock);
    }

    [TestMethod]
    public async Task ShouldDeleteProductLocation()
    {
      // Arrange
      ProductLocation newProductLocation = new ProductLocation() {
        ProductId = _mockProduct.ProductId,
        LocationId = _mockLocation.LocationId,
        Stock = 10,
        MinStock = 0
      };

      await AppServices.ProductLocationService
        .AddProductLocationAsync(newProductLocation, _mockUser.UserId);

      // Act
      await AppServices.ProductLocationService
        .DeleteProductLocationAsyn(newProductLocation.ProductLocationId, _mockUser.UserId);

      // Assert
      StockMovement stockMovement = await AppServices.StockMovementService
        .GetProductLastStockMovementAsync(newProductLocation.ProductId);

      Assert.AreEqual(stockMovement.FromLocationId, newProductLocation.LocationId);
      Assert.IsNull(stockMovement.ToLocationId);
      Assert.AreEqual(stockMovement.UserId, _mockUser.UserId);
      Assert.AreEqual(stockMovement.Qty, newProductLocation.Stock * (-1));
      Assert.AreEqual(stockMovement.Stock, 0);
    }

    [TestMethod]
    public async Task ShouldFailCreateProductLocation_NoLocationId()
    {
      // Arrange
      ProductLocation newProductLocation = new ProductLocation() {
        ProductId = _mockProduct.ProductId,
        Stock = 10,
        MinStock = 5
      };

      try
      {
        // Act
        await AppServices.ProductLocationService
          .AddProductLocationAsync(newProductLocation, _mockUser.UserId);

        Assert.Fail("It should have thrown an OperationErrorExeption");
      }
      catch (OperationErrorException ex)
      {
        // Assert
        Assert.AreEqual(ex.Errors.Count, 1);
        Assert.AreEqual(ex.Errors[0].Field, "LocationId");
        Assert.AreEqual(ex.Errors[0].Error, Phrases.GlobalRequiredField);
      }
    }

    [TestMethod]
    public async Task ShouldFailCreateProductLocation_AlreadyAssociated()
    {
      // Arrange
      ProductLocation newProductLocation = new ProductLocation() {
        ProductId = _mockProduct.ProductId,
        LocationId = _mockLocation.LocationId,
        Stock = 10,
        MinStock = 0
      };

      ProductLocation newProductLocation2 = new ProductLocation() {
        ProductId = _mockProduct.ProductId,
        LocationId = _mockLocation.LocationId,
        Stock = 20,
        MinStock = 10
      };

      try
      {
        // Act
        await AppServices.ProductLocationService
          .AddProductLocationAsync(newProductLocation, _mockUser.UserId);

        await AppServices.ProductLocationService
          .AddProductLocationAsync(newProductLocation2, _mockUser.UserId);

        Assert.Fail("It should have thrown an OperationErrorExeption");
      }
      catch (OperationErrorException ex)
      {
        // Assert
        Assert.AreEqual(ex.Errors.Count, 1);
        Assert.AreEqual(ex.Errors[0].Field, "LocationId");
        Assert.AreEqual(ex.Errors[0].Error, Phrases.ProductLocationErrorAlreadyAssociated);
      }
    }
  }
}
