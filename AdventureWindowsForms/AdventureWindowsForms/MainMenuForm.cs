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
    public partial class MainMenuForm : Form
    {
        private MainGameForm mainGame;
        public MainMenuForm(MainGameForm mainGame = null)
        {
            InitializeComponent();
            this.mainGame = mainGame;
        }

        private void SaveFilesButton_Click(object sender, EventArgs e)
        {
            SavefilesForm savesForm = new SavefilesForm(mainGame, this);
            savesForm.ShowDialog();
        }

        private void StartNewGameButton_Click(object sender, EventArgs e)
        {
            using (var nameEntryForm = new NameEntryForm())
            {
                if (nameEntryForm.ShowDialog() == DialogResult.OK)
                {
                    string playerName = nameEntryForm.PlayerName;
                    if (!string.IsNullOrEmpty(playerName))
                    {
                        MainGameForm mainGame = new MainGameForm(null, playerName, this);
                        mainGame.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid name.");
                        // Handle empty name if needed
                    }
                }
                else
                {
                    MessageBox.Show("Name entry canceled. Returning to main menu.");
                    // Additional handling when the name entry is canceled
                }
            }
        }

        public void ShowMainMenu()
        {
            this.Show();
        }
    }
}

