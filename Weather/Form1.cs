namespace Weather
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //za³aduj ustawienia aplikacji z klasy Properties.Settings
            //zaczynamy od temperatury
            //pobieramy sobie jednostkê z ustawieñ
            string temperature = Properties.Settings.Default.temperatureUnit;
            if (temperature == "fahrenheit")
            {
                TemperatureUnitFMenuItem.Checked = true;
                TemperatureUnitCMenuItem.Checked = false;
            }
            else
            {
                TemperatureUnitFMenuItem.Checked = false;
                TemperatureUnitCMenuItem.Checked = true;
            }
            //to samo dla opadów
            string rainfall = Properties.Settings.Default.rainfallUnit;
            if (rainfall == "inch")
            {
                RainfallInchMenuItem.Checked = true;
                RainfallMmMenuItem.Checked = false;
            }
            else
            {
                RainfallInchMenuItem.Checked = false;
                RainfallMmMenuItem.Checked = true;
            }
            //w ten sam sposób dla prêdkoœci wiatru
            string windSpeed = Properties.Settings.Default.windSpeedUnit;
            if (windSpeed == "mph")
            {
                mphToolStripMenuItem.Checked = true;
                kmhToolStripMenuItem.Checked = false;
                msToolStripMenuItem.Checked = false;

            }
            else if (windSpeed == "ms")
            {
                msToolStripMenuItem.Checked = true;
                kmhToolStripMenuItem.Checked = false;
                mphToolStripMenuItem.Checked = false;
            }
            else
            {
                kmhToolStripMenuItem.Checked = true;
                mphToolStripMenuItem.Checked = false;
                msToolStripMenuItem.Checked = false;
            }
        }
        void LoadFromAPI()
        {
            using (HttpClient client = new HttpClient())
            {
                //bazowy adres API
                client.BaseAddress = new Uri("https://api.open-meteo.com/v1/");
                string query = "forecast?latitude=52.23&longitude=21.01&current=temperature_2m,relative_humidity_2m,precipitation,weather_code,surface_pressure,wind_speed_10m";
                //dodajemy do adresu zapytania jednostki z ustawieñ
                query += "&temperature_unit=" + Properties.Settings.Default.temperatureUnit;
                //odpytujemy o aktualn¹ pogodê
                HttpResponseMessage result = client.GetAsync(query).Result;
                //jeœli odpowiedŸ jest poprawna
                if (result.IsSuccessStatusCode)
                {
                    //odczytujemy odpowiedŸ jako string
                    string jsonResponse = result.Content.ReadAsStringAsync().Result;
                    //deserializujemy odpowiedŸ do obiektu APIResponse
                    APIResponse response = Newtonsoft.Json.JsonConvert.DeserializeObject<APIResponse>(jsonResponse);
                    //przypisjemy wartoœci do kontrolek na formularzu
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
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadFromAPI();
        }

        private void wyjœcieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// zmiana temperatury na stopnie Celsjusza
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TemperatureUnitCMenuItem_Click(object sender, EventArgs e)
        {
            //zmieniamy zapisane ustawienie
            Properties.Settings.Default.temperatureUnit = "celsius";
            Properties.Settings.Default.Save();
            //zmieniamy zaznaczenie w menu
            TemperatureUnitCMenuItem.Checked = true;
            TemperatureUnitFMenuItem.Checked = false;
            LoadFromAPI();
        }
        /// <summary>
        /// zmiana temperatury na stopnie Fahrenheita
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TemperatureUnitFMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.temperatureUnit = "fahrenheit";
            Properties.Settings.Default.Save();
            TemperatureUnitFMenuItem.Checked = true;
            TemperatureUnitCMenuItem.Checked = false;
            LoadFromAPI();
        }
    }
}
