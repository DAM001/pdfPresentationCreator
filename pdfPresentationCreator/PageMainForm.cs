using Microsoft.Web.WebView2.WinForms;
using PdfSharp.Drawing;
using PdfSharp.Drawing.Layout;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace pdfPresentationCreator
{
    public partial class PageMainForm : Form
    {
        private Form1 Form;
        private int Index;
        WebView2 PreviewWebView;

        public PageMainForm(Form1 form, int index)
        {
            Index = index;
            Form = form;

            InitializeComponent();

            PreviewWebView = Form.CreateWebView();
            Controls.Add(PreviewWebView);

            if (form.Pages[index].GetType() != typeof(PageMain))
            {
                string pageName = form.Pages[index].PageName;
                PageType pageType = form.Pages[index].PageType;

                form.Pages[index] = new PageMain(pageName);
                form.Pages[index].PageType = pageType;
            }
            else
            {
                titleTextBox.Text = (Form.Pages[Index] as PageMain).Title;
                authorTextBox.Text = (Form.Pages[Index] as PageMain).Author;
            }

            UpdatePreview();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            (Form.Pages[Index] as PageMain).Title = titleTextBox.Text;
            (Form.Pages[Index] as PageMain).Author = authorTextBox.Text;

            DialogResult = DialogResult.OK;
        }

        private void previewButton_Click(object sender, EventArgs e)
        {
            UpdatePreview();
        }

        private void UpdatePreview()
        {
            if (PreviewWebView.CoreWebView2 != null)
            {
                PreviewWebView.CoreWebView2.Reload();
            }

            Form.Pages[Index].CreatePdfFile(Form.Pages[Index].PageName);

            XFont font = new XFont("Verdana", 42);
            XRect rect = new XRect(0, 190, Form.Pages[Index].Widht(), 120);

            XFont font2 = new XFont("Verdana", 32);
            XRect rect2 = new XRect(0, 300, Form.Pages[Index].Widht(), 200);

            Form.Pages[Index].AddText(titleTextBox.Text, font, rect, XParagraphAlignment.Center);
            Form.Pages[Index].AddText(authorTextBox.Text, font2, rect2, XParagraphAlignment.Center);
            Form.Pages[Index].Save();

            PreviewWebView.Source = new Uri(Form.Pages[Index].Location());
        }
    }
}
