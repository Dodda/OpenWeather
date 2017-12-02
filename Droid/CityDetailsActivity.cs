using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Droid.Views;
using Newtonsoft.Json;
using OpenWeather.Models;
using OpenWeather.ViewModels;
namespace OpenWeather.Droid
{
    [Activity]
    public class CityDetailsActivity : MvxActivity<CityViewModel>
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.CityLayout);
            Button buttonFavorites = FindViewById<Button>(Resource.Id.btnAddToFav);

            //MvvmCross Binding for UI Controls.
            buttonFavorites.Text = ViewModel.ButtonText;
            Title = ViewModel.PageTitle;
            var set = this.CreateBindingSet<CityDetailsActivity, CityViewModel>();
            set.Bind(buttonFavorites).To(vm => vm.AddToFavoritesCommand);
            set.Apply();

            if (ViewModel.CityDetails != null)
            {
                FindViewById<TextView>(Resource.Id.textCity).Text = ViewModel.CityDetails.name;
                FindViewById<TextView>(Resource.Id.textTemperature).Text = ViewModel.CityDetails.main.temp.ToString();
                FindViewById<TextView>(Resource.Id.textLatitude).Text = ViewModel.CityDetails.coord.lat.ToString();
                FindViewById<TextView>(Resource.Id.textLongitude).Text = ViewModel.CityDetails.coord.lon.ToString();
                FindViewById<TextView>(Resource.Id.textWindSpeed).Text = ViewModel.CityDetails.wind.speed.ToString();
            }
        }
    }
}
