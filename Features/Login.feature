Feature: Login functionality

User navigates to the application and login 

@login @smoke @regression
Scenario: Standart user login
	Given user is navigated to the application
	#When user enters valid username "standard_user" and valid password "secret_sauce"
	When user enters valid username and valid password
	And user clicks on login button
	Then user is successfully logged in
