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
    public class TC004 : BaseTest
    {
        [Test]
        [Author("Edi Wittendorfer")]
        [Description("BakerOnline Make an order")]
        public void TC_004()
        {
            ExtentTest test = null;

            #region Data
            string date = DateTime.Now.ToString("ddMMyyyy-HHmmss");
            string sEmail = "bakermail1@net.hr";
            string sPassword = "Baker1234!";
            string sFirstProduct = "Whole Wheat Bread";
            string sSecoundProduct = "Croissant";
            #endregion

            try
            {
                test = extent.CreateTest("TC004").Info("Test started");

                MainPageObjects mainPage = new MainPageObjects();
                LoginPageObject loginPage = new LoginPageObject();
                MailPageObjects mailPageObjects = new MailPageObjects();
                OrderPageObject orderPageObject = new OrderPageObject();

                mainPage.Search(sFirstProduct);
                test.Log(Status.Pass, "Search for a product as a visitor");

                mainPage.Login();
                test.Log(Status.Pass, "Navigate to login page");

                loginPage.Login(sEmail, sPassword);
                test.Log(Status.Pass, "Login to an existing user");

                mainPage.Search(sSecoundProduct);
                test.Log(Status.Pass, "Search for a product as a user");

                mainPage.Order(3);
                test.Log(Status.Pass, "Order 4 of the same product");

                orderPageObject.Checkout();
                test.Log(Status.Pass, "Proceed to checkout and order the product");
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
