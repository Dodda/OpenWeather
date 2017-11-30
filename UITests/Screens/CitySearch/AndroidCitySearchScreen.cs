using System;
using Xamarin.UITest.Queries;

namespace OpenWeather.UITests.Screens.CitySearch
{
    public class AndroidCitySearchScreen : ICitySearchScreen
    {
        Func<AppQuery, AppQuery> ICitySearchScreen.cityText => new Func<AppQuery, AppQuery>(c => c.Marked("searchText"));

        Func<AppQuery, AppQuery> ICitySearchScreen.searchButton => new Func<AppQuery, AppQuery>(c => c.Marked("searchButton"));
    }
}
