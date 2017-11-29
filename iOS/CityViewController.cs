using System;
using UIKit;
using OpenWeather.ViewModels;
using OpenWeather.Models;

namespace OpenWeather.iOS
{
    public partial class CityViewController : UIViewController
    {
        public CityWeather City;

        private CityViewModel ViewModel { get; set; }

        public CityViewController (IntPtr handle) : base (handle)
        {
            ViewModel = new CityViewModel();
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            //Asinging the data from ViewModel
            Title = ViewModel.PageTitle;
            buttonFavorites.SetTitle(ViewModel.ButtonText,UIControlState.Normal);

            if (City != null)
            {
                textCityName.Text = City.name;
                textHumidity.Text = Convert.ToString(City.main.humidity);
                textLatitude.Text = Convert.ToString(City.coord.lat);
                textLongitude.Text = Convert.ToString(City.coord.lon);
                textPressure.Text = Convert.ToString(City.main.pressure);
                textWindSpeed.Text = Convert.ToString(City.wind.speed);
                textTemperature.Text = Convert.ToString(City.main.temp);
            }

            buttonFavorites.TouchUpInside += ButtonFavorites_TouchUpInside;
        }

        void ButtonFavorites_TouchUpInside(object sender, EventArgs e)
        {
            if (!GlobalSettings.FavoritesList.ContainsKey(City.name))
            {
                GlobalSettings.FavoritesList.Add(City.name, City);
            }
        }
    }
}