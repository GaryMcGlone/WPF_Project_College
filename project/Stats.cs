using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    public class Stats
    {
        //Instanciating the Random object so I can generate random stats for players
        Random r = new Random();

        public int JerseyNumber { get; set; }

        //GAME STATS USING THE getGameStats METHOD
        public int Appearances { get; set; }
        public int Goals { get; set; }
        public int Assists { get; set; }
        //END OF GAME STATS

        public decimal Value { get; set; }

        //Randomly calculating the DOB and the Age 
        //Once you get the DOB it then calculates the Age based off that dob
        public DateTime DOB { get; set; }
        public int Age { get; set; }
        

        public Stats()
        {
            JerseyNumber = this.GetJerseyNum();
            Appearances = this.GetGameStats();
            Assists = this.GetGameStats();
            Goals = this.GetGameStats();
            Value = this.GetValue();
            DOB = this.GetDOB();
            Age = this.GetAge();
        }
        public override string ToString()
        {
            return string.Format("Jersey Number - {0} \nAppearances - {1} \nGoals - {2} \nAssists - {3} \nValue - €{4}M \nDate of Birth - {5} \nAge - {6}", JerseyNumber, Appearances, Goals, Assists, Value, DOB.ToShortDateString(), Age);
        }
        public int GetJerseyNum()
        {
            const int MIN = 1, MAX = 99;
            int jerseyNum = r.Next(MIN, MAX);
            return jerseyNum;
        }
        public int GetGameStats()
        {
            const int MIN = 1, MAX = 500;
            int allStats = r.Next(MIN, MAX);
            return allStats;
        }
        public DateTime GetDOB()
        {
            const int OLDEST_AGE = 45, YOUNGEST_AGE = 17;

            DateTime currentDate = DateTime.Today;
            DateTime startDate = currentDate.AddYears(-OLDEST_AGE);
            DateTime endDate = currentDate.AddYears(-YOUNGEST_AGE);
            TimeSpan timeSpan = endDate - startDate;
            TimeSpan newSpan = new TimeSpan(0, r.Next(0, (int)timeSpan.TotalMinutes), 0);
            DateTime newDate = startDate + newSpan;

            return newDate;
        }
        public decimal GetValue()
        {
            const int LOWVAL = 1, HIGHVAL = 100;
            decimal value = r.Next(LOWVAL, HIGHVAL);
            return value;
        }
        public int GetAge()
        {
            int age;
            DateTime today = DateTime.Now;
            return age = today.Year - DOB.Year;
        }
    }
}
