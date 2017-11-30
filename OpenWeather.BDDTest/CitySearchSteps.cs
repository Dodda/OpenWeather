﻿using TechTalk.SpecFlow;

namespace OpenWeather.BDDTest
{
    [Binding]
    public class CitySearchSteps :StepsBase
    {
        [Given(@"I am on the Home Screen")]
        public void GivenIAmOnTheHomeScreen()
        {
            app.Screenshot("I am on the Home Screen");
        }

        [When(@"I have entered Hyderabad into the textfield")]
        public void WhenIHaveEnteredHyderabadIntoTheTextfield()
        {
            app.EnterText(x => x.Id("searchText"), "Hyderabad");  
        }

        [When(@"I press search")]
        public void WhenIPressSearch()
        {
            app.Tap(x => x.Id("searchButton"));
        }

        [Then(@"the result should be displayed on the city details screen")]
        public void ThenTheResultShouldBeOnTheCityDetailsScreen()
        {
            app.Screenshot("The result on the city details screen");
        }
    }
}
