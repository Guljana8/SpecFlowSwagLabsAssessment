Feature: AddToCart

A should be able add desired item to cart
Background: 
    Given user is navigated to the application
    When user enters valid username "standard_user" and valid password "secret_sauce"
	And user clicks on login button
	Then user is successfully logged in
	When user adding desired item to the cart
	And user navigates to the cart

@cart @regression
Scenario: User able to add item to cart
	When user clicks on CHECKOUT button
    And user enters firstname "Guljan", lastname "Amer" information and ZipCode "34400"
	And user clicks on CONTINUE button
	When user clicks on the FINISH button 
	Then user is able to see 'Thank you' message for his order

@cart @regression
Scenario: User is able to continue shopping
	When user clicks on 'CONTINUE SHOPING' button
	And user come back to the home page and add another item to cart
	And user navigates to the cart
	When user clicks on CHECKOUT button
    And user enters firstname "Guljan", lastname "Amer" information and ZipCode "34400"
	And user clicks on CONTINUE button
	When user clicks on the FINISH button 
	Then user is able to see 'Thank you' message for his order

@cart @regression
 Scenario: User should be able remove item from the cart
	When user is clicking on REMOVE button
	Then item is removed


