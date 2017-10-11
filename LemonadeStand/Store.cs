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
            string userInput = Console.Read();
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
                    OpenForBusiness();
                    break;
                default:
                    Console.WriteLine("Sorry, we don't carry that here.  Please type in '1' '2' '3' or '4'");
                    BuySupplies();
                    break;
            }

        }
        void BuyCups()
        {
            Console.WriteLine("Would you like to buy:\n[1] 25 cups for $.50\n[2] 50 cups for $.90\n[3] 100 cups for $1.75");
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
                default:
                    Console.WriteLine("Sorry, we don't carry that here.  Please type in '1' '2' or '3'");
                    BuyCups();
                    break;
            }
        }

        void BuyLemons() {
            Console.WriteLine("Would you like to buy\n[1] 10 Lemons for $1.00\n[2] 20 Lemons for $1.75\n[3] 50 Lemons for $4.00");
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
                    lemonsOnHand += lemonsOnHand + 10;
                    cashOnHand -= cashOnHand - 1;
                    break;
                case "3":
                    //CheckIfEnough();
                    lemonsOnHand += lemonsOnHand + 10;
                    cashOnHand -= cashOnHand - 1;
                    break;
                default:
                    Console.WriteLine("Sorry, we don't carry that here.  Please type in '1' '2' or '3'");
                    BuyLemons();
                    break;
            }
        }
        //BuySugar
        //BuyIce
    }
}
