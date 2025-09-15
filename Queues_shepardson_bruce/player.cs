using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Queues_shepardson_bruce
{
    // Define an internal class named 'player'
    internal class player
    {
        // Auto-implemented property for the player's health
        public int Health { get; set; }

        // Read-only property for the player's GamerTag (username or display name)
        public string GamerTag { get; }

        // Constructor for the player class that initializes health and GamerTag
        public player(int healthParam, string nameParam)
        {
            Health = healthParam;        // Set initial health
            GamerTag = nameParam;        // Set the player's name/tag
        }

        // Method that allows a player to attempt to join a game
        public void JoinGame(Game game, Queue<player> queue)
        {
            // Check if the game is already full
            if (game.CurrentPlayers == game.MaxPlayers)
            {
                // If full, add the player to the waiting queue
                queue.Enqueue(this);
            }
            else
            {
                // If not full, the player joins the game
                Console.WriteLine("joining Game");
                game.CurrentPlayers++;  // Increment the number of current players
            }
        }

        // Override the ToString method to return the player's GamerTag
        public override string ToString()
        {
            return GamerTag;
        }
    }
}

