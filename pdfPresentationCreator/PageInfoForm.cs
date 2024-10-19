using Microsoft.Web.WebView2.WinForms;
using PdfSharp.Drawing;
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
    public partial class PageInfoForm : Form
    {
        private Form1 Form;
        private int Index;
        private WebView2 PreviewWebView;
        private string ImagePath = "";

        public PageInfoForm(Form1 form, int index)
        {
            Index = index;
            Form = form;

            InitializeComponent();

            PreviewWebView = Form.CreateWebView();
            Controls.Add(PreviewWebView);

            if (form.Pages[index].GetType() != typeof(PageInfo))
            {
                string pageName = form.Pages[index].PageName;
                PageType pageType = form.Pages[index].PageType;

                form.Pages[index] = new PageInfo(pageName);
                form.Pages[index].PageType = pageType;
            }
            else
            {
                titleTextBox.Text = (Form.Pages[Index] as PageInfo).Title;
                descriptionTextBox.Text = (Form.Pages[Index] as PageInfo).Description;
            }

            UpdatePreview();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            (Form.Pages[Index] as PageInfo).Title = titleTextBox.Text;
            (Form.Pages[Index] as PageInfo).Description = descriptionTextBox.Text;

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
            XRect rect = new XRect(10, 0, Form.Pages[Index].Widht() - 20, 120);

            XFont font2 = new XFont("Verdana", 22);
            XRect rect2 = new XRect(10, 100, Form.Pages[Index].Widht() - 420, 300);

            Form.Pages[Index].AddText(titleTextBox.Text, font, rect);
            Form.Pages[Index].AddText(descriptionTextBox.Text, font2, rect2);

            //if (ImagePath.Length > 0) Form.Pages[Index].AddImage(ImagePath, 0, 0, 100, 100);
            Form.Pages[Index].Save();

            PreviewWebView.Source = new Uri(Form.Pages[Index].Location());
        }

        private void addImageButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Jpg (*.jpg)|*jpg|Png (*.png)|*.png";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ImagePath = openFileDialog.FileName;
                    pictureBox1.ImageLocation = ImagePath;
                    //File.Copy(openFileDialog.FileName, "test.jpg");
                }
            }
        }
    }
}
