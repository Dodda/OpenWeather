using Android.App;
using MvvmCross.Droid.Views;

namespace OpenWeather.Droid
{
    [Activity(MainLauncher = true, Icon = "@mipmap/icon")]
    public class SplashActivity : MvxSplashScreenActivity
    {
        public SplashActivity()
            : base(Resource.Layout.SplashLayout)
        {
        }
    }
}
