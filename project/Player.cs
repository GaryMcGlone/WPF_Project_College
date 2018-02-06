using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    //should be abstract but when its abstract I cant read in the json file
    public class Player : IComparable
    {
        public string Name { get; set; }
        public string PlayerType { get; set; }
        public Stats PlayerStats { get; set; }

        public int CompareTo(object obj)
        {
            Player temp = (Player)obj;
            return String.Compare(this.Name, temp.Name);
        }
        public override string ToString()
        {
            return string.Format("{0}", Name);
        }
    }
    class Starter : Player
    {
        public Starter()
        {
            Name = this.Name;
            PlayerType = this.PlayerType;
            PlayerStats = this.PlayerStats;
        }
        public Starter(string textboxVal, Stats Stats)
        {
            Name = textboxVal;
            PlayerType = GetType().Name;
            PlayerStats = Stats;
        }
        public override string ToString()
        {
            return string.Format("{0} - {1}", base.ToString(), PlayerType);
        }
    }
    class Substitute : Player
    {
        public Substitute()
        {
            Name = this.Name;
            PlayerType = this.PlayerType;
            PlayerStats = this.PlayerStats;
        }
        public Substitute(string textboxVal, Stats Stats)
        {
            Name = textboxVal;
            PlayerType = GetType().Name;
            PlayerStats = Stats;
        }
        public override string ToString()
        {
            return string.Format("{0} - {1}", base.ToString(), PlayerType);
        }
    }
}
