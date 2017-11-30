using NUnit.Framework;
using Xamarin.UITest;

namespace OpenWeather.BDDTest
{
    [TestFixture(Platform.Android)]
    [TestFixture(Platform.iOS)]
    public partial class CitySearchFeature : FeatureBase
    {
        public CitySearchFeature(Platform platform) : base(platform)
        {
            
        }
    }
}
