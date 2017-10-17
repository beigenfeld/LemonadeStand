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

        //member variables
        
        public int weatherNumber;
        public string weatherName;
        public double weatherTrafficMultiplier;
        //constructor
        public Weather(Random rdm)
        {
            GetWeather(rdm);
        }

        //member methods

        public void GetWeather (Random rdm)
        {
             
            switch (rdm.Next(1, 6))
            {
                case 1:
                    weatherNumber = 1;
                    weatherName = "Rainy";
                    weatherTrafficMultiplier = .7;
                    break;
                case 2:
                    weatherNumber = 2;
                    weatherName = "Cloudy";
                    weatherTrafficMultiplier = .9;
                    break;
                case 3:
                    weatherNumber = 3;
                    weatherName = "Hazy";
                    weatherTrafficMultiplier = 1;
                    break;
                case 4:
                    weatherNumber = 4;
                    weatherName = "Sunny";
                    weatherTrafficMultiplier = 1.5;
                    break;
                case 5:
                    weatherNumber = 5;
                    weatherName = "HOT!";
                    weatherTrafficMultiplier = 1.4;
                    break;
            }
        }
    }
}
