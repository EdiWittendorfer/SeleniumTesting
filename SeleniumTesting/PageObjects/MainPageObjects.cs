using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Support;
using SeleniumExtras.PageObjects;
using System.Threading;

namespace SeleniumTesting
{
    class MainPageObjects
    {
        public MainPageObjects()
        {
            PageFactory.InitElements(Properties.driver, this);
        }

        #region Mapping
        [FindsBy(How = How.XPath, Using = "//*[@id='menu']/div/div[2]/div[1]/div[2]/a[1]")]
        public IWebElement btnLogIn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='menu']/div/div[2]/div[1]/div[2]/a[2]")]
        public IWebElement btnRegister { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='userName']/p[3]/input")]
        public IWebElement btnLogin { get; set; }

        [FindsBy(How = How.Name, Using = "email")]
        public IWebElement txtEmail { get; set; }

        [FindsBy(How = How.Name, Using = "password")]
        public IWebElement txtPassword { get; set; }

        [FindsBy(How = How.Name, Using = "password-repeat")]
        public IWebElement txtPasswordRepeat { get; set; }

        [FindsBy(How = How.Name, Using = "firstname")]
        public IWebElement txtFirstName { get; set; }

        [FindsBy(How = How.Name, Using = "lastname")]
        public IWebElement txtLastName { get; set; }

        [FindsBy(How = How.Name, Using = "telephone")]
        public IWebElement txtPhoneNumber { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='app']/main/div[1]/section/div/footer/button")]
        public IWebElement btnCreateAccount { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='app']/main/div[2]/div/div/header/h1")]
        public IWebElement lblTermsAndConditions { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='app']/main/div[2]/div/div/header/h1")]
        public IWebElement lblPrivacyPolicy { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='app']/main/div[2]/div/div/div[2]/button")]
        public IWebElement btnAcceptTermsAndConditions { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='app']/main/div[2]/div/div/div[2]/button")]
        public IWebElement btnAcceptPrivacyPolicy { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='menu']/div/div[2]/div[1]/div[2]/button")]
        public IWebElement btnUserLogin { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='app']/div[5]/div/div/header/h1")]
        public IWebElement lblUserLogin { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='app']/div[5]/div/div/div/a[3]")]
        public IWebElement lnkLogOut { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='app']/main/div[1]/section/ul/li")]
        public IWebElement lblEmailInUseError { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='menu']/div/div[2]/div[2]/div/div[2]/div/form/input")]
        public IWebElement txtSearch { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='productssection']/div/div[2]/div/article[1]/div/a/figure/div")]
        public IWebElement lblFirstProduct { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='app']/main/div[1]/header/div/h1/span")]
        public IWebElement lblWholeWheatBreadProduct { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='app']/main/div[1]/section/div[2]/form/div/div/div[3]/button[2]")]
        public IWebElement btnPluse { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='app']/main/div[1]/section/div[2]/form/footer/button")]
        public IWebElement btnOrder { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='app']/div[3]/div/div/div/div/div/div/textarea")]
        public IWebElement txtComment { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='app']/div[3]/div/div/div/div/div/footer/button")]
        public IWebElement btnSave { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='menu']/div/div[2]/div[1]/div[2]/div")]
        public IWebElement btnCart { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='app']/div[8]/div/div/header/a")]
        public IWebElement btnProceedOrder { get; set; }


        #endregion

        public MainPageObjects Register(string sEmail, string sName, string sLastName, string sPassword, string sPhoneNumber)
        {
            btnRegister.IsDisplayed();
            btnRegister.IsEnabled();

            //STEP: Click on button Register
            btnRegister.Clicks();

            txtEmail.IsDisplayed();
            txtEmail.IsEnabled();
            txtEmail.VerifyText("");  //Verify that textbox is empty

            txtFirstName.IsDisplayed();
            txtFirstName.IsEnabled();
            txtFirstName.VerifyText("");

            txtLastName.IsDisplayed();
            txtLastName.IsEnabled();
            txtLastName.VerifyText("");

            txtPassword.IsDisplayed();
            txtPassword.IsEnabled();
            txtPassword.VerifyText("");

            txtPasswordRepeat.IsDisplayed();
            txtPasswordRepeat.IsEnabled();
            txtPasswordRepeat.VerifyText("");

            txtPhoneNumber.IsDisplayed();
            txtPhoneNumber.IsEnabled();
            txtPhoneNumber.VerifyText("");

            btnCreateAccount.IsDisplayed();
            btnCreateAccount.IsEnabled();

            //STEP: Enter corresponding string into "Email" textbox.
            txtEmail.EnterText(sEmail);
            txtEmail.VerifyText(sEmail);

            //STEP: Enter corresponding string into "First name" textbox.
            txtFirstName.EnterText(sName);
            txtFirstName.VerifyText(sName);

            //STEP: Enter corresponding string into "Last name" textbox.
            txtLastName.EnterText(sLastName);
            txtLastName.VerifyText(sLastName);

            //STEP: Enter corresponding string into "Password" textbox.
            txtPassword.EnterText(sPassword);
            txtPassword.VerifyText(sPassword);

            //STEP: Enter corresponding string "Password repeat"  textbox.
            txtPasswordRepeat.EnterText(sPassword);
            txtPasswordRepeat.VerifyText(sPassword);

            //STEP: Enter corresponding string into "Phone number" textbox.
            txtPhoneNumber.EnterText(sPhoneNumber);
            txtPhoneNumber.VerifyText(sPhoneNumber);

            //STEP: Clicks "Create account" button.
            btnCreateAccount.Clicks();

            lblTermsAndConditions.IsDisplayed();
            btnAcceptTermsAndConditions.IsDisplayed();
            btnAcceptTermsAndConditions.IsEnabled();

            //STEP: Clicks "I read and accept these terms" button.
            btnAcceptTermsAndConditions.Clicks();

            lblPrivacyPolicy.IsDisplayed();
            btnAcceptPrivacyPolicy.IsDisplayed();
            btnAcceptPrivacyPolicy.IsEnabled();

            //STEP: Clicks "Accept privacy policy" button.
            btnAcceptPrivacyPolicy.Clicks();
            Thread.Sleep(2000);
            if(lblEmailInUseError.IsDisplayed() == true)
            {
                throw new Exception("This email alrary exists");
            }

            return new MainPageObjects();
        }

        public MainPageObjects Login()
        {
            btnLogIn.IsDisplayed();
            btnLogIn.IsEnabled();

            //STEP: Clicks "Login" button.
            btnLogIn.Clicks();

            return new MainPageObjects();
        }
        public MainPageObjects CheckLoginUser()
        {
            btnUserLogin.IsDisplayed();
            btnUserLogin.IsEnabled();

            //STEP: Clicks "Login" button.
            btnUserLogin.Clicks();

            return new MainPageObjects();
        }
        public MainPageObjects Logout()
        {
            btnUserLogin.IsDisplayed(); 
            btnUserLogin.IsEnabled();

            //STEP: Clicks "User login" button.
            btnUserLogin.Clicks();

            lblUserLogin.IsDisplayed();

            lnkLogOut.IsDisplayed();
            lnkLogOut.IsEnabled();

            //STEP: Clicks "Logout" link.
            lnkLogOut.Clicks();

            return new MainPageObjects();
        }
        public MainPageObjects Search(string sProduct)
        {
            txtSearch.IsDisplayed();
            txtSearch.IsEnabled();
            txtSearch.VerifyText("");

            //STEP: Enter corresponding in "Search" textbox.
            txtSearch.EnterText(sProduct);
            txtSearch.VerifyText(sProduct);

            //STEP: Submit "Search" textbox.
            txtSearch.Submit();

            lblFirstProduct.IsDisplayed();
            lblFirstProduct.IsEnabled();

            //STEP: Click on "First product" button.
            lblFirstProduct.Clicks();

            lblWholeWheatBreadProduct.IsDisplayed();
            lblWholeWheatBreadProduct.IsEnabled();

            return new MainPageObjects();
        }
        public MainPageObjects Order(int iProductCount)
        {
            btnPluse.IsDisplayed();
            btnPluse.IsEnabled();

            btnOrder.IsDisplayed();
            btnOrder.IsEnabled();

            for (int i = 0; i < iProductCount; i++)
            {
                //STEP: Click on "Pluse" button.
                btnPluse.Clicks();
            }

            //STEP: Click on "Order" button.
            btnOrder.Clicks();

            Thread.Sleep(1000);

            txtComment.IsDisplayed();
            txtComment.IsEnabled();
            txtComment.VerifyText("");

            btnSave.IsDisplayed();
            btnSave.IsEnabled();

            //STEP: Enter "Tasty!" string in "Comment" textbox.
            txtComment.EnterText("Tasty!");
            txtComment.VerifyText("Tasty!");

            //STEP: Click on "Save" button.
            btnSave.Clicks();

            btnCart.IsDisplayed();
            btnCart.IsEnabled();

            Thread.Sleep(1000);

            //STEP: Click on "Cart" button.
            btnCart.Clicks();

            btnProceedOrder.IsDisplayed();
            btnProceedOrder.IsEnabled();

            Thread.Sleep(1000);

            //STEP: Click on "Proceed order" button.
            btnProceedOrder.Clicks();

            return new MainPageObjects();
        }
    }
}
