Feature: Categories Web API
		Web APi to get categories

A short summary of the feature

@mytag
Scenario: Get categories
	Given the repository has categories data
	When I make a GET request to 'categories'
	Then the response status code is '200'
	And the response json should be 'categories.json'

Scenario: Get category by id
	Given the repository has categories data
	When I make a GET request with id '6e27b4b8-e66c-450a-bf41-58344b208512' to 'categories'
	Then the response status code is '200'
	And the response json should be 'category.json'

Scenario: Add category
	Given the repository has categories data
	When I make a POST request with 'category.json' to 'categories'
	Then the response status code is '201'

Scenario: Update category
	Given the repository has categories data
	When I make a PUT request with '6e27b4b8-e66c-450a-bf41-58344b208512' to 'categories'
	Then the response status code is '200'
	And the response entity should be 'category.json'
	
Scenario: Remove category
	Given the repository has categories data
	When I make a DELETE request with id '6e27b4b8-e66c-450a-bf41-58344b208513' to 'categories'
	Then the response status code is '204'
