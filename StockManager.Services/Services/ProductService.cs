using StockManager.Services.Contracts;
using StockManager.Storage.Contracts;
using StockManager.Storage.Models;
using StockManager.Types.Types;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockManager.Services.Services {
  public class ProductService : IProductService {
    private readonly IProductRepository productRepo;

    public ProductService(IProductRepository productRepo) {
      this.productRepo = productRepo;
    }

    /// <summary>
    /// Create new product async
    /// </summary>
    public async Task CreateProductAsync(Product product) {
      try {
        await this.ValidateProductFormData(product);

        await this.productRepo.AddProductAsync(product);
        await this.productRepo.SaveDbChangesAsync();
      } catch (OperationErrorException operationErrorException) {
        throw operationErrorException;
      }
    }

    /// <summary>
    /// Edit product async
    /// </summary>
    public async Task EditProductAsync(Product product) {
      try {
        Product dbProduct = await this.productRepo
          .FindProductByIdAsync(product.ProductId);

        await this.ValidateProductFormData(product, dbProduct);

        dbProduct.Reference = product.Reference;
        dbProduct.Name = product.Name;

        await this.productRepo.SaveDbChangesAsync();
      } catch (OperationErrorException operationErrorException) {
        throw operationErrorException;
      }
    }

    /// <summary>
    /// Delete products async
    /// </summary>
    public async Task DeleteProductAsync(int[] productIds) {
      OperationErrorsList errorsList = new OperationErrorsList();

      try {
        for (int i = 0; i < productIds.Length; i += 1) {
          int productId = productIds[i];

          Product product = await this.productRepo
            .FindProductByIdAsync(productId);

          if (product != null) {
            this.productRepo.RemoveProduct(product);
          }
        }

        await this.productRepo.SaveDbChangesAsync();
      } catch {
        errorsList.AddError("delete-product-db-error", "Oops.. something went wrong. Try it again!");

        throw new ServiceErrorException(errorsList);
      }
    }

    /// <summary>
    /// Get all products async
    /// </summary>
    public async Task<IEnumerable<Product>> GetProductsAsync(string searchValue = null) {
      IEnumerable<Product> products = await this.productRepo.FindAllProductsAsync(searchValue);

      // Calculate the product total stock
      products.ToList().ForEach(product => {
        product.Stock = product.ProductLocations?.Sum(x => x.Stock);
      });

      return products;
    }

    /// <summary>
    /// Get product by id async
    /// </summary>
    public async Task<Product> GetProductByIdAsync(int productId) {
      return await this.productRepo.FindProductByIdAsync(productId);
    }

    /// <summary>
    /// Validate Product form data
    /// </summary>
    private async Task ValidateProductFormData(Product product, Product dbProduct = null) {
      OperationErrorsList errorsList = new OperationErrorsList();

      if (string.IsNullOrEmpty(product.Name)) {
        errorsList.AddError("Name", "This field is required.");
      }

      if (string.IsNullOrEmpty(product.Reference)) {
        errorsList.AddError("Reference", "This field is required.");
      }

      if (errorsList.HasErrors()) {
        throw new OperationErrorException(errorsList);
      }

      // Check if the reference already exist
      // This validation only occurs when all form fields have no errors
      // And only if is a create or an update and the reference has changed
      Product nameCheck = ((dbProduct == null) || (dbProduct.Reference != product.Reference))
        ? await this.productRepo.FindProductByReferenceAsync(product.Reference)
        : null;

      if (nameCheck != null) {
        errorsList.AddError("Reference", "A product with this reference already exist.");

        throw new OperationErrorException(errorsList);
      }
    }
  }
}
