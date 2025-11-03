namespace Weather
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {
                //bazowy adres API
                client.BaseAddress = new Uri("https://api.open-meteo.com/v1/");
                //odpytujemy o aktualnπ pogodÍ
                HttpResponseMessage result = client.GetAsync("forecast?latitude=52.23&longitude=21.01&current=temperature_2m,relative_humidity_2m,precipitation,weather_code,surface_pressure,wind_speed_10m").Result;
                //jeúli odpowiedü jest poprawna
                if (result.IsSuccessStatusCode)
                {
                    //odczytujemy odpowiedü jako string
                    string jsonResponse = result.Content.ReadAsStringAsync().Result;
                    //deserializujemy odpowiedü do obiektu APIResponse
                    APIResponse response = Newtonsoft.Json.JsonConvert.DeserializeObject<APIResponse>(jsonResponse);
                    //przypisjemy wartoúci do kontrolek na formularzu
                    string temperature = response.current.temperature_2m.ToString();
                    temperature += response.current_units.temperature_2m;
                    TemperatureTextBox.Text = temperature;
                    string rainfall = response.current.precipitation.ToString();
                    rainfall += response.current_units.precipitation;
                    RainTextBox.Text = rainfall;
                    string humidity = response.current.relative_humidity_2m.ToString();
                    humidity += response.current_units.relative_humidity_2m;
                    HumidityTextBox.Text = humidity;
                    string pressure = response.current.surface_pressure.ToString();
                    pressure += response.current_units.surface_pressure;
                    PressureTextBox.Text = pressure;
                    string windSpeed = response.current.wind_speed_10m.ToString();
                    windSpeed += response.current_units.wind_speed_10m;
                    WindSpeedTextBox.Text = windSpeed;
                    string conditionDescription = Forecast.GetDescription(response.current.weather_code);
                    WMOLabel.Text = conditionDescription;
                    string iconUrl = Forecast.GetIconUrl(response.current.weather_code);
                    WMOPictureBox.Load(iconUrl);
                }
            }
        }

        private void wyjúcieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
