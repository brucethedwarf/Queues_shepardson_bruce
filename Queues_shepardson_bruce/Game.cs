using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Queues_shepardson_bruce
{
    // Internal class 'Game' - accessible only within the same assembly
    internal class Game
    {
        // Property to store the maximum number of players allowed in the game
        public int MaxPlayers { get; }

        // Property to store the current number of players in the game
        public int CurrentPlayers { get; set; }

        // Constructor to initialize the MaxPlayers and CurrentPlayers properties
        public Game(int MaxP, int currentP)
        {
            MaxPlayers = MaxP;
            CurrentPlayers = currentP;
        }

        // Method to remove a player from the game (decrement current players)
        public void KickPlayer()
        {
            CurrentPlayers--;  // Decrease the current player count by one
        }

        // Method to check if there's space in the game and add players from the queue
        public void CheckQueue(Queue<player> playerQueue)
        {
            // Only add a player if the game isn't full
            if (CurrentPlayers < MaxPlayers)
            {
                // Check if there are players waiting in the queue
                if (playerQueue.Count > 0)
                {
                    playerQueue.Dequeue(); // Remove the player from the front of the queue
                    CurrentPlayers++;      // Add one to the current player count
                }
                else
                {
                    // If no players are in the queue, output a message
                    Console.WriteLine("No players in the queue");
                }
            }
        }
    }
}
