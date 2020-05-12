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

        IWebDriver blueDriver = new ChromeDriver();
        IWebElement element;
        SelectElement selectElement;

        static void Main(string[] args)
        {
        }

        [Test]
        public void ContactFormTest()
        {
            
            Console.WriteLine("Test execution phase");

            element = blueDriver.FindElement(By.XPath(".//form/div/div/label/div/input[@data-request-data='id:1,post_id:370']"));
            element.Click();

            WebDriverWait wait = new WebDriverWait(blueDriver, TimeSpan.FromSeconds(5));
            wait.Until(blueDriver => blueDriver.FindElement(By.Id("name")));
            blueDriver.FindElement(By.Id("name")).SendKeys("BlueServices Test");

            element = blueDriver.FindElement(By.Id("email_c"));
            element.SendKeys("bs@blueservices.pl");

            element = blueDriver.FindElement(By.Id("company_name"));
            element.SendKeys("BlueServices Company");

            element = blueDriver.FindElement(By.Id("phone"));
            element.SendKeys("+48 123 123 123");
            
            element = blueDriver.FindElement(By.Id("select2-subject-container"));
            element.Click();
            element = blueDriver.FindElement(By.ClassName("select2-search__field"));
            element.SendKeys("Przelewy natychmiastowe"+Keys.Enter);

            element = blueDriver.FindElement(By.Id("body"));
            element.SendKeys("automat test Blueservices");

            element = blueDriver.FindElement(By.XPath(".//*[@id='result']/div/div/div/label/div/input[@value='email']"));
            element.Click();

            element = blueDriver.FindElement(By.Name("agreement_1"));
            element.Click();

        }

        [SetUp]
        public void TestPreparation()
        {

            Console.WriteLine("Test preparation phase");

            blueDriver.Navigate().GoToUrl("https://bluemedia.pl/kontakt");
            blueDriver.Manage().Window.Maximize();

        }

        [TearDown]
        public void TestFinalization()
        {

            Console.WriteLine("Test finalization phase");
            
            // Close the browser here, cleanup and finish test (no requirement for that)

        }
    }
}
