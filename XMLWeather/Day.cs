using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XMLWeather
{
    public class Day
    {
        public string date, currentTemp, currentTime, condition, location, tempHigh, tempLow, tempUnits, 
            windSpeed, windDirection, precipitation, visibility, humidity;

        /// <summary>
        /// This will create a blank day object where all values are set to "" initially
        /// </summary>
        public Day()
        {
            date = currentTemp = currentTime = condition = location = tempHigh = tempLow =
               tempUnits = windSpeed = windDirection = precipitation = visibility = humidity = "";
        }
    }
}
