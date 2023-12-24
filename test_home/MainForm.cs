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
using Newtonsoft.Json.Linq; //библиотека для работы с данными в формате JSON

namespace test_home
{
    public partial class MainForm : Form
    {
        private const string ApiKey = "Ваш_Ключ"; // подставьте свой ключ
        public MainForm()
        {
            InitializeComponent();
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
                using (WebClient client = new WebClient()) // Создаем экземпляр WebClient.
                {
                    string json = client.DownloadString(apiUrl); //Выполняем запрос на внешний веб-сервер
                    dynamic data = JObject.Parse(json); // разбираем JSON-строки в объект dynamic

                    string temperature = $"{data.main.temp} °C";
                    string description = data.weather[0].description;
                    string windSpeed = $"{data.wind.speed} m/s";

                    labelTemperature.Text = $"Температура: {temperature}";
                    labelDescription.Text = $"Описание: {description}";
                    labelWindSpeed.Text = $"Скорость ветра: {windSpeed}";
                }
            }
            catch (WebException) // обработка ошибок, если проблемы с веб-запросом, выводим ошибку
            {
                MessageBox.Show("Ошибка при получении данных. Проверьте подключение к интернету или правильность ввода города.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
