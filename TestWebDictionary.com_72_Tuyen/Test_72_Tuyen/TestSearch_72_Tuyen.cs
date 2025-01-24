using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Globalization;
using System.IO;

namespace Test_72_Tuyen
{
    [TestClass]
    public class TestSearch_72_Tuyen
    {
        public WebDriver driver;
        public string search, expectedResult;
        public TestContext TestContext { get; set; }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @".\Data\TestSearch_72_Tuyen.csv", "TestSearch_72_Tuyen#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        public void TestSuccessfulSearch_72_Tuyen()
        {
            search = TestContext.DataRow[0].ToString();
            expectedResult = TestContext.DataRow[1].ToString();
            if (expectedResult == "View synonyms for")
            {
                driver = new ChromeDriver();
                driver.Navigate().GoToUrl("https://www.dictionary.com/");
                System.Threading.Thread.Sleep(1000);

                IWebElement element_72_Tuyen = driver.FindElement(By.CssSelector("input[type='text']"));
                element_72_Tuyen.SendKeys(search);
                System.Threading.Thread.Sleep(1000);

                IWebElement element1_72_Tuyen = driver.FindElement(By.ClassName("BPEynxB5UemsqiLj7s2H"));
                element1_72_Tuyen.Click();
                System.Threading.Thread.Sleep(1000);

                IWebElement element3_72_Tuyen = driver.FindElement(By.XPath("//*[@id=\"root\"]/div/main/div[2]/div[2]/div[1]/span"));
                element3_72_Tuyen.Click();
                Assert.IsTrue(element3_72_Tuyen.Text.Contains(expectedResult));
                driver.Quit();
            }

        }


        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @".\Data\TestSearch_72_Tuyen.csv", "TestSearch_72_Tuyen#csv", DataAccessMethod.Sequential)]
        public void TestFailSearch_72_Tuyen()
        {
            search = TestContext.DataRow[0].ToString();
            expectedResult = TestContext.DataRow[1].ToString();
            if (expectedResult == "No results found for")
            {
                driver = new ChromeDriver();
                driver.Navigate().GoToUrl("https://www.dictionary.com/");
                System.Threading.Thread.Sleep(1000);

                IWebElement element_72_Tuyen = driver.FindElement(By.CssSelector("input[type='text']"));
                element_72_Tuyen.SendKeys(search);
                System.Threading.Thread.Sleep(1000);

                IWebElement element1_72_Tuyen = driver.FindElement(By.ClassName("BPEynxB5UemsqiLj7s2H"));
                element1_72_Tuyen.Click();
                System.Threading.Thread.Sleep(1000);

                IWebElement element3_72_Tuyen = driver.FindElement(By.XPath("//*[@id=\"root\"]/div/main/div/section/section[1]/span"));
                element3_72_Tuyen.Click();

                Assert.IsTrue(element3_72_Tuyen.Text.Contains(expectedResult));
                driver.Quit();
            }
        }
    }
}
