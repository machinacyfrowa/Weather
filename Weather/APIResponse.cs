using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather
{
    /// <summary>
    /// Klasa opisująca strukturę odpowiedzi z API pogodowego
    /// </summary>
    internal class APIResponse
    {
        public double latitude { get; set; }
        public double longitude { get; set; }
        public double generationtime_ms { get; set; }
        public int utc_offset_seconds { get; set; }
        public string timezone { get; set; }
        public string timezone_abbreviation { get; set; }
        //jeśli dostaliśmy nawet int to zmieniamy na double
        //wysokośc nad poziomem morza może mieć wartość ułamkową
        public double elevation { get; set; }
        public CurrentUnits current_units { get; set; }
        public Current current { get; set; }
    }
}
