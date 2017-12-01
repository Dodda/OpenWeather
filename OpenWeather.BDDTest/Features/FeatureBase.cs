using NUnit.Framework;
using TechTalk.SpecFlow;
using Xamarin.UITest;

namespace OpenWeather.BDDTest
{
    [TestFixture(Platform.Android)]
    [TestFixture(Platform.iOS)]
    public class FeatureBase
    {
        public IApp app;
        Platform platform;

        public FeatureBase(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform);
            FeatureContext.Current.Add("App", app);
        }
    }
}
