Feature: Iframe

@Iframe
Scenario: Check forms texts are equal
	Given Navigate to main page
	When I click on Alerts, Frame & Windows button
	And I click on Nested Frames button
	Then Page with Nested Frames form is open
	And There are messages "Parent frame" and "Child Iframe" present on page
	When I select Frames option in a left menu
	Then Page with Frames form is open
	And Message from upper frame is equal to the message from lower frame
