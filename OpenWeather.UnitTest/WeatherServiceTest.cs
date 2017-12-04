using NUnit.Framework;
using OpenWeather.Interfaces;
using System.Threading.Tasks;
using Moq;
using OpenWeather.Models;
using OpenWeather.ViewModels;

namespace OpenWeather.UnitTest
{
    [TestFixture]
    public class WeatherServiceTest
    {
        private Mock<IWeatherService> mockWeatherService;

        public WeatherServiceTest()
        {
            mockWeatherService = new Mock<IWeatherService>();
        }

        [Test()]
        public void Get_City_Weather_Details_Success()
        {
            //Arrange
            string cityName = "Hyderabad";
            var mockCityDetails = GetCityDetailsMock();
            mockWeatherService.Setup(x => x.GetDetailsByCityName(It.IsAny<string>())).Returns(Task.FromResult(mockCityDetails));

            //Act
            HomeViewModel viewmodel = new HomeViewModel(mockWeatherService.Object, null);
            var cityDetails = Task.Run(async () => await viewmodel.GetCityWeatherDetails("Hyderabad")).Result;

            //Assert
            Assert.IsNotNull(cityDetails);
            Assert.AreEqual(cityName,cityDetails.name);
        }

        private CityWeather GetCityDetailsMock()
        {
            return new CityWeather
            {
                name = "Hyderabad",
                main = new Main { temp = 35.05, temp_min = 25.45, temp_max = 36.56, pressure = 1012, humidity = 54 },
                coord = new Coord { lon = 17.38, lat = 78.47 },
            };
        }
    }
}
