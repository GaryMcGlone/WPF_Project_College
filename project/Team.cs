using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    public class Team
    {
        public string TeamName { get; set; }
        public List<Player> Players { get; set; }

        public override string ToString()
        {
            return TeamName;
        }

        //Overloading constructors allowing me to just send a player list
        // also allowing to read in a json file
        public Team()
        {
            TeamName = TeamName;
            Players = this.Players;
        }
        public Team(string textboxVal)
        {
            TeamName = textboxVal;
        }
        public Team(List<Player> playerList)
        {
            Players = playerList; 
        }
        public Team(string textboxValue, List<Player> playerList)
        {
            TeamName = textboxValue;
            Players = playerList;
        }
    }
}
