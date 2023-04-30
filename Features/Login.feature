Feature: Login functionality

User navigates to the application and login 

@login @smoke @regression
Scenario: Standart user login
	#Given user is navigated to the application
	When user enters valid username "standard_user" and valid password "secret_sauce"
	#When user enters valid username and valid password
	And user clicks on login button
	Then user is successfully logged in

@login @regression
Scenario: Locked user login
	When user enters locked username "locked_out_user" and valid password "secret_sauce"
	And user clicks on login button
	Then error message is displayed

@login @regression
Scenario: Problem user login
	When user enters problem username "problem_user" and valid password "secret_sauce"
	And user clicks on login button
	Then user is successfully logged in

@login @regression
Scenario: Performance glitch user login
	When user enters performance glitch username "performance_glitch_user " and valid password "secret_sauce"
	And user clicks on login button
	Then user is successfully logged in