using System;
using System.Drawing;
using ZXing;
using ZXing.QrCode;

namespace ZxingQRcode
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiate a writer object
            var barcodeWriter = new BarcodeWriter();

            var options = new QrCodeEncodingOptions
            {
                DisableECI = true,
                CharacterSet = "UTF-8",
                Width = 230,
                Height = 230,
            };

            // set the barcode format
            barcodeWriter.Format = BarcodeFormat.QR_CODE;
            barcodeWriter.Options = options;

            // write text and generate a 2-D barcode as a bitmap
            barcodeWriter
                .Write("https://www.linkedin.com/in/miroslaw-kaczor-b7777444/")
                .Save(@"C:\Users\Miroslaw\Desktop\My CV and Covering Letter\IT\generated.jpeg");

            //www.linkedin.com/in/miroslaw-kaczor-b7777444


            ReadBarcode();

        }

        public static void ReadBarcode()
        {
            // create a barcode reader instance
            var barcodeReader = new BarcodeReader();

            // create an in memory bitmap
            var barcodeBitmap = (Bitmap)Bitmap.FromFile(@"C:\Users\Miroslaw\Desktop\My CV and Covering Letter\IT\generated.jpeg");

            // decode the barcode from the in memory bitmap
            var barcodeResult = barcodeReader.Decode(barcodeBitmap);

            // output results to console
            Console.WriteLine($"Decoded barcode text: {barcodeResult?.Text}");
            Console.WriteLine($"Barcode format: {barcodeResult?.BarcodeFormat}");
        }
    }
}
