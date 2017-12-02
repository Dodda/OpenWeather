using System;
using MvvmCross.Core.ViewModels;
using MvvmCross.iOS.Platform;
using MvvmCross.iOS.Views.Presenters;

namespace OpenWeather.iOS
{
    public class Setup : MvxIosSetup
    {
        public Setup(MvxApplicationDelegate appDelegate, IMvxIosViewPresenter presenter)
        : base(appDelegate, presenter)
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
