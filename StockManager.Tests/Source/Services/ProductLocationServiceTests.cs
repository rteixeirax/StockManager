using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StockManager.Tests.Source.Services
{
  /// <summary>
  /// ProductLocation service tests
  /// </summary>
  [TestClass]
  public class ProductLocationServiceTests
  {
    private TestsConfig _config;

    [TestInitialize]
    public void BeforeEach()
    {
      _config = new TestsConfig();
    }

    [TestCleanup]
    public void AfterEach()
    {
      _config.CloseConnection();
    }

    [TestMethod]
    public void ShouldCreateProductLocation()
    {
      // TODO: write the test
    }

    [TestMethod]
    public void ShouldDeleteProductLocation()
    {
      // TODO: write the test
    }

    [TestMethod]
    public void ShouldFailCreateProductLocation_NoLocationId()
    {
      // TODO: write the test
    }

    [TestMethod]
    public void ShouldFailCreateProductLocation_NoStock()
    {
      // TODO: write the test
    }

    [TestMethod]
    public void ShouldFailCreateProductLocation_NoMinStock()
    {
      // TODO: write the test
    }

    [TestMethod]
    public void ShouldFailCreateProductLocation_AlreadyAssociated()
    {
      // TODO: write the test
    }
  }
}
