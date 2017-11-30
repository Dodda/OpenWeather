using System;
using TechTalk.SpecFlow;
using Xamarin.UITest;

namespace OpenWeather.UITests.Steps
{
    [Binding]
    public class CitySearchStep : StepsBase
    {
        [Given(@"I am on the Home screen")]
        public void GivenIAmOnTheHomeScreen()
        {
            app.Screenshot("Given I am on the Home screen");
        }

        [When(@"I have entered Hyderabad into the textfield")]
        public void WhenIHaveEnteredHyderabadIntoTheTextfield()
        {
           // ScenarioContext.Current.Pending();
        }

        [When(@"I press search")]
        public void WhenIPressSearch()
        {
           // ScenarioContext.Current.Pending();
        }

        [Then(@"the result should be on the CityDetails screen")]
        public void ThenTheResultShouldBeOnTheCityDetailsScreen()
        {
            //ScenarioContext.Current.Pending();
        }
    }

}
