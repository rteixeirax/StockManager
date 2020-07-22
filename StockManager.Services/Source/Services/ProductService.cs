using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using StockManager.Database.Source.Contracts;
using StockManager.Database.Source.Models;
using StockManager.Services.Source.Contracts;
using StockManager.Translations.Source;
using StockManager.Types.Source;

namespace StockManager.Services.Source.Services
{
    public class ProductService : IProductService
    {
        private readonly IRepository _repository;

        public ProductService(IRepository repository)
        {
            _repository = repository;
        }

        public async Task<int> CountAsync()
        {
            return await _repository.Products.CountAsync();
        }

        public async Task CreateProductAsync(Product product, int userId)
        {
            try
            {
                await ValidateProductFormData(product);

                await _repository.Products.AddProductAsync(product);
                await _repository.SaveChangesAsync();

                // Get the main location
                Location mainLocation = await AppServices.LocationService.GetMainLocationAsync();

                // Associate the product to the main location
                await AppServices.ProductLocationService
                  .AddProductLocationAsync(new ProductLocation()
                  {
                      LocationId = mainLocation.LocationId,
                      ProductId = product.ProductId,
                      Stock = 0,
                      MinStock = 0,
                  },
                  userId
                );

                // Save changes to save the association
                await _repository.SaveChangesAsync();
            }
            catch (OperationErrorException operationErrorException)
            {
                throw operationErrorException;
            }
        }

        public async Task DeleteProductAsync(int[] productIds)
        {
            OperationErrorsList errorsList = new OperationErrorsList();

            try
            {
                for (int i = 0; i < productIds.Length; i += 1)
                {
                    int productId = productIds[i];

                    Product product = await _repository.Products.FindProductByIdAsync(productId, false);

                    if (product != null)
                    {
                        _repository.Products.RemoveProduct(product);
                    }
                }

                await _repository.SaveChangesAsync();
            }
            catch
            {
                errorsList.AddError("delete-product-db-error", Phrases.GlobalErrorOperationDB);

                throw new ServiceErrorException(errorsList);
            }
        }

        public async Task EditProductAsync(Product product)
        {
            try
            {
                Product dbProduct = await _repository.Products.FindProductByIdAsync(product.ProductId, false);
                await ValidateProductFormData(product, dbProduct);

                dbProduct.Reference = product.Reference;
                dbProduct.Name = product.Name;

                await _repository.SaveChangesAsync();
            }
            catch (OperationErrorException operationErrorException)
            {
                throw operationErrorException;
            }
        }

        public async Task<Product> GetProductByIdAsync(int productId)
        {
            return await _repository.Products.FindProductByIdAsync(productId);
        }

        public async Task<IEnumerable<Product>> GetProductsAsync(string searchValue = null)
        {
            IEnumerable<Product> products = await _repository.Products.FindAllProductsAsync(searchValue);

            // Calculate the product total stock
            products.ToList().ForEach(product => {
                product.Stock = product.ProductLocations?.Sum(x => x.Stock);
            });

            return products;
        }

        /// <summary>
        /// Validate Product form data
        /// </summary>
        private async Task ValidateProductFormData(Product product, Product dbProduct = null)
        {
            OperationErrorsList errorsList = new OperationErrorsList();

            if (string.IsNullOrEmpty(product.Name))
            {
                errorsList.AddError("Name", Phrases.GlobalRequiredField);
            }

            if (string.IsNullOrEmpty(product.Reference))
            {
                errorsList.AddError("Reference", Phrases.GlobalRequiredField);
            }

            if (errorsList.HasErrors())
            {
                throw new OperationErrorException(errorsList);
            }

            // Check if the reference already exist This validation only occurs when all form fields
            // have no errors And only if is a create or an update and the reference has changed
            Product nameCheck = ((dbProduct == null) || (dbProduct.Reference != product.Reference))
              ? await _repository.Products.FindProductByReferenceAsync(product.Reference)
              : null;

            if (nameCheck != null)
            {
                errorsList.AddError("Reference", Phrases.ProductErrorReference);

                throw new OperationErrorException(errorsList);
            }
        }
    }
}
