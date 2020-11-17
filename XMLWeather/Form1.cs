using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Xml;
using System.Diagnostics;

namespace XMLWeather
{
    public partial class Form1 : Form
    {
        // list to hold day objects
        public static List<Day> days = new List<Day>();

        public Form1()
        {
            InitializeComponent();

            ExtractForecast();
            ExtractCurrent();

            // open weather screen for todays weather
            CurrentScreen cs = new CurrentScreen();
            Controls.Add(cs);
        }

        /// <summary>
        /// This method will get forecast information for each day, including today.
        /// Each day will be setup as a separate Day object and added to the days list. 
        /// </summary>
        private void ExtractForecast()
        {
            // get forecast information from web and place in an xml file
            XmlReader reader = XmlReader.Create
                ("http://api.openweathermap.org/data/2.5/forecast/daily?q=Stratford,CA&mode=xml&units=metric&cnt=7&appid=3f2e224b815c0ed45524322e145149f0");

            // extract the relevant information for a day, and repeat for each day in the forecast
            while (reader.Read())
            {
                // create blank day object
                Day d = new Day();

                // find the time element, and get the day attribute
                reader.ReadToFollowing("time");
                d.date = reader.GetAttribute("day");

                // retrieve outdoor conditions
                reader.ReadToFollowing("symbol");
                d.condition = reader.GetAttribute("name");

                // find the temperature element, and get the min and max attributes
                reader.ReadToFollowing("temperature");
                d.tempLow = reader.GetAttribute("min");
                d.tempHigh = reader.GetAttribute("max");

                // retrieve humidity
                reader.ReadToFollowing("humidity");
                d.humidity = reader.GetAttribute("value");

                // add day to days list
                days.Add(d);
            }
        }

        /// <summary>
        /// This method will get the current conditions from the web, convert them to an XML file,
        /// and then use that file to extract information that is not in the forecast file, 
        /// such as the current temperature
        /// </summary>
        private void ExtractCurrent()
        {
            // get current information from web and place in an xml file
            XmlReader reader = XmlReader.Create("http://api.openweathermap.org/data/2.5/weather?q=Stratford,CA&mode=xml&units=metric&appid=3f2e224b815c0ed45524322e145149f0");

            // find the city element, and add it's name attribute to days[0], (today)
            reader.ReadToFollowing("city");
            days[0].location = reader.GetAttribute("name");

            // retrieve min and max temperatures, as well as current value and units
            reader.ReadToFollowing("temperature");
            days[0].tempUnits = reader.GetAttribute("unit");
            days[0].tempLow = reader.GetAttribute("min");
            days[0].tempHigh = reader.GetAttribute("max");
            days[0].currentTemp = reader.GetAttribute("value");

            // retrieve humidity
            reader.ReadToFollowing("humidity");
            days[0].humidity = reader.GetAttribute("value");

            // retrieve outdoor conditions
            reader.ReadToFollowing("weather");
            days[0].condition = reader.GetAttribute("value");

        }
    }
}
