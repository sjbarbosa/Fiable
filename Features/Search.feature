Feature: Search

The website allows users to search for businesses using their names or ABNs and provides results.

Background:
	Given I go to ABN lookup website
	And the search field is empty

@functional
#Entering single to multiple keyword and validate response
Scenario: Search using any keyword
	When I enter a keyword in the search field
	And I click the search button 
	Then I should see search results
	And I should see keyword matches responses in the name column

#@functional
#Entering an empty search query and validate response
#Scenario: Search using empty string
#	When I click the search button
#	Then I should see "Search text required" notification

#@functional
#Entering an invalid query such as special characters only
#Scenario: Search using special characters
#	When I enter special characters in 'SearchText'
#	And I click the search button 
#	Then I should see "No matching names found" notification

#@functional
#Entering a valid query and validate the pagination
#Scenario: Search and validate the end of pagination
#	When I enter 'ABN' in 'SearchText'
#	And I click the search button
#	Then I should see pagination
#	And I should see keyword matches responses in the name column in each pagination

#@functional
#Entering a long query and validate response
#Scenario: Search using long query
#	When I enter a 'ABN AMRO EQUITY CAPITAL MARKETS AUSTRALIA LIMITED' in 'SearchText'
#	And I click the search button
#	Then I should see 'ABN AMRO EQUITY CAPITAL MARKETS AUSTRALIA LIMITED'
#	And I should see keyword matches responses in the name column