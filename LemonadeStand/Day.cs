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
        //DailyWeather
        //daily income
        //cups sold
        //traffic counter

        
        //member variables //HAS A 
        public Weather todaysWeather;
        List<Customer> customerList;
        int dayOfTheWeekNumber;
        public string dayOfTheWeekName;
        int baseTraffic = 100;
        double dayTrafficMultiplier;
        double trafficToday;
        
        //constructor

        //The Day consists of: Creating the weather, (StartDay: ability to check forecast for the day, buy supplies, set your price, **adjust your recipe**, or OpenForBusiness),
        //Open for business generates customers, factoring in the weather, day of the week, and recipe.  
        //If you run out of any item, no more sales can be made that day. CheckForSupplies if(iceOnHand < icePerCup || cupsOnHand = 0)NoMoreSales
        //if (lemonsOnHand < lemonsPerPitcher || sugarOnHand < sugarPerPitcher)EndOfDay
        //EndOfDay will display: traffic count, number of cups sold, total sales, cash on hand, and final inventory.
        public Day(int dayOfWeek,Random rdm)
        {
            GetDay(dayOfWeek);
            todaysWeather = new Weather(rdm);
            customerList = new List<Customer>();
            TodaysTraffic();
            CreateCustomerList(rdm);
        }

        //member methods
        //CheckForecast();
        //GetSupplies();
        //EndOfDay(){display inventory, traffic, sales, cw(All your remaining Ice has melted) iceOnHand = 0;}

        private void CreateCustomerList(Random rdm)
        {
            for (int i=0; i < trafficToday; i++)
            {
                Customer customer = new Customer(rdm);
                customerList.Add(customer);
            }
            
        }
        
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
                    dayTrafficMultiplier = 1.2;
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

        public void StartDay(Player player, Store store, Week week)
        {

            Console.WriteLine("Today is " + dayOfTheWeekName + ", and the weather is going to be " + todaysWeather.weatherName + ". What would you like to do?\n[1] Check this week's Forecast\n[2] Check Inventory\n[3] Buy Supplies\n[4] Adjust Recipe\n[5] Adjust Price\n[6] Sell some Lemonade!");
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    week.DisplayForecast(week);
                    
                    Console.WriteLine("Anything else?");
                    StartDay(player, store, week);
                    break;

                case "2":
                    player.inventory.DisplayInventory();
                    Console.WriteLine("Anything else?");
                    StartDay(player, store, week);
                    break;
                case "3":
                    store.BuySupplies(player);
                    Console.WriteLine("Anything else?");
                    StartDay(player, store, week);
                    break;
                case "4":
                    player.recipe.ChangeRecipe();
                    Console.WriteLine("Anything else?");
                    StartDay(player, store, week);
                    break;
                case "5":
                    player.ChangePrice();
                    Console.WriteLine("Anything else?");
                    StartDay(player, store, week);
                    break;
                case "6":
                    OpenForBusiness(player, week);
                    break;
                default:
                    Console.WriteLine("You want to do what?!  No, no, no.  Focus!  We have a lemonade stand to run!");
                    StartDay(player, store, week);
                    break;
            }
        }

        public void OpenForBusiness(Player player, Week week)
        {
            for (int i = 0; i < customerList.Count; i++)
            {
                customerList[i].WillTheyBuy(player, week);
            }
        }

        public void EndOfDay(Player player)
        {
            Console.WriteLine("The day has come to a close, and it's time to count the till!");
            Console.WriteLine("You had " + customerList.Count + " people walk by your Stand today.");
            Console.WriteLine("You sold" + player.cupsSold + " cups of lemonade today for $" + (player.cupsSold * player.pricePerCup) + " in sales.");
            Console.ReadLine();
            Console.WriteLine("Your remaining Ice has melted");
            player.inventory.iceOnHand = 0;
            Console.ReadLine();
            Console.WriteLine("Here is a list of your remaining inventory:");
            player.inventory.DisplayInventory();
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
        }

        

        private void TodaysTraffic()
        {
            trafficToday = baseTraffic * dayTrafficMultiplier * todaysWeather.weatherTrafficMultiplier;

        }









    }
}
