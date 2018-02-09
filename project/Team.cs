using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    public class Team
    {
        public string TeamName { get; set; }
        public ObservableCollection<Player> Players { get; set; }

        public override string ToString()
        {
            return TeamName;
        }

        //Overloading constructors allowing me to just send a player list
        // also allowing to read in a json file
        public Team()
        {
            TeamName = TeamName;
        }
        public Team(string textboxVal)
        {
            TeamName = textboxVal;
        }
        public Team(ObservableCollection<Player> players)
        {
            Players = players; 
        }
        public Team(string textboxValue, ObservableCollection<Player> players)
        {
            TeamName = textboxValue;
            Players = players;
        }
    }
}
