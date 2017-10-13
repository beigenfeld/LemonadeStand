using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Day //: IS A (AND HAS UNIQUE QUALITIES)
    {
        //notes
        //Weeks [j] 1-3 
        //Day [i] 1-7
        //DailyWeather
        //
        //daily income
        //cups sold
        //traffic counter
        //base traffic 
        //running total


        //member variables //HAS A 
        public Weather todaysWeather;

        int dayOfTheWeekNumber;
        string dayOfTheWeekName;
        int baseTraffic = 100;
        double dayTrafficMultiplier;
        //constructor

        //The Day consists of: Creating the weather, (StartDay: ability to check forecast for the day, buy supplies, set your price, **adjust your recipe**, or OpenForBusiness),
        //Open for business generates customers, factoring in the weather, day of the week, and **recipe**.  
        //If you run out of any item, no more sales can be made that day. CheckForSupplies if(iceOnHand < icePerCup || cupsOnHand = 0)NoMoreSales
        //if (lemonsOnHand < lemonsPerPitcher || sugarOnHand < sugarPerPitcher)NoMoreSales
        //EndOfDay will display: traffic count, number of cups sold, total sales, cash on hand, and final inventory.
        public Day(int dayOfWeek)
        {
            GetDay(dayOfWeek);
            todaysWeather = new Weather();

        }

        //member methods
        //CheckForecast();
        //GetSupplies();
        //EndOfDay(){display inventory, traffic, sales, cw(All your remaining Ice has melted) iceOnHand = 0;}

        
        
        void GetDay(int dayOfWeek)
        {
            switch (dayOfWeek)
            {
                case 1:
                    dayOfTheWeekNumber = 1;
                    dayOfTheWeekName = "Monday";
                    dayTrafficMultiplier = .8;

                    break;

                case 2:
                    dayOfTheWeekNumber = 2;
                    dayOfTheWeekName = "Tuesday";
                    dayTrafficMultiplier = .9;
                    break;

                case 3:
                    dayOfTheWeekNumber = 3;
                    dayOfTheWeekName = "Wednesday";
                    dayTrafficMultiplier = 1;
                    break;

                case 4:
                    dayOfTheWeekNumber = 4;
                    dayOfTheWeekName = "Thursday";
                    dayTrafficMultiplier = 1.1;
                    break;

                case 5:
                    dayOfTheWeekNumber = 5;
                    dayOfTheWeekName = "Friday";
                    dayTrafficMultiplier = 1.6;
                    break;

                case 6:
                    dayOfTheWeekNumber = 6;
                    dayOfTheWeekName = "Saturday";
                    dayTrafficMultiplier = 1.8;
                    break;

                case 7:
                    dayOfTheWeekNumber = 7;
                    dayOfTheWeekName = "Sunday";
                    dayTrafficMultiplier = 1.4;
                    break;
            }

        }

        public void StartDay(Player player, Store store)
        {

            Console.WriteLine("Today is " + dayOfTheWeekName + ". What would you like to do?\n[1] Check Today's Forecast\n[2] Buy Supplies\n[3] Adjust Recipe");
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    //CheckForecast();
                    Console.WriteLine("The forecast this week is: " + todaysWeather);
                    break;

                case "2":
                    store.BuySupplies(player);
                    break;
                case "3":

                    break;
                default:
                    Console.WriteLine("You want to do what?!  No, no, no.  Focus!  We have a lemonade stand to run!");
                    StartDay(player, store);
                    break;
            }
        }

        private void OpenForBusiness()
        {
            //Generate customer hoard
            //WillTheyBuy() foreach loop
            
        }

        private void EndOfDay()
        {
            //display stats
            //NextDay() - move to the next index on the List, if Sunday, move to the next List
        }




    }
}
