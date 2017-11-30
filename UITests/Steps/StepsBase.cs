using System;
using OpenWeather.UITests.Screens;
using OpenWeather.UITests.Screens.CitySearch;
using TechTalk.SpecFlow;
using Xamarin.UITest;

namespace OpenWeather.UITests.Steps
{
    public class StepsBase
    {
        protected readonly ICitySearchScreen homeScreen;
        //protected readonly IAddTaskScreen addTaskScreen;
        protected readonly IApp app;

        public StepsBase()
        {
            app = FeatureContext.Current.Get<IApp>("App");
            homeScreen = FeatureContext.Current.Get<ICitySearchScreen>(ScreenNames.CitySearch);
            //addTaskScreen = FeatureContext.Current.Get<IAddTaskScreen>(ScreenNames.AddTask);
        }
    }
}
