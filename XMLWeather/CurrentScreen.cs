using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            // Example of assigning values from the first (current) day
            cityOutput.Text = Form1.days[0].location;
            dateOutput.Text = Form1.days[0].date;
            currentTempOutput.Text = $"{Form1.days[0].currentTemp}";
            conditionOutput.Text = Form1.days[0].condition;
            minOutput.Text = $"Low: {Form1.days[0].tempLow}°C";
            maxOutput.Text = $"High: {Form1.days[0].tempHigh}°C";

            int weatherValue = Convert.ToInt32(Form1.days[0].icon);

            if (weatherValue >= 200 && weatherValue < 300) weatherBox.Image = Properties.Resources.Thunderstorm;
            else if (weatherValue >= 300 && weatherValue < 400 || weatherValue >= 520 && weatherValue < 532) weatherBox.Image = Properties.Resources.ShowerRain;
            else if (weatherValue >= 500 && weatherValue < 505) weatherBox.Image = Properties.Resources.Raining;
            else if (weatherValue >= 600 && weatherValue < 623 || weatherValue == 511) weatherBox.Image = Properties.Resources.Snow;
            else if (weatherValue >= 701 && weatherValue < 782) weatherBox.Image = Properties.Resources.Mist;
            else if (weatherValue == 800) weatherBox.Image = Properties.Resources.FullSun;
            else if (weatherValue == 801) weatherBox.Image = Properties.Resources.CloudySun;
            else if (weatherValue == 802) weatherBox.Image = Properties.Resources.FullCloud;
            else if (weatherValue == 803 || weatherValue == 804) weatherBox.Image = Properties.Resources.BrokenClouds;  

        }
        private void CurrentScreen_Paint(object sender, PaintEventArgs e)
        {           
            Graphics g = e.Graphics;
             g.Clear(ColorTranslator.FromHtml("#fdeee1"));
            cityTextbox.BackColor = System.Drawing.ColorTranslator.FromHtml("#fdeee1");
        }

        private void forecastLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ForecastScreen fs = new ForecastScreen();
            f.Controls.Add(fs);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string newCity = cityTextbox.Text;

            try
            {

                Form1.currentCity = newCity;

                // Reload weather data
                Form1.days.Clear();
                Form1 f = (Form1)this.FindForm();
                f.ExtractForecast();
                f.ExtractCurrent();

                // Refresh this screen
                f.Controls.Clear();
                CurrentScreen cs = new CurrentScreen();
                f.Controls.Add(cs);
            }
            catch (Exception)
            {
                cityTextbox.Text = "ERROR";
                return;
            }
        }
    }
}
