using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace TestProject
{
    public class GoogleTests
    {
        private IWebDriver driver;

        private readonly By luckyButton = By.XPath("//div[@class='FPdoLc lJ9FBc']/descendant::*[@class='RNmpXc']");
        private readonly By pageTitle = By.XPath("//title");
        private string titleValue = "Google Doodles";

        [SetUp]
        public void Setup()
        {
            /* incognito mode
            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.AddArgument("--incognito");
            driver = new ChromeDriver(chromeOptions);*/ 
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.google.com/");
            //driver.Url = "https://www.google.com/";
            driver.Manage().Cookies.DeleteAllCookies();

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
            driver.Quit();
            //driver.Close();
        }
    }
}