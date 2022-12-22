using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace TestProjectNUnit

{
    public class Tests

    {

        IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            var options = new ChromeOptions();
            options.AddArgument("headless");
            driver = new ChromeDriver("C:\\Users\\MuhammadRashid\\source\\repos\\CA1\\bp-master\\bp-master\\TestProjectNUnit\\bin\\Debug\\net6.0\\chromedriver.exe", options);

            driver.Url = "https://x00193247-bpcalculator-devp.azurewebsites.net/";
          //  driver.Navigate().GoToUrl("https://x00193247-bpcalculator-devp.azurewebsites.net/");

        }

        [Test]
        public void Test()
        {
            IWebElement systolicInput = driver.FindElement(By.Id("BP_Systolic"));
            systolicInput.SendKeys("150");

            IWebElement diasysInput = driver.FindElement(By.Id("BP_Diastolic"));
            systolicInput.SendKeys("90");

            IWebElement SubBtn = driver.FindElement(By.ClassName("btn-default"));
            SubBtn.Click();

            Assert.Pass();

        }
    }
}