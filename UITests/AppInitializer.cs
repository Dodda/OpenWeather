using OpenWeather.UITests.Screens;
using OpenWeather.UITests.Screens.CitySearch;
using TechTalk.SpecFlow;
using Xamarin.UITest;

namespace OpenWeather.UITests
{
    public class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
            if (platform == Platform.Android)
            {
                return ConfigureApp.Android.StartApp();
            }

            return ConfigureApp.iOS.EnableLocalScreenshots().StartApp();
        }

        public static void InitializeScreens(Platform platform)
        {
            if (platform == Platform.iOS)
            {
                //FeatureContext.Current.Add(ScreenNames.Home, new iOSHomeScreen());
                //FeatureContext.Current.Add(ScreenNames.AddTask, new iOSAddTaskScreen());
            }
            else if (platform == Platform.Android)
            {
                FeatureContext.Current.Add(ScreenNames.CitySearch, new AndroidCitySearchScreen());
               // FeatureContext.Current.Add(ScreenNames.CityDetails, new AndroidAddTaskScreen());
            }
        }
    }
}
