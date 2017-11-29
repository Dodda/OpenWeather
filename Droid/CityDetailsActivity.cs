using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;
using Newtonsoft.Json;
using OpenWeather.Models;
using OpenWeather.ViewModels;
namespace OpenWeather.Droid
{
    [Activity]
    public class CityDetailsActivity : Activity
    {
        private CityWeather cityDetails;
        private CityViewModel ViewModel;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.CityLayout);

            ViewModel = new CityViewModel();
            TextView textCityName = FindViewById<TextView>(Resource.Id.textCity);
            cityDetails = JsonConvert.DeserializeObject<CityWeather>(Intent.GetStringExtra("JsonData"));
            textCityName.Text = cityDetails.name;
            FindViewById<TextView>(Resource.Id.textTemperature).Text = cityDetails.main.temp.ToString();
            FindViewById<TextView>(Resource.Id.textLatitude).Text = cityDetails.coord.lat.ToString();
            FindViewById<TextView>(Resource.Id.textLongitude).Text = cityDetails.coord.lon.ToString();
            FindViewById<TextView>(Resource.Id.textWindSpeed).Text = cityDetails.wind.speed.ToString();
            Button buttonFavorites = FindViewById<Button>(Resource.Id.btnAddToFav);

            //Asigning the data from ViewModel
            Title = ViewModel.PageTitle;
            buttonFavorites.Text = ViewModel.ButtonText;

            buttonFavorites.Click += (sender, e) => 
            {
                if (!GlobalSettings.FavoritesList.ContainsKey(textCityName.Text))
                {
                    GlobalSettings.FavoritesList.Add(textCityName.Text, cityDetails);
                }
            };
        }
    }
}
