using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using StockManager.Core.Source;
using StockManager.Core.Source.Models;
using StockManager.Core.Source.Services;
using StockManager.Core.Source.Types;
using StockManager.Translations.Source;

namespace StockManager.Services.Source.Services
{
    public class ProductService : IProductService
    {
        private readonly IAppRepository _repository;

        public ProductService(IAppRepository repository)
        {
            _repository = repository;
        }

        public async Task<int> CountAsync()
        {
            return await _repository.Products.CountAsync();
        }

        public async Task CreateAsync(Product product, int userId)
        {
            try
            {
                await ValidateProductFormData(product);

                await _repository.Products.AddAsync(product);
                await _repository.SaveChangesAsync();

                // Get the main location
                Location mainLocation = await AppServices.LocationService.GetMainAsync();

                ProductLocation plocation = new ProductLocation()
                {
                    LocationId = mainLocation.LocationId,
                    ProductId = product.ProductId,
                    Stock = 0,
                    MinStock = 0,
                };

                // Associate the product to the main location
                await AppServices.ProductLocationService.CreateAsync(plocation, userId);

                // When the product is created the stock is 0 by default, so we need to set an stock alert
                await AppServices.NotificationService.ToggleStockAlertsAsync(plocation, 0);

                // Save changes to save the association
                await _repository.SaveChangesAsync();
            }
            catch (OperationErrorException operationErrorException)
            {
                throw operationErrorException;
            }
        }

        public async Task DeleteAsync(int[] productIds)
        {
            OperationErrorsList errorsList = new OperationErrorsList();

            try
            {
                for (int i = 0; i < productIds.Length; i += 1)
                {
                    int productId = productIds[i];

                    Product product = await _repository.Products.GetByIdAsync(productId);

                    if (product != null)
                    {
                        _repository.Products.Remove(product);
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

        public async Task EditAsync(Product product)
        {
            try
            {
                Product dbProduct = await _repository.Products.GetByIdAsync(product.ProductId);
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

        public async Task<Product> GetByIdAsync(int productId)
        {
            return await _repository.Products.GetByIdWithProductLocationsAndStockMovementsAsync(productId);
        }

        public async Task<IEnumerable<Product>> GetAllAsync(string searchValue = null)
        {
            IEnumerable<Product> products;

            if (!string.IsNullOrEmpty(searchValue))
            {
                products = await _repository.Products
                    .FindAllWithProductLocationsAsync(product => product.Reference.ToLower().Contains(searchValue.ToLower())
                    || product.Name.ToLower().Contains(searchValue.ToLower()));
            }
            else
            {
                products = await _repository.Products.FindAllWithProductLocationsAsync();
            }

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
              ? await _repository.Products.FindOneAsync(p => p.Reference.ToLower() == product.Reference.ToLower())
              : null;

            if (nameCheck != null)
            {
                errorsList.AddError("Reference", Phrases.ProductErrorReference);

                throw new OperationErrorException(errorsList);
            }
        }
    }
}
