using MvvmCross.Core.ViewModels;
using OpenWeather.Models;

namespace OpenWeather.ViewModels
{
    public class CityViewModel : MvxViewModel<CityWeather>
    {
        public string PageTitle { get; }
        public string ButtonText { get; }
        public CityWeather CityDetails { get; set; }

        public override void Prepare(CityWeather parameter)
        {
            CityDetails = parameter;
        }

        public CityViewModel()
        {
            PageTitle = "City Weather Details";
            ButtonText = "Add To Favorites";
        }

        private IMvxCommand addToFavoritesCommand;
        public virtual IMvxCommand AddToFavoritesCommand
        {
            get
            {
                addToFavoritesCommand = addToFavoritesCommand ?? new MvxCommand(() =>
                {
                    if (!GlobalSettings.FavoritesList.ContainsKey(CityDetails.name))
                    {
                        GlobalSettings.FavoritesList.Add(CityDetails.name, CityDetails);
                    }
                });

                return addToFavoritesCommand;
            }
        }
    }
}
