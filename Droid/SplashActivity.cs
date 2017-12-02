using System.Threading;
using System.Threading.Tasks;
using Android.App;
using Android.OS;
using Android.Widget;
using MvvmCross.Droid.Views;
using OpenWeather.ViewModels;

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
