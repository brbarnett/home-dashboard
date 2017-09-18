using System.Threading.Tasks;
using Repository.Models;

namespace Repository
{
    public interface IWeatherRepository
    {
        Task<WeatherData> GetWeather(string zip);
    }
}
