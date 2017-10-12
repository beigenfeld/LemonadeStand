﻿using System;
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
        string rules = "Your goal is to make as much money as you can in 7 days by selling lemonade at your lemonade stand.  Buy cups, lemons, sugar, and ice cubes, then set your recipe based on the weather and conditions. Start with the basic recipe, but try to vary the recipe and see if you can do better. Lastly, set your price and sell your lemonade at the stand. Try changing up the price based on the weather conditions as well.  At the end of the game, you'll see how much money you made. Write it down and play again to try and beat your score!";
        public Player player;
        public Store store;
        public Week week;
        int numberOfWeeks = 0;
        public List<Week> weeks;



        //constructor
        public Game()
        {
           player = new Player();
           store = new Store();
           //week = new Week();
           weeks = new List<Week>();

        }


        //member methods
        void HowManyWeeks()
        {
            for (int j = 1; j <= numberOfWeeks; j++)
            {
                Week week = new Week();
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
                DisplayRules();
                PlayHowLong();
                HowManyWeeks();
                //week.days[0].StartDay(player, store);
                
            }















    }
}
