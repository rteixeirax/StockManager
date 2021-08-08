using System;
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
    public class NotificationService : INotificationService
    {
        private readonly IAppRepository _repository;

        public NotificationService(IAppRepository repository)
        {
            _repository = repository;
        }

        public async Task CreateAsync(int productLocationId, bool applyDbChanges = true)
        {
            await _repository.Notifications
                .AddAsync(new Notification() { ProductLocationId = productLocationId });

            if (applyDbChanges)
            {
                await _repository.SaveChangesAsync();
            }
        }

        public async Task ExportNotificationsToPDFAsync(IEnumerable<Notification> notifications)
        {
            try
            {
                PDFGenerator pdf = new PDFGenerator(Phrases.GlobalStockAlerts, Phrases.StockAlertsListOf);
                Section section = pdf.CreateDocumentSection();

                // Set title
                pdf.AddParagraph(Phrases.GlobalStockAlerts, true, false, 16);
                pdf.AddParagraph($"{Phrases.GlobalDate}: {DateTime.Now.ShortDate()}", false, true, null, 1);

                // Create table and table columns
                Table table = pdf.CreateTable();
                pdf.AddTableColumn(table, ParagraphAlignment.Left);
                pdf.AddTableColumn(table, ParagraphAlignment.Left);
                pdf.AddTableColumn(table, ParagraphAlignment.Left);
                pdf.AddTableColumn(table, ParagraphAlignment.Left);
                pdf.AddTableColumn(table, ParagraphAlignment.Right);
                pdf.AddTableColumn(table, ParagraphAlignment.Right);

                // Create table header
                Row row = pdf.CreateTableHeaderRow(table);
                pdf.AddTableRowCell(row, 0, ParagraphAlignment.Left, Phrases.GlobalDate, true);
                pdf.AddTableRowCell(row, 1, ParagraphAlignment.Left, Phrases.GlobalReference, true);
                pdf.AddTableRowCell(row, 2, ParagraphAlignment.Left, Phrases.GlobalProduct, true);
                pdf.AddTableRowCell(row, 3, ParagraphAlignment.Left, Phrases.GlobalLocation, true);
                pdf.AddTableRowCell(row, 4, ParagraphAlignment.Right, Phrases.StockMovementMinStock, true);
                pdf.AddTableRowCell(row, 5, ParagraphAlignment.Right, Phrases.StockMovementsStock, true);

                // Populate the table rows
                notifications.ToList().ForEach((notification) => {
                    row = table.AddRow();
                    pdf.AddTableRowCell(row, 0, ParagraphAlignment.Left, notification.CreatedAt.ShortDateWithTime());
                    pdf.AddTableRowCell(row, 1, ParagraphAlignment.Left, notification.ProductLocation.Product.Reference);
                    pdf.AddTableRowCell(row, 2, ParagraphAlignment.Left, notification.ProductLocation.Product.Name);
                    pdf.AddTableRowCell(row, 3, ParagraphAlignment.Left, notification.ProductLocation.Location.Name);
                    pdf.AddTableRowCell(row, 4, ParagraphAlignment.Right, notification.ProductLocation.Stock.ToString());
                    pdf.AddTableRowCell(row, 5, ParagraphAlignment.Right, notification.ProductLocation.MinStock.ToString());
                });

                // Add the table to the section
                pdf.AddTableToLastSection(table);

                // Rendering the document
                await pdf.GenerateAsync();
            }
            catch
            {
                OperationErrorsList errorsList = new OperationErrorsList();
                errorsList.AddError("export-notifications-error", Phrases.GlobalErrorOperationDB);
                throw new ServiceErrorException(errorsList);
            }
        }

        public async Task<IEnumerable<Notification>> GetAllAsync()
        {
            return await _repository.Notifications.GetAllWithProductLocationAsync();
        }

        public async Task<Notification> GetByIdAsync(int id)
        {
            return await _repository.Notifications.GetByIdAsync(id);
        }

        public async Task<Notification> GetByProductLocationIdAsync(int productLocationId)
        {
            return await _repository.Notifications
                .FindOneAsync(x => x.ProductLocationId == productLocationId);
        }

        public async Task RemoveAsync(int id)
        {
            Notification notification = await _repository.Notifications.GetByIdAsync(id);
            _repository.Notifications.Remove(notification);
            await _repository.SaveChangesAsync();
        }

        public async Task ToggleStockAlertsAsync(ProductLocation plocation, float newStock)
        {
            Notification notification = await GetByProductLocationIdAsync(plocation.ProductLocationId);

            // If there is a notification for that productLocationId
            // and the new acc stock is greater than the min stock, we remove the existing notification.
            if ((notification != null) && (newStock > plocation.MinStock))
            {
                await RemoveAsync(notification.NotificationId);
            }
            else if ((notification == null) && (newStock <= plocation.MinStock))
            {
                // If no notification but the new acc stock is less or equal than the min stock,
                // we need to create a new notification to alert the admin
                await CreateAsync(plocation.ProductLocationId);
            }
        }
    }
}
