using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Tables;

using StockManager.Src.Data.Entities;
using StockManager.Src.Data.Repositories;
using StockManager.Src.Extensions;
using StockManager.Src.Models;
using StockManager.Src.Tools;
using StockManager.Src.Translations;

namespace StockManager.Src.Services.Services
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

        public async Task ExportStockMovementsToPDFAsync(ExportData<IEnumerable<StockMovement>, StockMovementOptions> data)
        {
            try
            {
                IEnumerable<StockMovement> movements = data.Data;
                StockMovementOptions options = data?.Options;

                PDFGenerator pdf = new PDFGenerator(Phrases.StockMovementsLabel, Phrases.StockMovementsListOf);
                Section section = pdf.CreateDocumentSection();

                // Set title
                pdf.AddParagraph(Phrases.StockMovementsLabel, true, false, 16);

                if (options != null)
                {
                    string startDate = (options?.StartDate != default)
                        ? $"{options.StartDate.ShortDate()} - "
                        : "";

                    string endDate = (options?.EndDate != default)
                        ? options.EndDate.ShortDate()
                        : "";

                    pdf.AddParagraph($"{Phrases.GlobalDate}: {startDate}{endDate}", false, true);

                    if (!string.IsNullOrEmpty(options.SearchValue))
                    {
                        Product product = movements.ElementAt(0).Product;
                        pdf.AddParagraph($"{Phrases.GlobalProduct}: {product.Reference} {product.Name}", false, true);
                    }

                    if (options.LocationId != null)
                    {
                        Location location = await AppServices.LocationService.GetByIdAsync(( int )options.LocationId);
                        pdf.AddParagraph($"{Phrases.GlobalLocation}: {location.Name}", false, true);
                    }

                    if (options.UserId != null)
                    {
                        User user = await AppServices.UserService.GetByIdAsync(( int )options.UserId);
                        pdf.AddParagraph($"{Phrases.GlobalUser}: {user.Username}", false, true);
                    }

                    pdf.AddParagraph("", false, false, null, 1);
                }

                // Create table and table columns
                Table table = pdf.CreateTable();
                pdf.AddTableColumn(table, ParagraphAlignment.Left);
                pdf.AddTableColumn(table, ParagraphAlignment.Left);
                pdf.AddTableColumn(table, ParagraphAlignment.Left);
                pdf.AddTableColumn(table, ParagraphAlignment.Left);
                pdf.AddTableColumn(table, ParagraphAlignment.Left);
                pdf.AddTableColumn(table, ParagraphAlignment.Right);
                pdf.AddTableColumn(table, ParagraphAlignment.Right);

                // Create table header
                Row row = pdf.CreateTableHeaderRow(table);
                pdf.AddTableRowCell(row, 0, ParagraphAlignment.Left, Phrases.GlobalDate, true);
                pdf.AddTableRowCell(row, 1, ParagraphAlignment.Left, Phrases.GlobalUser, true);
                pdf.AddTableRowCell(row, 2, ParagraphAlignment.Left, Phrases.GlobalReference, true);
                pdf.AddTableRowCell(row, 3, ParagraphAlignment.Left, Phrases.GlobalName, true);
                pdf.AddTableRowCell(row, 4, ParagraphAlignment.Left, Phrases.GlobalMovement, true);
                pdf.AddTableRowCell(row, 5, ParagraphAlignment.Right, Phrases.StockMovementQty, true);
                pdf.AddTableRowCell(row, 6, ParagraphAlignment.Right, Phrases.StockMovementStockAcc, true);

                // Populate the table rows
                movements.ToList().ForEach((movement) => {
                    row = table.AddRow();
                    pdf.AddTableRowCell(row, 0, ParagraphAlignment.Left, movement.CreatedAt.ShortDateWithTime());
                    pdf.AddTableRowCell(row, 1, ParagraphAlignment.Left, movement.User.Username);
                    pdf.AddTableRowCell(row, 2, ParagraphAlignment.Left, movement.Product.Reference);
                    pdf.AddTableRowCell(row, 3, ParagraphAlignment.Left, movement.Product.Name);
                    pdf.AddTableRowCell(row, 4, ParagraphAlignment.Left, movement.ConcatMovementString());
                    pdf.AddTableRowCell(row, 5, ParagraphAlignment.Right, movement.Qty.ToString());
                    pdf.AddTableRowCell(row, 6, ParagraphAlignment.Right, movement.Stock.ToString());
                });

                // Add the table to the section
                pdf.AddTableToLastSection(table);

                // Rendering the document
                await pdf.GenerateAsync();
            }
            catch
            {
                OperationErrorsList errorsList = new OperationErrorsList();
                errorsList.AddError("export-stock-movements-error", Phrases.GlobalErrorOperationDB);
                throw new ServiceErrorException(errorsList);
            }
        }

        public async Task<IEnumerable<StockMovement>> GetAllAsync(StockMovementOptions options = null)
        {
            return options != null
                ? await _repository.StockMovements.FindAllOrderedByDescendingWithProductAndUserAsync(options)
                : await _repository.StockMovements.FindAllOrderedByDescendingWithProductAndUserAsync();
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
