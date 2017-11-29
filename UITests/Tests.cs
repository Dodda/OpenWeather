using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace OpenWeather.UITests
{
    [TestFixture(Platform.Android)]
    [TestFixture(Platform.iOS)]
    public class Tests
    {
        IApp app;
        Platform platform;

        public Tests(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform);
        }

        [Test]
        public void HomeScreen()
        {
            app.Screenshot("Home Screen");
            app.WaitForElement(c => c.Marked("Home Screen").Text("Home Screen"));
            app.EnterText(x => x.Class("UITextField"), "Hyderabad");
            app.Tap(x => x.Class("UIButton"));
            app.Screenshot("City Waeather Details Screen");
            app.Tap(c => c.Class("UIButton"));
            app.WaitForElement(c =>c.Class("Home Screen"));
            app.Tap(c => c.Marked("Home Screen"));
            app.Screenshot("Home Screen With Favorites List");
            app.Tap(c => c.Class("UITableViewCell").Text("Hyderabad"));
        }

        //[Test]
        //public void CitySearch()
        //{
        //    //app.Repl();

        //}

        //[Test]
        //public void CityScreen()
        //{
        //}

        //[Test]
        //public void AddToFavorites()
        //{
        //}

        //[Test]
        //public void BackToHomeScreen()
        //{
            
        //}

        //[Test]
        //public void ClikOnFavoriteCity()
        //{
        //}
    }
}
