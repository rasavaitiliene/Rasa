Feature: SkycopSteps

Scenario: Open Skycop claim page
	Given I navigate to claim
	Then I set Kaunas as Departure airport
	And I set London Gatwick as arrival airport
	And I choose airlines
	And I set 1234 as Flight number
	And I set flight data
	And I choose Flight delayed as the problem of the flight you encountered
	And I choose More than 3 hours as How long were you delayed to reach the final airport?
	And I choose what was the reason provided by airlines 
	And I choose Where did you hear about us?
	And I push the button Next step
	And I Briefly describe situation
	And I Enter flight reservation number
	And I push the button Enter travellers details
	And I write my Name
	And I write my Surname
	And I set my Birthdate
	And I write my Email
	And I repeat my Email
	And I set user phone
	And I set Address
	And I set City
	And I set Postcode
	And I choose Country
	And I choose Language
	And I push the button No, I was travelling alone
	And I click the button I have read and agree to the Terms of sevice and Privacy policy
	And I puch the button Final Step
	And I sign The assignment form