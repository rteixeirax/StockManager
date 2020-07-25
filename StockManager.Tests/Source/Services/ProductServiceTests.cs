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
    /// Product service tests
    /// </summary>
    [TestClass]
    public class ProductServiceTests
    {
        private User _adminUser;
        private TestsConfig _config;
        private readonly List<Product> _mockProducts = new List<Product>();

        [TestCleanup]
        public void AfterEach()
        {
            _config.CloseConnection();
        }

        [TestInitialize]
        public async Task BeforeEach()
        {
            _config = new TestsConfig();

            _adminUser = await AppServices.UserService.GetByIdAsync(1);

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

        /// <summary>
        /// Should create product
        /// </summary>
        [TestMethod]
        public async Task ShouldCreateProduct()
        {
            // Arrange
            Product product = _mockProducts[0];

            // Act
            await AppServices.ProductService.CreateAsync(product, _adminUser.UserId);

            // Assert
            Assert.AreEqual(product.Reference, "mockRef1");
            Assert.AreEqual(product.Name, "Mock product 1");
            Assert.IsNotNull(product.CreatedAt);
            Assert.IsNotNull(product.UpdatedAt);
        }

        /// <summary>
        /// Should delete product
        /// </summary>
        [TestMethod]
        public async Task ShouldDeleteProduct()
        {
            // Arrange
            Product mockProduct = _mockProducts[0];
            await AppServices.ProductService.CreateAsync(mockProduct, _adminUser.UserId);

            // Act
            await AppServices.ProductService.DeleteAsync(new int[] { mockProduct.ProductId });
            Product dbProduct = await AppServices.ProductService.GetByIdAsync(mockProduct.ProductId);

            // Assert
            Assert.IsNull(dbProduct);
        }

        /// <summary>
        /// Should edit product
        /// </summary>
        [TestMethod]
        public async Task ShouldEditProduct()
        {
            // Arrange
            Product mockProduct = _mockProducts[0];
            await AppServices.ProductService.CreateAsync(mockProduct, _adminUser.UserId);

            // Act
            Product updatedProduct = new Product()
            {
                ProductId = mockProduct.ProductId,
                Reference = mockProduct.Reference,
                Name = "Updated product"
            };

            await AppServices.ProductService.EditAsync(updatedProduct);
            Product dbProduct = await AppServices.ProductService.GetByIdAsync(updatedProduct.ProductId);

            // Assert
            Assert.AreEqual(dbProduct.ProductId, updatedProduct.ProductId);
            Assert.AreEqual(dbProduct.Name, "Updated product");
        }

        /// <summary>
        /// Should fail create product with a existing reference
        /// </summary>
        [TestMethod]
        public async Task ShouldFailCreateProduct_ExistingReference()
        {
            // Arrange
            Product product = _mockProducts[0];
            await AppServices.ProductService.CreateAsync(product, _adminUser.UserId);

            try
            {
                // Act
                Product newProduct = _mockProducts[0];
                await AppServices.ProductService.CreateAsync(newProduct, _adminUser.UserId);

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
        /// Should fail edit product - existing reference
        /// </summary>
        [TestMethod]
        public async Task ShouldFailEditProduct_ExistingProductReference()
        {
            // Arrange
            Product mockProduct = _mockProducts[0];
            Product mockProduct2 = _mockProducts[1];
            await AppServices.ProductService.CreateAsync(mockProduct, _adminUser.UserId);
            await AppServices.ProductService.CreateAsync(mockProduct2, _adminUser.UserId);

            try
            {
                // Act
                Product updatedProduct = new Product()
                {
                    ProductId = mockProduct.ProductId,
                    Reference = mockProduct2.Reference,
                    Name = mockProduct.Reference
                };

                await AppServices.ProductService.EditAsync(updatedProduct);

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
        /// Should get all products
        /// </summary>
        [TestMethod]
        public async Task ShouldGetAllProducts()
        {
            // Arrange
            Product product = _mockProducts[0];
            Product otherProduct = _mockProducts[1];
            await AppServices.ProductService.CreateAsync(product, _adminUser.UserId);
            await AppServices.ProductService.CreateAsync(otherProduct, _adminUser.UserId);

            // Act
            IEnumerable<Product> products = await AppServices.ProductService.GetAllAsync();

            // Assert
            Assert.AreEqual(products.Count(), 2);
            Assert.AreEqual(products.ElementAt(0).Reference, product.Reference);
            Assert.AreEqual(products.ElementAt(1).Reference, otherProduct.Reference);
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
            await AppServices.ProductService.CreateAsync(product, _adminUser.UserId);
            await AppServices.ProductService.CreateAsync(otherProduct, _adminUser.UserId);

            // Act
            IEnumerable<Product> products = await AppServices.ProductService.GetAllAsync(product.Name);

            // Assert
            Assert.AreEqual(products.Count(), 1);
            Assert.AreEqual(products.ElementAt(0).Name, product.Name);
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
            await AppServices.ProductService.CreateAsync(product, _adminUser.UserId);
            await AppServices.ProductService.CreateAsync(otherProduct, _adminUser.UserId);

            // Act
            IEnumerable<Product> products = await AppServices.ProductService.GetAllAsync(product.Reference);

            // Assert
            Assert.AreEqual(products.Count(), 1);
            Assert.AreEqual(products.ElementAt(0).Reference, product.Reference);
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
                await AppServices.ProductService.CreateAsync(newProduct, _adminUser.UserId);

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
    }
}
