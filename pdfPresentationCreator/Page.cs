using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace pdfPresentationCreator
{
    public class Page
    {
        public string PageName;

        protected PdfDocument Document;
        protected PdfPage PdfPage;
        protected XGraphics Graphics;

        public Page(string name)
        {
            PageName = name;

            CreatePdfFile();
        }

        public void CreatePdfFile()
        {
            // Create a new PDF file
            Document = new PdfDocument();
            Document.Info.Title = "PDF File";

            // Add a new page
            PdfPage = Document.AddPage();
            PdfPage.Orientation = PdfSharp.PageOrientation.Landscape;
            Graphics = XGraphics.FromPdfPage(PdfPage);
        }

        public void AddText(string text)
        {
            // Create a font and write text
            XFont font = new XFont("Verdana", 20);
            Graphics.DrawString(text, font, XBrushes.Black,
                new XRect(0, 0, PdfPage.Width, PdfPage.Height), XStringFormats.Center);

            // Save the document
            Document.Save("example.pdf");
        }

        // Open the PDF file
        public void OpenPdfFile()
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "example.pdf",
                UseShellExecute = true
            });
        }
    }
}
