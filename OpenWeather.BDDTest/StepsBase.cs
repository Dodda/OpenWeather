using System;
using TechTalk.SpecFlow;
using Xamarin.UITest;

namespace OpenWeather.BDDTest
{
    public class StepsBase
    {
        protected readonly IApp app;

        public StepsBase()
        {
            app = FeatureContext.Current.Get<IApp>("App");
        }
    }
}
