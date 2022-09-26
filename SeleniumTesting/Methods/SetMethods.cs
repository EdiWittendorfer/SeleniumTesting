using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumTesting
{
    public static class SetMethods
    {
        /// <summary>
        /// Extended method for entering text in the control
        /// </summary>
        /// <param name="element"></param>
        /// <param name="value"></param>
        public static void EnterText(this IWebElement element, string value)
        {
            element.SendKeys(value);
        }


        /// <summary>
        /// Click into a button, checkbox, option etc.
        /// </summary>
        /// <param name="element"></param>
        public static void Clicks(this IWebElement element)
        {
            element.Click();
        }

        /// <summary>
        /// Selecting a dropdown cell
        /// </summary>
        /// <param name="element"></param>
        /// <param name="value"></param>
        public static void SelectDropDown(this IWebElement element, string value)
        {
            new SelectElement(element).SelectByText(value);
        }

        /// <summary>
        /// Checks if element is displayed
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public static bool IsDisplayed(this IWebElement element)
        {
            bool result;
            try
            {
                result = element.Displayed;
            }
            catch (Exception)
            {
                result = false;
            }
            // Log the Action
            return result;
        }

        /// <summary>
        /// Checks if element is displayed
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public static bool IsEnabled(this IWebElement element)
        {
            bool result;
            try
            {
                result = element.Enabled;
            }
            catch (Exception)
            {
                result = false;
            }
            // Log the Action
            return result;
        }
    }
}
