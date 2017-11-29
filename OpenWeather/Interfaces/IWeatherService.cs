using System.Threading.Tasks;
using OpenWeather.Models;

namespace OpenWeather.Interfaces
{
    public interface IWeatherService
    {
        Task<CityWeather> GetDetailsByCityName(string cityName);
    }
}
