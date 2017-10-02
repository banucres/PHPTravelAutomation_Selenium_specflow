Feature: ProfileUpdate
	Responsible for  updating  my profile details.
	My profie includes Personal Information and your location details.

@smoke
Scenario: Check to update My Profile details.
	Given I have navigated to the application
	When I enter UserName and Password and click login 
	| UserName | Password |
	| user@phptravels.com    | demouser |
	Then I click login button 
	Then I should see the username with hi
	Then I click MyProfile Tab
	And  I clear already existing details
	Then I enter the following details
	 | Address1 | Address2  |
	 | R3Avenue | Avenwelly |
	And I click submit button


