using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.Windows.Forms;

namespace WeatherDashboard
{
    public partial class Form1 : Form
    {
        private static readonly HttpClient client = new HttpClient();

        private async Task GetWeatherDataAsync(string city)
        {
            string apiKey = "260aa87a39e4031228b216ec052c4b7e"; // OpenWeatherMap API key
            string url = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={apiKey}&units=metric";

            HttpResponseMessage response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                string responseData = await response.Content.ReadAsStringAsync();
                ParseWeatherData(responseData);
            }
            else
            {
                MessageBox.Show("Error: Unable to retrieve data");
            }
        }

        private void ParseWeatherData(string json)
        {
            var data = JObject.Parse(json);
            string cityName = data["name"]?.ToString() ?? "Unknown";
            string temperature = data["main"]?["temp"]?.ToString() ?? "N/A";
            string weatherCondition = data["weather"]?[0]?["description"]?.ToString() ?? "N/A";

            // Update background video based on the weather condition
            if (weatherCondition.Contains("sunny"))
            {
                PlayBackgroundVideo(@"C:\Users\Samuele25\source\repos\WeatherDashboard\WeatherDashboard\img\sunny-video.mp4");
            }
            else if (weatherCondition.Contains("clear sky"))
            {
                PlayBackgroundVideo(@"C:\Users\Samuele25\source\repos\WeatherDashboard\WeatherDashboard\img\rain-video.mp4");
            }
            else if (weatherCondition.Contains("cloud"))
            {
                PlayBackgroundVideo(@"C:\Users\Samuele25\source\repos\WeatherDashboard\WeatherDashboard\img\cloud-video.mp4");
            }
            else
            {
                StopBackgroundVideo();
            }

            string humidity = data["main"]?["humidity"]?.ToString() ?? "N/A";
            string windSpeed = data["wind"]?["speed"]?.ToString() ?? "N/A";

            // Display data on the labels
            TemperatureLabel.Text = $"Temperature: {temperature} °C";
            WeatherLabel.Text = $"Condition: {weatherCondition}";
            HumidityLabel.Text = $"Humidity: {humidity}%";
            WindSpeedLabel.Text = $"Wind Speed: {windSpeed} m/s";
        }

        private void PlayBackgroundVideo(string videoPath)
        {
            // Implement video playback logic here
            // This is a placeholder method

        }

        private void StopBackgroundVideo()
        {
            // Implement logic to stop video playback here
            // This is a placeholder method
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private async void SearchButton_Click(object sender, EventArgs e)
        {
            string city = CityTextBox.Text;
            if (!string.IsNullOrEmpty(city))
            {
                await GetWeatherDataAsync(city);
            }
            else
            {
                MessageBox.Show("Please enter a city name.");
            }
        }
    }
}
