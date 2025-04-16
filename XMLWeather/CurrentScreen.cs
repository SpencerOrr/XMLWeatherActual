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
        // Convert the icon value to an integer to determine the correct weather image
        int weatherValue = Convert.ToInt32(Form1.days[0].icon);
        public CurrentScreen()
        {
            InitializeComponent();
            DisplayCurrent();
        }

        public void DisplayCurrent()
        {
            // Set weather information using the first element in the days list
            cityOutput.Text = Form1.days[0].location;
            dateOutput.Text = Form1.days[0].date;
            currentTempOutput.Text = $"{Math.Round(Convert.ToDouble(Form1.days[0].tempLow))}°C";
            conditionOutput.Text = Form1.days[0].condition;
            minOutput.Text = $"Low: {Form1.days[0].tempLow}°C";
            maxOutput.Text = $"High: {Form1.days[0].tempHigh}°C";

            // Convert the icon value to an integer to determine the correct weather image
            int weatherValue = Convert.ToInt32(Form1.days[0].icon);

            // Select appropriate weather icon based on weather code range
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

        // Paint event for setting background colors
        private void CurrentScreen_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (weatherValue >= 200 && weatherValue < 782)
            {
                g.Clear(ColorTranslator.FromHtml("#A9A9A9"));// Set background color
                cityTextbox.BackColor = System.Drawing.ColorTranslator.FromHtml("#A9A9A9"); // Match city textbox background
            }
            else
            {
                g.Clear(ColorTranslator.FromHtml("#fdeee1"));// Set background color
                cityTextbox.BackColor = System.Drawing.ColorTranslator.FromHtml("#fdeee1"); // Match city textbox background
            }
        }

        // Handles click event to switch to the forecast screen
        private void forecastLabel_Click(object sender, EventArgs e)
        {
            if (Form1.days.Count < 7)
            {
                MessageBox.Show("Incorrect city input. Please try another city.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Form f = this.FindForm(); // Get current form
            f.Controls.Remove(this); // Remove current screen

            ForecastScreen fs = new ForecastScreen(); // Create forecast screen
            f.Controls.Add(fs); // Add forecast screen
        }

        // Handles the click event for changing the city
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string previousCity = Form1.currentCity; // Save current city
            string newCity = cityTextbox.Text.Trim(); // Get new city name from input

            try
            {
                Form1.currentCity = newCity;

                // Reload weather data
                Form1.days.Clear();
                Form1 f = (Form1)this.FindForm();
                f.ExtractForecast();
                f.ExtractCurrent();

                // Ensure enough data is available
                if (Form1.days.Count < 7)
                {
                    throw new Exception("Incomplete weather data.");
                }

                // Refresh the CurrentScreen
                f.Controls.Clear();
                CurrentScreen cs = new CurrentScreen();
                f.Controls.Add(cs);
            }
            catch (Exception)
            {
                // Restore previous city and show error
                Form1.currentCity = previousCity;
                cityTextbox.Text = "ERROR";
                MessageBox.Show("Could not load data for the entered city. Please check the name and try again.",
                                "City Not Found",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }
    }
    }


