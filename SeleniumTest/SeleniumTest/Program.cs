using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace SeleniumTest
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new FirefoxDriver();

            driver.Navigate().GoToUrl("https://www.mail.ru/");

            IWebElement element = driver.FindElement(By.Name("login"));
            element.SendKeys("Nigle");
        }
    }
}
