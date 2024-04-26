using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using Aquality.Appium.Mobile.Actions;
using Aquality.Appium.Mobile.Applications;
using Aquality.Appium.Mobile.Elements.Interfaces;
using Aquality.Appium.Mobile.Screens;
using Aquality.Appium.Mobile.Template.Models;
using Aquality.Appium.Mobile.Template.Utilities;
using OpenQA.Selenium;

namespace Aquality.Appium.Mobile.Template.Screens.Mastodon
{
    public abstract class ExploreScreen : Screen
    {
        protected readonly ILabel toolbar;
        protected readonly ILabel posts;
        protected readonly ILabel searchLabel;
        protected readonly ITextBox searchfield;
        protected readonly IButton searchResults;
        protected readonly ILabel fourthPost;
        protected readonly ILabel topHeader;
        protected readonly string childrenFooterLoc;
        protected readonly string childrenHeaderLoc;
        protected readonly string childrenBodyLoc;

        protected ExploreScreen(By locator) : base(locator, "Mastodon explore screen")
        {
            posts = ElementFactory.GetLabel(PostsLoc, "Posts");
            toolbar = ElementFactory.GetLabel(ToolbarLoc, "Tool Bar");
            searchLabel = ElementFactory.GetLabel(SearchLabelLoc, "SearchLabel");
            searchfield = ElementFactory.GetTextBox(SearchfieldLoc, "Search field");
            searchResults = ElementFactory.GetButton(ResultsLoc, "Search results");
            fourthPost = ElementFactory.GetLabel(PostLoc, "Fourth post");
            topHeader = ElementFactory.GetLabel(TopHeaderLoc, "Top Header");
            childrenFooterLoc = ChildrenFooterLoc;
            childrenHeaderLoc = ChildrenHeaderLoc;
            childrenBodyLoc = ChildrenBodyLoc;
        }

        protected abstract By PostsLoc { get; }
        protected abstract By ToolbarLoc { get; }
        protected abstract By SearchLabelLoc { get; }
        protected abstract By SearchfieldLoc { get; }
        protected abstract By ResultsLoc { get; }
        protected abstract By PostLoc { get; }
        protected abstract By TopHeaderLoc {  get; }
        protected abstract string ChildrenFooterLoc { get; }
        protected abstract string ChildrenHeaderLoc { get; }
        protected abstract string ChildrenBodyLoc { get; }


        public void TapFirstPost() => posts.Click();
        public bool IsPostOpened() => toolbar.State.WaitForDisplayed();
        public bool ArePosts() => posts.State.WaitForDisplayed();
        public ElementPosition GetSearchfieldPos()
        {
            Point location = searchLabel.GetElement().Location;
            ElementPosition position = new ElementPosition()
            {
                X = location.X,
                Y = location.Y
            };

            return position;
        }
        public string GetPostText()
        {
            return posts.FindChildElement<IButton>(By.XPath(childrenBodyLoc)).Text;
        }
        public void TapByPosition(int X, int Y) => AqualityServices.TouchActions.SwipeWithLongPress(new Point(X, Y), new Point(X, Y));
        public void SetSearchfield(string value) => searchfield.SendKeys(value);
        public string GetSearchfieldValue() => searchfield.Text;
        public void TapFirstResult() => searchResults.Click();
        public void ScrollToPost() => fourthPost.TouchActions.ScrollToElement(SwipeDirection.Down);
        public string ShowContextHandles()
        {
            foreach (var item in AqualityServices.Application.Driver.Contexts)
            {
                Console.WriteLine(item);
            }

            return AqualityServices.Application.Driver.Context;
        }
        public void ScrollToPost(int postNumber)
        {
            int counter = 0;
            while (counter < postNumber)
            {
                IList<ILabel> postHeaderList = posts.FindChildElements<ILabel>(By.XPath(childrenHeaderLoc)).ToList<ILabel>();
                ILabel firstFooter = posts.FindChildElement<ILabel>(By.XPath(childrenFooterLoc), "First Footer found in screen");
                int displayedPosts = postHeaderList.Count;
                ILabel lastHeaderPost = postHeaderList[displayedPosts - 1];
                if (counter + displayedPosts < postNumber)
                {
                    ScrollUtilities.HideElementBehind(lastHeaderPost, topHeader);
                    if (!firstFooter.State.IsDisplayed)
                    {
                        ScrollUtilities.ScrollUntilDisplayed(firstFooter);
                    }
                    ScrollUtilities.HideElementBehind(firstFooter, topHeader);
                    counter += displayedPosts;
                }
                else
                {
                    int index = postNumber - counter;
                    ILabel targetPost = postHeaderList[index - 1];
                    ScrollUtilities.ScrollUntilQuarter(targetPost);
                    break;
                }
            }
        }
        public void ScrollBackToPost(string parameter)
        {
            string postLoc = childrenBodyLoc.Replace("]", $" and contains(@text, \"{parameter}\")]");
            ILabel firstPost = posts.FindChildElement<ILabel>(By.XPath(postLoc));
            firstPost.TouchActions.ScrollToElement(SwipeDirection.Up);
        }
    }
}
