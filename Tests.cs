using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace TestProject
{
    public class Tests
    {
        private IWebDriver driver;

        private readonly By luckyButton = By.XPath("//div[@class='FPdoLc tfB0Bf']/descendant::*[@class='RNmpXc']");
        private readonly By pageTitle = By.XPath("//title");
        private string titleValue = "Google Doodles";

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
            driver.FindElement(luckyButton).Click();
            driver.FindElement(pageTitle).Equals(titleValue);
            Thread.Sleep(3000);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Close();
        }
    }
}