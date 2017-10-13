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


        //member variables //HAS A 
        public Weather todaysWeather;
        //List of Customers
        int dayOfTheWeekNumber;
        string dayOfTheWeekName;
        int baseTraffic = 100;
        double dayTrafficMultiplier;
        double trafficToday;
        int cupsSold = 0;
        //constructor

        //The Day consists of: Creating the weather, (StartDay: ability to check forecast for the day, buy supplies, set your price, **adjust your recipe**, or OpenForBusiness),
        //Open for business generates customers, factoring in the weather, day of the week, and recipe.  
        //If you run out of any item, no more sales can be made that day. CheckForSupplies if(iceOnHand < icePerCup || cupsOnHand = 0)NoMoreSales
        //if (lemonsOnHand < lemonsPerPitcher || sugarOnHand < sugarPerPitcher)NoMoreSales
        //EndOfDay will display: traffic count, number of cups sold, total sales, cash on hand, and final inventory.
        public Day(int dayOfWeek,Random rdm)
        {
            GetDay(dayOfWeek);
            todaysWeather = new Weather(rdm);

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

            Console.WriteLine("Today is " + dayOfTheWeekName + ". What would you like to do?\n[1] Check Today's Forecast\n[2] Check Inventory\n[3] Buy Supplies\n[4] Adjust Recipe\n[5] Adjust Price");
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    //CheckForecast();
                    Console.WriteLine("The forecast this week is: " + todaysWeather);
                    break;

                case "2":
                    player.inventory.DisplayInventory();
                    break;
                case "3":
                    store.BuySupplies(player);
                    break;
                case "4":
                    player.recipe.ChangeRecipe();
                    break;
                case "5":
                    player.SetPrice();
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

        //private void EndOfDay()
        //{
        //    Console.WriteLine("The day has come to a close, and it's time to count the till!");
        //    Console.WriteLine("You sold" + cupsSold + " cups of lemonade today for $" +(cupsSold * pricePerCup) + " in sales.");
        //    Console.WriteLine("Your remaining Ice has melted");
        //    iceOnHand = 0;
        //    Console.WriteLine("Here is a list of your remaining inventory:");
        //    DisplayInventory();
        //    //display stats
        //    //NextDay() - increment dayCounter(Week class), if Sunday, increment the weekCounter(Game class)
        //    //
        //}

        private void TodaysTraffic()
        {
            
            trafficToday = baseTraffic * dayTrafficMultiplier * todaysWeather.weatherTrafficMultiplier;
        }









    }
}
