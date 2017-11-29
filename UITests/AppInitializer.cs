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
    }
}
