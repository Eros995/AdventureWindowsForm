namespace AdventureWindowsForms
{
    partial class NameEntryForm
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
            nameTextBox = new TextBox();
            nameLabel = new Label();
            confirmButton = new Button();
            cancelButton = new Button();
            SuspendLayout();
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(106, 107);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(269, 27);
            nameTextBox.TabIndex = 0;
            nameTextBox.KeyPress += nameTextBox_KeyPress;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(138, 68);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(186, 20);
            nameLabel.TabIndex = 1;
            nameLabel.Text = "What is your name Knight?";
            // 
            // confirmButton
            // 
            confirmButton.Location = new Point(266, 168);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new Size(94, 29);
            confirmButton.TabIndex = 2;
            confirmButton.Text = "Confirm";
            confirmButton.UseVisualStyleBackColor = true;
            confirmButton.Click += confirmButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(103, 168);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(94, 29);
            cancelButton.TabIndex = 3;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // NameEntryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(474, 266);
            Controls.Add(cancelButton);
            Controls.Add(confirmButton);
            Controls.Add(nameLabel);
            Controls.Add(nameTextBox);
            Name = "NameEntryForm";
            Text = "NameEntryForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nameTextBox;
        private Label nameLabel;
        private Button confirmButton;
        private Button cancelButton;
    }
}