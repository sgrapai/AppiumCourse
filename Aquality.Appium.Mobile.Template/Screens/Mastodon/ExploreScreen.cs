using System;
using System.Drawing;
using Aquality.Appium.Mobile.Actions;
using Aquality.Appium.Mobile.Applications;
using Aquality.Appium.Mobile.Elements.Interfaces;
using Aquality.Appium.Mobile.Screens;
using Aquality.Appium.Mobile.Template.Models;
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

        protected ExploreScreen(By locator) : base(locator, "Mastodon explore screen")
        {
            posts = ElementFactory.GetLabel(PostsLoc, "Posts");
            toolbar = ElementFactory.GetLabel(ToolbarLoc, "Tool Bar");
            searchLabel = ElementFactory.GetLabel(SearchLabelLoc, "SearchLabel");
            searchfield = ElementFactory.GetTextBox(SearchfieldLoc, "Search field");
            searchResults = ElementFactory.GetButton(ResultsLoc, "Search results");
            fourthPost = ElementFactory.GetLabel(PostLoc, "Fourth post");
        }

        protected abstract By PostsLoc { get; }
        protected abstract By ToolbarLoc { get; }
        protected abstract By SearchLabelLoc { get; }
        protected abstract By SearchfieldLoc { get; }
        protected abstract By ResultsLoc { get; }
        protected abstract By PostLoc { get; }


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
        public void TapByPosition(int X, int Y) => AqualityServices.TouchActions.SwipeWithLongPress(new Point(X, Y), new Point(X, Y));
        public void SetSearchfield(string value) => searchfield.SendKeys(value);
        public string GetSearchfieldValue() => searchfield.Text;
        public void TapFirstResult() => searchResults.Click();
        public void ScrollDownToPost() => fourthPost.TouchActions.ScrollToElement(SwipeDirection.Down);
        public string ShowContextHandles()
        {
            foreach (var item in AqualityServices.Application.Driver.Contexts)
            {
                Console.WriteLine(item);
            }

            return AqualityServices.Application.Driver.Context;
        }
    }
}
