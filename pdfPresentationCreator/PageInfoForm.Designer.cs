namespace pdfPresentationCreator
{
    partial class PageInfoForm
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
            descriptionTextBox = new TextBox();
            saveButton = new Button();
            label1 = new Label();
            label2 = new Label();
            previewButton = new Button();
            addImageButton = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // titleTextBox
            // 
            titleTextBox.Location = new Point(12, 27);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.Size = new Size(280, 23);
            titleTextBox.TabIndex = 0;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(12, 106);
            descriptionTextBox.Multiline = true;
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(280, 80);
            descriptionTextBox.TabIndex = 1;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 3;
            label1.Text = "Topic";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 88);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 4;
            label2.Text = "Description";
            // 
            // previewButton
            // 
            previewButton.Location = new Point(93, 426);
            previewButton.Name = "previewButton";
            previewButton.Size = new Size(75, 23);
            previewButton.TabIndex = 5;
            previewButton.Text = "Preview";
            previewButton.UseVisualStyleBackColor = true;
            previewButton.Click += previewButton_Click;
            // 
            // addImageButton
            // 
            addImageButton.Location = new Point(12, 236);
            addImageButton.Name = "addImageButton";
            addImageButton.Size = new Size(280, 23);
            addImageButton.TabIndex = 6;
            addImageButton.Text = "Add Image";
            addImageButton.UseVisualStyleBackColor = true;
            addImageButton.Click += addImageButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 265);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(280, 155);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // PageInfoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 461);
            Controls.Add(pictureBox1);
            Controls.Add(addImageButton);
            Controls.Add(previewButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(saveButton);
            Controls.Add(descriptionTextBox);
            Controls.Add(titleTextBox);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "PageInfoForm";
            Text = "PageInfoForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox titleTextBox;
        private TextBox descriptionTextBox;
        private Button saveButton;
        private Label label1;
        private Label label2;
        private Button previewButton;
        private Button addImageButton;
        private PictureBox pictureBox1;
    }
}