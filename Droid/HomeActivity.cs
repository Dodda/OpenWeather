using Android.App;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;
using OpenWeather.ViewModels;
using MvvmCross.Droid.Views;
using MvvmCross.Binding.BindingContext;

namespace OpenWeather.Droid
{
    [Activity]
    public class HomeActivity : MvxActivity<HomeViewModel>
    {
        private ListView favoritesListView;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.HomeLayout);

            // Get our button from the layout resource,
            // and attach an event to it
            Button searchButton = FindViewById<Button>(Resource.Id.searchButton);
            favoritesListView = FindViewById<ListView>(Resource.Id.favoritesListView);
            TextView searchText = FindViewById<TextView>(Resource.Id.searchText);

            //MvvmCross Binding for UI Controls.
            Title = ViewModel.PageTitle;
            var set = this.CreateBindingSet<HomeActivity, HomeViewModel>();
            set.Bind(searchButton).For(x => x.Text).To(vm => vm.SearchButtonText);
            set.Bind(searchText).For(x => x.Hint).To(vm => vm.PlaceHolerText);
            set.Bind(searchText).To(vm => vm.SearchText);
            set.Bind(searchButton).To(vm => vm.SearchCommand);
            set.Apply();
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

