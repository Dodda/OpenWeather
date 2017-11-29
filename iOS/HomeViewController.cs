using System;
using UIKit;
using OpenWeather.ViewModels;
using OpenWeather.Models;
using System.Collections.Generic;

namespace OpenWeather.iOS
{
    public partial class HomeViewController : UIViewController
    {
        public HomeViewModel ViewModel { get; set; }

        public HomeViewController(IntPtr handle) : base(handle)
        {
            ViewModel = new HomeViewModel();
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            //Assigning the data from ViewModel
            Title = ViewModel.PageTitle;
            ButtonSearch.SetTitle(ViewModel.SearchButtonText,UIControlState.Normal);
            TextSearch.Placeholder = ViewModel.PlaceHolerText;

            ButtonSearch.TouchUpInside += async(sender, e) =>
            {
                TextSearch.ResignFirstResponder();
                ActivityLoader.StartAnimating();
                var result = await ViewModel.GetWeatherForCity(TextSearch.Text.Trim());
                ActivityLoader.StopAnimating();
                NavigateToCityDetails(result);
            };
        }

        /// <summary>
        /// Navigates to city details.
        /// </summary>
        /// <param name="result">Result.</param>
        private void NavigateToCityDetails(CityWeather result)
        {
            var cityViewController = Storyboard.InstantiateViewController("CityViewController") as CityViewController;
            cityViewController.City = result;
            NavigationController.PushViewController(cityViewController, true);
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);

            var source = new FavoriteTableViewSource(new List<string>(GlobalSettings.FavoritesList.Keys));
            TableFavorites.Source = source;
            TableFavorites.ReloadData();
            source.SelectedItem += (sender, e) =>
            {
                var data = GlobalSettings.FavoritesList[e as string];
                NavigateToCityDetails(data);
            };
        }
    }
}