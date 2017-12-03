using System;
using OpenWeather.ViewModels;
using System.Collections.Generic;
using MvvmCross.iOS.Views;
using MvvmCross.Binding.BindingContext;
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
            var set = this.CreateBindingSet<HomeViewController, HomeViewModel>();
            set.Bind().For(x => x.Title).To(vm => vm.PageTitle);
            set.Bind(TextSearch).For(x => x.Placeholder).To(vm => vm.PlaceHolerText);
            set.Bind(ButtonSearch).For(x => x.TitleLabel.Text).To(vm => vm.SearchButtonText);
            set.Bind(ButtonSearch).To(vm => vm.SearchCommand);
            set.Bind(TextSearch).To(vm => vm.SearchText);
            set.Bind(ActivityLoader).For(x => x.Hidden).To(vm => vm.IsVisible).Mode(MvvmCross.Binding.MvxBindingMode.TwoWay);
            set.Apply();
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
            ActivityLoader.StopAnimating();
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