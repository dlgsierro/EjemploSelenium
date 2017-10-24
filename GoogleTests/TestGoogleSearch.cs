using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace PruebaSelenium
{
    [TestFixture]
    public class SeleniumTests
    {
        [Test]
        public void TestGoogleSearch()
        {
            IWebDriver driver = null;
            try
            {
                driver = new FirefoxDriver();
                driver.Navigate().GoToUrl("http://www.google.cl");
                driver.FindElement(By.Name("q")).SendKeys("Pruebas Selenium");
                driver.FindElement(By.Name("btnK")).Click();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: {0}", e.Message);
            }
            finally
            {
                if(driver != null)
                {
                    driver.Close();
                    driver.Quit();
                }
            }
        }
    }
}
