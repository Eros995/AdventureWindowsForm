namespace AdventureWindowsForms
{
    partial class BarracksForm
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
            BarracksLabel1 = new Label();
            BarracksLabel2 = new Label();
            BarracksLabel3 = new Label();
            BarracksLabel4 = new Label();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            TrainingProgressBar = new ProgressBar();
            trainingButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // BarracksLabel1
            // 
            BarracksLabel1.AutoSize = true;
            BarracksLabel1.Location = new Point(12, 20);
            BarracksLabel1.Name = "BarracksLabel1";
            BarracksLabel1.Size = new Size(177, 20);
            BarracksLabel1.TabIndex = 0;
            BarracksLabel1.Text = "Welcome to the Barracks!";
            // 
            // BarracksLabel2
            // 
            BarracksLabel2.AutoSize = true;
            BarracksLabel2.Location = new Point(12, 53);
            BarracksLabel2.Name = "BarracksLabel2";
            BarracksLabel2.Size = new Size(221, 20);
            BarracksLabel2.TabIndex = 1;
            BarracksLabel2.Text = "I see you are in need of a shield.";
            // 
            // BarracksLabel3
            // 
            BarracksLabel3.AutoSize = true;
            BarracksLabel3.Location = new Point(12, 84);
            BarracksLabel3.Name = "BarracksLabel3";
            BarracksLabel3.Size = new Size(182, 20);
            BarracksLabel3.TabIndex = 2;
            BarracksLabel3.Text = "You may have one of ours,";
            // 
            // BarracksLabel4
            // 
            BarracksLabel4.AutoSize = true;
            BarracksLabel4.Location = new Point(12, 114);
            BarracksLabel4.Name = "BarracksLabel4";
            BarracksLabel4.Size = new Size(198, 20);
            BarracksLabel4.TabIndex = 3;
            BarracksLabel4.Text = "If you complete our training!";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.BarracksPicture;
            pictureBox1.Location = new Point(259, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(252, 205);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(321, 263);
            label5.Name = "label5";
            label5.Size = new Size(129, 20);
            label5.TabIndex = 5;
            label5.Text = "Training Progress :";
            // 
            // TrainingProgressBar
            // 
            TrainingProgressBar.Location = new Point(279, 306);
            TrainingProgressBar.Name = "TrainingProgressBar";
            TrainingProgressBar.Size = new Size(203, 29);
            TrainingProgressBar.TabIndex = 6;
            // 
            // trainingButton
            // 
            trainingButton.Location = new Point(333, 362);
            trainingButton.Name = "trainingButton";
            trainingButton.Size = new Size(94, 29);
            trainingButton.TabIndex = 7;
            trainingButton.Text = "Train!";
            trainingButton.UseVisualStyleBackColor = true;
            trainingButton.Click += trainingButton_Click;
            // 
            // BarracksForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(trainingButton);
            Controls.Add(TrainingProgressBar);
            Controls.Add(label5);
            Controls.Add(pictureBox1);
            Controls.Add(BarracksLabel4);
            Controls.Add(BarracksLabel3);
            Controls.Add(BarracksLabel2);
            Controls.Add(BarracksLabel1);
            Name = "BarracksForm";
            Text = "Barracks";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label BarracksLabel1;
        private Label BarracksLabel2;
        private Label BarracksLabel3;
        private Label BarracksLabel4;
        private PictureBox pictureBox1;
        private Label label5;
        private ProgressBar TrainingProgressBar;
        private Button trainingButton;
    }
}