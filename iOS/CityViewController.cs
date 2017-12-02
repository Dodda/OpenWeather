using System;
using UIKit;
using OpenWeather.ViewModels;
using OpenWeather.Models;
using MvvmCross.iOS.Views;
using MvvmCross.Binding.BindingContext;

namespace OpenWeather.iOS
{
    [MvxFromStoryboard("Main")]
    public partial class CityViewController : MvxViewController<CityViewModel>
    {
        public CityViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            //MvvmCross Binding for UI Controls.
            buttonFavorites.TitleLabel.Text = ViewModel.ButtonText;
            var set = this.CreateBindingSet<CityViewController, CityViewModel>();
            set.Bind(Title).To(vm => vm.PageTitle);
            set.Bind(buttonFavorites).To(vm => vm.AddToFavoritesCommand);
            set.Apply();

            if (ViewModel.CityDetails != null)
            {
                textCityName.Text = ViewModel.CityDetails.name;
                textHumidity.Text = Convert.ToString(ViewModel.CityDetails.main.humidity);
                textLatitude.Text = Convert.ToString(ViewModel.CityDetails.coord.lat);
                textLongitude.Text = Convert.ToString(ViewModel.CityDetails.coord.lon);
                textPressure.Text = Convert.ToString(ViewModel.CityDetails.main.pressure);
                textWindSpeed.Text = Convert.ToString(ViewModel.CityDetails.wind.speed);
                textTemperature.Text = Convert.ToString(ViewModel.CityDetails.main.temp);
            }
        }
    }
}