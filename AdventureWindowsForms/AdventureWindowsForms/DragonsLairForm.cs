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
    public partial class DragonsLairForm : Form
    {
        private MainGameForm mainGameForm;
        private GameManager gameManager;
        public DragonsLairForm(GameManager gm, MainGameForm mainGame)
        {
            InitializeComponent();
            gameManager = gm;
            mainGameForm = mainGame;
            DisplayInventory();
        }

        private void fightDragonButton_Click(object sender, EventArgs e)
        {
            if (!gameManager.HasItem("Sword") || !gameManager.HasItem("Shield") || !gameManager.HasItem("Horse"))
            {
                // If the player doesn't have all three items, show defeat message.
                MessageBox.Show("You fought the dragon without all necessary items and were defeated. You lost your items.");

                // Remove all items from the inventory.
                gameManager.RemoveAllItems();
                DisplayInventory();
                mainGameForm.UpdateInventoryListBox();
                // Redirect the player back to the Main game.
                this.Hide();
            }
            else
            {
                MessageBox.Show("You successfully fought and defeated the dragon!");
                this.Hide();  
            }
        }

        private void speakWithDragonButton_Click(object sender, EventArgs e)
        {
            if (gameManager.HasItem("Sword") && gameManager.HasItem("Shield") && gameManager.HasItem("Horse"))
            {
                MessageBox.Show("You try to talk to the dragon, but it feels too threatened by your power...");
            }
            else
            {
                MessageBox.Show("You talk to the dragon and peacefully resolve the situation. The dragon returns the princess and you save the kingdom!");
                this.Hide();
            }

        }
        private void DisplayInventory()
        {
            List<string> inventory = gameManager.GetInventory();

            inventoryListBox.DataSource = inventory;
        }
    }
}
