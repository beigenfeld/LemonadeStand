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

        //private void MakeSale (Recipe recipe)
        //{
        //    if (cupsInPitcher != 0)
        //    {
        //        //cupsInPitcher-- , 
        //        //cupsOnHand--
        //        //icePerCup--
        //        //cashOnHand += price, 
        //        //cupsSold++
        //    }
        //    else
        //    {
        //        MakeNewPitcher();
        //        MakeSale();
        //    }
        //}

        private void ChangePrice()
        {

        }


    }
}
