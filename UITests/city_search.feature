Feature: Search for City
	I want to search for city
	
@mytag
Scenario: Search for City
    Given I am on the Home screen
	When I have entered Hyderabad into the textfield
	And I press search
	Then the result should be on the CityDetails screen
