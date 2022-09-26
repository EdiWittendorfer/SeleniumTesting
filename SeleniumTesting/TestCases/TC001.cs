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
    public class TC001 : BaseTest
    {
        [Test]
        [Author("Edi Wittendorfer")]
        [Description("BakerOnline Register")]
        public void TC_001()
        {
            ExtentTest test = null;
            #region
            string date = DateTime.Now.ToString("ddMMyyyy-HHmmss");
            string sEmail = "bakermail"+ date +"@net.hr";
            string sName = "Edi";
            string sLastName = "Wittendorfer";
            string sPassword = "Baker1234!";
            string sPhoneNumber = "+385911231231";
            #endregion

            try
            {
                test = extent.CreateTest("TC001").Info("Test started");

                MainPageObjects mainPage = new MainPageObjects();

                test.Log(Status.Pass, "Filling register form");
                mainPage.Register(sEmail, sName, sLastName, sPassword, sPhoneNumber);
                test.Log(Status.Pass, "New user " + sName + " " + sLastName + " created");

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
