using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Weather // IS A
    {
        //notes
        // 1=Rainy, 2=Cloudy, 3=hazy 4=Sunny, 5=HOT!; multiplier for thirst level
        //type of weather has a traffic multiplier. Rainy = .7, Cloudy = .9, hazy = 1, Sunny 1.5. Hot = 1.4
        //

        //member variables
        Random rdm = new Random();
        int weatherToday;
        string weatherName;
        double weatherTrafficMultiplier;
        //constructor
        public Weather()
        {
            GetWeather();
        }

        //member methods

        public void GetWeather ()
        {
             
            switch (rdm.Next(1, 6))
            {
                case 1:
                    weatherToday = 1;
                    weatherName = "Rainy";
                    weatherTrafficMultiplier = .7;
                    break;
                case 2:
                    weatherToday = 2;
                    weatherName = "Cloudy";
                    weatherTrafficMultiplier = .9;
                    break;
                case 3:
                    weatherToday = 3;
                    weatherName = "Hazy";
                    weatherTrafficMultiplier = 1;
                    break;
                case 4:
                    weatherToday = 4;
                    weatherName = "Sunny";
                    weatherTrafficMultiplier = 1.5;
                    break;
                case 5:
                    weatherToday = 5;
                    weatherName = "HOT!";
                    weatherTrafficMultiplier = 1.4;
                    break;
            }
        }
    }
}
