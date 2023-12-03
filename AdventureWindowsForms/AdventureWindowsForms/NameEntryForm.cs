using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdventureWindowsForms
{
    public partial class NameEntryForm : Form
    {
        public string PlayerName { get; set; }
        public NameEntryForm()
        {
            InitializeComponent();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            PlayerName = nameTextBox.Text.Trim(); 
            if (!string.IsNullOrWhiteSpace(PlayerName))
            {
                DialogResult = DialogResult.OK; 
            }
            else
            {
                MessageBox.Show("Please enter a valid name.");
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void nameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
            {
                e.Handled = true;
                MessageBox.Show("Please enter only characters (letters and spaces).");
            }
        }
    
    }
}
