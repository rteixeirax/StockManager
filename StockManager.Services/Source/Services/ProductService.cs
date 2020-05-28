using StockManager.Services.Source.Contracts;
using StockManager.Database.Source.Contracts;
using StockManager.Database.Source.Models;
using StockManager.Translations.Source;
using StockManager.Types.Source;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockManager.Services.Source.Services {
  public class ProductService : IProductService {
    private readonly IProductRepository _productRepo;

    public ProductService(IProductRepository productRepo) {
      _productRepo = productRepo;
    }

    /// <summary>
    /// Create new product async
    /// </summary>
    public async Task CreateProductAsync(Product product) {
      try {
        await this.ValidateProductFormData(product);

        await _productRepo.AddProductAsync(product);
        await _productRepo.SaveDbChangesAsync();
      } catch (OperationErrorException operationErrorException) {
        throw operationErrorException;
      }
    }

    /// <summary>
    /// Edit product async
    /// </summary>
    public async Task EditProductAsync(Product product) {
      try {
        Product dbProduct = await _productRepo
          .FindProductByIdAsync(product.ProductId, false);

        await this.ValidateProductFormData(product, dbProduct);

        dbProduct.Reference = product.Reference;
        dbProduct.Name = product.Name;

        await _productRepo.SaveDbChangesAsync();
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

          Product product = await _productRepo.FindProductByIdAsync(productId, false);

          if (product != null) {
            _productRepo.RemoveProduct(product);
          }
        }

        await _productRepo.SaveDbChangesAsync();
      } catch {
        errorsList.AddError("delete-product-db-error", Phrases.GlobalErrorOperationDB);

        throw new ServiceErrorException(errorsList);
      }
    }

    /// <summary>
    /// Get all products async
    /// </summary>
    public async Task<IEnumerable<Product>> GetProductsAsync(string searchValue = null) {
      IEnumerable<Product> products = await _productRepo.FindAllProductsAsync(searchValue);

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
      return await _productRepo.FindProductByIdAsync(productId);
    }

    /// <summary>
    /// Validate Product form data
    /// </summary>
    private async Task ValidateProductFormData(Product product, Product dbProduct = null) {
      OperationErrorsList errorsList = new OperationErrorsList();

      if (string.IsNullOrEmpty(product.Name)) {
        errorsList.AddError("Name", Phrases.GlobalRequiredField);
      }

      if (string.IsNullOrEmpty(product.Reference)) {
        errorsList.AddError("Reference", Phrases.GlobalRequiredField);
      }

      if (errorsList.HasErrors()) {
        throw new OperationErrorException(errorsList);
      }

      // Check if the reference already exist
      // This validation only occurs when all form fields have no errors
      // And only if is a create or an update and the reference has changed
      Product nameCheck = ((dbProduct == null) || (dbProduct.Reference != product.Reference))
        ? await _productRepo.FindProductByReferenceAsync(product.Reference)
        : null;

      if (nameCheck != null) {
        errorsList.AddError("Reference", Phrases.ProductErrorReference);

        throw new OperationErrorException(errorsList);
      }
    }
  }
}
