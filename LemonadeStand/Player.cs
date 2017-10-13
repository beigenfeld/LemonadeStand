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

        private void MakeSale (Recipe recipe)
        {
            if (cupsInPitcher != 0)
            {
                //cupsInPitcher-- , 
                //cupsOnHand--
                //icePerCup--
                //cashOnHand += price, 
            }
            else
            {
                MakeNewPitcher();
                MakeSale();
            }
        }




    }
}
