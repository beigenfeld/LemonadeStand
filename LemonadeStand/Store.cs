using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Store
    {
        //notes


        //member variables
        

        //constructor
        public Store()
        {
            
        }

        //member methods
        void DisplayInventory(Player player) {
            Console.WriteLine("Your inventory is now at:");
            Console.WriteLine("Cash: $" + player.inventory.cashOnHand);
            Console.WriteLine("Cups: " + player.inventory.cupsOnHand);
            Console.WriteLine("Lemons: " + player.inventory.lemonsOnHand);
            Console.WriteLine("Sugar: " + player.inventory.sugarOnHand);
            Console.WriteLine("Ice: " + player.inventory.iceOnHand);
        }
        bool CheckIfEnough(double price, double cashOnHand)
        {
            if (price > cashOnHand)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void BuySupplies(Player player)
        {
            Console.WriteLine("Would you like to buy:\n[1] Cups\n[2] Lemons\n[3] Sugar\n[4] Ice\n[5] Check Inventory\n[6] Nothing more.  I'm all set to sell some lemonade!");
            string userInput = Console.ReadLine();
            
            switch (userInput)
            {
                case "1":
                    BuyCups(player);
                    break;
                case "2":
                    BuyLemons(player);
                    break;
                case "3":
                    BuySugar(player);
                    break;
                case "4":
                    BuyIce(player);
                    break;
                case "5":
                    DisplayInventory(player);
                    BuySupplies(player);
                    break;
                //case "6":
                //    //OpenForBusiness();
                //    break;
                default:
                    Console.WriteLine("Sorry, we don't carry that here.  Please type in '1' '2' '3' or '4'");
                    BuySupplies(player);
                    break;
            }

        }
        void BuyCups(Player player)
        {
            Console.WriteLine("Would you like to buy:\n[1] 25 cups for $.50\n[2] 50 cups for $.90\n[3] 100 cups for $1.75\n[4] I have all the cups I need, thanks.");
            string userInput = Console.ReadLine();
            double price = 0;
            int quantity = 0;
            switch (userInput)
            {
                case "1":
                    price = .5;
                    quantity = 25;
                    break;
                case "2":
                    price = .9;
                    quantity = 50;
                    break;
                case "3":
                    price = 1.75;
                    quantity = 100;
                    break;
                case "4":
                    break;
                default:
                    Console.WriteLine("Sorry, we don't carry that here.  Please type in '1' '2' '3' or '4'");
                    BuyCups(player);
                    break;
            }
            if (CheckIfEnough(price, player.inventory.cashOnHand) == false)
            {
                Console.WriteLine("Ummmm, you seem to be a little short... You only have $" + player.inventory.cashOnHand);
                BuyCups(player);
            }
            else
            {
                player.inventory.cupsOnHand += quantity;
                player.inventory.cashOnHand -= price;
                Console.WriteLine("You bought " + quantity + " Cups for $" + price);
                DisplayInventory(player);
                Console.WriteLine("Anything else?");
                BuySupplies(player);
            }

        }

        void BuyLemons(Player player)
        {
            Console.WriteLine("Would you like to buy\n[1] 10 Lemons for $1.00\n[2] 20 Lemons for $1.75\n[3] 50 Lemons for $4.00\n[4] Life has given me enough lemons.");
            string userInput = Console.ReadLine();
            double price = 0;
            int quantity = 0;
            switch (userInput)
            {
                case "1":
                    price = 1;
                    quantity = 10;
                    break;
                case "2":
                    price = 1.75;
                    quantity = 20;
                    break;
                case "3":
                    price = 4;
                    quantity = 50;
                    break;
                case "4":
                    break;
                default:
                    Console.WriteLine("Sorry, we don't carry that here.  Please type in '1' '2' or '3'");
                    BuyLemons(player);
                    break;
            }
            if (CheckIfEnough(price, player.inventory.cashOnHand) == false)
            {
                Console.WriteLine("Ummmm, you seem to be a little short... You only have $" + player.inventory.cashOnHand);
                BuyLemons(player);
            }
            else
            {
                player.inventory.lemonsOnHand += quantity;
                player.inventory.cashOnHand -= price;
                Console.WriteLine("You bought " + quantity + " Cups for $" + price);
                DisplayInventory(player);
                Console.WriteLine("Anything else?");
                BuySupplies(player);
            }
        }
        void BuySugar(Player player)
        {
            Console.WriteLine("Would you like to buy\n[1] 10 cups of Sugar for $1.00\n[2] 20 cups of Sugar for $1.75\n[3] 50 cups of Sugar for $4.00\n[4] No more sugar for me, I'm sweet enough!");
            string userInput = Console.ReadLine();
            double price = 0;
            int quantity = 0;
            switch (userInput)
            {
                case "1":
                    price = 1;
                    quantity = 10;
                    break;
                case "2":
                    price = 1.75;
                    quantity = 20;
                    break;
                case "3":
                    price = 4;
                    quantity = 50;
                    break;
                case "4":
                    break;
                default:
                    Console.WriteLine("Sorry, we don't carry that here.  Please type in '1' '2' '3' or '4'");
                    BuySugar(player);
                    break;
            }
            if (CheckIfEnough(price, player.inventory.cashOnHand) == false)
            {
                Console.WriteLine("Ummmm, you seem to be a little short... You only have $" + player.inventory.cashOnHand);
                BuySugar(player);
            }
            else
            {
                player.inventory.sugarOnHand += quantity;
                player.inventory.cashOnHand -= price;
                DisplayInventory(player);
                Console.WriteLine("Anything else?");
                BuySupplies(player);
            }
        }
        void BuyIce(Player player)
        {
            Console.WriteLine("Would you like to buy\n[1] 10 cubes of Ice for $.50\n[2] 20 cubes of Ice for $.90\n[3] 50 cubes of Ice for $2.00\n[4] Brrrr, it's cold in here! Let's get out of the freezer!");
            string userInput = Console.ReadLine();
            double price = 0;
            int quantity = 0;
            switch (userInput)
            {
                case "1":
                    price = .5;
                    quantity = 10;
                    break;
                case "2":
                    price = .9;
                    quantity = 20;
                    break;
                case "3":
                    price = 2;
                    quantity = 50;
                    break;
                case "4":
                    break;
                default:
                    Console.WriteLine("Sorry, we don't carry that here.  Please type in '1' '2' '3' or '4'");
                    BuyIce(player);
                    break;
            }
            if (CheckIfEnough(price, player.inventory.cashOnHand) == false)
            {
                Console.WriteLine("Ummmm, you seem to be a little short... You only have $" + player.inventory.cashOnHand);
                BuyIce(player);
            }
            else
            {
                player.inventory.iceOnHand += quantity;
                player.inventory.cashOnHand -= price;
                DisplayInventory(player);
                Console.WriteLine("Anything else?");
                BuySupplies(player);
            }
            
        }
    }
}
