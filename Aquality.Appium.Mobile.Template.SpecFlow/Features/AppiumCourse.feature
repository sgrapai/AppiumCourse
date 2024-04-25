Feature: Course

Background: Establishing connection and openning app
	Given Connection is ok
	When I launch Mastodon app
	

@course
@Task7
Scenario Outline: Testing connection with appium server
	Then Mastodon app is opened
	When I close Mastodon app
	Then Home Screen is opened

@course
@Task8
Scenario Outline: Searching for items and startup/shutdown of applications
	Then Mastodon Login Screen is opened
	When I close Mastodon app
	Then Home Screen is opened
	When I launch Mastodon app
	Then Mastodon Login Screen is opened
	When I tap on log in button
		And Select Mastodon.social server
	Then Web Login Screen is opened
	When I log in with data:
		| Name     | Value                  |
		| Username | taccs.grapai@gmail.com |
		| Password | 9wsjdxyZ!fyXLu8        |
		And I authorize log in
	Then Mastodon app is opened
	When I tap on Explore
		And I tap the first post
	Then First post is opened

@Course
@Task9
Scenario Outline: Interaction with elements
	Then Mastodon Login Screen is opened
	When I tap on log in button
		And Select Mastodon.social server
	Then Web Login Screen is opened
	When I log in with data:
		| Name     | Value                  |
		| Username | taccs.grapai@gmail.com |
		| Password | 9wsjdxyZ!fyXLu8        |
		And I authorize log in
	Then Mastodon app is opened
	When I tap on Explore
	Then There are posts displayed
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
	Then Mastodon Login Screen is opened
	When I tap on log in button
		And Select Mastodon.social server
	Then Web Login Screen is opened
	When I log in with data:
		| Name     | Value                  |
		| Username | taccs.grapai@gmail.com |
		| Password | 9wsjdxyZ!fyXLu8        |
		And I authorize log in
	Then Mastodon app is opened
	When I tap on Explore
	Then There are posts displayed
	When I get the current context
	Then Current context should be 'NATIVE_APP'