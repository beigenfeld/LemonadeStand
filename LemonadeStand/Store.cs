using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Store : Inventory
    {
        //notes


        //member variables


        //constructor
        public Store()
        {

        }

        //member methods
        //DisplayCurrentInventory
        void BuySupplies()
        {
            Console.WriteLine("Would you like to buy\n[1] Cups\n[2] Lemons\n[3]Sugar\n[4] Ice\n[5] Nothing more.  I'm all set to sell some lemonade!");
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    BuyCups();
                    break;
                case "2":
                    BuyLemons();
                    break;
                case "3":
                    BuySugar();
                    break;
                case "4":
                    BuyIce();
                    break;
                case "5":
                    //OpenForBusiness();
                    break;
                default:
                    Console.WriteLine("Sorry, we don't carry that here.  Please type in '1' '2' '3' or '4'");
                    BuySupplies();
                    break;
            }

        }
        void BuyCups()
        {
            Console.WriteLine("Would you like to buy:\n[1] 25 cups for $.50\n[2] 50 cups for $.90\n[3] 100 cups for $1.75\n[4] I have all the cups I need, thanks.");
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    //CheckIfEnough
                    cupsOnHand += cupsOnHand + 25;
                    cashOnHand -= cashOnHand - .5;
                    break;
                case "2":
                    //CheckIfEnough
                    cupsOnHand += cupsOnHand + 50;
                    cashOnHand -= cashOnHand - .9;
                    break;
                case "3":
                    //CheckIfEnough
                    cupsOnHand += cupsOnHand + 100;
                    cashOnHand -= cashOnHand - 1.75;
                    break;
                case "4":
                    break;
                default:
                    Console.WriteLine("Sorry, we don't carry that here.  Please type in '1' '2' '3' or '4'");
                    BuyCups();
                    break;
            }
        }

        void BuyLemons()
        {
            Console.WriteLine("Would you like to buy\n[1] 10 Lemons for $1.00\n[2] 20 Lemons for $1.75\n[3] 50 Lemons for $4.00\n[4] Life has given me enough lemons.");
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    //CheckIfEnough();
                    lemonsOnHand += lemonsOnHand + 10;
                    cashOnHand -= cashOnHand - 1;
                    break;
                case "2":
                    //CheckIfEnough();
                    lemonsOnHand += lemonsOnHand + 20;
                    cashOnHand -= cashOnHand - 1.75;
                    break;
                case "3":
                    //CheckIfEnough();
                    lemonsOnHand += lemonsOnHand + 50;
                    cashOnHand -= cashOnHand - 4;
                    break;
                case "4":
                    break;
                default:
                    Console.WriteLine("Sorry, we don't carry that here.  Please type in '1' '2' or '3'");
                    BuyLemons();
                    break;
            }
        }
        void BuySugar()
        {
            Console.WriteLine("Would you like to buy\n[1] 10 cups of Sugar for $1.00\n[2] 20 cups of Sugar for $1.75\n[3] 50 cups of Sugar for $4.00\n[4] No more sugar for me, I'm sweet enough!");
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    //CheckIfEnough();
                    sugarOnHand += sugarOnHand + 10;
                    cashOnHand -= cashOnHand - 1;
                    break;
                case "2":
                    //CheckIfEnough();
                    sugarOnHand += sugarOnHand + 20;
                    cashOnHand -= cashOnHand - 1.75;
                    break;
                case "3":
                    //CheckIfEnough();
                    sugarOnHand += sugarOnHand + 50;
                    cashOnHand -= cashOnHand - 4;
                    break;
                case "4":
                    break;
                default:
                    Console.WriteLine("Sorry, we don't carry that here.  Please type in '1' '2' '3' or '4'");
                    BuySugar();
                    break;
            }
        }
        void BuyIce()
        {
            Console.WriteLine("Would you like to buy\n[1] 10 cubes of Ice for $.50\n[2] 20 cubes of Ice for $.90\n[3] 50 cubes of Ice for $2.00\n[4] Brrrr, it's cold in here! Let's get out of the freezer!");
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    //CheckIfEnough();
                    iceOnHand += iceOnHand + 10;
                    cashOnHand -= cashOnHand - .5;
                    break;
                case "2":
                    //CheckIfEnough();
                    iceOnHand += iceOnHand + 20;
                    cashOnHand -= cashOnHand - .9;
                    break;
                case "3":
                    //CheckIfEnough();
                    iceOnHand += iceOnHand + 50;
                    cashOnHand -= cashOnHand - 2;
                    break;
                case "4":
                    break;
                default:
                    Console.WriteLine("Sorry, we don't carry that here.  Please type in '1' '2' '3' or '4'");
                    BuyIce();
                    break;
            }
        }
    }
}
