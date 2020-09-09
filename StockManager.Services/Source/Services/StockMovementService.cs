using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using StockManager.Core.Source;
using StockManager.Core.Source.Models;
using StockManager.Core.Source.Services;
using StockManager.Core.Source.Types;
using StockManager.Translations.Source;

namespace StockManager.Services.Source.Services
{
    public class StockMovementService : IStockMovementService
    {
        private readonly IAppRepository _repository;

        public StockMovementService(IAppRepository repository)
        {
            _repository = repository;
        }

        public async Task CreateAsync(StockMovement data, bool applyDbChanges = false)
        {
            try
            {
                int locationId = ( int )((data.ToLocationId != null)
                  ? data.ToLocationId
                  : data.FromLocationId);

                ProductLocation productLocation = await AppServices.ProductLocationService
                  .GetOneAsync(data.ProductId, locationId);

                // Calculate the new accumulated stock
                if (productLocation != null)
                {
                    data.Stock = (productLocation.Stock + data.Qty);

                    await AppServices.NotificationService.ToggleStockAlertsAsync(productLocation, data.Stock);
                }
                else
                {
                    // Set the accumulated if it is the first movement
                    data.Stock = data.Qty;
                }

                await _repository.StockMovements.AddAsync(data);

                // Normally this service is called inside other services and the call of the
                // SaveChangesAsync method it will be the responsibility of the other service. In
                // some circumstances we want the apply the db changes after create the stock
                // movement, for that we need to sent the applyDbChanges setted to true.
                if (applyDbChanges)
                {
                    await _repository.SaveChangesAsync();
                }
            }
            catch
            {
                OperationErrorsList errorsList = new OperationErrorsList();
                errorsList.AddError("add-stock-movement-db-error", Phrases.GlobalErrorOperationDB);

                throw new ServiceErrorException(errorsList);
            }
        }

        public async Task CreateMovementInsideMainLocationAsync(int productId, float qty, bool isEntry, int userId)
        {
            try
            {
                Location mainLocation = await AppServices.LocationService.GetMainAsync();
                ProductLocation productLocation = await AppServices.ProductLocationService
                  .GetOneAsync(productId, mainLocation.LocationId);

                // If is an exit movement, set negative qty
                float qtyToMove = isEntry ? qty : (qty * (-1));

                StockMovement movement = new StockMovement()
                {
                    UserId = userId,
                    ProductId = productId,
                    Qty = qtyToMove,
                };

                if (isEntry)
                {
                    movement.ToLocationId = mainLocation.LocationId;
                    movement.ToLocationName = mainLocation.Name;
                }
                else
                {
                    movement.FromLocationId = mainLocation.LocationId;
                    movement.FromLocationName = mainLocation.Name;
                }


                // Create the stock movement
                await CreateAsync(movement);

                // Update the stock in the ProductLocation relation
                productLocation.Stock += qtyToMove;

                await AppServices.NotificationService.ToggleStockAlertsAsync(productLocation, productLocation.Stock);

                await _repository.SaveChangesAsync();
            }
            catch (OperationErrorException operationErrorException)
            {
                throw operationErrorException;
            }
        }

        public async Task<IEnumerable<StockMovement>> GetAllAsync(StockMovementOptions options)
        {
            string searchValue = options.SearchValue.ToLower();
            DateTime startDate = new DateTime(options.StartDate.Year, options.StartDate.Month, options.StartDate.Day, 0, 0, 0);
            DateTime endDate = new DateTime(options.EndDate.Year, options.EndDate.Month, options.EndDate.Day, 23, 59, 59);

            return await _repository.StockMovements.FindAllWithProductAndUserAsync(x =>
            (x.Product.Reference.ToLower().Contains(searchValue) || x.Product.Name.ToLower().Contains(searchValue))
            && (x.CreatedAt >= startDate) && (x.CreatedAt <= endDate));
        }

        public async Task<StockMovement> GetProductLastMovementAsync(int productId)
        {
            return await _repository.StockMovements.FindLastStockMovementAsync(x => x.ProductId == productId);
        }

        public async Task MoveStockBetweenLocationsAsync(int fromLocationId, int toLocationId, int productId, float qty, int userId, bool verifyStock = true)
        {
            try
            {
                // Get the relation productId > fromLocationId to check if the qty can be accepted 
                ProductLocation fromLocationRelation = await AppServices.ProductLocationService
                   .GetOneAsync(productId, fromLocationId);

                if (verifyStock)
                {
                    VerifyIfHasStockAvailableToMove(fromLocationRelation, qty);
                }

                Location fromLocation = await AppServices.LocationService.GetByIdAsync(fromLocationId);
                Location toLocation = await AppServices.LocationService.GetByIdAsync(toLocationId);

                // Set the stock movement between locations
                StockMovement stockMovement = new StockMovement()
                {
                    UserId = userId,
                    ProductId = productId,
                    FromLocationId = fromLocation.LocationId,
                    FromLocationName = fromLocation.Name,
                    ToLocationId = toLocation.LocationId,
                    ToLocationName = toLocation.Name,
                    Qty = qty,
                };

                // Create the stock movement
                await CreateAsync(stockMovement);

                // Update the stock in the From location
                fromLocationRelation.Stock -= qty;

                await AppServices.NotificationService.ToggleStockAlertsAsync(fromLocationRelation, fromLocationRelation.Stock);

                // Update the stock in the To location
                ProductLocation toLocationRelation = await AppServices.ProductLocationService
                   .GetOneAsync(productId, toLocationId);

                // If the product is associated to the location, update the stock
                if (toLocationRelation != null)
                {
                    toLocationRelation.Stock += qty;
                }
                else
                {
                    // If not, create the relation
                    await AppServices.ProductLocationService.CreateAsync(
                      new ProductLocation
                      {
                          LocationId = toLocationId,
                          ProductId = productId,
                          Stock = qty,
                      },
                      userId,
                      false,
                      false
                    );
                }

                await _repository.SaveChangesAsync();
            }
            catch (OperationErrorException operationErrorException)
            {
                throw operationErrorException;
            }
        }

        public async Task MoveStockToMainLocationAsync(ProductLocation data, int userId, bool applyDbChanges = false)
        {
            // Get the main location
            Location mainLocation = await AppServices.LocationService.GetMainAsync();

            // Only create the stock movement if it has stock and the fromLocation is not the main location.
            if ((data.Stock > 0) && (mainLocation.LocationId != data.LocationId))
            {
                // Create a stock movement between locations
                StockMovement stockMovement = new StockMovement()
                {
                    UserId = userId,
                    ProductId = data.ProductId,
                    FromLocationId = data.LocationId,
                    FromLocationName = data.Location.Name,
                    ToLocationId = mainLocation.LocationId,
                    ToLocationName = mainLocation.Name,
                    Qty = data.Stock,
                };

                await CreateAsync(stockMovement);

                // Get the relation between the product and the main location to be updated
                ProductLocation mainLocationRelation = await AppServices.ProductLocationService
                  .GetOneAsync(data.ProductId, mainLocation.LocationId);

                // Update the relation stock
                mainLocationRelation.Stock += data.Stock;

                await AppServices.NotificationService.ToggleStockAlertsAsync(mainLocationRelation, mainLocationRelation.Stock);

                if (applyDbChanges)
                {
                    await _repository.SaveChangesAsync();
                }
            }
        }

        public async Task RefillStockAsync(int locationId, int productId, float currentStock, float refilledQty, int userId)
        {
            try
            {
                // Get the product location relation
                ProductLocation productLocation = await AppServices.ProductLocationService.GetOneAsync(productId, locationId);

                // Only proceed if the user has make real changes to the qtys.
                if ((productLocation.Stock != currentStock) || (refilledQty != 0))
                {
                    // Get the main location
                    Location mainLocation = await AppServices.LocationService.GetMainAsync();

                    // check if the main location has enough stock that allow the qty to be accepted
                    if (refilledQty != 0)
                    {
                        ProductLocation mainPlocation = await AppServices.ProductLocationService
                            .GetOneAsync(productId, mainLocation.LocationId);

                        VerifyIfHasStockAvailableToMove(mainPlocation, refilledQty, "RefillQty");
                    }

                    // Calculate how much units has spend
                    float stockToRemove = productLocation.Stock - currentStock;

                    // We only create a exit movement if we have units to remove.
                    if (stockToRemove != 0)
                    {
                        // Get the current location
                        Location location = await AppServices.LocationService.GetByIdAsync(locationId);

                        // Remove the used stock from the given location
                        await CreateAsync(new StockMovement()
                        {
                            UserId = userId,
                            ProductId = productId,
                            FromLocationId = locationId,
                            FromLocationName = location.Name,
                            Qty = (stockToRemove * (-1)),
                        }, true);

                        // Update the stock in the location
                        productLocation.Stock -= stockToRemove;
                    }

                    // Move stock from the main location to the given location.
                    // Skip this if the qty is zero.
                    if (refilledQty != 0)
                    {
                        // The stock in the main location is already verified, soo at this point, 
                        // we know that the main location has enough stock to allow us to refill the given location.
                        // For that reason, we send the flag set as false to skip the stock verification.
                        await MoveStockBetweenLocationsAsync(mainLocation.LocationId, locationId, productId, refilledQty, userId, false);
                    }
                }
            }
            catch (OperationErrorException operationErrorException)
            {
                throw operationErrorException;
            }
        }

        private void VerifyIfHasStockAvailableToMove(ProductLocation plocation, float qty, string field = "qty")
        {
            OperationErrorsList errorsList = new OperationErrorsList();

            if (plocation.Stock < qty)
            {
                errorsList.AddError(field, Phrases.StockMovementErrorQty);
                throw new OperationErrorException(errorsList);
            }
        }
    }
}
