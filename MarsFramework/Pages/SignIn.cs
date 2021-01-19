using MarsFramework.Global;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;

namespace MarsFramework.Pages
{
    class SignIn
    {
        public SignIn()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        #region  Initialize Web Elements 
        //Finding the Sign Link
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Sign')]")]
        private IWebElement SignIntab { get; set; }

        // Finding the Email Field
        [FindsBy(How = How.Name, Using = "email")]
        private IWebElement Email { get; set; }

        //Finding the Password Field
        [FindsBy(How = How.Name, Using = "password")]
        private IWebElement Password { get; set; }

        //Finding the Login Button
        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Login')]")]
        private IWebElement LoginBtn { get; set; }

        #endregion

        internal void LoginSteps()
        {
            //Populate the excel data

            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "SignIn");

            //Click on SignIn
            SignIntab.Click();

            //Enter Username
            Email.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Username"));

            //Enter Password
            Password.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Password"));

            //Click login
            LoginBtn.Click();
            try
            {
                GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, "XPath", "//*[contains(text(),'Mike K')]", 10000);
                // check login is successfull
                var loginCheck = "test";
                loginCheck = GlobalDefinitions.driver.FindElement(By.XPath("//*[contains(text(),'Mike K')]")).GetAttribute("innerText");

                Assert.That(loginCheck == "Mike K");
            }
            catch (Exception ex)
            {
                Assert.Fail("Test failed at login step", ex.Message);
            }

        }

    }
}