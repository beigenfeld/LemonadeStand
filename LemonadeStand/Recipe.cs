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

        int lemonsPerPitcher = 2;
        int sugarPerPitcher = 2;
        int icePerCup = 3;
        int cupsInPitcher;
        //constructor

        
        //number of lemons per pitcher 1, 2, 3, customer preference if 1 and lem/pitcher = 3, "Too strong!", or vice versa, "Too weak!" bump last 3 customers from the list
        //cups of sugar per pitcher 1, 2, 3, customer pref if 1 and sugarPerPitcher = 3, "Too sweet!", or vice versa, "Too tart!"
        //each pitcher serves 5 customers
        //If strength level and sweetness level match exactly, add 1 customer to the end of the list


        //member methods
        public void ChangeRecipe()
        {
            
            Console.WriteLine("Each pitcher will have 5 servings");
            HowManyLemons();
            HowMuchSugar();
            HowMuchIce();
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


        private void MakeNewPitcher(Player player)
        {
            CheckForIngredients(player);
            player.inventory.lemonsOnHand -= lemonsPerPitcher;
            player.inventory.sugarOnHand -= sugarPerPitcher;
            cupsInPitcher = 5;
        }

        private void CheckForIngredients(Player player)
        {
            if (lemonsPerPitcher < player.inventory.lemonsOnHand || sugarPerPitcher < player.inventory.sugarOnHand) //any ingredient in recipe < ingredientOnHand)
            {
                //cw:"You ran short on supplies?" run EndOfDay()
            }
        }




    }
}
