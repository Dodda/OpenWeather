using System;
using NUnit.Framework;
using TechTalk.SpecFlow;
using Xamarin.UITest;

namespace OpenWeather.UITests.Features
{
    [TestFixture(Platform.Android,"")]
    [TestFixture(Platform.iOS)]
    public class FeatureBase
    {
        protected static IApp app;
        protected Platform platform;
        protected string iOSSimulator;
        protected bool resetDevice;

        public FeatureBase(Platform platform, string iOSSimulator, bool resetDevice = true)
        {
           // this.iOSSimulator = iOSSimulator;
            this.platform = platform;
            //this.resetDevice = resetDevice;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform);
            FeatureContext.Current.Add("App", app);
            AppInitializer.InitializeScreens(platform);
        }
    }
}
