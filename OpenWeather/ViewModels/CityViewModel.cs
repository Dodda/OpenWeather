namespace OpenWeather.ViewModels
{
    public class CityViewModel : BaseViewModel
    {
        public string PageTitle { get; }

        public string ButtonText { get; }

        public CityViewModel()
        {
            PageTitle = "City Weather Details";
            ButtonText = "Add To Favorites";
        }
    }
}
