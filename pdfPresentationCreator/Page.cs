using PdfSharp.Drawing;
using PdfSharp.Drawing.Layout;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using PdfSharp.Pdf.Annotations;
using PdfSharp.Snippets.Pdf;
using PdfSharp.UniversalAccessibility.Drawing;
using System.Drawing;
using PdfSharp.Pdf.IO;

namespace pdfPresentationCreator
{
    public enum PageType
    {
        Main, Topic, Info
    }

    public class Page
    {
        public string PageName;
        public PageType PageType = PageType.Info;

        protected PdfDocument Document;
        public PdfPage PdfPage;
        protected XGraphics Graphics;

        protected string Name;

        public Page(string name, bool createPage = true)
        {
            Name = name;
            PageName = name;

            CreatePdfFile(Name, createPage);
        }

        public string Location()
        {
            return AppDomain.CurrentDomain.BaseDirectory + Name;
        }

        public XUnit Widht()
        {
            return PdfPage.Width;
        }

        public XUnit Height()
        {
            return PdfPage.Height;
        }

        public void CreatePdfFile(string name, bool createPage = true)
        {
            Name = name;

            // Create a new PDF file
            Document = new PdfDocument();
            Document.Info.Title = "PDF File";

            if (createPage) CreatePage();
        }

        public void AddExistingPage(PdfPage page)
        {
            Document.AddPage(page);
        }

        public void CreatePage()
        {
            // Add a new page
            PdfPage = Document.AddPage();
            PdfPage.Orientation = PdfSharp.PageOrientation.Landscape;
            Graphics = XGraphics.FromPdfPage(PdfPage);
        }

        public void AddText(string text, XFont font, XRect rect, 
            XParagraphAlignment alignment = XParagraphAlignment.Left)
        {
            // Write text
            //Graphics.DrawString(text, font, XBrushes.Black, rect, XStringFormat.Center);

            // Write text with wrap (break text if its too long)
            XTextFormatter textFormatter = new XTextFormatter(Graphics);
            textFormatter.Alignment = alignment;
            textFormatter.DrawString(text, font, XBrushes.Black, rect);
        }

        public void AddImage(string imagePath, int x, int y, int width, int height)
        {
            XImage image = XImage.FromFile(imagePath);
            Graphics.DrawImage(image, x, y, width, height);
        }

        public void Save()
        {
            // Save the document
            Document.Save(Name);
        }

        // Open the PDF file
        public void OpenPdfFile()
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = Name,
                UseShellExecute = true
            });
        }
    }
}
