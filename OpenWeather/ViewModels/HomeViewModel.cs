using System.Threading.Tasks;
using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;
using OpenWeather.Interfaces;
using OpenWeather.Models;

namespace OpenWeather.ViewModels
{
    public class HomeViewModel : MvxViewModel
    {
        private readonly IMvxNavigationService _navigationService;
        private IWeatherService _weatherService { get; set; }

        public string PageTitle { get; }
        public string PlaceHolerText { get; set; }
        public string SearchButtonText { get; set; }


        public HomeViewModel(IWeatherService weatherService, IMvxNavigationService navigationService)
        {
            PageTitle = "Home Screen";
            PlaceHolerText = "Enter City Name";
            SearchButtonText = "Search";
            _weatherService = weatherService;
            _navigationService = navigationService;
        }

        private string searchMessage;
        public string SearchText
        {
            get { return searchMessage; }

            set { SetProperty(ref searchMessage, value); RaisePropertyChanged(() => SearchText); }
        }

        private bool isVisible = true;
        public bool IsVisible
        {
            get { return isVisible; }

            set { SetProperty(ref isVisible, value); RaisePropertyChanged(() => IsVisible); }
        }


        private IMvxCommand searchCommand;
        public virtual IMvxCommand SearchCommand
        {
            get
            {
                searchCommand = searchCommand ?? new MvxCommand(() =>
                {
                    Task.Run(async () => {
                        IsVisible = true;
                        var cityDetails = await GetCityWeatherDetails(SearchText);
                        isVisible = false;
                        await _navigationService.Navigate<CityViewModel, CityWeather>(cityDetails);
                    });
                });
                return searchCommand;
            }
        }

        /// <summary>
        /// Gets the city weather details.
        /// </summary>
        /// <returns>The city weather details.</returns>
        /// <param name="cityName">City name.</param>
        public async Task<CityWeather> GetCityWeatherDetails(string cityName)
        {
            return await _weatherService.GetDetailsByCityName(cityName);
        }
    }
}
