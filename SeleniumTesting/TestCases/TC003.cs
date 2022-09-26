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
    public class TC003 : BaseTest
    {
        [Test]
        [Author("Edi Wittendorfer")]
        [Description("BakerOnline Reset password")]
        public void TC_003()
        {
            ExtentTest test = null;

            #region Data
            string date = DateTime.Now.ToString("ddMMyyyy-HHmmss");
            string sEmail = "bakermail1@net.hr";
            string sName = "Edi";
            string sPassword = "Baker1234!";
            string sNewPassword = "Baker5678!";
            #endregion

            try
            {
                test = extent.CreateTest("TC003").Info("Test started");

                MainPageObjects mainPage = new MainPageObjects();
                LoginPageObject loginPage = new LoginPageObject();
                MailPageObjects mailPageObjects = new MailPageObjects();

                mainPage.Login();
                loginPage.ResetPassword(sEmail);

                Properties.driver.Navigate().GoToUrl("https://user.net.hr/");

                mailPageObjects.LoginAndResetPassword(sEmail, sPassword);
                test.Log(Status.Pass, "Login to the mail and requesting a password reset");

                loginPage.NewPassword(sNewPassword);
                test.Log(Status.Pass, "Serring up a new password");
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
