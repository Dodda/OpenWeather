using NUnit.Framework;
using Xamarin.UITest;

namespace OpenWeather.UITests
{
    [TestFixture(Platform.Android)]
    [TestFixture(Platform.iOS)]
    public class CitySearchTest
    {
        IApp app;
        Platform platform;

        public CitySearchTest(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform);
        }

        [Test]
        public void CitySearch()
        {
            app.Screenshot("Home Screen");
            app.WaitForElement(c => c.Marked("Home Screen").Text("Home Screen"));
            app.EnterText(x => x.Id("searchText"), "Hyderabad");
            app.Tap(x => x.Id("searchButton"));
            app.Screenshot("City Waeather Details Screen");
            app.Tap(c => c.Id("btnAddToFav"));
            app.Back();
            app.Screenshot("Home Screen With Favorites List");
            app.Tap(c => c.Id("text1").Text("Hyderabad"));
        }
    }
}
