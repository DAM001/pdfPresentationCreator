using Microsoft.Web.WebView2.WinForms;
using PdfSharp.Drawing;
using PdfSharp.Drawing.Layout;
using PdfSharp.Pdf;
using System.Diagnostics;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace pdfPresentationCreator
{
    public partial class Form1 : Form
    {
        public List<Page> Pages = new List<Page>();

        public Form1()
        {
            InitializeComponent();

            pageTypeComboBox.Items.Add(PageType.Main);
            pageTypeComboBox.Items.Add(PageType.Topic);
            pageTypeComboBox.Items.Add(PageType.Info);
            pageTypeComboBox.SelectedIndex = 0;
        }

        // Create a new page and add it to the listBox
        private void createPageButton_Click(object sender, EventArgs e)
        {
            string pageName = "Item" + Pages.Count;
            Pages.Add(new Page(pageName));
            pageListBox.Items.Add(pageName);
        }

        // Delete the selected listBox element
        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (pageListBox.SelectedIndex < 0) return;

            Pages.RemoveAt(pageListBox.SelectedIndex);
            pageListBox.Items.RemoveAt(pageListBox.SelectedIndex);
        }

        // Update the side view with the selected Page data
        private void pageListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pageListBox.SelectedIndex < 0) return;

            Page currentPage = Pages[pageListBox.SelectedIndex];
            pageNameTextBox.Text = currentPage.PageName;
            pageTypeComboBox.SelectedIndex = (int)currentPage.PageType;
        }

        // Rename the selected Page data with the name
        private void pageNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (pageListBox.SelectedIndex < 0) return;

            Pages[pageListBox.SelectedIndex].PageName = pageNameTextBox.Text;
            pageListBox.Items[pageListBox.SelectedIndex] = pageNameTextBox.Text;
        }

        // Update the Page data with the type
        private void pageTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pageListBox.SelectedIndex < 0) return;

            Pages[pageListBox.SelectedIndex].PageType = (PageType)pageTypeComboBox.SelectedIndex;
        }

        // Open the Page properties form
        private void editPageButton_Click(object sender, EventArgs e)
        {
            if (pageListBox.SelectedIndex < 0) return;

            if (Pages[pageListBox.SelectedIndex].PageType == PageType.Main)
            {
                PageMainForm form = new PageMainForm(this, pageListBox.SelectedIndex);
                form.ShowDialog();
            }

            if (Pages[pageListBox.SelectedIndex].PageType == PageType.Topic)
            {
                PageTopicForm form = new PageTopicForm(this, pageListBox.SelectedIndex);
                form.ShowDialog();
            }

            if (Pages[pageListBox.SelectedIndex].PageType == PageType.Info)
            {
                PageInfoForm form = new PageInfoForm(this, pageListBox.SelectedIndex);
                form.ShowDialog();
            }
        }

        // Create the webView component
        public WebView2 CreateWebView()
        {
            WebView2 webView = new WebView2();
            webView.Name = "previewWebView";
            webView.Width = 400;
            webView.Height = 400;
            webView.Location = new Point(300, 12);
            return webView;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (Pages.Count == 0) return;
            Page page = new Page(fileNameTextBox.Text + ".pdf", false);

            for (int i = 0; i < Pages.Count; i++)
            {
                page.CreatePage();

                if (Pages[i].PageType == PageType.Main)
                {
                    XFont font = new XFont("Verdana", 42);
                    XRect rect = new XRect(0, 190, Pages[i].Widht(), 120);

                    XFont font2 = new XFont("Verdana", 32);
                    XRect rect2 = new XRect(0, 300, Pages[i].Widht(), 200);

                    page.AddText((Pages[i] as PageMain).Title, font, rect, XParagraphAlignment.Center);
                    page.AddText((Pages[i] as PageMain).Author, font2, rect2, XParagraphAlignment.Center);
                }

                if (Pages[i].PageType == PageType.Topic)
                {
                    XFont font = new XFont("Verdana", 36);
                    XRect rect = new XRect(0, 250, Pages[i].Widht(), 200);

                    page.AddText((Pages[i] as PageTopic).Title, font, rect, XParagraphAlignment.Center);
                }

                if (Pages[i].PageType == PageType.Info)
                {
                    XFont font = new XFont("Verdana", 42);
                    XRect rect = new XRect(10, 0, Pages[i].Widht() - 20, 120);

                    XFont font2 = new XFont("Verdana", 22);
                    XRect rect2 = new XRect(10, 100, Pages[i].Widht() - 420, 300);

                    page.AddText((Pages[i] as PageInfo).Title, font, rect);
                    page.AddText((Pages[i] as PageInfo).Description, font2, rect2);
                }
            }

            page.Save();
            page.OpenPdfFile();

            CreateCsvFile();
        }

        private void CreateCsvFile()
        {
            if (Pages.Count == 0) return;
            string fileName = fileNameTextBox.Text + ".csv";
            string[] content = new string[Pages.Count];

            for (int i = 0; i < Pages.Count; i++)
            {
                content[i] = Pages[i].PageName;
                content[i] += "," + Pages[i].PageType;

                if (Pages[i].PageType == PageType.Main)
                {
                    content[i] += "," + (Pages[i] as PageMain).Title;
                    content[i] += "," + (Pages[i] as PageMain).Author;
                }

                if (Pages[i].PageType == PageType.Topic)
                {
                    content[i] += "," + (Pages[i] as PageTopic).Title;
                }

                if (Pages[i].PageType == PageType.Info)
                {
                    content[i] += "," + (Pages[i] as PageInfo).Title;
                    content[i] += "," + (Pages[i] as PageInfo).Description;
                }
            }

            File.WriteAllLines(fileName, content);
        }

        private void importButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string[] content = File.ReadAllLines(openFileDialog.FileName);

                    for (int i = 0; i < content.Length; i++)
                    {
                        string[] data = content[i].Split(',');
                        PageType type = (PageType)Enum.Parse(typeof(PageType), data[1]);

                        if (type == PageType.Main)
                        {
                            PageMain page = new PageMain(data[0]);
                            page.PageType = type;
                            page.Title = data[2];
                            page.Author = data[3];
                            Pages.Add(page);
                        }

                        if (type == PageType.Topic)
                        {
                            PageTopic page = new PageTopic(data[0]);
                            page.PageType = type;
                            page.Title = data[2];
                            Pages.Add(page);
                        }

                        if (type == PageType.Info)
                        {
                            PageInfo page = new PageInfo(data[0]);
                            page.PageType = type;
                            page.Title = data[2];
                            page.Description = data[3];
                            Pages.Add(page);
                        }

                        pageListBox.Items.Add(Pages[i].PageName);
                    }
                }
            }
        }
    }
}
