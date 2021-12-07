using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace RUAP_LV4
{
    [TestClass]
    public class UnitTest1
    {
        [TestFixture]
        public class UntitledTestCase
        {
            private IWebDriver driver;
            private StringBuilder verificationErrors;
            private string baseURL;
            private bool acceptNextAlert = true;
            static Random rnd = new Random();
            int i = rnd.Next(1, 100000);

            [SetUp]
            public void SetupTest()
            {
                driver = new FirefoxDriver();
                baseURL = "https://www.google.com/";
                verificationErrors = new StringBuilder();
            }

            [TearDown]
            public void TeardownTest()
            {
                try
                {
                    driver.Quit();
                }
                catch (Exception)
                {
                    // Ignore errors if unable to close the browser
                }
                NUnit.Framework.Assert.AreEqual("", verificationErrors.ToString());
            }

            [Test]
            public void TheUntitledTestCaseTest()
            {
                driver.Navigate().GoToUrl("https://demo.opencart.com/");
                driver.FindElement(By.XPath("//div[@id='top-links']/ul/li[2]/a/span")).Click();
                driver.FindElement(By.LinkText("Register")).Click();
                driver.FindElement(By.Id("input-firstname")).Click();
                driver.FindElement(By.Id("input-firstname")).Clear();
                driver.FindElement(By.Id("input-firstname")).SendKeys("John");
                driver.FindElement(By.Id("input-lastname")).Clear();
                driver.FindElement(By.Id("input-lastname")).SendKeys("Doe");
                driver.FindElement(By.Id("input-email")).Clear();
                driver.FindElement(By.Id("input-email")).SendKeys("test432112311" + i + "@test123.com");
                //driver.FindElement(By.Id("input-email")).SendKeys("test123@test.com");
                driver.FindElement(By.Id("input-telephone")).Clear();
                driver.FindElement(By.Id("input-telephone")).SendKeys("123123123");
                driver.FindElement(By.XPath("//div[@id='content']/form/fieldset[2]")).Click();
                driver.FindElement(By.Id("input-password")).Click();
                driver.FindElement(By.Id("input-password")).Clear();
                driver.FindElement(By.Id("input-password")).SendKeys("randompassword");
                driver.FindElement(By.Id("input-confirm")).Clear();
                driver.FindElement(By.Id("input-confirm")).SendKeys("randompassword");
                driver.FindElement(By.Name("agree")).Click();
                driver.FindElement(By.XPath("//input[@value='Continue']")).Click();
                //driver.FindElement(By.Id("input-email")).Click();
                //driver.FindElement(By.Id("input-email")).Click();
                //driver.FindElement(By.Id("input-email")).Clear();
                //driver.FindElement(By.Id("input-email")).SendKeys("test123@test123.com");
                //driver.FindElement(By.XPath("//input[@value='Continue']")).Click();
                //driver.FindElement(By.Id("input-email")).Click();
                //driver.FindElement(By.Id("input-email")).Clear();
                //driver.FindElement(By.Id("input-email")).SendKeys("test4321123" + i + "@test123.com");
                //driver.FindElement(By.XPath("//input[@value='Continue']")).Click();
                driver.FindElement(By.XPath("//div[@id='top-links']/ul/li[2]/a/span[2]")).Click();
                driver.FindElement(By.LinkText("Logout")).Click();
                driver.FindElement(By.XPath("//div[@id='top-links']/ul/li[2]/a/span")).Click();
                driver.FindElement(By.LinkText("Login")).Click();
                driver.FindElement(By.Id("input-email")).Click();
                driver.FindElement(By.Id("input-email")).Clear();
                driver.FindElement(By.Id("input-email")).SendKeys("test432112311" + i + "@test123.com");
                driver.FindElement(By.Id("input-password")).Click();
                driver.FindElement(By.Id("input-password")).Clear();
                driver.FindElement(By.Id("input-password")).SendKeys("randompassword");
                driver.FindElement(By.XPath("//input[@value='Login']")).Click();
                driver.FindElement(By.XPath("//*[@id='menu']/div[2]/ul/li[1]/a")).Click();
                driver.FindElement(By.LinkText("Mac (1)")).Click();
                driver.FindElement(By.LinkText("iMac")).Click();
                driver.FindElement(By.Id("button-cart")).Click();
                driver.FindElement(By.XPath("//div[@id='top-links']/ul/li[2]/a/span")).Click();
                driver.FindElement(By.XPath("//a[contains(text(),'My Account')]")).Click();
                driver.FindElement(By.LinkText("Edit your account information")).Click();
                driver.FindElement(By.Id("input-lastname")).Click();
                driver.FindElement(By.Id("input-lastname")).Clear();
                driver.FindElement(By.Id("input-lastname")).SendKeys("Doakes");
                driver.FindElement(By.XPath("//input[@value='Continue']")).Click();
                driver.FindElement(By.Name("search")).Click();
                driver.FindElement(By.Name("search")).Clear();
                driver.FindElement(By.Name("search")).SendKeys("mac");
                driver.FindElement(By.Name("search")).SendKeys(Keys.Enter);
                i++;
            }
            private bool IsElementPresent(By by)
            {
                try
                {
                    driver.FindElement(by);
                    return true;
                }
                catch (NoSuchElementException)
                {
                    return false;
                }
            }

            private bool IsAlertPresent()
            {
                try
                {
                    driver.SwitchTo().Alert();
                    return true;
                }
                catch (NoAlertPresentException)
                {
                    return false;
                }
            }

            private string CloseAlertAndGetItsText()
            {
                try
                {
                    IAlert alert = driver.SwitchTo().Alert();
                    string alertText = alert.Text;
                    if (acceptNextAlert)
                    {
                        alert.Accept();
                    }
                    else
                    {
                        alert.Dismiss();
                    }
                    return alertText;
                }
                finally
                {
                    acceptNextAlert = true;
                }
            }
        }
    }
}
