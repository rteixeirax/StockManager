using Microsoft.VisualStudio.TestTools.UnitTesting;
using StockManager.Database.Source.Models;
using StockManager.Services.Source;
using StockManager.Translations.Source;
using StockManager.Types.Source;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockManager.Tests.Source.Services
{
  /// <summary>
  /// Product service tests
  /// </summary>
  [TestClass]
  public class ProductServiceTests
  {
    private TestsConfig _config;
    private User _adminUser;
    private List<Product> _mockProducts = new List<Product>();

    [TestInitialize]
    public async Task BeforeEach()
    {
      _config = new TestsConfig();

      _adminUser = await AppServices.UserService.GetUserByIdAsync(1);

      _mockProducts.AddRange(new Product[] {
       new Product() {
          Reference = "mockRef1",
          Name = "Mock product 1",
        },
        new Product() {
          Reference = "mockRef2",
          Name = "Mock product 2",
        }
      });
    }

    [TestCleanup]
    public void AfterEach()
    {
      _config.CloseConnection();
    }

    /// <summary>
    /// Should get all products
    /// </summary>
    [TestMethod]
    public async Task ShouldGetAllProducts()
    {
      // Arrange
      Product product = _mockProducts[0];
      Product otherProduct = _mockProducts[1];
      await AppServices.ProductService.CreateProductAsync(product, _adminUser.UserId);
      await AppServices.ProductService.CreateProductAsync(otherProduct, _adminUser.UserId);

      // Act
      IEnumerable<Product> products = await AppServices.ProductService.GetProductsAsync();

      // Assert
      Assert.AreEqual(products.Count(), 2);
      Assert.AreEqual(products.ElementAt(0).Reference, product.Reference);
      Assert.AreEqual(products.ElementAt(1).Reference, otherProduct.Reference);
    }

    /// <summary>
    /// Should search products by reference
    /// </summary>
    [TestMethod]
    public async Task ShouldSearchProductByReference()
    {
      // Arrange
      Product product = _mockProducts[0];
      Product otherProduct = _mockProducts[1];
      await AppServices.ProductService.CreateProductAsync(product, _adminUser.UserId);
      await AppServices.ProductService.CreateProductAsync(otherProduct, _adminUser.UserId);

      // Act
      IEnumerable<Product> products = await AppServices.ProductService.GetProductsAsync(product.Reference);

      // Assert
      Assert.AreEqual(products.Count(), 1);
      Assert.AreEqual(products.ElementAt(0).Reference, product.Reference);
    }

    /// <summary>
    /// Should search products by name
    /// </summary>
    [TestMethod]
    public async Task ShouldSearchProductByName()
    {
      // Arrange
      Product product = _mockProducts[0];
      Product otherProduct = _mockProducts[1];
      await AppServices.ProductService.CreateProductAsync(product, _adminUser.UserId);
      await AppServices.ProductService.CreateProductAsync(otherProduct, _adminUser.UserId);

      // Act
      IEnumerable<Product> products = await AppServices.ProductService.GetProductsAsync(product.Name);

      // Assert
      Assert.AreEqual(products.Count(), 1);
      Assert.AreEqual(products.ElementAt(0).Name, product.Name);
    }

    /// <summary>
    /// Should create product
    /// </summary>
    [TestMethod]
    public async Task ShouldCreateProduct()
    {
      // Arrange
      Product product = _mockProducts[0];

      // Act
      await AppServices.ProductService.CreateProductAsync(product, _adminUser.UserId);

      // Assert
      Assert.AreEqual(product.Reference, "mockRef1");
      Assert.AreEqual(product.Name, "Mock product 1");
      Assert.IsNotNull(product.CreatedAt);
      Assert.IsNotNull(product.UpdatedAt);
    }

    /// <summary>
    /// Should fail create product with a existing reference
    /// </summary>
    [TestMethod]
    public async Task ShouldFailCreateProduct_ExistingReference()
    {
      // Arrange
      Product product = _mockProducts[0];
      await AppServices.ProductService.CreateProductAsync(product, _adminUser.UserId);

      try
      {
        // Act
        Product newProduct = _mockProducts[0];
        await AppServices.ProductService.CreateProductAsync(newProduct, _adminUser.UserId);

        Assert.Fail("It should have thrown an OperationErrorExeption");
      }
      catch (OperationErrorException ex)
      {
        // Assert
        Assert.AreEqual(ex.Errors.Count, 1);
        Assert.AreEqual(ex.Errors[0].Field, "Reference");
        Assert.AreEqual(ex.Errors[0].Error, Phrases.ProductErrorReference);
      }
    }

    /// <summary>
    /// Should fail create product - no reference and name sent
    /// </summary>
    [TestMethod]
    public async Task ShoulFailCreateProduct_NoReferenceAndNameSent()
    {
      // Arrange
      Product newProduct = new Product() { Reference = "", Name = "" };

      try
      {
        // Act
        await AppServices.ProductService.CreateProductAsync(newProduct, _adminUser.UserId);

        Assert.Fail("It should have thrown an OperationErrorExeption");
      }
      catch (OperationErrorException ex)
      {
        // Assert
        Assert.AreEqual(ex.Errors.Count, 2);
        Assert.AreEqual(ex.Errors[0].Field, "Name");
        Assert.AreEqual(ex.Errors[0].Error, Phrases.GlobalRequiredField);
        Assert.AreEqual(ex.Errors[1].Field, "Reference");
        Assert.AreEqual(ex.Errors[1].Error, Phrases.GlobalRequiredField);
      }
    }

    /// <summary>
    /// Should edit product
    /// </summary>
    [TestMethod]
    public async Task ShouldEditProduct()
    {
      // Arrange
      Product mockProduct = _mockProducts[0];
      await AppServices.ProductService.CreateProductAsync(mockProduct, _adminUser.UserId);

      // Act
      Product updatedProduct = new Product() {
        ProductId = mockProduct.ProductId,
        Reference = mockProduct.Reference,
        Name = "Updated product"
      };

      await AppServices.ProductService.EditProductAsync(updatedProduct);
      Product dbProduct = await AppServices.ProductService.GetProductByIdAsync(updatedProduct.ProductId);

      // Assert
      Assert.AreEqual(dbProduct.ProductId, updatedProduct.ProductId);
      Assert.AreEqual(dbProduct.Name, "Updated product");
    }

    /// <summary>
    /// Should fail edit product - existing reference
    /// </summary>
    [TestMethod]
    public async Task ShouldFailEditProduct_ExistingProductReference()
    {
      // Arrange
      Product mockProduct = _mockProducts[0];
      Product mockProduct2 = _mockProducts[1];
      await AppServices.ProductService.CreateProductAsync(mockProduct, _adminUser.UserId);
      await AppServices.ProductService.CreateProductAsync(mockProduct2, _adminUser.UserId);

      try
      {
        // Act
        Product updatedProduct = new Product() {
          ProductId = mockProduct.ProductId,
          Reference = mockProduct2.Reference,
          Name = mockProduct.Reference
        };

        await AppServices.ProductService.EditProductAsync(updatedProduct);

        Assert.Fail("It should have thrown an OperationErrorExeption");
      }
      catch (OperationErrorException ex)
      {
        // Assert
        Assert.AreEqual(ex.Errors.Count, 1);
        Assert.AreEqual(ex.Errors[0].Field, "Reference");
        Assert.AreEqual(ex.Errors[0].Error, Phrases.ProductErrorReference);
      }
    }

    /// <summary>
    /// Should delete product
    /// </summary>
    [TestMethod]
    public async Task ShouldDeleteProduct()
    {
      // Arrange
      Product mockProduct = _mockProducts[0];
      await AppServices.ProductService.CreateProductAsync(mockProduct, _adminUser.UserId);

      // Act
      await AppServices.ProductService.DeleteProductAsync(new int[] { mockProduct.ProductId });
      Product dbProduct = await AppServices.ProductService.GetProductByIdAsync(mockProduct.ProductId);

      // Assert
      Assert.IsNull(dbProduct);
    }
  }
}
