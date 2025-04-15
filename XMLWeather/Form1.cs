using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Xml;

namespace XMLWeather
{
    public partial class Form1 : Form

        // Spencer Orr 
    {
        public static List<Day> days = new List<Day>();
        public static string currentCity = "Stratford";
        public Form1()
        {
            InitializeComponent();
            ExtractForecast();
            ExtractCurrent();
            
            // open weather screen for todays weather
            CurrentScreen cs = new CurrentScreen();
            this.Controls.Add(cs);
        }

         public void ExtractForecast()
        {
            XmlReader reader = XmlReader.Create($"http://api.openweathermap.org/data/2.5/forecast/daily?q={currentCity},CA&mode=xml&units=metric&cnt=7&appid=3f2e224b815c0ed45524322e145149f0");



            while (reader.Read())
            {
               
                Day d = new Day();

                reader.ReadToFollowing("time");
                d.date = reader.GetAttribute("day");

                reader.ReadToFollowing("symbol");
                d.icon = reader.GetAttribute("number");
                d.condition = reader.GetAttribute("name");              

                reader.ReadToFollowing("precipitation");
                d.precipitation = reader.GetAttribute("value") ?? "0";

                reader.ReadToFollowing("windDirection");
                d.windDirection = reader.GetAttribute("name");

                reader.ReadToFollowing("windSpeed");
                d.windSpeed = reader.GetAttribute("name");

                reader.ReadToFollowing("temperature");
                d.tempLow = reader.GetAttribute("min");
                d.tempHigh = reader.GetAttribute("max");

                days.Add(d);
            }
        }

        public void ExtractCurrent()
        {
            // current info is not included in forecast file so we need to use this file to get it
            XmlReader reader = XmlReader.Create($"http://api.openweathermap.org/data/2.5/weather?q={currentCity},CA&mode=xml&units=metric&appid=3f2e224b815c0ed45524322e145149f0");

            reader.ReadToFollowing("city");
            days[0].location = reader.GetAttribute("name");

            reader.ReadToFollowing("temperature");
            days[0].currentTemp = reader.GetAttribute("value");

            reader.ReadToFollowing("speed");
            days[0].windSpeed = reader.GetAttribute("name");

            reader.ReadToFollowing("direction");
            days[0].windDirection = reader.GetAttribute("name");

            reader.ReadToFollowing("precipitation");
            days[0].precipitation = reader.GetAttribute("mode") ?? "none";

            reader.ReadToFollowing("weather");
            days[0].icon = reader.GetAttribute("number");
        }


    }
}
