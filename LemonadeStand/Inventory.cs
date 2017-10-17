using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Inventory
    {
        //member variables
        public double cashOnHand;
        public int cupsOnHand;
        public int lemonsOnHand;
        public int sugarOnHand;
        public int iceOnHand;
        public Store store;

        //constructor
        public Inventory()
        {
            store = new Store();
            cashOnHand = 20.00;
            cupsOnHand = 0;
            lemonsOnHand = 0;
            sugarOnHand = 0;
        }

        //member methods
        public void DisplayInventory()
        {
            Console.WriteLine("Your inventory is now at:");
            Console.WriteLine("Cash: " + cashOnHand.ToString("C"));
            Console.WriteLine("Cups: " + cupsOnHand);
            Console.WriteLine("Lemons: " + lemonsOnHand);
            Console.WriteLine("Sugar: " + sugarOnHand);
            Console.WriteLine("Ice: " + iceOnHand);
        }
    }
}
