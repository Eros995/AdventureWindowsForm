namespace AdventureWindowsForms
{
    partial class MainGameForm
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
            stableButton = new Button();
            ForgeButton = new Button();
            BarracksButton = new Button();
            DragonsLairButton = new Button();
            saveProgressbutton = new Button();
            returnToStartMenuButton = new Button();
            MainGamePictureBox = new PictureBox();
            inventoryListBox = new ListBox();
            inventoryLabel = new Label();
            playerLabel = new Label();
            throwAwayItemsButton = new Button();
            guideLabel1 = new Label();
            guideLabel2 = new Label();
            guideLabel3 = new Label();
            guidelabel4 = new Label();
            ((System.ComponentModel.ISupportInitialize)MainGamePictureBox).BeginInit();
            SuspendLayout();
            // 
            // stableButton
            // 
            stableButton.Location = new Point(12, 383);
            stableButton.Name = "stableButton";
            stableButton.Size = new Size(127, 29);
            stableButton.TabIndex = 0;
            stableButton.Text = "Go to the stable";
            stableButton.UseVisualStyleBackColor = true;
            stableButton.Click += StableButton_Click_1;
            // 
            // ForgeButton
            // 
            ForgeButton.Location = new Point(167, 383);
            ForgeButton.Name = "ForgeButton";
            ForgeButton.Size = new Size(127, 29);
            ForgeButton.TabIndex = 1;
            ForgeButton.Text = "Go to the forge";
            ForgeButton.UseVisualStyleBackColor = true;
            ForgeButton.Click += ForgeButton_Click;
            // 
            // BarracksButton
            // 
            BarracksButton.Location = new Point(345, 383);
            BarracksButton.Name = "BarracksButton";
            BarracksButton.Size = new Size(141, 29);
            BarracksButton.TabIndex = 2;
            BarracksButton.Text = "Go to the barracks";
            BarracksButton.UseVisualStyleBackColor = true;
            BarracksButton.Click += BarracksButton_Click;
            // 
            // DragonsLairButton
            // 
            DragonsLairButton.Location = new Point(536, 383);
            DragonsLairButton.Name = "DragonsLairButton";
            DragonsLairButton.Size = new Size(168, 29);
            DragonsLairButton.TabIndex = 3;
            DragonsLairButton.Text = "Go to the dragons lair";
            DragonsLairButton.UseVisualStyleBackColor = true;
            DragonsLairButton.Click += DragonsLairButton_Click;
            // 
            // saveProgressbutton
            // 
            saveProgressbutton.Location = new Point(668, 25);
            saveProgressbutton.Name = "saveProgressbutton";
            saveProgressbutton.Size = new Size(120, 29);
            saveProgressbutton.TabIndex = 4;
            saveProgressbutton.Text = "Save Progress";
            saveProgressbutton.UseVisualStyleBackColor = true;
            saveProgressbutton.Click += saveProgressbutton_Click;
            // 
            // returnToStartMenuButton
            // 
            returnToStartMenuButton.Location = new Point(611, 75);
            returnToStartMenuButton.Name = "returnToStartMenuButton";
            returnToStartMenuButton.Size = new Size(165, 29);
            returnToStartMenuButton.TabIndex = 5;
            returnToStartMenuButton.Text = "Return to Main Menu";
            returnToStartMenuButton.UseVisualStyleBackColor = true;
            returnToStartMenuButton.Click += returnToStartMenuButton_Click;
            // 
            // MainGamePictureBox
            // 
            MainGamePictureBox.Image = Properties.Resources.CrossroadsPicture;
            MainGamePictureBox.Location = new Point(275, 40);
            MainGamePictureBox.Name = "MainGamePictureBox";
            MainGamePictureBox.Size = new Size(222, 240);
            MainGamePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            MainGamePictureBox.TabIndex = 6;
            MainGamePictureBox.TabStop = false;
            // 
            // inventoryListBox
            // 
            inventoryListBox.FormattingEnabled = true;
            inventoryListBox.ItemHeight = 20;
            inventoryListBox.Location = new Point(44, 75);
            inventoryListBox.Name = "inventoryListBox";
            inventoryListBox.Size = new Size(150, 104);
            inventoryListBox.TabIndex = 7;
            // 
            // inventoryLabel
            // 
            inventoryLabel.AutoSize = true;
            inventoryLabel.Location = new Point(44, 52);
            inventoryLabel.Name = "inventoryLabel";
            inventoryLabel.Size = new Size(70, 20);
            inventoryLabel.TabIndex = 8;
            inventoryLabel.Text = "Inventory";
            // 
            // playerLabel
            // 
            playerLabel.AutoSize = true;
            playerLabel.Location = new Point(77, 226);
            playerLabel.Name = "playerLabel";
            playerLabel.Size = new Size(12, 20);
            playerLabel.TabIndex = 9;
            playerLabel.Text = "'";
            // 
            // throwAwayItemsButton
            // 
            throwAwayItemsButton.Location = new Point(27, 249);
            throwAwayItemsButton.Name = "throwAwayItemsButton";
            throwAwayItemsButton.Size = new Size(182, 29);
            throwAwayItemsButton.TabIndex = 10;
            throwAwayItemsButton.Text = "Throw away your items";
            throwAwayItemsButton.UseVisualStyleBackColor = true;
            throwAwayItemsButton.Click += throwAwayItemsButton_Click;
            // 
            // guideLabel1
            // 
            guideLabel1.AutoSize = true;
            guideLabel1.Location = new Point(505, 126);
            guideLabel1.Name = "guideLabel1";
            guideLabel1.Size = new Size(173, 20);
            guideLabel1.TabIndex = 11;
            guideLabel1.Text = "To gain enough strength,";
            // 
            // guideLabel2
            // 
            guideLabel2.AutoSize = true;
            guideLabel2.Location = new Point(505, 146);
            guideLabel2.Name = "guideLabel2";
            guideLabel2.Size = new Size(283, 20);
            guideLabel2.TabIndex = 12;
            guideLabel2.Text = "Be sure to earn yourself some equipment.";
            // 
            // guideLabel3
            // 
            guideLabel3.AutoSize = true;
            guideLabel3.Location = new Point(505, 166);
            guideLabel3.Name = "guideLabel3";
            guideLabel3.Size = new Size(181, 20);
            guideLabel3.TabIndex = 13;
            guideLabel3.Text = "And a loyal horse, or else..";
            // 
            // guidelabel4
            // 
            guidelabel4.AutoSize = true;
            guidelabel4.Location = new Point(505, 186);
            guidelabel4.Name = "guidelabel4";
            guidelabel4.Size = new Size(234, 20);
            guidelabel4.TabIndex = 14;
            guidelabel4.Text = "the dragon might overwhelm you!";
            // 
            // MainGameForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(guidelabel4);
            Controls.Add(guideLabel3);
            Controls.Add(guideLabel2);
            Controls.Add(guideLabel1);
            Controls.Add(throwAwayItemsButton);
            Controls.Add(playerLabel);
            Controls.Add(inventoryLabel);
            Controls.Add(inventoryListBox);
            Controls.Add(MainGamePictureBox);
            Controls.Add(returnToStartMenuButton);
            Controls.Add(saveProgressbutton);
            Controls.Add(DragonsLairButton);
            Controls.Add(BarracksButton);
            Controls.Add(ForgeButton);
            Controls.Add(stableButton);
            Name = "MainGameForm";
            Text = "MainGame";
            FormClosing += MainGameForm_FormClosing;
            ((System.ComponentModel.ISupportInitialize)MainGamePictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button stableButton;
        private Button ForgeButton;
        private Button BarracksButton;
        private Button DragonsLairButton;
        private Button saveProgressbutton;
        private Button returnToStartMenuButton;
        private PictureBox MainGamePictureBox;
        private ListBox inventoryListBox;
        private Label inventoryLabel;
        private Label playerLabel;
        private Button throwAwayItemsButton;
        private Label guideLabel1;
        private Label guideLabel2;
        private Label guideLabel3;
        private Label guidelabel4;
    }
}