using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Globalization;
using System.IO;

namespace Test_72_Tuyen
{
    [TestClass]
    public class TestLogin_72_Tuyen
    {
        public WebDriver driver;
        public string email, password, expectedResult;

        public TestContext TestContext { get; set; }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @".\Data\TestLogin_72_Tuyen.csv", "TestLogin_72_Tuyen#csv", DataAccessMethod.Sequential)]
        public void TestSuccessfulLogin_72_Tuyen()//Đăng nhập thành công
        {
            email = TestContext.DataRow[0].ToString();
            password = TestContext.DataRow[1].ToString();
            expectedResult = TestContext.DataRow[2].ToString();
            if (expectedResult == "https://www.dictionary.com/sign-in?redirect=https://www.dictionary.com/")
            {
                driver = new ChromeDriver();
                driver.Navigate().GoToUrl("https://www.dictionary.com/");
                System.Threading.Thread.Sleep(1000);

                //72_Tuyen
                IWebElement element_72_Tuyen = driver.FindElement(By.ClassName("UF_oG6g2bZsM7t2hjU3j"));
                element_72_Tuyen.Click();
                System.Threading.Thread.Sleep(1000);

                //72_Tuyen
                IWebElement element1_72_Tuyen = driver.FindElement(By.Id("email"));
                element1_72_Tuyen.SendKeys(email);
                System.Threading.Thread.Sleep(1000);

                //72_Tuyen
                IWebElement element2_72_Tuyen = driver.FindElement(By.Id("password"));
                element2_72_Tuyen.SendKeys(password);
                System.Threading.Thread.Sleep(1000);

                //72_Tuyen
                IWebElement element3_72_Tuyen = driver.FindElement(By.XPath("//*[@id=\"root\"]/div/main/div/div/form/div/button[1]"));
                element3_72_Tuyen.Click();
                System.Threading.Thread.Sleep(2000);

                Assert.AreEqual(expectedResult, driver.Url);
                driver.Quit();
            }
        }


        [TestMethod] //Không điền trường Email
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @".\Data\TestLogin_72_Tuyen.csv", "TestLogin_72_Tuyen#csv", DataAccessMethod.Sequential)]
        public void TestFailedLogin_NoEmail_72_Tuyen()
        {
            email = TestContext.DataRow[0].ToString();
            password = TestContext.DataRow[1].ToString();
            expectedResult = TestContext.DataRow[2].ToString();
            if (email == "")
            {
                driver = new ChromeDriver();
                driver.Navigate().GoToUrl("https://www.dictionary.com/");
                System.Threading.Thread.Sleep(1000);

                IWebElement element_72_Tuyen = driver.FindElement(By.ClassName("UF_oG6g2bZsM7t2hjU3j"));
                element_72_Tuyen.Click();
                System.Threading.Thread.Sleep(1000);

                IWebElement element1_72_Tuyen = driver.FindElement(By.Id("email"));
                element1_72_Tuyen.SendKeys(email);
                System.Threading.Thread.Sleep(1000);

                IWebElement element2_72_Tuyen = driver.FindElement(By.Id("password"));
                element2_72_Tuyen.SendKeys(password);
                System.Threading.Thread.Sleep(1000);

                IWebElement element3_72_Tuyen = driver.FindElement(By.XPath("//*[@id=\"root\"]/div/main/div/div/form/div/button[1]"));
                element3_72_Tuyen.Click();

                IWebElement element4_72_Tuyen = driver.FindElement(By.XPath("//*[@id=\"root\"]/div/main/div/div/form/div/div[1]/p"));
                System.Threading.Thread.Sleep(2000);

                Assert.AreEqual(expectedResult, element4_72_Tuyen.Text);
                driver.Quit();
            }
        }


        [TestMethod]//Không điền trường Password
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @".\Data\TestLogin_72_Tuyen.csv", "TestLogin_72_Tuyen#csv", DataAccessMethod.Sequential)]

        public void TestFailedLogin_NoPassword_72_Tuyen()
        {
            email = TestContext.DataRow[0].ToString();
            password = TestContext.DataRow[1].ToString();
            expectedResult = TestContext.DataRow[2].ToString();
            if (expectedResult == "Please enter a password.")
            {
                driver = new ChromeDriver();
                driver.Navigate().GoToUrl("https://www.dictionary.com/");
                System.Threading.Thread.Sleep(1000);

                IWebElement element_72_Tuyen = driver.FindElement(By.ClassName("UF_oG6g2bZsM7t2hjU3j"));
                element_72_Tuyen.Click();
                System.Threading.Thread.Sleep(1000);

                IWebElement element1_72_Tuyen = driver.FindElement(By.Id("email"));
                element1_72_Tuyen.SendKeys(email);
                System.Threading.Thread.Sleep(1000);

                IWebElement element2_72_Tuyen = driver.FindElement(By.Id("password"));
                element2_72_Tuyen.SendKeys(password);
                System.Threading.Thread.Sleep(1000);

                IWebElement element3_72_Tuyen = driver.FindElement(By.XPath("//*[@id=\"root\"]/div/main/div/div/form/div/button[1]"));
                element3_72_Tuyen.Click();
                System.Threading.Thread.Sleep(2000);

                IWebElement element4_72_Tuyen = driver.FindElement(By.XPath("//*[@id=\"root\"]/div/main/div/div/form/div/div[2]/p"));
                Assert.AreEqual(expectedResult, element4_72_Tuyen.Text);
                driver.Quit();
            }
        }

        [TestMethod]//email và password không tồn tại
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @".\Data\TestLogin_72_Tuyen.csv", "TestLogin_72_Tuyen#csv", DataAccessMethod.Sequential)]
        public void TestFailedLogin_WrongPasswordorLogin_72_Tuyen()
        {
            email = TestContext.DataRow[0].ToString();
            password = TestContext.DataRow[1].ToString();
            expectedResult = TestContext.DataRow[2].ToString();
            if (expectedResult == "Incorrect email address or password.")
            {
                driver = new ChromeDriver();
                driver.Navigate().GoToUrl("https://www.dictionary.com/");
                System.Threading.Thread.Sleep(1000);

                IWebElement element_72_Tuyen = driver.FindElement(By.ClassName("UF_oG6g2bZsM7t2hjU3j"));
                element_72_Tuyen.Click();
                System.Threading.Thread.Sleep(1000);

                IWebElement element1_72_Tuyen = driver.FindElement(By.Id("email"));
                element1_72_Tuyen.SendKeys(email);
                System.Threading.Thread.Sleep(1000);

                IWebElement element2_72_Tuyen = driver.FindElement(By.Id("password"));
                element2_72_Tuyen.SendKeys(password);
                System.Threading.Thread.Sleep(1000);

                IWebElement element3_72_Tuyen = driver.FindElement(By.XPath("//*[@id=\"root\"]/div/main/div/div/form/div/button[1]"));
                element3_72_Tuyen.Click();
                System.Threading.Thread.Sleep(2000);

                IWebElement element4_72_Tuyen = driver.FindElement(By.ClassName("BYHIXdj8Bf9CJAeu3iRG"));
                Assert.AreEqual(expectedResult, element4_72_Tuyen.Text);
                driver.Quit();
            }
        }
    }
}
