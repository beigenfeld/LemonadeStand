using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Day
    {
        //notes
        //Day [i] 1-7
        //DailyWeather
        //
        //daily income
        //cups sold
        //traffic counter
        //base traffic 
        //running total


        //member variables
        public Weather todaysWeather;

        int dayOfTheWeekNumber;
        string dayOfTheWeekName;
        int baseTraffic = 100;
        double dayTrafficMultiplier;
        //constructor
        public Day()
        {
            todaysWeather = new Weather();
        }

        //member methods
        //CheckForecast();
        //GetSupplies();
        //EndOfDay(){display inventory, traffic, sales, cw(All your remaining Ice has melted) iceOnHand = 0;}
        
        public void StartDay()
        {
            
            Console.WriteLine("Today is " + dayOfTheWeekName + ". What would you like to do?\n[1] Check Today's Forecast\n[2] Buy Supplies\n[3] ");
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":

                    break;
                case "2":
                    //CheckForecast();
                    Console.WriteLine("Today's weather will be: " + todaysWeather);
                    break;
                case "3":
                    store.BuySupplies();
                    break;
                default:
                    Console.WriteLine("You want to do what?!  No, no, no.  Focus!  We have a lemonade stand to run!");
                    StartDay();
                    break;
            }
        }
        
        //nested loops to play multiple weeks
        void Monday()
        {
            dayOfTheWeekNumber = 1;
            dayOfTheWeekName = "Monday";
            dayTrafficMultiplier = .8;
        }

        void Tuesday()
        {
            dayOfTheWeekNumber = 2;
            dayOfTheWeekName = "Tuesday";
            dayTrafficMultiplier = .9;

        }
        void Wednesday()
        {
            dayOfTheWeekNumber = 3;
            dayOfTheWeekName = "Wednesday";
            dayTrafficMultiplier = 1;
        }

        void Thursday()
        {
            dayOfTheWeekNumber = 4;
            dayOfTheWeekName = "Thursday";
            dayTrafficMultiplier = 1.1;
        }

        void Friday()
        {
            dayOfTheWeekNumber = 5;
            dayOfTheWeekName = "Friday";
            dayTrafficMultiplier = 1.6;
        }

        void Saturday()
        {
            dayOfTheWeekNumber = 6;
            dayOfTheWeekName = "Saturday";
            dayTrafficMultiplier = 1.8;
        }

        void Sunday()
        {
            dayOfTheWeekNumber = 7;
            dayOfTheWeekName = "Sunday";
            dayTrafficMultiplier = 1.4;
        }
    }
}
