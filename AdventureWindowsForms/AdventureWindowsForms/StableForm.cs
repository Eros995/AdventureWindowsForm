using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AdventureWindowsForms
{
    public partial class StableForm : Form
    {
        private MainGameForm mainGameForm;
        private GameManager gameManager;
        private int progress = 0;
        public StableForm(GameManager gm, MainGameForm mainGame)
        {
            InitializeComponent();
            gameManager = gm;
            mainGameForm = mainGame;
        }

        private void TamingButton_Click(object sender, EventArgs e)
        {
            progress += 5;
            TamingProgressBar.Value = progress;

            if (progress >= 100)
            {
                MessageBox.Show("You have successfully tamed the horse!");
                gameManager.AddHorse();
                mainGameForm.UpdateInventoryListBox();
                this.Close();
            }
        }
    }
}
