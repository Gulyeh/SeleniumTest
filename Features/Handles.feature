Feature: Handles

@Handles
Scenario: Switching between tabs
	Given Navigate to main page
	When I click on Alerts, Frame & Windows button
	And I click on Browser Windows in the menu
	Then Page with Browser Windows form is open
	When I click on New Tab button
	Then New tab with sample page is open
	When I close current tab
	Then Page with Browser Windows form is open
	When I click Elements button in the menu
	And I click Links button in the menu
	Then Page with Links form is open
	When I click on Home link
	Then 2 Tabs are open
	When I switch to tab with index 1
	Then Main Page is open
	When I resume to previous tab
	Then Page with Links form is open
	
