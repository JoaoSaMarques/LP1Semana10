using System;
using System.Collections.Generic;

namespace SamePlayer
{
    class Program
    {
        /// <summary>
        /// Main Program
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Hashset
            HashSet<Player> setOfPlayers = new HashSet<Player>();

            //Player 1
            Player player1 = new Player{Type =PlayerType.Tank, Name ="Ana"};
            //Player 2
            Player player2 = new Player{Type =PlayerType.Slayer, Name ="Paulo"};
            //Player 3
            Player player3 = new Player{Type =PlayerType.Tank, Name ="Ana"};
        }
    }
}

