using System;
using System.Drawing;
using System.Text.RegularExpressions;
using Aquality.Appium.Mobile.Applications;
using Aquality.Appium.Mobile.Elements.Interfaces;
using Aquality.Selenium.Core.Elements;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Aquality.Appium.Mobile.Template.Utilities
{
    public static class ScrollUtilities
    {
        private static readonly Size dims = AqualityServices.Application.Driver.Manage().Window.Size;
        private static readonly int edgeBorder = 10;
        private static readonly Point absoluteCenter = new Point(dims.Width / 2, dims.Height / 2);
        private static readonly Point absoluteTop = new Point(dims.Width / 2, edgeBorder);

        public static void HideElementBehind(IElement element, IElement endElement)
        {
            Point endPoint = new Point(element.GetElement().Location.X, endElement.GetElement().Location.Y);
            MoveToPoint(element, endPoint);
        }

        public static void ScrollUntilDisplayed(IElement element)
        {
            do
            {
                AqualityServices.TouchActions.Swipe(absoluteCenter, absoluteTop);

            } while (!element.State.IsDisplayed);
        }

        public static void ScrollUntilQuarter(IElement element)
        {
            Point quarterPoint = new Point(element.GetElement().Location.X, dims.Height / 4);
            MoveToPoint(element, quarterPoint);
        }

        private static void MoveToPoint(IElement element, Point endPoint)
        {
            element.TouchActions.Swipe(endPoint);
        }
    }
}
