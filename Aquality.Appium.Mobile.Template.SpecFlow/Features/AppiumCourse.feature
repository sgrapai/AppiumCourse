Feature: Course

@course
Scenario: Testing connection with appium server
	Given Connection is ok
	When I launch 'Mastodon' app
	Then 'Mastodon' app is open
	When I close 'Mastodon' app
	Then Home screen is open
