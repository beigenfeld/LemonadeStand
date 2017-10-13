using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Customer
    {
        //notes
        //price level 1-10
        //frugality level 1-5
        //thirst level 1-10
        //weather 1-5
        //What influences decision to buy?    Price (randomly generated frugality level 1-5) , randomly generated thirst level (which is affected by the weather)
        //If price > frugality level, it will move to thirst level test 
        //If thirst * weather > fugality * price, frugality decreases by thirst level,
        //If still no, 1 in 10 chance Generosity factor 

        //Where do the TrafficMultipliers come in?

        //Thirst Level: randomly generated number 1-10; multiplied by weather **1-5**

        //Price Level = 1.00 = +1, .90 = +2, .80 = +3, .70 = +4, .60 = +5, .50 = +6 
        // .40 = +7, .30 = +8, .20 = +9, .10 = +10

        //Daily Traffic level affected by day (Friday, Saturday, and Sunnday have a traffic multiplier) and weather

        //member variables
        int thirstLevel;
        int strengthPreference;
        int sweetPreference;
        //int chillPreference;
        int frugalityLevel;
        int generosityLevel;
        //
        //pass in weather from Day
         

        //constructor
        public Customer()
        {
            //thirst level
        }

        //member methods
        private void CreateCustomer()
        {

        }
        
        
        private void WillTheyBuy()
        {
            CheckPrice();
            CheckThirst();
            CheckGenerosity();
        }

        private void CheckPrice()
        {
            if (priceLevel <= frugalityLevel)
            {
                MakeSale();
            }
        }

        private void CheckThirst()
        {
           if (thirstLevel * weatherToday >= frugalityLevel * priceLevel)
            {
                frugalityLevel = frugalityLevel - thirstLevel;
                CheckPrice();
            }
        }

       private void CheckGenerosity()
        {
            generosityLevel = rdm.Next(1, 11);
            if (generosityLevel == 10)
            {
                MakeSale();
            }
        }
        //= Price*frugality < thirst*weather; if over x, they will buy
        //else, if not buying, 1 in 10 chance they will buy anyway
        //buy function cashOnHand += cashOnHand + price, pitcher -- 


        //foreach index on the List of customers of length "trafficToday"
        //
        //
    }
}
