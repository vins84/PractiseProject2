using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Tables;

namespace PdfSharpMigraDoc
{
    public class Label
    {
        public Document CreateDocument()
        {
            // Create a new MigraDoc document
            Document document = new Document();
            document.Info.Title = "Hello, MigraDoc";
            document.Info.Subject = "Demonstrates an excerpt of the capabilities of MigraDoc.";
            document.Info.Author = "Stefan Lange";

            //DefineStyles(document);
            Style style = document.Styles["Normal"];
            style.Font.Name = "Times New Roman";
            style.Font.Bold = true;


            Section section = document.AddSection();
            section.PageSetup = document.DefaultPageSetup.Clone();
            section.PageSetup.PageHeight = Unit.FromMillimeter(30);
            section.PageSetup.PageWidth = Unit.FromMillimeter(50);

            section.PageSetup.TopMargin = Unit.FromMillimeter(1);
            section.PageSetup.RightMargin = Unit.FromMillimeter(1);
            section.PageSetup.LeftMargin = Unit.FromMillimeter(2);
            section.PageSetup.BottomMargin = Unit.FromMillimeter(1);


            //DefineTables(document);
            DemonstrateSimpleTable(document);
            //DefineCharts(document);

            return document;
        }

        public static void DefineStyles(Document document)
        {
            // Get the predefined style Normal.
            Style style = document.Styles["Normal"];
            style.Font.Name = "Times New Roman";


            style = document.Styles["Heading1"];
            style.Font.Name = "Tahoma";
            style.Font.Size = 8;
            style.Font.Bold = true;
            style.Font.Color = Colors.BlueViolet;
            style.ParagraphFormat.PageBreakBefore = true;
            style.ParagraphFormat.SpaceAfter = 6;

        }

        public static void DemonstrateSimpleTable(Document document)
        {
            Table table = new Table();
            table.Borders.Width = 0.15;

            Column column = table.AddColumn(Unit.FromMillimeter(45));
            //column.Format.Alignment = ParagraphAlignment.Center;

            Row row = table.AddRow();
            row.Height = (Unit.FromMillimeter(8));
            //row.Shading.Color = Colors.PaleGoldenrod;
            Cell cell = row.Cells[0];
            cell.AddParagraph("Item No: ABC123456");
            row.Format.Alignment = ParagraphAlignment.Center;
            row.Cells[0].VerticalAlignment = VerticalAlignment.Center;

            row = table.AddRow();
            row.Height = (Unit.FromMillimeter(8));
            cell = row.Cells[0];
            cell.AddParagraph("PVO: 987654");
            row.Format.Alignment = ParagraphAlignment.Center;
            row.Cells[0].VerticalAlignment = VerticalAlignment.Center;

            row = table.AddRow();
            row.Height = (Unit.FromMillimeter(10));
            cell = row.Cells[0];
            cell.AddParagraph("||||||||||||||||||||||||||||||||||");
            row.Format.Alignment = ParagraphAlignment.Center;
            row.Cells[0].VerticalAlignment = VerticalAlignment.Center;

            table.SetEdge(0, 0, 1, 3, Edge.Box, BorderStyle.Single, 1.5, Colors.Black);

            document.LastSection.Add(table);
        }

    }
}
