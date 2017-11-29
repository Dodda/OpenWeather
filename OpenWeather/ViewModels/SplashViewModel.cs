using System;

namespace OpenWeather.ViewModels
{
    public class SplashViewModel : BaseViewModel
    {
        public string SplashMessage { get; }

        public int WaitTime { get; }

        public SplashViewModel()
        {
            SplashMessage = "Open Weather";
            WaitTime = 2000;
        }

    }
}
