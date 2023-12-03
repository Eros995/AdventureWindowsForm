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
    public partial class ForgeForm : Form
    {
        private MainGameForm mainGameForm;
        private GameManager gameManager;
        private int progress = 0;
        public ForgeForm(GameManager gm, MainGameForm mainGame)
        {
            InitializeComponent();
            gameManager = gm;
            mainGameForm = mainGame;
        }

        private void ForgeButton_Click(object sender, EventArgs e)
        {
            progress += 5;
            ForgingProgressBar.Value = progress;

            if (progress >= 100)
            {
                MessageBox.Show("You have successfully forged a Sword!");
                gameManager.AddSword();
                mainGameForm.UpdateInventoryListBox();
                this.Close();
            }
        }
    }
}
