using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SeleniumTesting
{
    public static class GetMethods
    {
        /// <summary>
        /// Extended method for verifying text in the control
        /// </summary>
        /// <param name="element"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string VerifyText(this IWebElement element, string value)
        {
            try
            {
                string elementValue = element.GetAttribute("value");
                if(elementValue == value)
                {
                    return element.GetAttribute("value");
                }
                else
                {
                    throw new Exception(String.Format("Text doesn't match", value, elementValue));
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
