using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Support;
using SeleniumExtras.PageObjects;
using System.Threading;

namespace SeleniumTesting
{
    class OrderPageObject
    {
        public OrderPageObject()
        {
            PageFactory.InitElements(Properties.driver, this);
        }

        #region Mapping

        [FindsBy(How = How.XPath, Using = "//*[@id='app']/main/div[1]/div[2]/div[1]/div[1]/footer/button")]
        public IWebElement btnContinue { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='test-calendar-date']")]
        public IWebElement ddlPickupDate { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='app']/main/div[1]/section/div[2]/div[1]/div/div[1]/div[2]/div[2]")]
        public IWebElement ddlTime { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='test-calendar-next-month']")]
        public IWebElement btnNextMonth { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='app']/main/div[1]/section/div[2]/div[1]/div/div[1]/div[1]/div[2]/div/div/div[3]/div[1]/div[6]")]
        public IWebElement btnDate { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='app']/main/div[1]/section/div[2]/div[1]/div/div[1]/div[2]/div[1]/div/div/div[2]/div[1]/div/div[2]")]
        public IWebElement btnHours { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='app']/main/div[1]/section/div[2]/div[1]/div/div[1]/div[2]/div[1]/div/div/div[2]/div[2]/div/div[2]")]
        public IWebElement btnMinutes { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='test-next']")]
        public IWebElement btnContinueToCheckout { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='test-pay-submit']")]
        public IWebElement btnPlaceOrder { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='test-payment-method-0']")]
        public IWebElement btnPaymentAtPickup { get; set; }        

        [FindsBy(How = How.XPath, Using = "//*[@id='button_do_payment']")]
        public IWebElement btnContinueCheckout { get; set; }

        #endregion

        public OrderPageObject Checkout() 
        {
            btnContinue.IsDisplayed();
            btnContinue.IsEnabled();

            //STEP: Click "Continue" button.
            btnContinue.Clicks();
            Thread.Sleep(2000);

            ddlPickupDate.IsDisplayed();
            ddlPickupDate.IsEnabled();

            ddlTime.IsDisplayed();
            ddlTime.IsEnabled();

            btnContinueToCheckout.IsDisplayed();
            btnContinueToCheckout.IsEnabled();

            //STEP: Click "Pickup date" dropdown menu.
            ddlPickupDate.Clicks();

            Thread.Sleep(1000);

            btnNextMonth.IsDisplayed();
            btnNextMonth.IsEnabled();
            btnDate.IsDisplayed();
            btnDate.IsEnabled();

            //STEP: Click "Next month" button.
            btnNextMonth.Clicks();

            Thread.Sleep(1000);

            //STEP: Click corresonding "Date" button.
            btnDate.Clicks();
            Thread.Sleep(1000);
            //STEP: Click corresonding "Hours" button.
            btnHours.Clicks();
            //STEP: Click corresonding "Minutes" button.
            btnMinutes.Clicks();

            //STEP: Click "Continue to checkout" button.
            btnContinueToCheckout.Clicks();
            Thread.Sleep(1000);

            btnPaymentAtPickup.IsDisplayed();
            btnPaymentAtPickup.IsEnabled();

            btnPlaceOrder.IsDisplayed();
            btnPlaceOrder.IsEnabled();

            //STEP: Click "Payment at pickup" button.
            btnPaymentAtPickup.Clicks();
            //STEP: Click "Place oroder" button.
            btnPlaceOrder.Clicks();

            return new OrderPageObject();
        }
    }
}
