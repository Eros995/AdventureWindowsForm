namespace AdventureWindowsForms
{
    partial class StableForm
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
            pictureBox1 = new PictureBox();
            TamingButton = new Button();
            TamingProgressBar = new ProgressBar();
            Stablelabel1 = new Label();
            Stablelabel2 = new Label();
            Stablelabel3 = new Label();
            Stablelabel4 = new Label();
            TamingLabelText = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.StablePicture;
            pictureBox1.Location = new Point(252, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(329, 221);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // TamingButton
            // 
            TamingButton.Location = new Point(361, 356);
            TamingButton.Name = "TamingButton";
            TamingButton.Size = new Size(94, 29);
            TamingButton.TabIndex = 1;
            TamingButton.Text = "Tame";
            TamingButton.UseVisualStyleBackColor = true;
            TamingButton.Click += TamingButton_Click;
            // 
            // TamingProgressBar
            // 
            TamingProgressBar.Location = new Point(310, 305);
            TamingProgressBar.Name = "TamingProgressBar";
            TamingProgressBar.Size = new Size(200, 29);
            TamingProgressBar.TabIndex = 2;
            // 
            // Stablelabel1
            // 
            Stablelabel1.AutoSize = true;
            Stablelabel1.Location = new Point(12, 33);
            Stablelabel1.Name = "Stablelabel1";
            Stablelabel1.Size = new Size(164, 20);
            Stablelabel1.TabIndex = 3;
            Stablelabel1.Text = "Welcome to the Stable!";
            // 
            // Stablelabel2
            // 
            Stablelabel2.AutoSize = true;
            Stablelabel2.Location = new Point(12, 53);
            Stablelabel2.Name = "Stablelabel2";
            Stablelabel2.Size = new Size(138, 20);
            Stablelabel2.TabIndex = 4;
            Stablelabel2.Text = "If you need a horse,";
            // 
            // Stablelabel3
            // 
            Stablelabel3.AutoSize = true;
            Stablelabel3.Location = new Point(12, 73);
            Stablelabel3.Name = "Stablelabel3";
            Stablelabel3.Size = new Size(214, 20);
            Stablelabel3.TabIndex = 5;
            Stablelabel3.Text = "You've come to the right place!";
            // 
            // Stablelabel4
            // 
            Stablelabel4.AutoSize = true;
            Stablelabel4.Location = new Point(-3, 93);
            Stablelabel4.Name = "Stablelabel4";
            Stablelabel4.Size = new Size(249, 20);
            Stablelabel4.TabIndex = 6;
            Stablelabel4.Text = "However.. You must tame it yourself!";
            // 
            // TamingLabelText
            // 
            TamingLabelText.AutoSize = true;
            TamingLabelText.Location = new Point(345, 271);
            TamingLabelText.Name = "TamingLabelText";
            TamingLabelText.Size = new Size(124, 20);
            TamingLabelText.TabIndex = 7;
            TamingLabelText.Text = "Taming Progress :";
            // 
            // StableForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TamingLabelText);
            Controls.Add(Stablelabel4);
            Controls.Add(Stablelabel3);
            Controls.Add(Stablelabel2);
            Controls.Add(Stablelabel1);
            Controls.Add(TamingProgressBar);
            Controls.Add(TamingButton);
            Controls.Add(pictureBox1);
            Name = "StableForm";
            Text = "Stable";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button TamingButton;
        private ProgressBar TamingProgressBar;
        private Label Stablelabel1;
        private Label Stablelabel2;
        private Label Stablelabel3;
        private Label Stablelabel4;
        private Label TamingLabelText;
    }
}