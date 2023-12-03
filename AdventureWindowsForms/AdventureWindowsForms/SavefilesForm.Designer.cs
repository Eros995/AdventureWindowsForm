namespace AdventureWindowsForms
{
    partial class SavefilesForm
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
            returnToMainMenuButton = new Button();
            loadSaveButton = new Button();
            SaveFileListBox = new ListBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // returnToMainMenuButton
            // 
            returnToMainMenuButton.Location = new Point(580, 385);
            returnToMainMenuButton.Name = "returnToMainMenuButton";
            returnToMainMenuButton.Size = new Size(167, 29);
            returnToMainMenuButton.TabIndex = 0;
            returnToMainMenuButton.Text = "Return to Main Menu";
            returnToMainMenuButton.UseVisualStyleBackColor = true;
            returnToMainMenuButton.Click += returnToMainMenuButton_Click;
            // 
            // loadSaveButton
            // 
            loadSaveButton.Location = new Point(424, 385);
            loadSaveButton.Name = "loadSaveButton";
            loadSaveButton.Size = new Size(94, 29);
            loadSaveButton.TabIndex = 1;
            loadSaveButton.Text = "Load Save";
            loadSaveButton.UseVisualStyleBackColor = true;
            loadSaveButton.Click += loadSaveButton_Click;
            // 
            // SaveFileListBox
            // 
            SaveFileListBox.FormattingEnabled = true;
            SaveFileListBox.ItemHeight = 20;
            SaveFileListBox.Location = new Point(62, 67);
            SaveFileListBox.Name = "SaveFileListBox";
            SaveFileListBox.Size = new Size(196, 244);
            SaveFileListBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(123, 26);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 3;
            label1.Text = "Save Files";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.KnightPicture;
            pictureBox1.Location = new Point(361, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(386, 340);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // SavefilesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(SaveFileListBox);
            Controls.Add(loadSaveButton);
            Controls.Add(returnToMainMenuButton);
            Name = "SavefilesForm";
            Text = "Savefiles";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button returnToMainMenuButton;
        private Button loadSaveButton;
        private ListBox SaveFileListBox;
        private Label label1;
        private PictureBox pictureBox1;
    }
}