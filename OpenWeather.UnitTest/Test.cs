using NUnit.Framework;
using OpenWeather.Interfaces;
using OpenWeather.Services;
using System.Threading.Tasks;

namespace OpenWeather.UnitTest
{
    [TestFixture()]
    public class Test
    {
        [Test()]
        public void WeatherServiceTest()
        {
            IWeatherService service = new WeatherService();
            string cityName = "Chennai";
            var cityDetails = Task.Run(async () => await service.GetDetailsByCityName(cityName)).Result;
            Assert.IsNotNull(cityDetails);
            Assert.AreEqual(cityName,cityDetails.name);
        }
    }
}
