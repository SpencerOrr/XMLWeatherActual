using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace XMLWeather
{
    public partial class ForecastScreen : UserControl
    {
        // List to hold all the PictureBoxes used for weather icons
        List<PictureBox> pictureBoxes = new List<PictureBox>();

        public ForecastScreen()
        {
            InitializeComponent();

            // Add each forecast day's PictureBox to the list
            pictureBoxes.Add(pictureBox2);
            pictureBoxes.Add(pictureBox3);
            pictureBoxes.Add(pictureBox4);
            pictureBoxes.Add(pictureBox5);
            pictureBoxes.Add(pictureBox6);
            pictureBoxes.Add(pictureBox7);

            // Display the forecast data when the screen is created
            displayForecast();
        }

        // Displays the 6-day weather forecast
        public void displayForecast()
        {
            if (Form1.days.Count < 7)
            {
                MessageBox.Show("Incorrect city input. Please try another city.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Set date and low temperature text for each day
            date1.Text = Form1.days[1].date;
            deg1.Text = $"L: {Math.Round(Convert.ToDouble(Form1.days[1].tempLow))}°C";
            label2.Text = $"H: {Math.Round(Convert.ToDouble(Form1.days[1].tempHigh))}°C";

            date2.Text = Form1.days[2].date;
            deg2.Text = $"L: {Math.Round(Convert.ToDouble(Form1.days[2].tempLow))}°C";
            label3.Text = $"H: {Math.Round(Convert.ToDouble(Form1.days[2].tempHigh))}°C";

            date3.Text = Form1.days[3].date;
            deg3.Text = $"L: {Math.Round(Convert.ToDouble(Form1.days[3].tempLow))}°C";
            label4.Text = $"H: {Math.Round(Convert.ToDouble(Form1.days[3].tempHigh))}°C";

            date4.Text = Form1.days[4].date;
            deg4.Text = $"L: {Math.Round(Convert.ToDouble(Form1.days[4].tempLow))}°C";
            label5.Text = $"H: {Math.Round(Convert.ToDouble(Form1.days[4].tempHigh))}°C";

            date5.Text = Form1.days[5].date;
            deg5.Text = $"L: {Math.Round(Convert.ToDouble(Form1.days[5].tempLow))}°C";
            label6.Text = $"H: {Math.Round(Convert.ToDouble(Form1.days[5].tempHigh))}°C";

            date6.Text = Form1.days[6].date;
            deg6.Text = $"L: {Math.Round(Convert.ToDouble(Form1.days[6].tempLow))}°C";
            label7.Text = $"H: {Math.Round(Convert.ToDouble(Form1.days[6].tempHigh))}°C";

            // Loop through all 6 days to assign the correct weather icons
            for (int i = 1; i < 6; i++)
            {
                int weatherValue = Convert.ToInt32(Form1.days[i].icon); // Get weather condition code

                // Match icon to weather condition code
                if (weatherValue >= 200 && weatherValue < 300) pictureBoxes[i].Image = Properties.Resources.Thunderstorm;
                else if (weatherValue >= 300 && weatherValue < 400 || weatherValue >= 520 && weatherValue < 532) pictureBoxes[i].Image = Properties.Resources.ShowerRain;
                else if (weatherValue >= 500 && weatherValue < 505) pictureBoxes[i].Image = Properties.Resources.Raining;
                else if (weatherValue >= 600 && weatherValue < 623 || weatherValue == 511) pictureBoxes[i].Image = Properties.Resources.Snow;
                else if (weatherValue >= 701 && weatherValue < 782) pictureBoxes[i].Image = Properties.Resources.Mist;
                else if (weatherValue == 800) pictureBoxes[i].Image = Properties.Resources.FullSun;
                else if (weatherValue == 801) pictureBoxes[i].Image = Properties.Resources.CloudySun;
                else if (weatherValue == 802) pictureBoxes[i].Image = Properties.Resources.FullCloud;
                else if (weatherValue == 803) pictureBoxes[i].Image = Properties.Resources.BrokenClouds;
            }
        }

        // Paint event to draw a custom background with rectangles
        private void ForecastScreen_Paint(object sender, PaintEventArgs e)
        {
            // Set background color of the city textbox
            cityTextbox.BackColor = System.Drawing.ColorTranslator.FromHtml("#fdeee1");

            Graphics g = e.Graphics;

            // Rectangle properties
            int rectWidth = 225;
            int rectHeight = 40;
            int spacing = 10;
            int totalHeight = (rectHeight * 6) + (spacing * 5);
            int startX = (this.Width - rectWidth) / 2;
            int startY = (this.Height - totalHeight) / 2;

            // Set brush color
            SolidBrush brush = new SolidBrush(ColorTranslator.FromHtml("#d9d5d4")); // soft gray tone

            // Draw 6 forecast rectangles vertically spaced
            for (int i = 0; i < 6; i++)
            {
                Rectangle rect = new Rectangle(startX, startY + i * (rectHeight + spacing), rectWidth, rectHeight);
                g.FillRectangle(brush, rect);
            }

            brush.Dispose(); // Clean up brush
        }

        // Event handler for label click to switch back to current weather screen
        private void label1_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm(); // Get the current form
            f.Controls.Remove(this);  // Remove forecast screen

            CurrentScreen cs = new CurrentScreen(); // Create current weather screen
            f.Controls.Add(cs); // Add it to the form
        }

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

        // Refresh the ForecastScreen
        f.Controls.Clear();
        ForecastScreen fs = new ForecastScreen();
        f.Controls.Add(fs);
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
