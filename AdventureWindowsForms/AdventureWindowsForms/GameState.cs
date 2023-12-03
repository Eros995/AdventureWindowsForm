using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWindowsForms
{
    public class GameState
    {
        public string PlayerName { get; set; }  // Represents the name of the player in the game
        public List<string> Inventory { get; set; } // Represents the inventory of the player, containing a list of items 
    }

    
}
