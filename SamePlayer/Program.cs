using System;
using System.Collections.Generic;

namespace SamePlayer
{
    //Class
    public enum PlayerType { Tank, Fighter, Slayer, Mage, Controller, Marksmen }

    //Player
    public class Player
    {
        //PlayerType
        public PlayerType Type { get; set; }
        public string Name { get; set; }

        
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Player otherPlayer = (Player)obj;
            return Type == otherPlayer.Type && Name == otherPlayer.Name;
        }

    
    }

}
