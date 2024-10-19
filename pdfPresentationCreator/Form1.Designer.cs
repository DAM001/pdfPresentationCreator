namespace pdfPresentationCreator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pageListBox = new ListBox();
            createPageButton = new Button();
            editPageButton = new Button();
            deleteButton = new Button();
            pageNameTextBox = new TextBox();
            pageTypeComboBox = new ComboBox();
            fileNameTextBox = new TextBox();
            saveButton = new Button();
            importButton = new Button();
            SuspendLayout();
            // 
            // pageListBox
            // 
            pageListBox.FormattingEnabled = true;
            pageListBox.ItemHeight = 15;
            pageListBox.Location = new Point(12, 12);
            pageListBox.Name = "pageListBox";
            pageListBox.Size = new Size(336, 424);
            pageListBox.TabIndex = 0;
            pageListBox.SelectedIndexChanged += pageListBox_SelectedIndexChanged;
            // 
            // createPageButton
            // 
            createPageButton.Location = new Point(354, 12);
            createPageButton.Name = "createPageButton";
            createPageButton.Size = new Size(150, 23);
            createPageButton.TabIndex = 1;
            createPageButton.Text = "Create Page";
            createPageButton.UseVisualStyleBackColor = true;
            createPageButton.Click += createPageButton_Click;
            // 
            // editPageButton
            // 
            editPageButton.Location = new Point(354, 41);
            editPageButton.Name = "editPageButton";
            editPageButton.Size = new Size(150, 23);
            editPageButton.TabIndex = 2;
            editPageButton.Text = "Edit Page";
            editPageButton.UseVisualStyleBackColor = true;
            editPageButton.Click += editPageButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(354, 70);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(150, 23);
            deleteButton.TabIndex = 3;
            deleteButton.Text = "Delete Page";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // pageNameTextBox
            // 
            pageNameTextBox.Location = new Point(523, 12);
            pageNameTextBox.Name = "pageNameTextBox";
            pageNameTextBox.Size = new Size(249, 23);
            pageNameTextBox.TabIndex = 4;
            pageNameTextBox.TextChanged += pageNameTextBox_TextChanged;
            // 
            // pageTypeComboBox
            // 
            pageTypeComboBox.FormattingEnabled = true;
            pageTypeComboBox.Location = new Point(523, 42);
            pageTypeComboBox.Name = "pageTypeComboBox";
            pageTypeComboBox.Size = new Size(249, 23);
            pageTypeComboBox.TabIndex = 5;
            pageTypeComboBox.SelectedIndexChanged += pageTypeComboBox_SelectedIndexChanged;
            // 
            // fileNameTextBox
            // 
            fileNameTextBox.Location = new Point(365, 413);
            fileNameTextBox.Name = "fileNameTextBox";
            fileNameTextBox.Size = new Size(342, 23);
            fileNameTextBox.TabIndex = 6;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(713, 413);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(75, 23);
            saveButton.TabIndex = 7;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // importButton
            // 
            importButton.Location = new Point(713, 384);
            importButton.Name = "importButton";
            importButton.Size = new Size(75, 23);
            importButton.TabIndex = 8;
            importButton.Text = "Import";
            importButton.UseVisualStyleBackColor = true;
            importButton.Click += importButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(importButton);
            Controls.Add(saveButton);
            Controls.Add(fileNameTextBox);
            Controls.Add(pageTypeComboBox);
            Controls.Add(pageNameTextBox);
            Controls.Add(deleteButton);
            Controls.Add(editPageButton);
            Controls.Add(createPageButton);
            Controls.Add(pageListBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox pageListBox;
        private Button createPageButton;
        private Button editPageButton;
        private Button deleteButton;
        private TextBox pageNameTextBox;
        private ComboBox pageTypeComboBox;
        private TextBox fileNameTextBox;
        private Button saveButton;
        private Button importButton;
    }
}
