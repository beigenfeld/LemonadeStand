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
        //constructor
        public Player()
        {
            GetName();
            inventory = new Inventory();
            store = new Store();
        }

        //member methods
        void GetName ()
        {
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
        }
    }
}
