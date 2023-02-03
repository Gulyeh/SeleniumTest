@Tables
Feature: Tables

Scenario Outline: Add and remove user from a table
	Given Navigate to main page
	When I click on Elements button
	And I click on Web Tables button in the menu
	Then Page with Web Tables form is open
	When I click on Add button
	Then Registration Form has appeared on page
	When I complete user data form
	| FirstName   | LastName   | Email   | Age   | Salary   | Department   |
	| <FirstName> | <LastName> | <Email> | <Age> | <Salary> | <Department> |
	And I click Submit button
	Then Registration form has closed
	And User data has appeared in the table
	When I click delete button in a row which contains user data
	Then Number of records in table has changed
	And User data has been deleted from table

Examples:
	| FirstName  | LastName      | Email                     | Age | Salary | Department |
	| Jon        | Snow          | knownothing@gmail.com     | 30  | 3000   | alpha      |
	| Buttercup  | Cumbersnatch  | BudapestCandygram@mail.io | 41  | 2000   | beta       |




