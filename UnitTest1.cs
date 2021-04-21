using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace TestProject
{
    public class Tests
    {
        private IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com/");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void Test1()
        {
            driver.FindElement(By.XPath("//div[@class='FPdoLc tfB0Bf']/descendant::*[@class='RNmpXc']")).Click();
            driver.FindElement(By.XPath("//title")).Equals("Google Doodles");
            Thread.Sleep(3000);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Close();
        }
    }
}