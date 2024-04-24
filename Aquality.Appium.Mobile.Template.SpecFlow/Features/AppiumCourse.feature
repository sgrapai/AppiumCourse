Feature: Course

@course
@Task7
Scenario: Testing connection with appium server
	Given Connection is ok
	When I launch Mastodon app
	Then Mastodon app is opened
	When I close Mastodon app
	Then Home Screen is opened

@course
@Task8
Scenario: Searching for items and startup/shutdown of applications
	Given Connection is ok
	When I launch Mastodon app
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

