using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather
{
    internal class Forecast
    {
        public static Dictionary<int, string> conditions = new Dictionary<int, string>
        {
            { 0, "Słonecznie" },
            { 1, "Głównie słonecznie" },
            { 2, "Lekkie zachmurzenie" },
            { 3, "Zachmurzenie" },
            { 4, "Mgła" },
            { 5, "Mżawka" },
            { 6, "Deszcz" },
            { 7, "Śnieg" },
            { 8, "Ulewa" },
            { 9, "Burza" }
        };
        public static Dictionary<int, string> iconUrl = new Dictionary<int, string>
        {
            { 0, "http://openweathermap.org/img/wn/13d@2x.png" },
            { 1, "http://openweathermap.org/img/wn/13d@2x.png" },
            { 2, "http://openweathermap.org/img/wn/13d@2x.png" },
            { 3, "http://openweathermap.org/img/wn/13d@2x.png" },
            { 4, "http://openweathermap.org/img/wn/13d@2x.png" },
            { 5, "http://openweathermap.org/img/wn/13d@2x.png" },
            { 6, "http://openweathermap.org/img/wn/13d@2x.png" },
            { 7, "http://openweathermap.org/img/wn/13d@2x.png" },
            { 8, "http://openweathermap.org/img/wn/13d@2x.png" },
            { 9, "http://openweathermap.org/img/wn/13d@2x.png" }
        };
        public static string GetDescription(int code)
        {
            //pobierz tylko pierwszą cyfrę z kodu
            code = int.Parse(code.ToString().Substring(0, 1));
            return conditions[code];

        }
        public static string GetIconUrl(int code)
        {
            code = int.Parse(code.ToString().Substring(0, 1));
            return iconUrl[code];
        }
}
