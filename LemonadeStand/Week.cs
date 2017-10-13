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
        public int dayCounter = 0;

        public List<Day> days;
        
        //int numberOfWeeks;
        //constructor
        public Week(Random rdm)
        {
            days = new List<Day>();
            CreateWeek(rdm);
        }

        //member methods
        void CreateWeek(Random rdm)
        {
            for (int i = 1; i <= 7; i++)
            {
                Day day = new Day(i, rdm);
                days.Add(day);
                
            }

        }











    }
}
