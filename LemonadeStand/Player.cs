using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Player
    {
        //notes
        // instantiate Recipe recipe = new Recipe(); somewhere in this class

        //member variables
        string name;
        public Inventory inventory;
        public Store store;
        public Recipe recipe;
        double pricePerCup = .2;
        int frugalityTrigger = 9;
        int cupsInPitcher;

        //constructor
        public Player()
        {
            GetName();
            inventory = new Inventory();
            store = new Store();
            recipe = new Recipe();
        }

        //member methods
        void GetName ()
        {
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
        }

        private void MakeSale(Player player)
        {
            if (cupsInPitcher != 0)
            {
                
                cupsInPitcher -= 1;
                player.inventory.cupsOnHand -= 1;
                player.inventory.iceOnHand -= player.recipe.icePerCup;
                player.inventory.cashOnHand += pricePerCup;
                week.day.cupsSold++;
            }
            else
            {
                CheckForIngredients(player);
                MakeNewPitcher(player);
                MakeSale();
            }
        }

        private void CheckForIngredients(Player player)
        {
            if (player.inventory.lemonsOnHand < player.recipe.lemonsPerPitcher || player.inventory.sugarOnHand < player.recipe.sugarPerPitcher)
            {
                Console.WriteLine("You dont have enough materials to make a new pitcher!  You must close for the day.");
                week.day.EndOfDay();
            }
        }

        public void MakeNewPitcher(Player player)
        {
            inventory.lemonsOnHand -= recipe.lemonsPerPitcher;
            inventory.sugarOnHand -= recipe.sugarPerPitcher;
            cupsInPitcher = 5;
        }

        public void ChangePrice()
        {
            Console.WriteLine("How much per cup will you charge today?");
            Console.WriteLine("[1] $.10  [2] $.20  [3] $.30  [4] $.40  [5] $.50");
            Console.WriteLine("[6] $.60  [7] $.70  [8] $.80  [9] $.90  [10] $1.00");
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    pricePerCup = .1;
                    frugalityTrigger = 10;
                    break;
                case "2":
                    pricePerCup = .2;
                    frugalityTrigger = 9;
                    break;
                case "3":
                    pricePerCup = .3;
                    frugalityTrigger = 8;
                    break;
                case "4":
                    pricePerCup = .4;
                    frugalityTrigger = 7;
                    break;
                case "5":
                    pricePerCup = .5;
                    frugalityTrigger = 6;
                    break;
                case "6":
                    pricePerCup = .6;
                    frugalityTrigger = 5;
                    break;
                case "7":
                    pricePerCup = .7;
                    frugalityTrigger = 4;
                    break;
                case "8":
                    pricePerCup = .8;
                    frugalityTrigger = 3;
                    break;
                case "9":
                    pricePerCup = .9;
                    frugalityTrigger = 2;
                    break;
                case "10":
                    pricePerCup = 1;
                    frugalityTrigger = 1;
                    break;
                default:
                    Console.WriteLine("Come on, this is serious business, how much are you charging today?");
                    ChangePrice();
                    break;

            }
        }


    }
}
