namespace Queues_shepardson_bruce
{ using System.Collections.Generic; 
    internal class Program
    {
        static void Main(string[] args)
        {   // Create a new game instance with capacity parameters (e.g., maxPlayers = 50, currentPlayers
            Game myGame = new Game(50, 49);

            // Create a queue to hold players who are waiting to join the game
            Queue<player> waitingToJoinQ = new Queue<player>();

            // Instantiate player objects with health = 100 and a unique username
            player p1 = new player (100,"MMsix");
            player p2 = new player(100, "xXAwsomenessXx");
            player p3 = new player(100, "Get good");
            player p4 = new player(100, "ZombieSlaya");
            // Each player attempts to join the game; if game is full, they are added to the waiting queue
            p1.JoinGame(myGame, waitingToJoinQ);
            p2.JoinGame(myGame, waitingToJoinQ);
            p3.JoinGame(myGame, waitingToJoinQ);
            p4.JoinGame(myGame, waitingToJoinQ);
            // Print out the current players in the waiting queue
            Console.WriteLine("Players in da Q");
             foreach (player player in waitingToJoinQ) 
             {
                Console.WriteLine(player);
             }
            // Simulate kicking a player from the game (e.g., to make space for a waiting player)
            myGame.KickPlayer();

            // Check the waiting queue and try to add any waiting players to the game
            myGame.CheckQueue(waitingToJoinQ);
            // Print the updated queue after one player may have been added to the game
            Console.WriteLine("\nPlayers in da Q");
            foreach (player player in waitingToJoinQ)
            {
                Console.WriteLine(player);
            }



        }
    }
}