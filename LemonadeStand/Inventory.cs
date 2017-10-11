using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Inventory : Player
    {
        //notes
        //lemons, sugar, cups, ice


        //member variables
        protected double cashOnHand;
        protected int cupsOnHand;
        protected int lemonsOnHand;
        protected int sugarOnHand;
        protected int iceOnHand;

        //constructor
        public Inventory()
        {
            cashOnHand = 20.00;
            cupsOnHand = 0;
            lemonsOnHand = 0;
            sugarOnHand = 0;
        }

        //member methods
    }
}
