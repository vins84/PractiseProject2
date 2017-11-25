using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Tables;
using System;
using System.Data;


namespace PdfSharpMigraDoc
{
    public class MyDataTable
    {

        public Document CreateDocument()
        {
            // Create a new MigraDoc document
            Document document = new Document();
            document.Info.Title = "";
            document.Info.Subject = "";
            document.Info.Author = "Aftab";

            DefineStyles(document);
            CreatePage(document);
            //FillContent(document);
            return document;
        }

        void DefineStyles(Document document)
        {
            // Get the predefined style Normal.
            Style style = document.Styles["Normal"];
            // Because all styles are derived from Normal, the next line changes the 
            // font of the whole document. Or, more exactly, it changes the font of
            // all styles and paragraphs that do not redefine the font.
            style.Font.Name = "Verdana";

            style = document.Styles[StyleNames.Header];
            style.ParagraphFormat.AddTabStop("16cm", TabAlignment.Right);

            style = document.Styles[StyleNames.Footer];
            style.ParagraphFormat.AddTabStop("8cm", TabAlignment.Center);

            // Create a new style called Table based on style Normal
            style = document.Styles.AddStyle("Table", "Normal");
            style.Font.Name = "Verdana";
            style.Font.Name = "Times New Roman";
            style.Font.Size = 9;

            // Create a new style called Reference based on style Normal
            style = document.Styles.AddStyle("Reference", "Normal");
            style.ParagraphFormat.SpaceBefore = "5mm";
            style.ParagraphFormat.SpaceAfter = "5mm";
            style.ParagraphFormat.TabStops.AddTabStop("16cm", TabAlignment.Right);
        }


        void CreatePage(Document document)
        {
            // Each MigraDoc document needs at least one section.
            Section section = document.AddSection();

            // Put a logo in the header
            //Image image = section.AddImage(path);
            //image.Top = ShapePosition.Top;
            //image.Left = ShapePosition.Left;
            //image.WrapFormat.Style = WrapStyle.Through;

            // Create footer
            Paragraph paragraph = section.Footers.Primary.AddParagraph();
            paragraph.AddText("Health And Social Services.");
            paragraph.Format.Font.Size = 9;
            paragraph.Format.Alignment = ParagraphAlignment.Center;

            Table table = new Table();
            // Create the item table
            table = section.AddTable();
            table.Style = "Table";
            table.Borders.Width = 0.25;
            table.Borders.Left.Width = 0.5;
            table.Borders.Right.Width = 0.5;
            table.Rows.LeftIndent = 0;

            DataTable dt = new DataTable();
            dt.Columns.Add("Dosage", typeof(int));
            dt.Columns.Add("Drug", typeof(string));
            dt.Columns.Add("Patient", typeof(string));
            dt.Columns.Add("Date", typeof(DateTime));
            
            //dtre we add five DataRows.
            dt.Rows.Add(25, "Indocin", "David", DateTime.Now);
            dt.Rows.Add(50, "Enebrel", "Sam", DateTime.Now);
            dt.Rows.Add(10, "Hydralazine", "Christoff", DateTime.Now);
            dt.Rows.Add(21, "Combivent", "Janet", DateTime.Now);
            dt.Rows.Add(100, "Dilantin", "Melanie", DateTime.Now);

            // Before you can add a row, you must define the columns
            Column column;
            foreach (DataColumn col in dt.Columns)
            {
                column = table.AddColumn(Unit.FromCentimeter(3));
                column.Format.Alignment = ParagraphAlignment.Center;
            }

            // Create the header of the table
            Row row = table.AddRow();
            row.HeadingFormat = true;
            row.Format.Alignment = ParagraphAlignment.Center;
            row.Format.Font.Bold = true;

            for (int i = 0; i < dt.Columns.Count; i++)
            {
                row.Cells[i].AddParagraph(dt.Columns[i].ColumnName);
                row.Cells[i].Format.Font.Bold = false;
                row.Cells[i].Format.Alignment = ParagraphAlignment.Left;
                row.Cells[i].VerticalAlignment = VerticalAlignment.Bottom;
            }

            table.SetEdge(0, 0, dt.Columns.Count, 1, Edge.Box,
                 BorderStyle.Single, 0.75, Color.Empty);
            FillContent(dt, table);

        }

        void FillContent(DataTable dt, Table table)
        {
            Row row1;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                row1 = table.AddRow();
                row1.TopPadding = 1.5;

                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    //row1.Cells[j].Shading.Color = TableGray;
                    row1.Cells[j].VerticalAlignment = VerticalAlignment.Center;

                    row1.Cells[j].Format.Alignment = ParagraphAlignment.Left;
                    row1.Cells[j].Format.FirstLineIndent = 1;
                    row1.Cells[j].AddParagraph(dt.Rows[i][j].ToString());

                    table.SetEdge(0, table.Rows.Count - 2, dt.Columns.Count, 1,
                         Edge.Box, BorderStyle.Single, 0.75);
                }
            }

        }
    }
}
