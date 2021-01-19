using Excel;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using MarsFramework.Pages;

namespace MarsFramework.Global
{
    class GlobalDefinitions:ShareSkill
    {
        //Initialise the browser
        public static IWebDriver driver { get; set; }

        #region Wait
        //generic reusable wait function- ElementExist
        public static void WaitForElement(IWebDriver driver, string key, string value, int seconds)

        {
            try
            {
                if (key == "XPath")
                {
                    var wait = new WebDriverWait(driver, new TimeSpan(0, 0, seconds));
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath(value)));
                }
                if (key == "Id")
                {
                    var wait = new WebDriverWait(driver, new TimeSpan(0, 0, seconds));
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id(value)));
                }
                if (key == "CssSelector")
                {
                    var wait = new WebDriverWait(driver, new TimeSpan(0, 0, seconds));
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector(value)));
                }
                if (key == "Name")
                {
                    var wait = new WebDriverWait(driver, new TimeSpan(0, 0, seconds));
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Name(value)));
                }
                if (key == "LinkText")
                {
                    var wait = new WebDriverWait(driver, new TimeSpan(0, 0, seconds));
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.LinkText(value)));
                }
            }
            catch (Exception ex)
            {
                Assert.Fail("Test faied waiting for an webelement to be visible", ex.Message);
            }
        }


        //generic reusable wait function- ElementIsVisible
        public static void WaitForElementVisibility(IWebDriver driver, string key, string value, int seconds)
        {
            try
            {
                if (key == "XPath")
                {
                    var wait = new WebDriverWait(driver, new TimeSpan(0, 0, seconds));
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(value)));
                }
                if (key == "Id")
                {
                    var wait = new WebDriverWait(driver, new TimeSpan(0, 0, seconds));
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id(value)));
                }
                if (key == "CssSelector")
                {
                    var wait = new WebDriverWait(driver, new TimeSpan(0, 0, seconds));
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector(value)));
                }
                if (key == "Name")
                {
                    var wait = new WebDriverWait(driver, new TimeSpan(0, 0, seconds));
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Name(value)));
                }
                if (key == "LinkText")
                {
                    var wait = new WebDriverWait(driver, new TimeSpan(0, 0, seconds));
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.LinkText(value)));
                }
            }
            catch (Exception ex)
            {
                Assert.Fail("Test faied waiting for an webelement to be visible", ex.Message);
            }
        }
        public static void WaitForElementClickable(IWebDriver driver, string key, string value, int seconds)
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, seconds));
            if (key == "Id")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id(value)));
            }
            if (key == "XPath")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(value)));
            }
            if (key == "CssSelector")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.CssSelector(value)));
            }
            if (key == "ClassName")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.ClassName(value)));
            }
            if (key == "Name")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Name(value)));
            }

        }
        public static void SelectDayTime(IWebDriver driver,String Days, IWebElement Sunday, IWebElement Monday, IWebElement Tuesday, IWebElement Wednesday, IWebElement Thursday, IWebElement Friday, IWebElement Saturday)
        {
            switch(Days)
            {
            case "Sun": 
            {
                        
                        Sunday.Click();
                        GlobalDefinitions.wait(1500);
                        driver.FindElement(By.XPath("//input[@name='StartTime'][@index='0']")).Clear();
                        driver.FindElement(By.XPath("//input[@name='StartTime'][@index='0']")).SendKeys((GlobalDefinitions.ExcelLib.ReadData(2, "Starttime")));
                        GlobalDefinitions.wait(1500);
                        driver.FindElement(By.XPath("//input[@name='EndTime'][@index='0']")).Clear();
                        driver.FindElement(By.XPath("//input[@name='EndTime'][@index='0']")).SendKeys((GlobalDefinitions.ExcelLib.ReadData(2, "Endtime")));
                        break;
            }
            case "Mon": 
            {
                        Monday.Click();
                        GlobalDefinitions.wait(1500);
                      
                        driver.FindElement(By.XPath("//input[@name='StartTime'][@index='1']")).Click();
                        driver.FindElement(By.XPath("//input[@name='StartTime'][@index='1']")).SendKeys(((GlobalDefinitions.ExcelLib.ReadData(2, "Starttime"))));
                        
                        GlobalDefinitions.wait(1500);
                       
                        driver.FindElement(By.XPath("//input[@name='EndTime'][@index='1']")).Click();
                        driver.FindElement(By.XPath("//input[@name='EndTime'][@index='1']")).SendKeys((GlobalDefinitions.ExcelLib.ReadData(2, "Endtime")));
                        
                        break;
                    }
            case "Tue": 
            {

                        Tuesday.Click();
                        driver.FindElement(By.XPath("//input[@name='StartTime'][@index='2']")).SendKeys((GlobalDefinitions.ExcelLib.ReadData(2, "Starttime")));
                        driver.FindElement(By.XPath("//input[@name='EndTime'][@index='2']")).SendKeys((GlobalDefinitions.ExcelLib.ReadData(2, "Endtime")));
                        break;
                    }
            case "Wed": 
            {
                        Wednesday.Click();
                        driver.FindElement(By.XPath("//input[@name='StartTime'][@index='3']")).SendKeys((GlobalDefinitions.ExcelLib.ReadData(2, "Starttime")));
                        driver.FindElement(By.XPath("//input[@name='EndTime'][@index='3']")).SendKeys((GlobalDefinitions.ExcelLib.ReadData(2, "Endtime"))); break;
                    }
            case "Thu": 
            {
                Thursday.Click();
                        driver.FindElement(By.XPath("//input[@name='StartTime'][@index='4']")).SendKeys((GlobalDefinitions.ExcelLib.ReadData(2, "Starttime")));
                        driver.FindElement(By.XPath("//input[@name='EndTime'][@index='4']")).SendKeys((GlobalDefinitions.ExcelLib.ReadData(2, "Endtime")));
                        break;
                    }
            case "Fri": 
            {
                Friday.Click();
                        driver.FindElement(By.XPath("//input[@name='StartTime'][@index='5']")).SendKeys((GlobalDefinitions.ExcelLib.ReadData(2, "Starttime")));
                        driver.FindElement(By.XPath("//input[@name='EndTime'][@index='5']")).SendKeys((GlobalDefinitions.ExcelLib.ReadData(2, "Endtime")));
                        break;
                    }
            case "Sat": 
            {
                        Saturday.Click();
                        driver.FindElement(By.XPath("//input[@name='StartTime'][@index='6']")).SendKeys((GlobalDefinitions.ExcelLib.ReadData(2, "Starttime")));
                        driver.FindElement(By.XPath("//input[@name='EndTime'][@index='6']")).SendKeys((GlobalDefinitions.ExcelLib.ReadData(2, "Endtime")));
                        break;
                    }
            
            }
        }

        public static void WaitForTextPresentInElement(IWebDriver driver, IWebElement element, string text, int seconds)
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, seconds));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.TextToBePresentInElement(element, text));

        }
        public static void wait(int time)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(time);

        }
        public static IWebElement WaitForElement(IWebDriver driver, By by, int timeOutinSeconds)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeOutinSeconds));
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(by));
        }
        #endregion


        #region Excel 
        public class ExcelLib
        {
            static List<Datacollection> dataCol = new List<Datacollection>();

            public class Datacollection
            {
                public int rowNumber { get; set; }
                public string colName { get; set; }
                public string colValue { get; set; }
            }


            public static void ClearData()
            {
                dataCol.Clear();
            }


            private static DataTable ExcelToDataTable(string fileName, string SheetName)
            {
                // Open file and return as Stream
                using (System.IO.FileStream stream = File.Open(fileName, FileMode.Open, FileAccess.Read))
                {
                    using (IExcelDataReader excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream))
                    {
                        excelReader.IsFirstRowAsColumnNames = true;

                        //Return as dataset
                        DataSet result = excelReader.AsDataSet();
                        //Get all the tables
                        DataTableCollection table = result.Tables;

                        // store it in data table
                        DataTable resultTable = table[SheetName];

                        //excelReader.Dispose();
                        //excelReader.Close();
                        // return
                        return resultTable;
                    }
                }
            }

            public static string ReadData(int rowNumber, string columnName)
            {
                try
                {
                    //Retriving Data using LINQ to reduce much of iterations

                    rowNumber = rowNumber - 1;
                    string data = (from colData in dataCol
                                   where colData.colName == columnName && colData.rowNumber == rowNumber
                                   select colData.colValue).SingleOrDefault();

                    //var datas = dataCol.Where(x => x.colName == columnName && x.rowNumber == rowNumber).SingleOrDefault().colValue;


                    return data.ToString();
                }

                catch (Exception e)
                {
                    //Added by Kumar
                    Console.WriteLine("Exception occurred in ExcelLib Class ReadData Method!" + Environment.NewLine + e.Message.ToString());
                    return null;
                }
            }

            public static void PopulateInCollection(string fileName, string SheetName)
            {
                ExcelLib.ClearData();
                DataTable table = ExcelToDataTable(fileName, SheetName);

                //Iterate through the rows and columns of the Table
                for (int row = 1; row <= table.Rows.Count; row++)
                {
                    for (int col = 0; col < table.Columns.Count; col++)
                    {
                        Datacollection dtTable = new Datacollection()
                        {
                            rowNumber = row,
                            colName = table.Columns[col].ColumnName,
                            colValue = table.Rows[row - 1][col].ToString()
                        };


                        //Add all the details for each row
                        dataCol.Add(dtTable);

                    }
                }

            }
        }

        #endregion

        #region screenshots
        public class SaveScreenShotClass
        {
            public static string SaveScreenshot(IWebDriver driver, string ScreenShotFileName) // Definition
            {
                var folderLocation = (Base.ScreenshotPath);

                if (!System.IO.Directory.Exists(folderLocation))
                {
                    System.IO.Directory.CreateDirectory(folderLocation);
                }

                var screenShot = ((ITakesScreenshot)driver).GetScreenshot();
                var fileName = new StringBuilder(folderLocation);

                fileName.Append(ScreenShotFileName);
                fileName.Append(DateTime.Now.ToString("_dd-mm-yyyy_mss"));
                //fileName.Append(DateTime.Now.ToString("dd-mm-yyyym_ss"));
                fileName.Append(".jpeg");
                screenShot.SaveAsFile(fileName.ToString(), ScreenshotImageFormat.Jpeg);
                return fileName.ToString();
            }
        }
        #endregion
    }
}
