using System;

namespace Repository.Models
{
    public class WeatherData
    {
        public string Description { get; set; }
        public string FeelsLike { get; set; }
        public string Humidity { get; set; }
        public string IconUrl { get; set;   }
        public string Location { get; set; }
        public string PrecipitationToday { get; set; }
        public string Temperature { get; set; }
        public DateTime Updated { get; set; }
    }
}
