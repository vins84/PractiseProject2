using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Data;
using System.Diagnostics;

namespace pdfSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Dosage", typeof(int));
            table.Columns.Add("Drug", typeof(string));
            table.Columns.Add("Patient", typeof(string));
            table.Columns.Add("Date", typeof(DateTime));

            // Here we add five DataRows.
            table.Rows.Add(25, "Indocin", "David", DateTime.Now);
            table.Rows.Add(50, "Enebrel", "Sam", DateTime.Now);
            table.Rows.Add(10, "Hydralazine", "Christoff", DateTime.Now);
            table.Rows.Add(21, "Combivent", "Janet", DateTime.Now);
            table.Rows.Add(100, "Dilantin", "Melanie", DateTime.Now);


            // Create a new PDF document
            PdfDocument document = new PdfDocument();
            document.Info.Title = "Created with PDFsharp";

            // Create an empty page
            PdfPage page = document.AddPage();
            page.Width = XUnit.FromCentimeter(8);
            page.Height = XUnit.FromCentimeter(8);


            // Get an XGraphics object for drawing
            XGraphics gfx = XGraphics.FromPdfPage(page);
            DrawRectangle(gfx, 2);

            // Create a font
            XFont font = new XFont("Verdana", 20, XFontStyle.BoldItalic);

            // Draw the text
            gfx.DrawString("Hello, World!", font, XBrushes.Black,
              new XRect(0, 0, page.Width, page.Height),
              XStringFormats.Center);

            // Save the document...
            const string filename = "HelloWorld.pdf";
            document.Save(filename);
            // ...and start a viewer.
            Process.Start(filename);
        }


        static void DrawRectangle(XGraphics gfx, int number)
        {
            BeginBox(gfx, number, "DrawRectangle");

            XPen pen = new XPen(XColors.Navy, Math.PI);
            XPen pen2 = new XPen(XColor.FromName("black"));

            gfx.DrawRectangle(pen, 10, 0, 100, 60);
            gfx.DrawRectangle(pen2, 100, 0, 200, 0);

            gfx.DrawRectangle(XBrushes.Azure, 130, 0, 100, 60);
            //gfx.DrawRectangle(pen, XBrushes.Blue, 10, 80, 100, 60);
            //gfx.DrawRectangle(pen, XBrushes.Brown, 150, 80, 60, 60);

            EndBox(gfx);
        }
        public static void BeginBox(XGraphics gfx, int number, string title)
        {
            XRect rect = new XRect(0, 10, 200, 100);
            //if (number % 2 == 0)
            //    rect.X = 300 - 5;
            //rect.Y = 40 + ((number - 1) / 2) * (200 - 5);
            //rect.Inflate(-10, -10);
            //rect.Inflate(-5, -5);

            XFont font = new XFont("Verdana", 12, XFontStyle.Regular);
            gfx.DrawString(title, font, XBrushes.Navy, rect, XStringFormats.TopCenter);

            //rect.Inflate(-10, -5);
            //rect.Y += 20;
            //rect.Height -= 20;

            //this.state = gfx.Save();
            gfx.Save();
            gfx.TranslateTransform(rect.X, rect.Y);
        }

        public static void EndBox(XGraphics gfx)
        {
            gfx.Restore();
        }

        public static void DemonstrateSimpleTable(PdfDocument document)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Date", typeof(DateTime));
            table.Rows.Add(100, "Dilantin", "Melanie", DateTime.Now);
        }
    }
}
