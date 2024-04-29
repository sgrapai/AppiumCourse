Feature: Mastodon

Background: Establishing connection and openning app
	#Given Connection is ok
	#When I launch Mastodon app
	#Then Mastodon Login Screen is opened
	#When I tap on log in button
	#	And Select Mastodon.social server
	#Then Web Login Screen is opened
	#When I log in with data:
	#	| Name     | Value                  |
	#	| Username | taccs.grapai@gmail.com |
	#	| Password | 9wsjdxyZ!fyXLu8        |
	#	And I authorize log in
	#Then Mastodon app is opened
	#When I tap on Explore
	#Then There are posts displayed

@Course
@Task9
Scenario Outline: Interaction with elements
	When I get the position of the searchfield
		And I tap the searchfield by position
		And Fill in 'Tests'
	Then The search request should be 'Tests'
	When I tap on search
		And I open first result
		And I scroll down to fourth post

@Course
@Task10
Scenario Outline: Task context
	When I get the current context
	Then Current context should be 'NATIVE_APP'

@Course
@Task12
Scenario Outline: Swipes and appium visibility
	When I get the position of the first post
		And I scroll down to post 4
		And Scroll back to first post
		And I scroll down to post 20

@Course
@Task13
Scenario Outline: Appium visibility
	When I scroll down to post 20
	Then Post 20 is being displayed

@Course
@Task14
Scenario Outline: Keyboard processing
	When I get the position of the searchfield
		And I tap the searchfield by position
		Then The keyboard is being displayed
		When I tap on search
		Then The keyboard shouldn't be displayed
	When I tap the searchfield
		Then The keyboard is being displayed
		When I send keys to the keyboard
		Then The keyboard shouldn't be displayed
	When I tap the searchfield
		Then The keyboard is being displayed
		When I hide the keyboard
		Then The keyboard shouldn't be displayed
	When I tap the searchfield
		Then The keyboard is being displayed
		When I tap outside the keyboard
		Then The keyboard shouldn't be displayed


@Probes
Scenario: Probes
	When Probe