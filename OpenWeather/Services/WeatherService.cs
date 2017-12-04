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
        public async Task<CityWeather> GetDetailsByCityName(string cityName)
        {
            HttpClient client = ServiceClient.GetClient();

            string responseResult = string.Empty;
            string requestUrl = $"{GlobalSettings.Url}{cityName}{GlobalSettings.ApplicationId}";

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
