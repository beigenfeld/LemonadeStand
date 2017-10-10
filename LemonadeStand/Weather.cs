using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Weather
    {
        //notes
        // 1=Rainy, 2=Cloudy, 3=Sunny, 4=HOT!

        //member variables
        Random rdm = new Random();
        int weatherToday;
        string weatherName;
        //constructor
        public Weather()
        {

        }

        //member methods
        void DailyWeather ()
        {
             
            switch (rdm.Next(1, 5))
            {
                case 1:
                    weatherToday = 1;
                    weatherName = "Rainy";
                    break;
                case 2:
                    weatherToday = 2;
                    weatherName = "Cloudy";
                    break;
                case 3:
                    weatherToday = 3;
                    weatherName = "Sunny";
                    break;
                case 4:
                    weatherToday = 4;
                    weatherName = "HOT!";
                    break;
            }
        }
    }
}
