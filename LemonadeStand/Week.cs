using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Week
    {
        //member variables //a Week HAS A Day
        //weeklyForecast list
        //weatherMonday
        //weatherTuesday
        //weatherWednesday
        //weatherThursday
        //weatherFriday
        //weatherSaturday
        //weatherSunday
        public List<Day> days;
        
        //int numberOfWeeks;
        //constructor
        public Week()
        {
            days = new List<Day>();
            CreateWeek();
        }

        //member methods
        void CreateWeek()
        {
            for (int i = 1; i <= 7; i++)
            {
                Day day = new Day(i);
                days.Add(day);
            }

        }











    }
}
