using System;
using OpenWeather.ViewModels;
using System.Collections.Generic;
using MvvmCross.iOS.Views;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platform;
namespace OpenWeather.iOS
{
    [MvxFromStoryboard("Main")]
    public partial class HomeViewController : MvxViewController<HomeViewModel>
    {
        public HomeViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            //MvvmCross Binding for UI Controls.

            ButtonSearch.TitleLabel.Text = ViewModel.SearchButtonText;
            TextSearch.Placeholder = ViewModel.PlaceHolerText;
            var set = this.CreateBindingSet<HomeViewController, HomeViewModel>();
            set.Bind(Title).To(vm => vm.PageTitle);
            set.Bind(ButtonSearch).To(vm => vm.SearchCommand);
            set.Bind(TextSearch).To(vm => vm.SearchText);
            set.Apply();
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);

            var source = new FavoriteTableViewSource(new List<string>(GlobalSettings.FavoritesList.Keys));
            TableFavorites.Source = source;
            TableFavorites.ReloadData();

            source.SelectedItem += (sender, e) =>
            {
                var cityDetails = GlobalSettings.FavoritesList[e as string];
            };
        }
    }
}