using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdventureWindowsForms
{
    public partial class MainGameForm : Form
    {
        public string selectedFileName;
        private MainMenuForm mainMenu;
        private SavefilesForm savesForm;
        public string playerName = "";
        private GameManager gameManager;
        public MainGameForm(string selectedFileName, string playerName, MainMenuForm mainMenu, bool showWelcomeMessage = true)
        {
            InitializeComponent();
            this.mainMenu = mainMenu;
            this.mainMenu.Hide();
            this.selectedFileName = selectedFileName;
            savesForm = new SavefilesForm(this, mainMenu); 
            this.playerName = playerName; 
            gameManager = new GameManager();
            gameManager.PlayerName = this.playerName; 
            UpdateInventoryListBox();

            if (string.IsNullOrEmpty(this.playerName))
            {
                MessageBox.Show("Player name is missing. Returning to the main menu.");
                this.Close(); // Close the form if playerName is missing
            }
            else if (showWelcomeMessage) // Check if the welcome message should be shown
            {
                playerLabel.Text = $"Knight: {this.playerName}"; // Update the label with the player's name
                MessageBox.Show($"Welcome, {this.playerName}!");
                // Proceed with the game using playerName
            }

        }

        public void UpdateInventoryListBox() // This updates the inventory list box with the current inventory.
        {
            List<string> inventory = gameManager.GetInventory();
            inventoryListBox.DataSource = null;
            inventoryListBox.DataSource = inventory;
        }

        private void StableButton_Click_1(object sender, EventArgs e) 
        {
            if (!gameManager.HasItem("Horse"))
            {
                StableForm stable = new StableForm(gameManager, this);
                stable.ShowDialog();
            }
            else
            {
                MessageBox.Show("You already have a horse. There's nothing more to get from here.");
            }
        }

        private void ForgeButton_Click(object sender, EventArgs e)
        {
            if (!gameManager.HasItem("Sword"))
            {
                ForgeForm forge = new ForgeForm(gameManager, this);
                forge.ShowDialog();
            }
            else
            {
                MessageBox.Show("You already have a sword. There's nothing more to get from here.");
            }
        }

        private void BarracksButton_Click(Object sender, EventArgs e)
        {
            if (!gameManager.HasItem("Shield"))
            {
                BarracksForm barracks = new BarracksForm(gameManager, this);
                barracks.ShowDialog();
            }
            else
            {
                MessageBox.Show("You already have a shield. There's nothing more to get from here.");
            }
        }

        private void DragonsLairButton_Click(object sender, EventArgs e)
        {
            DragonsLairForm dragons = new DragonsLairForm(gameManager, this);
            dragons.ShowDialog();
        }

        private void returnToStartMenuButton_Click(object sender, EventArgs e)
        {
            mainMenu.ShowMainMenu(); 
            this.Hide();
        }

        private void saveProgressbutton_Click(object sender, EventArgs e)
        {
            GameState gameState = CollectGameState();
            string saveFolder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string saveFilePath = Path.Combine(saveFolder, $"{gameState.PlayerName}_savefile.json");
            gameManager.SaveGameState(saveFilePath, gameState.PlayerName); 
            UpdateSaveFilesList();
            MessageBox.Show("Game progress saved successfully!");
        }
        public string PlayerName
        {
            get { return playerName; }
            set { playerName = value; }
        }

        private GameState CollectGameState() // Method to collect the current game state
        {
            GameState gameState = new GameState();
            gameState.PlayerName = playerName;
            gameState.Inventory = gameManager.GetInventory(); 
            return gameState;
        }

        public void LoadGameStateFromFile(string filePath, string playerName) // Method to load the game state from a file
        {
            if (File.Exists(filePath))
            {
                try
                {
                    string json = File.ReadAllText(filePath);
                    GameState loadedGameState = JsonConvert.DeserializeObject<GameState>(json);
                    gameManager.ApplyLoadedGameState(loadedGameState, playerName);
                    this.playerName = playerName;
                    playerLabel.Text = $"Knight: {playerName}";
                    UpdateInventoryListBox();
                    MessageBox.Show("Game progress loaded successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading game progress: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show($"Save file not found at path: {filePath}");
            }
        }

        private void UpdateSaveFilesList() // Method to update the list of saved files in SavefilesForm
        {
             savesForm.LoadSavedFiles(); 
        }

        private void MainGameForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                mainMenu.Show();
            }
        }

        private void throwAwayItemsButton_Click(object sender, EventArgs e)
        {
            if (gameManager.GetInventory().Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to throw away all your items?", "Confirm Discard",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    gameManager.RemoveAllItems(); // Remove all items from inventory
                    UpdateInventoryListBox(); // Update the inventory display
                    MessageBox.Show("You have thrown away all your items.");
                }
            }
            else
            {
                MessageBox.Show("You don't have any items to throw away.");
            }
        }
    }
}

