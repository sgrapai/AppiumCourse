Feature: Course

Background: Establishing connection and openning app
	Given Connection is ok
	

@Course
@Task7
Scenario: At testing connection with appium server
	When I close Mastodon app
	And I launch Mastodon app
	Then Home Screen is opened

@Course
@Task8
Scenario: Searching for items and startup/shutdown of applications
	Given Mastodon Login Screen is opened
	When I close Mastodon app
	And I launch Mastodon app
	Given Mastodon Login Screen is opened
	When I tap on log in button
	And Select Mastodon.social server
	Then Web Login Screen is opened
	When I log in Mastodon.social with 'taccs.grapai@gmail.com' username and '9wsjdxyZ!fyXLu8' password
	And I authorize log in
	Then Mastodon app is opened
	When I tap on Explore
	And I tap the first post
	Then First post is opened