using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pdfPresentationCreator
{
    public class Page
    {


        public void CreatePdfFile()
        {
            // Create a new PDF file
            PdfDocument document = new PdfDocument();
            document.Info.Title = "PDF File";

            // Add a new page
            PdfPage page = document.AddPage();
            page.Orientation = PdfSharp.PageOrientation.Landscape;
            XGraphics gfx = XGraphics.FromPdfPage(page);

            // Create a font and write text
            XFont font = new XFont("Verdana", 20);
            gfx.DrawString("Hello World!", font, XBrushes.Black,
                new XRect(0, 0, page.Width, page.Height), XStringFormats.Center);

            // Save the document
            document.Save("example.pdf");

            // Open the PDF file
            Process.Start(new ProcessStartInfo
            {
                FileName = "example.pdf",
                UseShellExecute = true
            });
        }
    }
}
