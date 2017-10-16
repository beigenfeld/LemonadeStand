using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
        //notes

        //member variables
        Random rdm = new Random();
        string rules = "Your goal is to make as much money as you can in 7 days by selling lemonade at your lemonade stand.  Buy cups, lemons, sugar, and ice cubes, then set your recipe based on the weather and conditions. Start with the basic recipe, of 2 lemons and 2 cups of sugar to make a pitcher that serves 5, and 3 ice cubes per cup when served, but try to vary the recipe and see if you can do better. Lastly, the price starts out at $.20 per cup, but try setting your price for the day based on the weather conditions as well.  At the end of each day, you'll see how much money you made. Save it and play again to try and beat your score!";
        public Player player;
        public Store store;
        int numberOfWeeks = 0;
        int weekCounter = 0;//increment after Sunday
        public List<Week> weeks;



        //constructor
        public Game()
        {
            DisplayRules();
            player = new Player();
            store = new Store();
            weeks = new List<Week>();
        }


        //member methods
        void EstablishWeeks(Random rdm)
        {
            for (int j = 1; j <= numberOfWeeks; j++)
            {
                Week week = new Week(rdm);
                weeks.Add(week);
            }
        }

        void DisplayRules()
            {
                Console.WriteLine(rules);
            }
            void CheckForecast()
            {
                //Console.WriteLine("The weather today is expected to be: " + GetWeather());
            }
        //BuySupplies(); //(store, inventory) -> OpenForBusiness (day, weather)
        //
        //
        public void PlayHowLong()
        {
            Console.WriteLine("Play for how many weeks? [1] [2] or [3]");
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    numberOfWeeks = 1;
                    break;
                case "2":
                    numberOfWeeks = 2;
                    break;
                case "3":
                    numberOfWeeks = 3;
                    break;
                default:
                    Console.WriteLine("Prime sales season will be over by then, please select '1' '2' or '3' weeks.");
                    PlayHowLong();
                    break;
            }
        }



        public void LemonyStandsSeriesOfUnfortunateEvents()
            {
                
                PlayHowLong();
                EstablishWeeks(rdm);
                weeks[weekCounter].days[weeks[weekCounter].dayCounter].StartDay(player, store, weeks[weekCounter]);
                weeks[weekCounter].days[weeks[weekCounter].dayCounter].OpenForBusiness(player, weeks[weekCounter]);
                weeks[weekCounter].days[weeks[weekCounter].dayCounter].EndOfDay(player);
                NextDay();
            }

        private void NextDay()
        {

            //if day < [6] increment day
            //StartDay();
            //if day = [6], increment week
            //- increment dayCounter(Week class), if Sunday (dayCounter = [6]), increment the weekCounter(Game class)
            //StartDay();
            //If week = 2 and day = 6,
            //EndGame();
        }













    }
}
