namespace AdventureWindowsForms
{
    partial class ForgeForm
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
            ForgeLabel1 = new Label();
            ForgeLabel2 = new Label();
            ForgeLabel3 = new Label();
            ForgeLabel4 = new Label();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            ForgingProgressBar = new ProgressBar();
            ForgeButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // ForgeLabel1
            // 
            ForgeLabel1.AutoSize = true;
            ForgeLabel1.Location = new Point(33, 27);
            ForgeLabel1.Name = "ForgeLabel1";
            ForgeLabel1.Size = new Size(160, 20);
            ForgeLabel1.TabIndex = 0;
            ForgeLabel1.Text = "Welcome to the Forge!";
            // 
            // ForgeLabel2
            // 
            ForgeLabel2.AutoSize = true;
            ForgeLabel2.Location = new Point(12, 56);
            ForgeLabel2.Name = "ForgeLabel2";
            ForgeLabel2.Size = new Size(198, 20);
            ForgeLabel2.TabIndex = 1;
            ForgeLabel2.Text = "Have you come for a sword?";
            // 
            // ForgeLabel3
            // 
            ForgeLabel3.AutoSize = true;
            ForgeLabel3.Location = new Point(12, 76);
            ForgeLabel3.Name = "ForgeLabel3";
            ForgeLabel3.Size = new Size(214, 20);
            ForgeLabel3.TabIndex = 2;
            ForgeLabel3.Text = "You may have one free of cost..";
            // 
            // ForgeLabel4
            // 
            ForgeLabel4.AutoSize = true;
            ForgeLabel4.Location = new Point(12, 96);
            ForgeLabel4.Name = "ForgeLabel4";
            ForgeLabel4.Size = new Size(245, 20);
            ForgeLabel4.TabIndex = 3;
            ForgeLabel4.Text = "However you must forge it yourself!";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ForgePicture;
            pictureBox1.Location = new Point(263, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(234, 232);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(320, 288);
            label5.Name = "label5";
            label5.Size = new Size(128, 20);
            label5.TabIndex = 5;
            label5.Text = "Forging progress :";
            // 
            // ForgingProgressBar
            // 
            ForgingProgressBar.Location = new Point(288, 322);
            ForgingProgressBar.Name = "ForgingProgressBar";
            ForgingProgressBar.Size = new Size(200, 29);
            ForgingProgressBar.TabIndex = 6;
            // 
            // ForgeButton
            // 
            ForgeButton.Location = new Point(342, 372);
            ForgeButton.Name = "ForgeButton";
            ForgeButton.Size = new Size(94, 29);
            ForgeButton.TabIndex = 7;
            ForgeButton.Text = "Forge";
            ForgeButton.UseVisualStyleBackColor = true;
            ForgeButton.Click += ForgeButton_Click;
            // 
            // ForgeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ForgeButton);
            Controls.Add(ForgingProgressBar);
            Controls.Add(label5);
            Controls.Add(pictureBox1);
            Controls.Add(ForgeLabel4);
            Controls.Add(ForgeLabel3);
            Controls.Add(ForgeLabel2);
            Controls.Add(ForgeLabel1);
            Name = "ForgeForm";
            Text = "Forge";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ForgeLabel1;
        private Label ForgeLabel2;
        private Label ForgeLabel3;
        private Label ForgeLabel4;
        private PictureBox pictureBox1;
        private Label label5;
        private ProgressBar ForgingProgressBar;
        private Button ForgeButton;
    }
}