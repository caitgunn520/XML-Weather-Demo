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
    public partial class ForecastScreen : UserControl
    {
        public ForecastScreen()
        {
            InitializeComponent();
            displayForecast();
        }

        /// <summary>
        /// This method displays forecast information. The information in days at 
        /// index 1 is tomorrow's information, 2 is 2 days from now, etc. 
        /// </summary>
        public void displayForecast()
        {
            date1.Text = Form1.days[1].date;
            min1.Text = Form1.days[1].tempLow;
            max1.Text = Form1.days[1].tempHigh;
            weatherCond1.Text = Form1.days[1].condition;

            date2.Text = Form1.days[2].date;
            min2.Text = Form1.days[2].tempLow;
            max2.Text = Form1.days[2].tempHigh;
            weatherCond2.Text = Form1.days[2].condition;

        }

        /// <summary>
        /// When the Today label is clicked, this user control is removed from the form
        /// and the CurrentScreen user control is added to the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void todayLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
        }
    }
}
