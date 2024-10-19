using Microsoft.Web.WebView2.WinForms;
using PdfSharp.Drawing;
using PdfSharp.Drawing.Layout;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pdfPresentationCreator
{
    public partial class PageTopicForm : Form
    {
        private Form1 Form;
        private int Index;
        private WebView2 PreviewWebView;

        public PageTopicForm(Form1 form, int index)
        {
            Form = form;
            Index = index;

            InitializeComponent();

            PreviewWebView = Form.CreateWebView();
            Controls.Add(PreviewWebView);

            if (form.Pages[index].GetType() != typeof(PageTopic))
            {
                string pageName = form.Pages[index].PageName;
                PageType pageType = form.Pages[index].PageType;

                form.Pages[index] = new PageTopic(pageName);
                form.Pages[index].PageType = pageType;
            }
            else
            {
                titleTextBox.Text = (Form.Pages[Index] as PageTopic).Title;
            }

            UpdatePreview();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            (Form.Pages[Index] as PageTopic).Title = titleTextBox.Text;

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

            XFont font = new XFont("Verdana", 36);
            XRect rect = new XRect(0, 250, Form.Pages[Index].Widht(), 200);

            Form.Pages[Index].AddText(titleTextBox.Text, font, rect, XParagraphAlignment.Center);
            Form.Pages[Index].Save();

            PreviewWebView.Source = new Uri(Form.Pages[Index].Location());
        }
    }
}
