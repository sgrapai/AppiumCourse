Feature: Mastodon

Background: Establishing connection and openning app
	Given Connection is ok
	Then Mastodon Login Screen is opened
	When I tap on log in button
	And Select Mastodon.social server
	Then Web Login Screen is opened
	When I log in Mastodon.social with 'taccs.grapai@gmail.com' username and '9wsjdxyZ!fyXLu8' password
	And I authorize log in
	Then Mastodon app is opened
	When I tap on Explore
	Then There are posts displayed

@Course
@Task9
Scenario: Interaction with elements
	When I get the position of the searchfield and save it as 'Searchfield position'
	And I tap the searchfield by position at 'Searchfield position'
	And Fill in 'Tests'
	Then The search request should be 'Tests'
	When I tap on search
	And I open first result
	And I scroll down to fourth post

@Course
@Task10
Scenario: Task context
	When I get the current context
	Then Current context should be 'NATIVE_APP'

@Course
@Task12
Scenario: Swipes and appium visibility
	When I get the position of the first post
	And I scroll down to post 4
	And Scroll back to first post
	And I scroll down to post 20

@Course
@Task13
Scenario: Appium visibility
	When I scroll down to post 20
	Then Post 20 is being displayed

@Course
@Task14
Scenario: Keyboard processing
	When I get the position of the searchfield and save it as 'Searchfield position'
	And I tap the searchfield by position at 'Searchfield position'
	Then The keyboard is being displayed
	When I tap on search
	Then The keyboard shouldn't be displayed
	When I tap the searchfield
	Then The keyboard is being displayed
	When I press enter on keyboard
	Then The keyboard shouldn't be displayed
	When I tap the searchfield
	Then The keyboard is being displayed
	When I hide the keyboard
	Then The keyboard shouldn't be displayed
	When I tap the searchfield
	Then The keyboard is being displayed
	When I tap outside the keyboard
	Then The keyboard shouldn't be displayed