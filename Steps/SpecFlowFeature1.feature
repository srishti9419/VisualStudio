
Feature: Login feature


	@tag2
	Scenario Outline: user logs in successfully using scenario outline
	Given user hits the url
	
	When enter "<username>" and "<password>"

	

	And click on login
	Then should be on homePage

	Examples: 
	|username|password|
	|user@phptravels.com|demouser|

