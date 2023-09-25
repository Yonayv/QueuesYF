using System;
namespace QueuesYF
{
    internal class Program
    {
        /// <summary>
        /// A game object is made and set to its max players to 50 & current players to 49
        /// a Queue of Player objects is made
        /// 4 Player objects are made, they are given 100 health & a unique gamertag
        /// JoinGame is called on all 4 player objects; passing through the game & queue as arguments
        /// "Players in Queue" is printed to console
        /// The queue is looped through & all the players are printed on a new line
        /// KickPlayer is called on the game
        /// CheckQueue is called on the game
        /// "\nPlayers in Queue" is printed to Console
        /// The queue is looped through and all the players are printed on a new line
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Game myGame = new Game(50, 49);
            
            Queue<Player> waitingToJoinQ = new Queue<Player>();

            Player p1 = new Player(100, "MMSix");
            Player p2 = new Player(100, "xXAwesomenessXx");
            Player p3 = new Player(100, "Get Good");
            Player p4 = new Player(100, "ZombieSlayar");

            p1.JoinGame(myGame, waitingToJoinQ);
            p2.JoinGame(myGame, waitingToJoinQ);
            p3.JoinGame(myGame, waitingToJoinQ);
            p4.JoinGame(myGame, waitingToJoinQ);

            Console.WriteLine("PLayers in da Q:");
            foreach (Player player in waitingToJoinQ)
            {
                Console.WriteLine(player);

            }

            myGame.KickPlayer();
            myGame.CheckQueue(waitingToJoinQ);

            Console.WriteLine("\nPlayers in da Q");
            foreach (Player player in waitingToJoinQ)
            {
                Console.WriteLine(player);
            }
        }
    }
}