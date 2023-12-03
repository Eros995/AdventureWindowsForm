namespace AdventureWindowsForms
{
    partial class DragonsLairForm
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
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            fightDragonButton = new Button();
            speakWithDragonButton = new Button();
            inventoryListBox = new ListBox();
            InventoryLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 89);
            label1.Name = "label1";
            label1.Size = new Size(194, 20);
            label1.TabIndex = 0;
            label1.Text = "You are at the Dragons Lair..";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 137);
            label2.Name = "label2";
            label2.Size = new Size(128, 20);
            label2.TabIndex = 1;
            label2.Text = "What will you do?";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.DragonsLairPicture;
            pictureBox1.Location = new Point(237, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(269, 268);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // fightDragonButton
            // 
            fightDragonButton.Location = new Point(213, 361);
            fightDragonButton.Name = "fightDragonButton";
            fightDragonButton.Size = new Size(142, 29);
            fightDragonButton.TabIndex = 3;
            fightDragonButton.Text = "Fight the dragon";
            fightDragonButton.UseVisualStyleBackColor = true;
            fightDragonButton.Click += fightDragonButton_Click;
            // 
            // speakWithDragonButton
            // 
            speakWithDragonButton.Location = new Point(402, 361);
            speakWithDragonButton.Name = "speakWithDragonButton";
            speakWithDragonButton.Size = new Size(168, 29);
            speakWithDragonButton.TabIndex = 4;
            speakWithDragonButton.Text = "Speak with the dragon";
            speakWithDragonButton.UseVisualStyleBackColor = true;
            speakWithDragonButton.Click += speakWithDragonButton_Click;
            // 
            // inventoryListBox
            // 
            inventoryListBox.FormattingEnabled = true;
            inventoryListBox.ItemHeight = 20;
            inventoryListBox.Location = new Point(620, 106);
            inventoryListBox.Name = "inventoryListBox";
            inventoryListBox.Size = new Size(150, 104);
            inventoryListBox.TabIndex = 5;
            // 
            // InventoryLabel
            // 
            InventoryLabel.AutoSize = true;
            InventoryLabel.Location = new Point(641, 84);
            InventoryLabel.Name = "InventoryLabel";
            InventoryLabel.Size = new Size(70, 20);
            InventoryLabel.TabIndex = 6;
            InventoryLabel.Text = "Inventory";
            // 
            // DragonsLairForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(InventoryLabel);
            Controls.Add(inventoryListBox);
            Controls.Add(speakWithDragonButton);
            Controls.Add(fightDragonButton);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DragonsLairForm";
            Text = "DragonsLair";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Button fightDragonButton;
        private Button speakWithDragonButton;
        private ListBox inventoryListBox;
        private Label InventoryLabel;
    }
}