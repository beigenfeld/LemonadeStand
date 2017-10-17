using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Recipe
    {
        //member variables
        public int lemonsPerPitcher = 2;
        public int sugarPerPitcher = 2;
        public int icePerCup = 2;

        //constructor
        public Recipe()
        {

        }
        //member methods
        public void ChangeRecipe()
        {
            DisplayCurrentRecipe();
            Console.WriteLine("Each pitcher will have 5 servings");
            HowManyLemons();
            HowMuchSugar();
            HowMuchIce();
        }

        private void DisplayCurrentRecipe()
        {
            Console.WriteLine("Your current recipe is:");
            Console.WriteLine("Lemons per pitcher: " + lemonsPerPitcher);
            Console.WriteLine("Cups of Sugar per pitcher: " + sugarPerPitcher);
            Console.WriteLine("Ice cubes per Cup: " + icePerCup);
        }

        void HowManyLemons()
        {
            Console.WriteLine("How many Lemons would you like to use per pitcher? [1] [2] or [3]");
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    lemonsPerPitcher = 1;
                    break;
                case "2":
                    lemonsPerPitcher = 2;
                    break;
                case "3":
                    lemonsPerPitcher = 3;
                    break;
                default:
                    Console.WriteLine("Come on, this is serious business, how many Lemons?  Type in '1' '2' or '3'");
                    HowManyLemons();
                    break;
            }
        }

        private void HowMuchSugar ()
        {
            Console.WriteLine("How many cups of Sugar would you like to use in each pitcher? [1] [2] or [3]");
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    sugarPerPitcher = 1;
                    break;
                case "2":
                    sugarPerPitcher = 2;
                    break;
                case "3":
                    sugarPerPitcher = 3;
                    break;
                default:
                    Console.WriteLine("Come on, this is serious business, how much Sugar?  Type in '1' '2' or '3'");
                    HowMuchSugar();
                    break;
            }
        }

        private void HowMuchIce()
        {
            Console.WriteLine("How many cubes of Ice would you like to use in each cup? [1] [2] or [3]");
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    icePerCup = 1;
                    break;
                case "2":
                    icePerCup = 2;
                    break;
                case "3":
                    icePerCup = 3;
                    break;
                default:
                    Console.WriteLine("Come on, this is serious business, how much Ice?  Type in '1' '2' or '3'");
                    HowMuchIce();
                    break;
            }
        }
    }
}
