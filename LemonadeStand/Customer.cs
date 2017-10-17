using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Customer
    {
        //member variables
        int thirstLevel;
        int strengthPreference;
        int sweetPreference;
        int chillPreference;
        int frugalityLevel;
        int generosityLevel;
        
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
        public void WillTheyBuy(Player player, Week week)
        {
            if (CheckPrice(player, week) == true)
            {
                player.MakeSale(week);
            }
            else if (CheckThirst(player, week) == true)
            {
                player.MakeSale(week);
            }
            else if (CheckGenerosity(player, week) == true)
            {
                player.MakeSale(week);
            }
        }

        private bool CheckPrice(Player player, Week week)
        {
            if (player.priceLevel <= frugalityLevel)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool CheckThirst(Player player, Week week)
        {
            if (thirstLevel * (2 * week.days[week.dayCounter].todaysWeather.weatherNumber) >= frugalityLevel * player.priceLevel)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool CheckGenerosity(Player player, Week week)
        {
            if (generosityLevel == 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
