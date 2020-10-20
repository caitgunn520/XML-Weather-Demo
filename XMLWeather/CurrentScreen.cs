using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XMLWeather
{
    public partial class CurrentScreen : UserControl
    {
        public CurrentScreen()
        {
            InitializeComponent();
            DisplayCurrent();
        }

        public void DisplayCurrent()
        {
            // the current information is in index 0, thus why all information is retreived from there
            cityOutput.Text = Form1.days[0].location;
            tempLabel.Text = Form1.days[0].currentTemp + " degrees " + Form1.days[0].tempUnits;
            minOutput.Text = Form1.days[0].tempLow + " degrees " + Form1.days[0].tempUnits;
            maxOutput.Text = Form1.days[0].tempHigh + " degrees " + Form1.days[0].tempUnits;
            weatherCondCurrent.Text = Form1.days[0].condition;

            // changes image based on weather
            switch(Form1.days[0].condition)
            {
                case "broken clouds":
                case "overcast clouds":
                    weatherSymbol.Image = XMLWeather.Properties.Resources.cloudIcon;
                    break;
                case "light rain":
                case "moderate rain":
                case "heavy rain":
                    weatherSymbol.Image = XMLWeather.Properties.Resources.rainIcon;
                    break;
                case "clear sky":
                    weatherSymbol.Image = XMLWeather.Properties.Resources.sunIcon;
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// When the forecast label is clicked this user control is removed from the form
        /// and the ForecastScreen user control is added to the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void forecastLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ForecastScreen fs = new ForecastScreen();
            f.Controls.Add(fs);
        }

        private void weatherCondCurrent_Click(object sender, EventArgs e)
        {

        }
    }
}
