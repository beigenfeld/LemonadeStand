using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Week
    {
        //member variables
        //weeklyForecast list
        //weatherMonday
        //weatherTuesday
        //weatherWednesday
        //weatherThursday
        //weatherFriday
        //weatherSaturday
        //weatherSunday
        public Day day;
        //constructor
        public Week()
        {
            day = new Day();
            GetWeeklyForecast();
        }

        //member methods
        void GetWeeklyForecast()
        {
            //GetWeather 7 times, assign to each day
        }
    }
}
