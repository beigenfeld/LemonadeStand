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

        

        //Daily Traffic level affected by day (Friday, Saturday, and Sunnday have a traffic multiplier) and weather

        //member variables
        int thirstLevel;
        int strengthPreference;
        int sweetPreference;
        int chillPreference;
        int frugalityLevel;
        int generosityLevel;
        //
        //pass in weather from Day
         

        //constructor
        public Customer(Random rdm)
        {
            frugalityLevel = rdm.Next(1,11);
            thirstLevel = rdm.Next(1, 6);
            generosityLevel = rdm.Next(1,11);
            chillPreference = rdm.Next(1, 4);
            strengthPreference = rdm.Next(1, 4);
            sweetPreference = rdm.Next(1, 4);
        }

        //member methods



        private void WillTheyBuy(Player player, Week week)
        {
            CheckPrice(player, week);
            CheckThirst(player, week);
            CheckGenerosity(player, week);
        }

        private void CheckPrice(Player player, Week week)
        {
            if (player.priceLevel <= frugalityLevel)
            {
                player.MakeSale(week);
            }
        }

        private void CheckThirst(Player player, Week week)
        {
            if (thirstLevel * week.days[day.weatherToday] >= frugalityLevel * player.priceLevel)
            {
                frugalityLevel -= thirstLevel;
                CheckPrice(player, week);
            }
        }

        private void CheckGenerosity(Player player, Week week)
        {
            if (generosityLevel == 10)
            {
                player.MakeSale(week);
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
