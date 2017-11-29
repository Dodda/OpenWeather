using System.Collections.Generic;
using OpenWeather.Models;

namespace OpenWeather
{
    //Just for the Test purpose i am storing the data in static dictionary.
    //Actually We need to store in Sqlite db or preferences in real time application.
    public static class GlobalSettings
    {
        public static Dictionary<string, CityWeather> FavoritesList { get; set; } = new Dictionary<string, CityWeather>();
    }
}
