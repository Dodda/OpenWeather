Feature: City Search
	I want to be search for city
	
@citySearch
Scenario: City Search
	Given I am on the Home Screen
	When I have entered Hyderabad into the textfield
	When I press search
	Then the result should be displayed on the city details screen
