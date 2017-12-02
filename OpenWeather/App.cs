using System;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform.IoC;

namespace OpenWeather
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterNavigationServiceAppStart<ViewModels.HomeViewModel>();
        }
    }
}
