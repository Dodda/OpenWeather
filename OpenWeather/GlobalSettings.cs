using System.Collections.Generic;
using OpenWeather.Models;

namespace OpenWeather
{
    public static class GlobalSettings
    {
        //Just for the Test purpose I am storing the data in static dictionary.
        //Actually We need to store in Sqlite db or preferences in real time application.
        public static Dictionary<string, CityWeather> FavoritesList { get; set; } = new Dictionary<string, CityWeather>();

        public const string ApplicationId = "&APPID=2040cf2ca882ebb88f12a58fcd5b73e1";

        public const string Url = "http://api.openweathermap.org/data/2.5/weather?q=";
    }
}
 