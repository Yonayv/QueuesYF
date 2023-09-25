using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueuesYF
{
    internal class Player
    {
        /// <summary>
        /// Player class is made
        /// A property GamerTag, has an automatic getter, & a string type
        /// A constructor is made it takes one int param & one string param
        /// The parameters are assigned to corresponding properties in the constructor
        /// A public method JoinGame, takes two params Game & Queue<Player>
        /// If the games current players is equal to max players, then add 'this' player to the queue
        /// Else, "Joining Game" is printed & increase current players by 1
        /// ToString method is overriden and return to GamerTag
        /// </summary>
        public int Health { get; set; }

        public string GamerTag { get; }

        public Player(int healthParam, string nameParam)

        {
            Health = healthParam;
            GamerTag = nameParam;
        }

        public void JoinGame(Game game, Queue<Player> queue)
        {
            if(game.CurrentPlayers == game.MaxPlayers)
            {
                queue.Enqueue(this);

            }
            else
            {
                Console.WriteLine("Joining Game!");

            }
        }

        public override string ToString()
        {
            return GamerTag;
        }
    }

}
