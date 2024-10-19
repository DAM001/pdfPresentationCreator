using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System.Diagnostics;

namespace pdfPresentationCreator
{
    public partial class Form1 : Form
    {
        private List<Page> Pages = new List<Page>();

        public Form1()
        {
            InitializeComponent();
        }

        private void createPageButton_Click(object sender, EventArgs e)
        {
            string pageName = "Item" + Pages.Count;
            Pages.Add(new Page(pageName));
            pageListBox.Items.Add(pageName);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (pageListBox.SelectedIndex < 0) return;

            Pages.RemoveAt(pageListBox.SelectedIndex);
            pageListBox.Items.RemoveAt(pageListBox.SelectedIndex);
        }

        private void pageListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pageListBox.SelectedIndex < 0) return;

            pageNameTextBox.Text = Pages[pageListBox.SelectedIndex].PageName;
        }

        private void pageNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (pageListBox.SelectedIndex < 0) return;

            Pages[pageListBox.SelectedIndex].PageName = pageNameTextBox.Text;
            pageListBox.Items[pageListBox.SelectedIndex] = pageNameTextBox.Text;
        }
    }
}
