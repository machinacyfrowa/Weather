using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather
{
    /// <summary>
    /// Klasa opisuje dane pogodowe dla aktualnej pogody otrzymywane z API Open-Meteo
    /// </summary>
    internal class Current
    {
        public string time { get; set; }
        public int interval { get; set; }
        public double temperature_2m { get; set; }
        public int weather_code { get; set; }
        public int relative_humidity_2m { get; set; }
        public double wind_speed_10m { get; set; }
        public double precipitation { get; set; }
        public double surface_pressure { get; set; }
    }
}
