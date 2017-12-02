using System;
using System.Threading.Tasks;
using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;
using OpenWeather.Interfaces;
using OpenWeather.Models;
using OpenWeather.Services;

namespace OpenWeather.ViewModels
{
    public class HomeViewModel : MvxViewModel
    {
        private readonly IMvxNavigationService _navigationService;
        private IWeatherService weatherService { get; set; }

        public string PageTitle { get; }
        public string PlaceHolerText { get; set; }
        public string SearchButtonText { get; set; }


        public HomeViewModel(IMvxNavigationService navigationService)
        {
            PageTitle = "Home Screen";
            PlaceHolerText = "Enter City Name";
            SearchButtonText = "Search";
            weatherService = new WeatherService();
            _navigationService = navigationService;
        }

        private string _searchMessage;
        public string SearchText
        {
            get { return _searchMessage; }

            set { SetProperty(ref _searchMessage, value); RaisePropertyChanged(() => SearchText); }
        }


        private IMvxCommand searchCommand;
        public virtual IMvxCommand SearchCommand
        {
            get
            {
                searchCommand = searchCommand ?? new MvxCommand(() =>
                {
                    Task.Run(async () => {
                        var cityDetails = await weatherService.GetDetailsByCityName(SearchText);
                        await _navigationService.Navigate<CityViewModel, CityWeather>(cityDetails);
                    });
                });

                return searchCommand;
            }
        }
    }
}
