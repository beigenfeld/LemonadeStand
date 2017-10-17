using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Player
    {
        //member variables
        string name;
        public Inventory inventory;
        public Store store;
        public Recipe recipe;
        public double pricePerCup = .2;
        public int cupsSold = 0;
        public int priceLevel = 9;
        int cupsInPitcher;
        string amount = ".20";

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
                CheckForSupplies(week);
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

        private void CheckForSupplies(Week week)
        {
            if (inventory.cupsOnHand == 0)
            {
                Console.WriteLine("Oh no!  You've run out of Cups and had to close down for the day!");
                week.days[week.dayCounter].EndOfDay(this);
            }
            else if (inventory.iceOnHand < recipe.icePerCup)
            {
                Console.WriteLine("Oh no!  You've run out of Ice and had to close down for the day!");
                week.days[week.dayCounter].EndOfDay(this);
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
            Console.WriteLine("You are currently charging $" + amount + " per cup.");
            Console.WriteLine("How much per cup will you charge today?");
            Console.WriteLine("[1] $.10  [2] $.20  [3] $.30  [4] $.40  [5] $.50");
            Console.WriteLine("[6] $.60  [7] $.70  [8] $.80  [9] $.90  [10] $1.00");
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    amount = ".10";
                    pricePerCup = .1;
                    priceLevel = 10;
                    break;
                case "2":
                    amount = ".20";
                    pricePerCup = .2;
                    priceLevel = 9;
                    break;
                case "3":
                    amount = ".30";
                    pricePerCup = .3;
                    priceLevel = 8;
                    break;
                case "4":
                    amount = ".40";
                    pricePerCup = .4;
                    priceLevel = 7;
                    break;
                case "5":
                    amount = ".50";
                    pricePerCup = .5;
                    priceLevel = 6;
                    break;
                case "6":
                    amount = ".60";
                    pricePerCup = .6;
                    priceLevel = 5;
                    break;
                case "7":
                    amount = ".70";
                    pricePerCup = .7;
                    priceLevel = 4;
                    break;
                case "8":
                    amount = ".80";
                    pricePerCup = .8;
                    priceLevel = 3;
                    break;
                case "9":
                    amount = ".90";
                    pricePerCup = .9;
                    priceLevel = 2;
                    break;
                case "10":
                    amount = "1.00";
                    pricePerCup = 1;
                    priceLevel = 1;
                    break;
                default:
                    Console.WriteLine("Come on, this is serious business, how much are you charging today?");
                    ChangePrice();
                    break;
            }
            Console.WriteLine("You have set your price to $" + amount + " per cup.");
        }
    }
}
