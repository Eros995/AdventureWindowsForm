using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWindowsForms
{
    public class GameManager
    {
        private string playerName;
        private List<string> inventory;

        public GameManager()
        {
            inventory = new List<string>();
            playerName = "";
        }

        public void AddItemToInventory(string item)
        {
            inventory.Add(item);
        }

        public bool HasItem(string item)
        {
            return inventory.Contains(item);
        }

        public void RemoveItemFromInventory(string item)
        {
            inventory.Remove(item);
        }

        public List<string> GetInventory()
        {
            return inventory;
        }

        public void RemoveAllItems()
        {
            inventory.Clear();
        }

        public void AddSword()
        {
            if (!HasItem("Sword"))
            {
                AddItemToInventory("Sword");
            }
        }

        public void AddShield()
        {
            if (!HasItem("Shield"))
            {
                AddItemToInventory("Shield");
            }
        }

        public void AddHorse()
        {
            if (!HasItem("Horse"))
            {
                AddItemToInventory("Horse");
            }
        }

        public void SaveGameState(string filePath, string playerName) // Method to save the game state to a file
        {
            GameState gameState = CollectGameState(playerName);
            string json = JsonConvert.SerializeObject(gameState);
            File.WriteAllText(filePath, json);
        }

        private GameState CollectGameState(string playerName) // Method to collect the current game state
        {
            GameState currentState = new GameState();
            currentState.PlayerName = playerName;
            currentState.Inventory = this.GetInventory(); // Fetch inventory items
            return currentState;
        }

        public string PlayerName
        {
            get { return playerName; }
            set { playerName = value; }
        }

        public void ApplyLoadedGameState(GameState loadedGameState, string playerName) // Method to apply a loaded game state
        {
            if (loadedGameState != null)
            {
                // Update player name
                this.PlayerName = playerName;

                // Clear existing inventory before adding the loaded items
                this.RemoveAllItems();

                // Load items from the loaded game state
                foreach (string item in loadedGameState.Inventory)
                {
                    this.AddItemToInventory(item);
                }
            }
        }


    }
}



       

