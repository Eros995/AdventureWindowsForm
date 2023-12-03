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
    public partial class BarracksForm : Form
    {
        private MainGameForm mainGameForm;
        private GameManager gameManager;
        private int progress = 0;
        public BarracksForm(GameManager gm, MainGameForm mainGame)
        {
            InitializeComponent();
            gameManager = gm;
            mainGameForm = mainGame;
        }

        private void trainingButton_Click(object sender, EventArgs e) 
        {
            progress += 5;
            TrainingProgressBar.Value = progress;

            if (progress >= 100)
            {
                MessageBox.Show("You have successfully completed your training and earned your shield!");
                gameManager.AddShield();
                mainGameForm.UpdateInventoryListBox();
                this.Close();
            }
        }
    }
}
