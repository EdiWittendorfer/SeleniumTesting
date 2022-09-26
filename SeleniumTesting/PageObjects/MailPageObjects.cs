using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Support;
using SeleniumExtras.PageObjects;
using System.Threading;

namespace SeleniumTesting
{
    class MailPageObjects
    {

        public MailPageObjects()
        {
            PageFactory.InitElements(Properties.driver, this);
        }

        #region Mapping
        [FindsBy(How = How.XPath, Using = "//*[@id='accounts-menu']")]
        public IWebElement btnUser { get; set; }

        [FindsBy(How = How.Id, Using = "ego_submit")]
        public IWebElement btnLoginToAccount { get; set; }

        [FindsBy(How = How.Id, Using = "ego_user")]
        public IWebElement txtEmail { get; set; }

        [FindsBy(How = How.Id, Using = "ego_secret")]
        public IWebElement txtPassword { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='qc-cmp2-ui']/div[2]/div/button[2]")] 
        public IWebElement btnDisagree { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='__layout']/div/div[1]/div/div[2]/nav/a[2]")]
        public IWebElement btnRefresh { get; set; }    

        [FindsBy(How = How.XPath, Using = "//div[normalize-space()='Bakeronline']")]
        public IWebElement lnkNewestMail { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='this link']")]
        public IWebElement lnkThisLink { get; set; }

       
        #endregion 


        public MailPageObjects LoginAndResetPassword(string sEmail, string sPassword)
        {
            txtEmail.IsDisplayed();
            txtEmail.IsEnabled();
            txtEmail.VerifyText("");

            txtPassword.IsDisplayed();
            txtPassword.IsEnabled();
            txtPassword.VerifyText("");

            btnLoginToAccount.IsDisplayed();
            btnLoginToAccount.IsEnabled();

            Thread.Sleep(1000);

            txtEmail.EnterText(sEmail);
            txtEmail.VerifyText(sEmail);

            txtPassword.EnterText(sPassword);
            txtPassword.VerifyText(sPassword);

            Thread.Sleep(5000);

            //STEP: Click "Login to account" button.
            btnLoginToAccount.Clicks(); //If the TestCase falis at this point, rerun it and wait for 30-45 sec. Possible fix could be to add a "wait time", but it is not practical

            Thread.Sleep(3000);

            lnkNewestMail.IsDisplayed();
            lnkNewestMail.IsEnabled();

            Thread.Sleep(3000);

            //STEP: Click "Newest mail" link.
            lnkNewestMail.Clicks();

            lnkThisLink.IsDisplayed();
            lnkThisLink.IsEnabled();

            //STEP: Click "This link" link.
            lnkThisLink.Clicks();

            return new MailPageObjects();
        }            
    }
}
