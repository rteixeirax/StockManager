using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Tables;
using MigraDoc.Rendering;

using StockManager.Core.Source;
using StockManager.Core.Source.Models;
using StockManager.Core.Source.Types;
using StockManager.Translations.Source;

namespace StockManager.Services.Source.Tools
{
    public class PDFGenerator
    {
        private readonly Document _document;

        public PDFGenerator(string documentTitle, string documentSubject = "")
        {
            _document = new Document();
            _document.Info.Title = documentTitle;
            _document.Info.Subject = documentSubject;
            _document.Info.Author = $"{AppInfo.Title} {AppInfo.Version}";

            _document.DefaultPageSetup.PageFormat = PageFormat.A4;
            _document.DefaultPageSetup.Orientation = Orientation.Portrait;
            _document.DefaultPageSetup.LeftMargin = Unit.FromCentimeter(2);
            _document.DefaultPageSetup.RightMargin = Unit.FromCentimeter(2);
            _document.DefaultPageSetup.TopMargin = Unit.FromCentimeter(2);
            _document.DefaultPageSetup.BottomMargin = Unit.FromCentimeter(2);
            // http://www.pdfsharp.net/wiki/MigraDoc_PageSetup.ashx?HL=oddandevenpagesheaderfooter
            _document.DefaultPageSetup.OddAndEvenPagesHeaderFooter = true;
            _document.DefaultPageSetup.StartingNumber = 1;

            Style style = _document.Styles.Normal;
            style.Font.Name = "Arial";
            style.Font.Size = 8;
        }

        public Section CreateDocumentSection()
        {
            Section section = _document.AddSection();

            // Set section footer
            Paragraph paragraph = new Paragraph();
            paragraph.Format.Font.Size = 6;
            paragraph.Format.Alignment = ParagraphAlignment.Right;
            paragraph.Format.Font.Italic = false;
            paragraph.Format.Font.Color = Colors.DarkGray;
            paragraph.AddText($"Powered by {AppInfo.Title} {AppInfo.Version}");
            paragraph.AddSpace(3);
            paragraph.AddText("|");
            paragraph.AddSpace(3);
            paragraph.AddText(Phrases.GlobalPage);
            paragraph.AddSpace(1);
            paragraph.AddPageField();
            paragraph.AddSpace(1);
            paragraph.AddText(Phrases.GlobalOf);
            paragraph.AddSpace(1);
            paragraph.AddNumPagesField();

            section.Footers.Primary.Add(paragraph);
            section.Footers.EvenPage.Add(paragraph.Clone());

            return section;
        }

        public Table CreateTable()
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

        public Row CreateTableHeaderRow(Table table)
        {
            Row row = table.AddRow();
            row.HeadingFormat = true;

            return row;
        }

        public void AddTableColumn(Table table, ParagraphAlignment alignment)
        {
            Column column = table.AddColumn();
            column.Format.Alignment = alignment;
        }

        public void AddTableRowCell(Row row, int index, ParagraphAlignment alignment, string text, bool bold = false)
        {
            row.Cells[index].AddParagraph(text);
            row.Cells[index].Format.Font.Bold = bold;
            row.Cells[index].Format.Alignment = alignment;
            row.Cells[index].VerticalAlignment = VerticalAlignment.Center;
        }

        public void AddTableToLastSection(Table table)
        {
            _document.LastSection.Add(table);
        }

        public void AddParagraph(string text, bool bold = false, bool caption = false, float? fontSize = null, float? spaceAfter = null)
        {
            Paragraph paragraph = new Paragraph();
            paragraph.AddText(text);
            paragraph.Format.Font.Size = fontSize ?? _document.Styles.Normal.Font.Size;
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

            _document.LastSection.Add(paragraph);
        }

        public async Task Generate()
        {
            // Rendering the document
            PdfDocumentRenderer documentRenderer = new PdfDocumentRenderer(false)
            {
                Document = _document
            };

            // Render document
            documentRenderer.RenderDocument();

            AppSettings appSettings = await AppServices.AppSettingsService.GetAppSettingsAsync();
            DocumentsFolder folder = AppConstants.DocumentsFolders.FirstOrDefault(x => x.Code == appSettings.DocumentsFolder);

            string dateTimeNow = Regex.Replace(DateTime.Now.ToString(), @"\s+", "_").Replace("/", "_").Replace(":", "").ToString();
            string pdfFile = $"{Regex.Replace(_document.Info.Title, @"\s+", "_")}_{dateTimeNow}.pdf";

            if (folder.CreateFolder && !Directory.Exists(folder.Path))
            {
                Directory.CreateDirectory(folder.Path);
            }

            string filePath = $@"{folder.Path}\{pdfFile}";

            // Save file
            documentRenderer.PdfDocument.Save(filePath);

            // Show the pdf
            Process.Start(filePath);
        }
    }
}
