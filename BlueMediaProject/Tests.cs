using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;



namespace BlueMediaProject
{

    class Tests
    {

        static void Main(string[] args) {}

        [SetUp]
        public void TestPreparation()
        {

            Console.WriteLine("Test preparation phase");

            BrowserDriver.Driver = new ChromeDriver();
            BrowserDriver.Driver.Navigate().GoToUrl("https://bluemedia.pl/kontakt");
            BrowserDriver.Driver.Manage().Window.Maximize();

        }

        [Test]
        public void ContactFormTest()
        {

            PageObjects pageObjects = new PageObjects();
            PageOperations pageOperations = new PageOperations();

            Console.WriteLine("Test execution phase");

            pageOperations.ClickOnElement(pageObjects.ClientTypeRadioButton);

            WebDriverWait wait = new WebDriverWait(BrowserDriver.Driver, TimeSpan.FromSeconds(3));
            wait.Until(blueDriver => BrowserDriver.Driver.FindElement(By.Id("name")));

            pageOperations.EnterString(pageObjects.Name,            "BlueServices Test");
            pageOperations.EnterString(pageObjects.Email,           "bs@blueservices.pl");
            pageOperations.EnterString(pageObjects.CompanyName,     "BlueServices Company");
            pageOperations.EnterString(pageObjects.Phone,           "+48 123 123 123");
            pageOperations.ClickOnElement(pageObjects.DropDownMenu);
            pageOperations.EnterString(pageObjects.DropDownSearch,  "Przelewy natychmiastowe" + Keys.Enter);
            pageOperations.EnterString(pageObjects.Message,         "automat test Blueservices");
            pageOperations.ClickOnElement(pageObjects.ResponseType);
            pageOperations.ClickOnElement(pageObjects.Agreement);

        }

        [TearDown]
        public void TestFinalization()
        {

            Console.WriteLine("Test finalization phase");
            
            // Close the browser here, cleanup and finish test (no requirement for that)

        }
    }
}
