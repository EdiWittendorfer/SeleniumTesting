using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumAutomation.BaseClass;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTesting
{
    public class TC002 : BaseTest
    {
        [Test]
        [Author("Edi Wittendorfer")]
        [Description("BakerOnline Login and Logout")]
        public void TC_002()
        {
            ExtentTest test = null;
            #region Data
            string date = DateTime.Now.ToString("ddMMyyyy-HHmmss");
            string sEmail = "bakermail1@net.hr";
            string sName = "Edi";
            string sPassword = "Baker1234!";
            #endregion

            try
            {
                test = extent.CreateTest("TC002").Info("Test started");

                MainPageObjects mainPage = new MainPageObjects();
                LoginPageObject loginPage = new LoginPageObject();

                mainPage.Login();
                test.Log(Status.Pass, "Clicking on login button");

                loginPage.Login(sEmail, sPassword);
                test.Log(Status.Pass, "User " + sName + " loged it.");

                mainPage.Logout();
                test.Log(Status.Pass, "User " + sName + " loged out.");

                test.Log(Status.Pass, "Test completed");

            }
            catch (Exception e)
            {
                #region generate screenshot
                //Generate screenshot
                ITakesScreenshot ts = Properties.driver as ITakesScreenshot;
                Screenshot screenshot = ts.GetScreenshot();

                //Save location for the screenshot *Should be adjusted for personal use*
                screenshot.SaveAsFile(@"C:\Users\Korisnik\source\repos\SeleniumTesting\SeleniumTesting\Screenshot\Screenshot" + date + ".png", ScreenshotImageFormat.Png);
                #endregion

                //Loging failed reason 
                test.Log(Status.Fail, e.Message + " " + e.StackTrace);

                throw;
            }
        }

    }
}
