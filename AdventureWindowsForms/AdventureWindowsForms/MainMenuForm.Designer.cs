namespace AdventureWindowsForms
{
    partial class MainMenuForm
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
            SaveFilesButton = new Button();
            StartNewGameButton = new Button();
            mainMenuPictureBox = new PictureBox();
            welcomeLabel = new Label();
            storyLabel1 = new Label();
            storyLabel2 = new Label();
            storyLabel3 = new Label();
            ((System.ComponentModel.ISupportInitialize)mainMenuPictureBox).BeginInit();
            SuspendLayout();
            // 
            // SaveFilesButton
            // 
            SaveFilesButton.Location = new Point(200, 387);
            SaveFilesButton.Name = "SaveFilesButton";
            SaveFilesButton.Size = new Size(116, 29);
            SaveFilesButton.TabIndex = 0;
            SaveFilesButton.Text = "Load Save File";
            SaveFilesButton.UseVisualStyleBackColor = true;
            SaveFilesButton.Click += SaveFilesButton_Click;
            // 
            // StartNewGameButton
            // 
            StartNewGameButton.Location = new Point(427, 387);
            StartNewGameButton.Name = "StartNewGameButton";
            StartNewGameButton.Size = new Size(128, 29);
            StartNewGameButton.TabIndex = 1;
            StartNewGameButton.Text = "Start New Game";
            StartNewGameButton.UseVisualStyleBackColor = true;
            StartNewGameButton.Click += StartNewGameButton_Click;
            // 
            // mainMenuPictureBox
            // 
            mainMenuPictureBox.Image = Properties.Resources.MainMenuPicture;
            mainMenuPictureBox.Location = new Point(181, 79);
            mainMenuPictureBox.Name = "mainMenuPictureBox";
            mainMenuPictureBox.Size = new Size(355, 233);
            mainMenuPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            mainMenuPictureBox.TabIndex = 2;
            mainMenuPictureBox.TabStop = false;
            // 
            // welcomeLabel
            // 
            welcomeLabel.AutoSize = true;
            welcomeLabel.Location = new Point(268, 47);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(190, 20);
            welcomeLabel.TabIndex = 3;
            welcomeLabel.Text = "Welcome to the Adventure!";
            // 
            // storyLabel1
            // 
            storyLabel1.AutoSize = true;
            storyLabel1.Location = new Point(547, 77);
            storyLabel1.Name = "storyLabel1";
            storyLabel1.Size = new Size(240, 20);
            storyLabel1.TabIndex = 4;
            storyLabel1.Text = "The princess has been kiddnapped,";
            // 
            // storyLabel2
            // 
            storyLabel2.AutoSize = true;
            storyLabel2.Location = new Point(547, 97);
            storyLabel2.Name = "storyLabel2";
            storyLabel2.Size = new Size(184, 20);
            storyLabel2.TabIndex = 5;
            storyLabel2.Text = "By a dragon! And we need";
            // 
            // storyLabel3
            // 
            storyLabel3.AutoSize = true;
            storyLabel3.Location = new Point(547, 117);
            storyLabel3.Name = "storyLabel3";
            storyLabel3.Size = new Size(183, 20);
            storyLabel3.TabIndex = 6;
            storyLabel3.Text = "a brave knight to save her!";
            // 
            // MainMenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(storyLabel3);
            Controls.Add(storyLabel2);
            Controls.Add(storyLabel1);
            Controls.Add(welcomeLabel);
            Controls.Add(mainMenuPictureBox);
            Controls.Add(StartNewGameButton);
            Controls.Add(SaveFilesButton);
            Name = "MainMenuForm";
            Text = "MainMenu";
            ((System.ComponentModel.ISupportInitialize)mainMenuPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SaveFilesButton;
        private Button StartNewGameButton;
        private PictureBox mainMenuPictureBox;
        private Label welcomeLabel;
        private Label storyLabel1;
        private Label storyLabel2;
        private Label storyLabel3;
    }
}