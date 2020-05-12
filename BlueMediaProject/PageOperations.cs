using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace BlueMediaProject
{
    class PageOperations
    {

        public void EnterString(IWebElement element, string text)
        {

            element.SendKeys(text);

        }

        public void ClickOnElement(IWebElement element)
        {

            element.Click();

        }

        public void EnterText(string type, string findByStr, string text)
        {

            if (String.Equals("id", type))
            {
                BrowserDriver.Driver.FindElement(By.Id(findByStr)).SendKeys(text);
            }
            else if (String.Equals("name", type))
            {
                BrowserDriver.Driver.FindElement(By.Name(findByStr)).SendKeys(text);
            }
            else if (String.Equals("classname", type))
            {
                BrowserDriver.Driver.FindElement(By.ClassName(findByStr)).SendKeys(text);
            }
            else if (String.Equals("xpath", type))
            {
                BrowserDriver.Driver.FindElement(By.XPath(findByStr)).SendKeys(text);
            }
            else
            {
                Console.WriteLine("FindElement(By.{0}) not specified or not matched",type);
            }

        }

        public void ClickOn(string type, string findByStr)
        {

            if (String.Equals("id", type))
            {
                BrowserDriver.Driver.FindElement(By.Id(findByStr)).Click();
            }
            else if (String.Equals("name", type))
            {
                BrowserDriver.Driver.FindElement(By.Name(findByStr)).Click();
            }
            else if (String.Equals("classname", type))
            {
                BrowserDriver.Driver.FindElement(By.ClassName(findByStr)).Click();
            }
            else if (String.Equals("xpath", type))
            {
                BrowserDriver.Driver.FindElement(By.XPath(findByStr)).Click();
            }
            else
            {
                Console.WriteLine("FindElement(By.{0}) not specified or not matched", type);
            }

        }

    }
}
