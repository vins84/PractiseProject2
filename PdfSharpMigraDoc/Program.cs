using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Shapes.Charts;
using MigraDoc.DocumentObjectModel.Tables;
using MigraDoc.Rendering;
using System.Diagnostics;

namespace PdfSharpMigraDoc
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Ticket
            Ticket ticket = new Ticket();
            Document document = ticket.CreateDocument();
            PdfDocumentRenderer renderer = new PdfDocumentRenderer(true, PdfSharp.Pdf.PdfFontEmbedding.Always);
            renderer.Document = document;
            renderer.RenderDocument();
            string filename = "TicketTest.pdf";
            renderer.PdfDocument.Save(filename);
            Process.Start(filename);
            #endregion

            #region Label
                Label label = new Label();
                Document labelDoc = label.CreateDocument();

                ////string ddl = MigraDoc.DocumentObjectModel.IO.DdlWriter.WriteToString(document);
                //MigraDoc.DocumentObjectModel.IO.DdlWriter.WriteToFile(document, "MigraDoc.mdddl");

                PdfDocumentRenderer rendererLabel = new PdfDocumentRenderer(true, PdfSharp.Pdf.PdfFontEmbedding.Always);
                rendererLabel.Document = labelDoc;
                rendererLabel.RenderDocument();

                // Save the document...
                string labelFilename = "LabelTest.pdf";
                rendererLabel.PdfDocument.Save(labelFilename);
                // ...and start a viewer.
                Process.Start(labelFilename);
            #endregion

            #region DAtaTAbleTEstin
                MyDataTable myDataTable = new MyDataTable();
                Document documentTable = myDataTable.CreateDocument();
                documentTable.UseCmykColor = true;

                PdfDocumentRenderer pdfRendererDt = new PdfDocumentRenderer(true);
                pdfRendererDt.Document = documentTable;
                pdfRendererDt.RenderDocument();
                string dataTableFilename = "DataTableTest.pdf";
                pdfRendererDt.Save(dataTableFilename);
                Process.Start(dataTableFilename);
            #endregion


            #region Old
            //// Create a MigraDoc document
            //Document document = CreateDocument();
            //document.UseCmykColor = true;

            //// ===== Unicode encoding and font program embedding in MigraDoc is demonstrated here =====

            //// A flag indicating whether to create a Unicode PDF or a WinAnsi PDF file.
            //// This setting applies to all fonts used in the PDF document.
            //// This setting has no effect on the RTF renderer.
            //const bool unicode = false;

            //// An enum indicating whether to embed fonts or not.
            //// This setting applies to all font programs used in the document.
            //// This setting has no effect on the RTF renderer.
            //// (The term 'font program' is used by Adobe for a file containing a font. Technically a 'font file'
            //// is a collection of small programs and each program renders the glyph of a character when executed.
            //// Using a font in PDFsharp may lead to the embedding of one or more font programms, because each outline
            //// (regular, bold, italic, bold+italic, ...) has its own fontprogram)
            //const PdfFontEmbedding embedding = PdfFontEmbedding.Always;

            //// ========================================================================================

            //// Create a renderer for the MigraDoc document.
            //PdfDocumentRenderer pdfRenderer = new PdfDocumentRenderer(unicode, embedding);

            //// Associate the MigraDoc document with a renderer
            //pdfRenderer.Document = document;

            //// Layout and render document to PDF
            //pdfRenderer.RenderDocument();

            //// Save the document...
            //const string filename = "HelloWorld.pdf";
            //pdfRenderer.PdfDocument.Save(filename);
            //// ...and start a viewer.
            //Process.Start(filename);
            #endregion
            Document testDocument = CreateDocument();

            ////string ddl = MigraDoc.DocumentObjectModel.IO.DdlWriter.WriteToString(document);
            //MigraDoc.DocumentObjectModel.IO.DdlWriter.WriteToFile(document, "MigraDoc.mdddl");

            PdfDocumentRenderer rendererTest = new PdfDocumentRenderer(true, PdfSharp.Pdf.PdfFontEmbedding.Always);
            rendererLabel.Document = testDocument;
            rendererLabel.RenderDocument();

            //string testFilename = "LabelTest.pdf";
            //rendererLabel.PdfDocument.Save(testFilename);
            //Process.Start(testFilename);


        }

        public static Document CreateDocument()
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

            //DefineCover(document);
            //DefineTableOfContents(document);
            //DefineContentSection(document);
            //DefineParagraphs(document);

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
            // Because all styles are derived from Normal, the next line changes the 
            // font of the whole document. Or, more exactly, it changes the font of
            // all styles and paragraphs that do not redefine the font.
            style.Font.Name = "Times New Roman";

            // Heading1 to Heading9 are predefined styles with an outline level. An outline level
            // other than OutlineLevel.BodyText automatically creates the outline (or bookmarks) 
            // in PDF.

            style = document.Styles["Heading1"];
            style.Font.Name = "Tahoma";
            style.Font.Size = 8;
            style.Font.Bold = true;
            style.Font.Color = Colors.BlueViolet;
            style.ParagraphFormat.PageBreakBefore = true;
            style.ParagraphFormat.SpaceAfter = 6;

            //style = document.Styles[StyleNames.Header];
            //style.ParagraphFormat.AddTabStop("16cm", TabAlignment.Right);

            //style = document.Styles[StyleNames.Footer];
            //style.ParagraphFormat.AddTabStop("8cm", TabAlignment.Center);

            //// Create a new style called TextBox based on style Normal
            //style = document.Styles.AddStyle("TextBox", "Normal");
            //style.ParagraphFormat.Alignment = ParagraphAlignment.Justify;
            //style.ParagraphFormat.Borders.Width = 2.5;
            //style.ParagraphFormat.Borders.Distance = "3pt";
            //style.ParagraphFormat.Shading.Color = Colors.SkyBlue;

            //// Create a new style called TOC based on style Normal
            //style = document.Styles.AddStyle("TOC", "Normal");
            //style.ParagraphFormat.AddTabStop("16cm", TabAlignment.Right, TabLeader.Dots);
            //style.ParagraphFormat.Font.Color = Colors.Blue;
        }
        public static void DefineCover(Document document)
        {
            Section section = document.AddSection();

            Paragraph paragraph = section.AddParagraph();
            paragraph.Format.SpaceAfter = "3cm";

            //Image image = section.AddImage("../../images/Logo landscape.png");
            //image.Width = "10cm";

            paragraph = section.AddParagraph("A sample document that demonstrates the\ncapabilities of MigraDoc");
            paragraph.Format.Font.Size = 16;
            paragraph.Format.Font.Color = Colors.DarkRed;
            paragraph.Format.SpaceBefore = "8cm";
            paragraph.Format.SpaceAfter = "3cm";

            paragraph = section.AddParagraph("Rendering date: ");
            paragraph.AddDateField();
        }
        public static void DefineTableOfContents(Document document)
        {
            Section section = document.LastSection;

            section.AddPageBreak();
            Paragraph paragraph = section.AddParagraph("Table of Contents");
            paragraph.Format.Font.Size = 14;
            paragraph.Format.Font.Bold = true;
            paragraph.Format.SpaceAfter = 24;
            paragraph.Format.OutlineLevel = OutlineLevel.Level1;

            paragraph = section.AddParagraph();
            paragraph.Style = "TOC";
            Hyperlink hyperlink = paragraph.AddHyperlink("Paragraphs");
            hyperlink.AddText("Paragraphs\t");
            hyperlink.AddPageRefField("Paragraphs");

            paragraph = section.AddParagraph();
            paragraph.Style = "TOC";
            hyperlink = paragraph.AddHyperlink("Tables");
            hyperlink.AddText("Tables\t");
            hyperlink.AddPageRefField("Tables");

            paragraph = section.AddParagraph();
            paragraph.Style = "TOC";
            hyperlink = paragraph.AddHyperlink("Charts");
            hyperlink.AddText("Charts\t");
            hyperlink.AddPageRefField("Charts");
        }
        static void DefineContentSection(Document document)
        {
            Section section = document.AddSection();
            section.PageSetup.OddAndEvenPagesHeaderFooter = true;
            section.PageSetup.StartingNumber = 1;

            HeaderFooter header = section.Headers.Primary;
            header.AddParagraph("\tOdd Page Header");

            header = section.Headers.EvenPage;
            header.AddParagraph("Even Page Header");

            // Create a paragraph with centered page number. See definition of style "Footer".
            Paragraph paragraph = new Paragraph();
            paragraph.AddTab();
            paragraph.AddPageField();

            // Add paragraph to footer for odd pages.
            section.Footers.Primary.Add(paragraph);
            // Add clone of paragraph to footer for odd pages. Cloning is necessary because an object must
            // not belong to more than one other object. If you forget cloning an exception is thrown.
            section.Footers.EvenPage.Add(paragraph.Clone());
        }

        public static void DefineParagraphs(Document document)
        {
            Paragraph paragraph = document.LastSection.AddParagraph("Paragraph Layout Overview", "Heading1");
            paragraph.AddBookmark("Paragraphs");

            DemonstrateAlignment(document);
            DemonstrateIndent(document);
            DemonstrateFormattedText(document);
            DemonstrateBordersAndShading(document);
        }

        static void DemonstrateAlignment(Document document)
        {
            document.LastSection.AddParagraph("Alignment", "Heading2");

            document.LastSection.AddParagraph("Left Aligned", "Heading3");

            Paragraph paragraph = document.LastSection.AddParagraph();
            paragraph.Format.Alignment = ParagraphAlignment.Left;
            paragraph.AddText("Miroslaw");

            document.LastSection.AddParagraph("Right Aligned", "Heading3");

            paragraph = document.LastSection.AddParagraph();
            paragraph.Format.Alignment = ParagraphAlignment.Right;
            paragraph.AddText("Miroslaw");

            document.LastSection.AddParagraph("Centered", "Heading3");

            paragraph = document.LastSection.AddParagraph();
            paragraph.Format.Alignment = ParagraphAlignment.Center;
            paragraph.AddText("Miroslaw");

            document.LastSection.AddParagraph("Justified", "Heading3");

            paragraph = document.LastSection.AddParagraph();
            paragraph.Format.Alignment = ParagraphAlignment.Justify;
            paragraph.AddText("Miroslaw");
        }

        static void DemonstrateIndent(Document document)
        {
            document.LastSection.AddParagraph("Indent", "Heading2");

            document.LastSection.AddParagraph("Left Indent", "Heading3");

            Paragraph paragraph = document.LastSection.AddParagraph();
            paragraph.Format.LeftIndent = "2cm";
            paragraph.AddText("Miroslaw");

            document.LastSection.AddParagraph("Right Indent", "Heading3");

            paragraph = document.LastSection.AddParagraph();
            paragraph.Format.RightIndent = "1in";
            paragraph.AddText("Miroslaw");

            document.LastSection.AddParagraph("First Line Indent", "Heading3");

            paragraph = document.LastSection.AddParagraph();
            paragraph.Format.FirstLineIndent = "12mm";
            paragraph.AddText("Miroslaw");

            document.LastSection.AddParagraph("First Line Negative Indent", "Heading3");

            paragraph = document.LastSection.AddParagraph();
            paragraph.Format.LeftIndent = "1.5cm";
            paragraph.Format.FirstLineIndent = "-1.5cm";
            paragraph.AddText("Miroslaw");
        }

        static void DemonstrateFormattedText(Document document)
        {
            document.LastSection.AddParagraph("Formatted Text", "Heading2");

            //document.LastSection.AddParagraph("Left Aligned", "Heading3");

            Paragraph paragraph = document.LastSection.AddParagraph();
            paragraph.AddText("Text can be formatted ");
            paragraph.AddFormattedText("bold", TextFormat.Bold);
            paragraph.AddText(", ");
            paragraph.AddFormattedText("italic", TextFormat.Italic);
            paragraph.AddText(", or ");
            paragraph.AddFormattedText("bold & italic", TextFormat.Bold | TextFormat.Italic);
            paragraph.AddText(".");
            paragraph.AddLineBreak();
            paragraph.AddText("You can set the ");
            FormattedText formattedText = paragraph.AddFormattedText("size ");
            formattedText.Size = 15;
            paragraph.AddText("the ");
            formattedText = paragraph.AddFormattedText("color ");
            formattedText.Color = Colors.Firebrick;
            paragraph.AddText("the ");
            formattedText = paragraph.AddFormattedText("font", new Font("Verdana"));
            paragraph.AddText(".");
            paragraph.AddLineBreak();
            paragraph.AddText("You can set the ");
            formattedText = paragraph.AddFormattedText("subscript");
            formattedText.Subscript = true;
            paragraph.AddText(" or ");
            formattedText = paragraph.AddFormattedText("superscript");
            formattedText.Superscript = true;
            paragraph.AddText(".");
        }

        static void DemonstrateBordersAndShading(Document document)
        {
            document.LastSection.AddPageBreak();
            document.LastSection.AddParagraph("Borders and Shading", "Heading2");

            document.LastSection.AddParagraph("Border around Paragraph", "Heading3");

            Paragraph paragraph = document.LastSection.AddParagraph();
            paragraph.Format.Borders.Width = 2.5;
            paragraph.Format.Borders.Color = Colors.Navy;
            paragraph.Format.Borders.Distance = 3;
            paragraph.AddText("Miroslaw");

            document.LastSection.AddParagraph("Shading", "Heading3");

            paragraph = document.LastSection.AddParagraph();
            paragraph.Format.Shading.Color = Colors.LightCoral;
            paragraph.AddText("Miroslaw");

            document.LastSection.AddParagraph("Borders & Shading", "Heading3");

            paragraph = document.LastSection.AddParagraph();
            paragraph.Style = "TextBox";
            paragraph.AddText("Miroslaw");
        }

        public static void DefineTables(Document document)
        {
            Paragraph paragraph = document.LastSection.AddParagraph("Table Overview", "Heading1");
            paragraph.AddBookmark("Tables");

            DemonstrateSimpleTable(document);
            DemonstrateAlignment(document);
            DemonstrateCellMerge(document);
        }

        public static void DemonstrateSimpleTable(Document document)
        {
            //document.LastSection.AddParagraph("This is my label", "Heading2");


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

            //row = table.AddRow();
            //row.Height = (Unit.FromMillimeter(10));
            //cell = row.Cells[0];
            //cell.AddParagraph("Pick Qty");
            //cell = row.Cells[1];
            //cell.AddParagraph("999");
            //row.Format.Alignment = ParagraphAlignment.Center;
            //row.Cells[0].VerticalAlignment = VerticalAlignment.Center;
            //row.Cells[1].VerticalAlignment = VerticalAlignment.Center;

            table.SetEdge(0, 0, 1, 3, Edge.Box, BorderStyle.Single, 1.5, Colors.Black);

            document.LastSection.Add(table);
        }

        //public static void DemonstrateAlignment(Document document)
        //{
        //    document.LastSection.AddParagraph("Cell Alignment", "Heading2");

        //    Table table = document.LastSection.AddTable();
        //    table.Borders.Visible = true;
        //    table.Format.Shading.Color = Colors.LavenderBlush;
        //    table.Shading.Color = Colors.Salmon;
        //    table.TopPadding = 5;
        //    table.BottomPadding = 5;

        //    Column column = table.AddColumn();
        //    column.Format.Alignment = ParagraphAlignment.Left;

        //    column = table.AddColumn();
        //    column.Format.Alignment = ParagraphAlignment.Center;

        //    column = table.AddColumn();
        //    column.Format.Alignment = ParagraphAlignment.Right;

        //    table.Rows.Height = 35;

        //    Row row = table.AddRow();
        //    row.VerticalAlignment = VerticalAlignment.Top;
        //    row.Cells[0].AddParagraph("Text");
        //    row.Cells[1].AddParagraph("Text");
        //    row.Cells[2].AddParagraph("Text");

        //    row = table.AddRow();
        //    row.VerticalAlignment = VerticalAlignment.Center;
        //    row.Cells[0].AddParagraph("Text");
        //    row.Cells[1].AddParagraph("Text");
        //    row.Cells[2].AddParagraph("Text");

        //    row = table.AddRow();
        //    row.VerticalAlignment = VerticalAlignment.Bottom;
        //    row.Cells[0].AddParagraph("Text");
        //    row.Cells[1].AddParagraph("Text");
        //    row.Cells[2].AddParagraph("Text");
        //}

        public static void DemonstrateCellMerge(Document document)
        {
            document.LastSection.AddParagraph("Cell Merge", "Heading2");

            Table table = document.LastSection.AddTable();
            table.Borders.Visible = true;
            table.TopPadding = 5;
            table.BottomPadding = 5;

            Column column = table.AddColumn();
            column.Format.Alignment = ParagraphAlignment.Left;

            column = table.AddColumn();
            column.Format.Alignment = ParagraphAlignment.Center;

            column = table.AddColumn();
            column.Format.Alignment = ParagraphAlignment.Right;

            table.Rows.Height = 35;

            Row row = table.AddRow();
            row.Cells[0].AddParagraph("Merge Right");
            row.Cells[0].MergeRight = 1;

            row = table.AddRow();
            row.VerticalAlignment = VerticalAlignment.Bottom;
            row.Cells[0].MergeDown = 1;
            row.Cells[0].VerticalAlignment = VerticalAlignment.Bottom;
            row.Cells[0].AddParagraph("Merge Down");

            table.AddRow();
        }

        public static void DefineCharts(Document document)
        {
            Paragraph paragraph = document.LastSection.AddParagraph("Chart Overview", "Heading1");
            paragraph.AddBookmark("Charts");

            document.LastSection.AddParagraph("Sample Chart", "Heading2");

            Chart chart = new Chart();
            chart.Left = 0;

            chart.Width = Unit.FromCentimeter(16);
            chart.Height = Unit.FromCentimeter(12);
            Series series = chart.SeriesCollection.AddSeries();
            series.ChartType = ChartType.Column2D;
            series.Add(new double[] { 1, 17, 45, 5, 3, 20, 11, 23, 8, 19 });
            series.HasDataLabel = true;

            series = chart.SeriesCollection.AddSeries();
            series.ChartType = ChartType.Line;
            series.Add(new double[] { 41, 7, 5, 45, 13, 10, 21, 13, 18, 9 });

            XSeries xseries = chart.XValues.AddXSeries();
            xseries.Add("A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N");

            chart.XAxis.MajorTickMark = TickMarkType.Outside;
            chart.XAxis.Title.Caption = "X-Axis";

            chart.YAxis.MajorTickMark = TickMarkType.Outside;
            chart.YAxis.HasMajorGridlines = true;

            chart.PlotArea.LineFormat.Color = Colors.DarkGray;
            chart.PlotArea.LineFormat.Width = 1;

            document.LastSection.Add(chart);
        }


        #region old
        //static PdfDocument CreateDocument()
        //{
        //    PdfDocument document = new PdfDocument();

        //    // Add a section to the document
        //    Section section = document.AddSection();

        //    // Add a paragraph to the section
        //    Paragraph paragraph = section.AddParagraph();

        //    paragraph.Format.Font.Color = Color.FromCmyk(100, 30, 20, 50);

        //    // Add some text to the paragraph
        //    paragraph.AddFormattedText("Hello, World!", TextFormat.Bold);

        //    return document;
        //}
        #endregion

    }
}
