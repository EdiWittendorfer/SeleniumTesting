using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Support;
using SeleniumExtras.PageObjects;
using System.Threading;
using NUnit.Framework;
using System.Linq;

namespace SeleniumTesting
{
    class LoginPageObject
    {
        public LoginPageObject()
        {
            PageFactory.InitElements(Properties.driver, this);
        }
        #region Mapping
        [FindsBy(How = How.Name, Using = "username")]
        public IWebElement txtEmail { get; set; }

        [FindsBy(How = How.Name, Using = "password")]
        public IWebElement txtPassword { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='app']/main/div[1]/section/form/div/button")]
        public IWebElement btnLogin { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='app']/main/div[1]/section/form/div/a")]
        public IWebElement btnForgotPassword { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='app']/main/div[1]/section/form/div[1]/div[1]/input")]
        public IWebElement txtEmailForgotPassword { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='app']/main/div[1]/section/form/div[2]/button")]
        public IWebElement btnSendForgotPassword { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='app']/main/div[1]/section/header/ul/li")]
        public IWebElement lblSuccessMessage { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/main/div[1]/section/form/input[1]")]
        public IWebElement txtNewPassword { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='app']/main/div[1]/section/form/input[2]")]
        public IWebElement txtRepeatNewPassword { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='app']/main/div[1]/section/form/div/button")]
        public IWebElement btnSave { get; set; }        

        #endregion

        public LoginPageObject Login(string sEmail, string sPassword)
        {
            txtEmail.IsDisplayed();
            txtEmail.IsEnabled();
            txtEmail.VerifyText(""); //Verify that textbox is empty

            txtPassword.IsDisplayed();
            txtPassword.IsEnabled();
            txtPassword.VerifyText("");

            btnLogin.IsDisplayed();
            btnLogin.IsEnabled();

            //STEP: Enter corresponding string into "Email" textbox.
            txtEmail.EnterText(sEmail);
            txtEmail.VerifyText(sEmail);

            //STEP: Enter corresponding string into "Password" textbox.
            txtPassword.EnterText(sPassword);
            txtPassword.VerifyText(sPassword);

            //STEP: Clicks "Login" button.
            btnLogin.Clicks();

            return new LoginPageObject();
        }
        public LoginPageObject ResetPassword(string sEmail)
        {
            btnForgotPassword.IsDisplayed();
            btnForgotPassword.IsEnabled();

            //STEP: Clicks "Forgot password" button.
            btnForgotPassword.Clicks();

            txtEmailForgotPassword.IsDisplayed();
            txtEmailForgotPassword.IsEnabled();
            txtEmailForgotPassword.VerifyText(""); //Verify that textbox is empty

            btnSendForgotPassword.IsDisplayed();
            btnSendForgotPassword.IsEnabled();

            //STEP: Enter corresponding string into "Email" textbox.
            txtEmailForgotPassword.EnterText(sEmail);
            txtEmailForgotPassword.VerifyText(sEmail);

            //STEP: Clicks "Send" button.
            btnSendForgotPassword.Clicks();

            lblSuccessMessage.IsDisplayed();

            return new LoginPageObject();
        }
        public LoginPageObject NewPassword(string sNewPassword)
        {
            Properties.driver.SwitchTo().Window(Properties.driver.WindowHandles.Last());

            txtNewPassword.IsDisplayed();
            txtNewPassword.IsEnabled();
            txtNewPassword.VerifyText("");

            txtRepeatNewPassword.IsDisplayed();
            txtRepeatNewPassword.IsEnabled();
            txtRepeatNewPassword.VerifyText("");

            btnSave.IsDisplayed();
            btnSave.IsEnabled();

            //STEP: Enter corresponding string into "New password" textbox.
            txtNewPassword.EnterText(sNewPassword);
            txtNewPassword.VerifyText(sNewPassword);

            //STEP: Enter corresponding string into "Repeart new password" textbox.
            txtRepeatNewPassword.EnterText(sNewPassword);
            txtRepeatNewPassword.VerifyText(sNewPassword);

            //STEP: Clicks "Forgot password" button.
            btnSave.Clicks();

            lblSuccessMessage.IsDisplayed();

            return new LoginPageObject();
        }

    }
}
