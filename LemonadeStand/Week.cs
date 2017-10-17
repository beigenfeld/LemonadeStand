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
        public int dayCounter = 0;
        public List<Day> days;
        
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

        public void DisplayForecast(Week week)
        {
            Console.WriteLine("The forecast this week is:");
            foreach (Day day in days)
            {
                Console.WriteLine(day.dayOfTheWeekName + ": " + day.todaysWeather.weatherName);
            }
        }
    }
}
