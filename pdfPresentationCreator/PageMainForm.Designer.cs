namespace pdfPresentationCreator
{
    partial class PageMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            titleTextBox = new TextBox();
            authorTextBox = new TextBox();
            saveButton = new Button();
            previewButton = new Button();
            Title = new Label();
            Author = new Label();
            SuspendLayout();
            // 
            // titleTextBox
            // 
            titleTextBox.Location = new Point(12, 27);
            titleTextBox.Multiline = true;
            titleTextBox.Name = "titleTextBox";
            titleTextBox.Size = new Size(280, 80);
            titleTextBox.TabIndex = 0;
            // 
            // authorTextBox
            // 
            authorTextBox.Location = new Point(12, 154);
            authorTextBox.Name = "authorTextBox";
            authorTextBox.Size = new Size(280, 23);
            authorTextBox.TabIndex = 1;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(12, 426);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(75, 23);
            saveButton.TabIndex = 2;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // previewButton
            // 
            previewButton.Location = new Point(93, 426);
            previewButton.Name = "previewButton";
            previewButton.Size = new Size(75, 23);
            previewButton.TabIndex = 4;
            previewButton.Text = "Preview";
            previewButton.UseVisualStyleBackColor = true;
            previewButton.Click += previewButton_Click;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Location = new Point(12, 9);
            Title.Name = "Title";
            Title.Size = new Size(30, 15);
            Title.TabIndex = 5;
            Title.Text = "Title";
            // 
            // Author
            // 
            Author.AutoSize = true;
            Author.Location = new Point(12, 136);
            Author.Name = "Author";
            Author.Size = new Size(44, 15);
            Author.TabIndex = 6;
            Author.Text = "Author";
            // 
            // PageMainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 461);
            Controls.Add(Author);
            Controls.Add(Title);
            Controls.Add(previewButton);
            Controls.Add(saveButton);
            Controls.Add(authorTextBox);
            Controls.Add(titleTextBox);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "PageMainForm";
            Text = "PageMainForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox titleTextBox;
        private TextBox authorTextBox;
        private Button saveButton;
        private Button previewButton;
        private Label Title;
        private Label Author;
    }
}