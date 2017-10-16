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
        

        //member variables
        string name;
        public Inventory inventory;
        public Store store;
        public Recipe recipe;
        public double pricePerCup = .2;
        public int cupsSold = 0;
        public int priceLevel = 9;
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

        public void MakeSale(Week week)
        {
            if (cupsInPitcher != 0)
            { 
                cupsInPitcher -= 1;
                inventory.cupsOnHand -= 1;
                inventory.iceOnHand -= recipe.icePerCup;
                inventory.cashOnHand += pricePerCup;
                cupsSold++;
            }
            else
            {
                CheckForIngredients(week);
                MakeNewPitcher();
                MakeSale(week);
            }
        }

        private void CheckForIngredients(Week week)
        {
            if (inventory.lemonsOnHand < recipe.lemonsPerPitcher || inventory.sugarOnHand < recipe.sugarPerPitcher)
            {
                Console.WriteLine("You dont have enough materials to make a new pitcher!  You must close for the day.");
                week.days[week.dayCounter].EndOfDay(this);
            }
        }

        public void MakeNewPitcher()
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
                    priceLevel = 10;
                    break;
                case "2":
                    pricePerCup = .2;
                    priceLevel = 9;
                    break;
                case "3":
                    pricePerCup = .3;
                    priceLevel = 8;
                    break;
                case "4":
                    pricePerCup = .4;
                    priceLevel = 7;
                    break;
                case "5":
                    pricePerCup = .5;
                    priceLevel = 6;
                    break;
                case "6":
                    pricePerCup = .6;
                    priceLevel = 5;
                    break;
                case "7":
                    pricePerCup = .7;
                    priceLevel = 4;
                    break;
                case "8":
                    pricePerCup = .8;
                    priceLevel = 3;
                    break;
                case "9":
                    pricePerCup = .9;
                    priceLevel = 2;
                    break;
                case "10":
                    pricePerCup = 1;
                    priceLevel = 1;
                    break;
                default:
                    Console.WriteLine("Come on, this is serious business, how much are you charging today?");
                    ChangePrice();
                    break;

            }
        }


    }
}
