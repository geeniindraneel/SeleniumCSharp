using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using System;
using OpenQA.Selenium.Support.UI;

namespace NUnitTestProject2
{
    public class Tests
    {
        IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
        }

        [Test]
        public void Test1()
        {
            
            driver.Url = "https://www.google.com/";
            driver.FindElement(By.Name("q")).SendKeys("Indraneel Geeni");
            string attributeValue = driver.FindElement(By.Name("q")).GetAttribute("Name");
            Console.WriteLine("The attribute name is " + attributeValue);
            /*WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Name("btnK")));*/
            Thread.Sleep(3000);
            IWebElement ele = driver.FindElement(By.Name("btnK"));
            IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
            executor.ExecuteScript("arguments[0].click();", ele);
            //driver.FindElement(By.Name("btnK")).Submit();
            


        }
        [Test]
        public void Test2()
        {

            driver.Url = "https://demoqa.com/automation-practice-form";

            string url = driver.Url;
            Console.WriteLine("the url is " + url);

            int urlLength = driver.Url.Length;
            Console.WriteLine("the url length of the page is " + urlLength);

            string title = driver.Title;
            Console.WriteLine("the title of the page is " + title);

            int titleLength = driver.Title.Length;
            Console.WriteLine("the length of the title is " + titleLength);

            string pageSource = driver.PageSource;
            Console.WriteLine("the pagesource of the page is " + pageSource);

            int pageSourceLength = driver.PageSource.Length;
            Console.WriteLine("the length of the pagesource is " + pageSourceLength);

            driver.FindElement(By.Id("firstName")).SendKeys("Indraneel");
            driver.FindElement(By.Id("lastName")).SendKeys("Geeni");

            string attributeValue = driver.FindElement(By.Id("lastName")).GetAttribute("Id");
            Console.WriteLine("the attribute value is " + attributeValue);

            string text = driver.FindElement(By.XPath("//label[text()='Music']")).Text;
            Console.WriteLine("the text is " + text);

            string tagName = driver.FindElement(By.Id("submit")).TagName;
            Console.WriteLine("the tag name is " + tagName);

            driver.FindElement(By.Id("userEmail")).SendKeys("geeniindraneel@gmail.com");
            driver.FindElement(By.XPath("//label[text()='Male']")).Click();
            Boolean male = driver.FindElement(By.XPath("//input[@value='Male']")).Selected;
            Console.WriteLine("male radio button is " + male);
            Boolean female = driver.FindElement(By.XPath("//input[@value='Female']")).Selected;
            Console.WriteLine("female radio button is " + female);
            driver.FindElement(By.Id("userNumber")).SendKeys("9121830789");

            string date = driver.FindElement(By.Id("dateOfBirthInput")).GetAttribute("value");
            Console.WriteLine("the date is " + date);

            driver.FindElement(By.XPath("//label[text()='Sports']")).Click();
            driver.FindElement(By.Id("currentAddress")).SendKeys("Calgary");
            Thread.Sleep(3000);
            driver.FindElement(By.Id("submit")).Click();
            Thread.Sleep(3000);

        }
        [TearDown]
        public void TearDown()
        {
            driver.Close();
        }
    }
}