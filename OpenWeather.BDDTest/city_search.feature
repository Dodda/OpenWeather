Feature: City Search
	I want to be search for city
	
@citySearch
Scenario: City Search
	Given I am on the Home Screen
	When I have entered "Hyderabad" into the textfield
	When I press search
	Then the result should be displayed on the city details screen
    When I press Add To Favorites button
    When I navigate back to Home Screen
    Then I could able to see the City name on the favorites list
