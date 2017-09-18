using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Repository.Models;

namespace Repository.Wunderground
{
    public class WundergroundRepository : IWeatherRepository
    {
        private readonly string _apiKey;
        private string ServiceUrl => $"https://api.wunderground.com/api/{this._apiKey}/conditions/q/60532.json";

        public WundergroundRepository(string apiKey)
        {
			if (string.IsNullOrEmpty(apiKey)) throw new ArgumentNullException(nameof(apiKey));

			this._apiKey = apiKey;
        }

        public async Task<WeatherData> GetWeather(string zip)
        {
			using (HttpClient client = new HttpClient())
			{
				string data = await client.GetStringAsync(this.ServiceUrl);
                WundergroundResponse response = JsonConvert.DeserializeObject<WundergroundResponse>(data);

                return new WeatherData
                {
                    Description = response.current_observation.weather,
                    FeelsLike = response.current_observation.feelslike_string,
                    Humidity = response.current_observation.relative_humidity,
                    IconUrl = response.current_observation.icon_url,
                    Location = response.current_observation.display_location.full,
                    PrecipitationToday = response.current_observation.precip_today_string,
                    Temperature = response.current_observation.temperature_string,
                    Updated = Convert.ToDateTime(response.current_observation.observation_time_rfc822)
                };
			}
        }
    }
}
