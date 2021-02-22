using MarsFramework.Global;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;

namespace MarsFramework.Pages
{
    internal class ShareSkill
    {
        public ShareSkill()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        #region Initialize web elements
        //Click on ShareSkill Button
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Share Skill')]")]
        private IWebElement ShareSkillButton { get; set; }

        //Enter the Title in textbox
        [FindsBy(How = How.XPath, Using = "//input[@name='title']")]
        private IWebElement Title { get; set; }

        //Enter the Description in textbox
        [FindsBy(How = How.XPath, Using = "//textarea[@name='description']")]
        private IWebElement Description { get; set; }

        //Click on Category Dropdown
        [FindsBy(How = How.XPath, Using = "//select[@name='categoryId']")]
        private IWebElement CategoryDropDown { get; set; }

        //Click on SubCategory Dropdown
        [FindsBy(How = How.XPath, Using = "//select[@name='subcategoryId']")]
        private IWebElement SubCategoryDropDown { get; set; }

        //Enter Tag names in textbox
        [FindsBy(How = How.XPath, Using = "//input[@class='ReactTags__tagInputField'][1]")]
        private IWebElement Tags { get; set; }

       

        //Select the Service type

        [FindsBy(How = How.XPath, Using = "(//input[@name='serviceType'])[1]")]
        private IWebElement ServiceTypeOptions { get; set; }
        [FindsBy(How = How.XPath, Using = "(//input[@name='serviceType'])[2]")]
        private IWebElement Servicetyp { get; set; }
       
        //Select the Location Type
        [FindsBy(How = How.XPath, Using = "(//input[@name='locationType'])[1]")]
        private IWebElement LocationTypeOption { get; set; }

        [FindsBy(How = How.XPath, Using = "(//input[@name='locationType'])[2]")]
        private IWebElement LocationSel { get; set; }
        
         [FindsBy(How = How.XPath, Using = "//input[@name='Available'][@index='0']")]
        private IWebElement Sun { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[@name='Available'][@index='1']")]
        private IWebElement Mon { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[@name='Available'][@index='2']")]
        private IWebElement Tue { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[@name='Available'][@index='3']")]
        private IWebElement Wed { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[@name='Available'][@index='4']")]
        private IWebElement Thu { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[@name='Available'][@index='5']")]
        private IWebElement Fri { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[@name='Available'][@index='6']")]
        private IWebElement Sat { get; set; }
             
             
             
             

        //Click on Start Date dropdown
        [FindsBy(How = How.XPath, Using = "//input[@name='startDate']")]
        private IWebElement StartDateDropDown { get; set; }

        //Click on End Date dropdown
        [FindsBy(How = How.XPath, Using = "//input[@name='endDate']")]
        private IWebElement EndDateDropDown { get; set; }

        //Storing the table of available days
        [FindsBy(How = How.XPath, Using = "//input[@type='checkbox']")]
        private IWebElement Days { get; set; }
        [FindsBy(How = How.XPath, Using = "(//input[@name='Available'])[2]")]
        private IWebElement Day { get; set; }

        //Storing the starttime
        [FindsBy(How = How.XPath, Using = "(//input[contains(@name,'serviceType')])[2]")]
        public IWebElement StartTime { get; set; }

        //Click on StartTime dropdown
        [FindsBy(How = How.XPath, Using = "(//input[@name='StartTime'])[2]")]
        private IWebElement StartTimeDropDown { get; set; }

        //Storing the Endtime
        [FindsBy(How = How.XPath, Using = "(//input[@name='EndTime'])[2]")]
        public IWebElement EndTime { get; set; }

        //Click on EndtTime dropdown
        [FindsBy(How = How.XPath, Using = "(//input[@name='EndTime'])[2]")]
        private IWebElement EndTimeDropDown { get; set; }

        //Click on Skill Trade option
        [FindsBy(How = How.XPath, Using = "(//input[contains(@name,'skillTrades')])[1]")]
        private IWebElement SkillTradeOption { get; set; }

        //Click SkillActiveOptions
        [FindsBy(How = How.XPath, Using = "//input[@name='isActive']")]
        private IWebElement SkillActiveOptions { get; set; }
        
        //Enter Skill Exchange
        [FindsBy(How = How.XPath, Using = "(//input[contains(@class,'tagInputField')])[2]")]
        private IWebElement SkillExctxtbx { get; set; }

        //Click on Active/Hidden option
        [FindsBy(How = How.XPath, Using = "(//input[@name='isActive'])[1]")]
        private IWebElement ActiveOption { get; set; }

        [FindsBy(How = How.XPath, Using = "(//input[@name='isActive'])[2]")]
        private IWebElement HiddenOption { get; set; }

        //Click on Save button
        [FindsBy(How = How.XPath, Using = "//input[@value='Save']")]
        private IWebElement Save { get; set; }

        //Validate share skill details
        //Click on manage listing
        [FindsBy(How = How.XPath, Using = "(//a[@class='item'])[11]")]
        private IWebElement ManageListbtn { get; set; }

        #endregion

        #region Enter share skill
        //Add share skill details
        internal void EnterShareSkill()
        {
            //Populate the excel data

            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ShareSkill");
            
            try
            {
                ShareSkillButton.Click();

                //Click on Share skill button
               // GlobalDefinitions.WaitForElementVisibility(GlobalDefinitions.driver, "XPath", "//a[contains(text(),'Share Skill')]", 10000);
               // ShareSkillButton.Click();

                //Enter the Title in textbox
                //GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, "XPath", "//input[@name='title']", 10000);
                Title.Click();
                Title.Clear();
                Title.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Title"));

                //Enter the Description in textbox
                //GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, "XPath", "//input[@name='description']", 10000);
                GlobalDefinitions.wait(1500);
                Description.Click();
                Description.Clear();
                Description.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Description"));

                //Select catagory from drop down
                //GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, "XPath", "//input[@name='categoryId']", 10000);
                CategoryDropDown.Click();
                new SelectElement(CategoryDropDown).SelectByText(GlobalDefinitions.ExcelLib.ReadData(2, "Category"));

                //Select catagory from drop down
                //GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, "XPath", "//input[@name='subcategoryId']", 10000);
                SubCategoryDropDown.Click();
                new SelectElement(SubCategoryDropDown).SelectByText(GlobalDefinitions.ExcelLib.ReadData(2, "SubCategory"));

                //Enter Tag names in textbox
              //  GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, "XPath", "//input[@value='']", 10000);
                Tags.Click();
                Tags.Clear();
                Tags.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Tags"));
                Tags.SendKeys(Keys.Enter);

                //Select service type
               // GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, "XPath", "//form/div[5]/div[@class='twelve wide column']/div/div[@class='field']", 10000);
                ServiceTypeOptions.Click();
                Servicetyp.Click();

                //Select the Location Type
                GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, "XPath", "(//input[@name='locationType'])[1]", 10000);
                LocationTypeOption.Click();
                LocationSel.Click();
               
               
                
                //Add start date
                StartDateDropDown.Click();
                // StartDateDropDown.Clear();
                StartDateDropDown.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Startdate"));

                //Add End date
                EndDateDropDown.Click();
                //EndDateDropDown.Clear();
                EndDateDropDown.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Enddate"));
                EndDateDropDown.SendKeys(Keys.Enter);
                GlobalDefinitions.SelectDayTime(GlobalDefinitions.driver,(GlobalDefinitions.ExcelLib.ReadData(2, "Day")),Sun,Mon,Tue,Wed,Thu,Fri,Sat);
                /*
                //Select available day
                GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, "XPath", "//body/div/div/div[@id='service-listing-section']/div[@class='ui container']/div[@class='listing']/form[@class='ui form']/div[7]/div[2]/div[1]", 10000);
                Days.Click();
                Day.Click();

                //Select start time
                GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, "XPath", "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[3]/div[2]/input", 10000);
                StartTime.Click();


                //enter start time
                StartTimeDropDown.Click();
                //StartTimeDropDown.Clear();
                StartTimeDropDown.SendKeys((GlobalDefinitions.ExcelLib.ReadData(2, "Starttime")));

                //Select end time
                GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, "XPath", "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[3]/div[3]/input", 10000);
                EndTime.Click();

                //Enter end time
                EndTimeDropDown.Click();
                //EndTimeDropDown.Clear();
                EndTimeDropDown.SendKeys("05:00 PM");// (GlobalDefinitions.ExcelLib.ReadData(2, "Endtime"));
                */
                //Click on Skill trade option
                SkillTradeOption.Click();

                //Add Skill exchange tag
               // GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, "XPath", "//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[4]/div/div/div/div/div/input", 10000);
               
                SkillExctxtbx.Clear();
                SkillExctxtbx.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Skill-Exchange"));
                SkillExctxtbx.SendKeys(Keys.Enter);

                //Select option Active or Hidden
                // GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, "XPath", "//form/div[10]/div[@class='twelve wide column']/div/div[@class = 'field']", 10000);
                //((GlobalDefinitions.ExcelLib.ReadData(2, "SkillActiveOptions"));
                //ActiveOption.Click();
                HiddenOption.Click();

                //Click on save button
                GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, "XPath", "//input[@value='Save']", 10000);
                Save.Click();
            }

            catch (Exception ex)
            {
                Assert.Fail("Test failed to enter Skill details", ex.Message);
            }
        }

        #endregion


        #region Validate share skill
        //Verify Share skill

        internal void VerifySkill()
        {

            //Populate the excel data

            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ShareSkill");
            
            //Verify share skill details
            GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, "XPath", "(//a[@class='item'])[11]", 10000);
            ManageListbtn.Click();
            try
            {
                GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, "XPath", "(//td[@class='one wide'])[2]", 10000);
                var categorycheck = GlobalDefinitions.driver.FindElement(By.XPath("(//td[@class='one wide'])[2]")).GetAttribute("textContent");
                Assert.That(categorycheck, Is.EqualTo(GlobalDefinitions.ExcelLib.ReadData(2, "Category")));

               GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, "XPath", "(//td[contains(@class,'four wide')])[1]", 10000);
                var titlecheck = GlobalDefinitions.driver.FindElement(By.XPath("(//td[contains(@class,'four wide')])[1]")).GetAttribute("textContent");
                Assert.That(titlecheck, Is.EqualTo(GlobalDefinitions.ExcelLib.ReadData(2, "Title")));
            }
            catch (Exception ex)
            {
                Assert.Fail("verify the share skill page failed", ex.Message);
                
            }
        }
        #endregion
    }
}
