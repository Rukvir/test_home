using System;
using System.Net;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace test_home
{
    public partial class MainForm : Form
    {
        private const string ApiKey = "c0f8ad91448e30cbc165087eac292b3d";
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnGetWeather_Click(object sender, EventArgs e)
        {
            string city = textCity.Text;
            if (string.IsNullOrEmpty(city))
            {
                MessageBox.Show("Введите город", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string apiUrl = $"http://api.openweathermap.org/data/2.5/weather?q={city}&appid={ApiKey}&units=metric";

            try
            {
                using (WebClient client = new WebClient())
                {
                    string json = client.DownloadString(apiUrl);
                    dynamic data = JObject.Parse(json);

                    string temperature = $"{data.main.temp} °C";
                    string description = data.weather[0].description;
                    string windSpeed = $"{data.wind.speed} m/s";

                    labelTemperature.Text = $"Температура: {temperature}";
                    labelDescription.Text = $"Описание: {description}";
                    labelWindSpeed.Text = $"Скорость ветра: {windSpeed}";
                }
            }
            catch (WebException)
            {
                MessageBox.Show("Ошибка при получении данных. Проверьте подключение к интернету или правильность ввода города.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
