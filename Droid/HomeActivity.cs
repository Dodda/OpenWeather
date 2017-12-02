using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;
using System.Collections.Generic;
using OpenWeather.ViewModels;
using OpenWeather.Models;
using Newtonsoft.Json;
using MvvmCross.Droid.Views;
using MvvmCross.Binding.BindingContext;

namespace OpenWeather.Droid
{
    [Activity]
    public class HomeActivity : MvxActivity<HomeViewModel>
    {
        private ListView favoritesListView;
        //private ProgressDialog loadingIndicator;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.HomeLayout);

            // Get our button from the layout resource,
            // and attach an event to it
            Button searchButton = FindViewById<Button>(Resource.Id.searchButton);
            favoritesListView = FindViewById<ListView>(Resource.Id.favoritesListView);
            TextView searchText = FindViewById<TextView>(Resource.Id.searchText);
            favoritesListView.ItemClick += FavList_ItemClick;

            //MvvmCross Binding for UI Controls.
            searchButton.Text = ViewModel.SearchButtonText;
            searchText.Hint = ViewModel.PlaceHolerText;
            Title = ViewModel.PageTitle;
            var set = this.CreateBindingSet<HomeActivity, HomeViewModel>();
            set.Bind(searchText).To(vm => vm.SearchText);
            set.Bind(searchButton).To(vm => vm.SearchCommand);
            set.Apply();
        }

        //private void NavigateToCityDetails(CityWeather cityDetails)
        //{
        //    var cityDetailsJson = JsonConvert.SerializeObject(cityDetails);
        //    var cityActivity = new Intent(this, typeof(CityDetailsActivity));
        //    cityActivity.PutExtra("JsonData", cityDetailsJson);
        //    StartActivity(cityActivity);
        //}

        private void FavList_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            string cityName = (string)favoritesListView.Adapter.GetItem(e.Position);
            if (GlobalSettings.FavoritesList.ContainsKey(cityName))
            {
                var cityDetails = GlobalSettings.FavoritesList[cityName];
                //NavigateToCityDetails(cityDetails);
            }
        }

        protected override void OnStart()
        {
            base.OnStart();
            List<string> keysList = new List<string>(GlobalSettings.FavoritesList.Keys);
            ArrayAdapter adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, keysList);
            favoritesListView.Adapter = adapter;
        }
    }
}

