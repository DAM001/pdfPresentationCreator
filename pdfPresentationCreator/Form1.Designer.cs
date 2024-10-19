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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}
