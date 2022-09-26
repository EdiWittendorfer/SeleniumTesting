using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumAutomation.BaseClass
{
    public class BaseTest
    {
        public ExtentReports extent = null;
        [SetUp]
        public void Initialize()
        {
            //Setting up Log file path
            extent = new ExtentReports();
            var htmlReporter = new ExtentHtmlReporter(@"C:\Users\Korisnik\source\repos\SeleniumTesting\SeleniumTesting\Logs\Log.html");
            extent.AttachReporter(htmlReporter);

            //Launching driver 
            Properties.driver = new ChromeDriver();            

            //Navigate to website
            Properties.driver.Navigate().GoToUrl("https://bakeronline.be/be-en/demo-shop");

            Properties.driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void CleanUp()
        {
            //Closing driver
            Properties.driver.Close();
            extent.Flush();
        }
    }
}
