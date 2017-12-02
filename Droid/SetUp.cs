using Android.Content;
using MvvmCross.Core.ViewModels;
using MvvmCross.Droid.Platform;

namespace OpenWeather.Droid
{
    public class Setup : MvxAndroidSetup
    {
        public Setup(Context applicationContext)
            : base(applicationContext)
        {
        }

        protected override MvvmCross.Platform.Logging.MvxLogProviderType GetDefaultLogProviderType()
        {
            return MvvmCross.Platform.Logging.MvxLogProviderType.None;
        }

        protected override IMvxApplication CreateApp()
        {
            return new App();
        }
    }
}
