using System.Threading.Tasks;
using OpenWeather.Interfaces;
using OpenWeather.Models;
using OpenWeather.Services;

namespace OpenWeather.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        private IWeatherService weatherService { get; set; }

        public string PageTitle { get; }
        public string PlaceHolerText { get; set; }
        public string SearchButtonText { get; set; }


        public HomeViewModel()
        {
            PageTitle = "Home Screen";
            PlaceHolerText = "Enter City Name";
            SearchButtonText = "Search";
            weatherService = new WeatherService();
        }

        /// <summary>
        /// Gets the weather details for city.
        /// </summary>
        /// <returns>The weather for city.</returns>
        /// <param name="cityName">City name.</param>
        public async Task<CityWeather> GetWeatherForCity(string cityName)
        {
            return await weatherService.GetDetailsByCityName(cityName);
        }
    }
}
