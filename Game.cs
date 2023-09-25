using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueuesYF
{
    internal class Game
    {
        /// <summary>
        /// Game class is made
        /// Property MaxPlayers has a automatic getter
        /// Property CurrentPlayers has a automatic getter & setter
        /// A Constructor is made that takes the two ints. maxPlayers & CurrentPlayers
        /// the params are assigned to corresponding properties in the constructor
        /// KickPlayer method is in the body decrement CurrentPlayers by 1
        /// CheckQueue method takes a Queue<Player> param.
        /// If CurrentPlayers is less than MaxPlayers, then the queue is check for elements in it
        /// If the queue has players in it then the Dequeue is called on the queue & increment current players by 1. Else, print "No Players in the Queue!"
        /// </summary>
        public int MaxPlayers { get; }

        public int CurrentPlayers { get; set; }

        public Game(int maxP, int currentP)
        {
            MaxPlayers = maxP;
            CurrentPlayers = currentP;

        }

        public void KickPlayer()
        {
            CurrentPlayers--;

        }

        public void CheckQueue(Queue<Player> playerQueue)
        {
            if(CurrentPlayers < MaxPlayers)
            {
                if (playerQueue.Count > 0)
                {
                    playerQueue.Dequeue();
                    CurrentPlayers++;
                }

                else
                {
                    Console.WriteLine("No Players in the queue!");
                }
            }
        }
    }
}
