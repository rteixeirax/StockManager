using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Tables;
using MigraDoc.Rendering;

using StockManager.Core.Source;
using StockManager.Core.Source.Extensions;
using StockManager.Core.Source.Models;
using StockManager.Core.Source.Services;
using StockManager.Core.Source.Types;
using StockManager.Translations.Source;

namespace StockManager.Services.Source.Services
{
    public class PdfService : IPdfService
    {
        private readonly IAppRepository _repository;

        public PdfService(IAppRepository repository)
        {
            _repository = repository;
        }

        public void ExportStockMovementsToPdfAsync(ExportData<IEnumerable<StockMovement>, StockMovementOptions> data)
        {
            try
            {
                IEnumerable<StockMovement> movements = data.Data;
                StockMovementOptions options = data?.Options;

                Document document = CreateDocument();
                Section section = document.AddSection();
                SetSectionFooter(section);

                // Set title
                AddParagraph(document, "Stock movements", true, false, 16); // TODO: Translations

                if (options != null) // TODO: Verify if the dates are sent
                {
                    AddParagraph(document, $"{options.StartDate.ShortDate()} - {options.EndDate.ShortDate()}", false, true, null, 1);
                }

                // TODO: if options.locationId, add the location name
                // TODO: if options.userId, add the user name

                // Create table and table columns
                Table table = CreateTable();
                AddTableColumn(table, ParagraphAlignment.Left);
                AddTableColumn(table, ParagraphAlignment.Left);
                AddTableColumn(table, ParagraphAlignment.Left);
                AddTableColumn(table, ParagraphAlignment.Left);
                AddTableColumn(table, ParagraphAlignment.Center);
                AddTableColumn(table, ParagraphAlignment.Center);
                AddTableColumn(table, ParagraphAlignment.Left);

                // Create table header
                Row row = CreateTableHeaderRow(table);
                AddTableRowCell(row, 0, ParagraphAlignment.Left, "Date", true); // TODO: add translations
                AddTableRowCell(row, 1, ParagraphAlignment.Left, "Reference", true);
                AddTableRowCell(row, 2, ParagraphAlignment.Left, "Name", true);
                AddTableRowCell(row, 3, ParagraphAlignment.Left, "Movement", true);
                AddTableRowCell(row, 4, ParagraphAlignment.Center, "Qty", true);
                AddTableRowCell(row, 5, ParagraphAlignment.Center, "Stock acc.", true);
                AddTableRowCell(row, 6, ParagraphAlignment.Left, "User", true);

                // Populate the table rows
                movements.ToList().ForEach((movement) => {
                    row = table.AddRow();
                    AddTableRowCell(row, 0, ParagraphAlignment.Left, movement.CreatedAt.ShortDateWithTime());
                    AddTableRowCell(row, 1, ParagraphAlignment.Left, movement.Product.Reference);
                    AddTableRowCell(row, 2, ParagraphAlignment.Left, movement.Product.Name);
                    AddTableRowCell(row, 3, ParagraphAlignment.Left, movement.ConcatMovementString());
                    AddTableRowCell(row, 4, ParagraphAlignment.Center, movement.Qty.ToString());
                    AddTableRowCell(row, 5, ParagraphAlignment.Center, movement.Stock.ToString());
                    AddTableRowCell(row, 6, ParagraphAlignment.Left, movement.User.Username);
                });

                // Add the table to the document
                document.LastSection.Add(table);

                // Rendering the document
                RenderAndShowPdf(document);
            }
            catch
            {
                OperationErrorsList errorsList = new OperationErrorsList();
                errorsList.AddError("export-stock-movements-error", Phrases.GlobalErrorOperationDB);

                throw new ServiceErrorException(errorsList);
            }
        }

        private Document CreateDocument()
        {
            Document document = new Document();
            document.DefaultPageSetup.PageFormat = PageFormat.A4;
            document.DefaultPageSetup.Orientation = Orientation.Portrait;
            document.DefaultPageSetup.LeftMargin = Unit.FromCentimeter(2);
            document.DefaultPageSetup.RightMargin = Unit.FromCentimeter(2);
            document.DefaultPageSetup.TopMargin = Unit.FromCentimeter(2);
            document.DefaultPageSetup.BottomMargin = Unit.FromCentimeter(2);
            // http://www.pdfsharp.net/wiki/MigraDoc_PageSetup.ashx?HL=oddandevenpagesheaderfooter
            document.DefaultPageSetup.OddAndEvenPagesHeaderFooter = true;
            document.DefaultPageSetup.StartingNumber = 1;

            Style style = document.Styles.Normal;
            style.Font.Name = "Arial";
            style.Font.Size = 8;

            return document;
        }

        private void SetSectionFooter(Section section)
        {
            // Footer
            Paragraph paragraph = new Paragraph();
            paragraph.Format.Font.Size = 6;
            paragraph.Format.Alignment = ParagraphAlignment.Right;
            paragraph.Format.Font.Italic = false;
            paragraph.Format.Font.Color = Colors.DarkGray;
            paragraph.AddText("Stock manager v.0.0.1"); // TODO: get from AppInfo and add more text
            paragraph.AddTab();
            paragraph.AddText("|");
            paragraph.AddSpace(3);
            paragraph.AddText("Page"); // TODO: add phrase
            paragraph.AddSpace(1);
            paragraph.AddPageField();
            paragraph.AddSpace(1);
            paragraph.AddText("of"); // TODO: add phrase
            paragraph.AddSpace(1);
            paragraph.AddNumPagesField();

            section.Footers.Primary.Add(paragraph);
            section.Footers.EvenPage.Add(paragraph.Clone());
        }

        private Table CreateTable()
        {
            Table table = new Table
            {
                TopPadding = 2,
                BottomPadding = 2,
            };

            table.Rows.Alignment = RowAlignment.Left;
            table.Borders.Bottom.Color = Colors.LightGray;
            table.Borders.Bottom.Width = 0.5;

            return table;
        }

        private Row CreateTableHeaderRow(Table table)
        {
            Row row = table.AddRow();
            row.HeadingFormat = true;

            return row;
        }

        private void AddTableColumn(Table table, ParagraphAlignment alignment)
        {
            Column column = table.AddColumn();
            column.Format.Alignment = alignment;
        }

        private void AddTableRowCell(Row row, int index, ParagraphAlignment alignment, string text, bool bold = false)
        {
            row.Cells[index].AddParagraph(text);
            row.Cells[index].Format.Font.Bold = bold;
            row.Cells[index].Format.Alignment = alignment;
            row.Cells[index].VerticalAlignment = VerticalAlignment.Center;
        }

        private void AddParagraph(Document document, string text, bool bold = false, bool caption = false, float? fontSize = null, float? spaceAfter = null)
        {
            Paragraph paragraph = new Paragraph();
            paragraph.AddText(text);
            paragraph.Format.Font.Size = fontSize ?? document.Styles.Normal.Font.Size;
            paragraph.Format.Font.Bold = bold;
            paragraph.Format.Alignment = ParagraphAlignment.Left;

            if (caption)
            {
                paragraph.Format.Font.Color = Colors.DimGray;
                paragraph.Format.Font.Size = 6;
            }

            if (spaceAfter != null)
            {
                paragraph.Format.SpaceAfter = Unit.FromCentimeter(( double )spaceAfter);
            }

            document.LastSection.Add(paragraph);
        }

        private void RenderAndShowPdf(Document document)
        {
            // Rendering the document
            PdfDocumentRenderer documentRenderer = new PdfDocumentRenderer(false) { Document = document };
            documentRenderer.RenderDocument();

            // Open file
            string filename = $"StockMovements_{DateTime.Now.FileNameDateTime()}.pdf"; // TODO: Change this (translate the stock movements)
            documentRenderer.PdfDocument.Save(filename);

            // Show the pdf
            Process.Start(filename);
        }
    }
}
