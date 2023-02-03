Feature: Alerts

@Alerts
Scenario: Text entered in alert prompt is the same as appeared
	Given Navigate to main page
	When I click on Alerts, Frame & Windows button
	And I click on Alerts button
	Then Alerts form page has appeared
	When I click on Click Button to see alert button
	Then Alert with text "You clicked a button" is open
	When I click OK button
	Then Alert has closed
	When I click on On button click, confirm box will appear button
	Then Alert with text "Do you confirm action?" is open
	When I click OK button
	Then Alert has closed
	When I click on On button click, prompt box will appear button
	Then Alert with text "Please enter your name" is open
	When I generate random string and save as "randomString"
	And I enter randomly generated text saved as "randomString"
	And I click OK button
	Then Alert has closed
	And Appeared text equals saved text as "randomString"
