using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using OpenWeather.Interfaces;
using OpenWeather.Models;

namespace OpenWeather.Services
{
    public class WeatherService : IWeatherService
    {
        private const string APP_ID = "&APPID=2040cf2ca882ebb88f12a58fcd5b73e1";
        private const string APP_URL = "http://api.openweathermap.org/data/2.5/weather?q=";

        public async Task<CityWeather> GetDetailsByCityName(string cityName)
        {
            HttpClient client = ServiceClient.GetClient();

            string responseResult = string.Empty;
            string requestUrl = $"{APP_URL}{cityName}{APP_ID}";

            HttpResponseMessage response;
            try
            {
                response = await client.GetAsync(requestUrl);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    responseResult = await response.Content.ReadAsStringAsync();
                }
            }
            catch (Exception ex)
            {
                string strErrorMessage = ex.Message;
            }

            CityWeather cityWeather = JsonConvert.DeserializeObject<CityWeather>(responseResult);
            return cityWeather;
        }
    }
}
