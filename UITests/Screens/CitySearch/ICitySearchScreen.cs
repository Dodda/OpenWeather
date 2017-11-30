using System;
using Xamarin.UITest.Queries;

namespace OpenWeather.UITests.Screens.CitySearch
{
    public interface ICitySearchScreen
    {
        Func<AppQuery, AppQuery> cityText { get; }
        Func<AppQuery, AppQuery> searchButton { get; }
    }
}
