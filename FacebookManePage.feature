Feature: FacebookManePage
	In order to use Facebook application
	As a potential Facebook user
	I want to register facebook account through Main page

@mytag
Scenario: Registration test
	Given Facebook main page is opened
	When I input 'Yanina' in name field
	And I input 'Беляков' in last name field
	And I input '380664563214' in number field
	And I input '123123qwe' in password field
	And I choose '22' in day list
	And I choose 'янв' in month list
	And I choose '1955' in year list
	And I choose gender
	And I click on the Registration button

