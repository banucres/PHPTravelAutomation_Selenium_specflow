Feature: Login
	Check if the login functionality is working 
	as expected with different permutations and 
	combinations of data


@smoke
Scenario: Check login with correct username and password
	Given I have navigated to the application
	And I see application opened
	When I enter UserName and Password and click login 
	| UserName | Password |
	| user@phptravels.com    | demouser |
	Then I click login button 
	Then I should see the username with hi
