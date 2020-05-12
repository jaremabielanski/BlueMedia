using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;



namespace BlueMediaProject
{
    class PageObjects
    {

        public PageObjects()
        {
            PageFactory.InitElements(BrowserDriver.Driver, this);
        }

        [FindsBy(How = How.XPath, Using = ".//form/div/div/label/div/input[@data-request-data='id:1,post_id:370']")]
        public IWebElement ClientTypeRadioButton { get; set; }

        [FindsBy(How = How.Id, Using = "name")]
        public IWebElement Name { get; set; }

        [FindsBy(How = How.Id, Using = "email_c")]
        public IWebElement Email { get; set; }

        [FindsBy(How = How.Id, Using = "company_name")]
        public IWebElement CompanyName { get; set; }

        [FindsBy(How = How.Id, Using = "phone")]
        public IWebElement Phone { get; set; }

        [FindsBy(How = How.Id, Using = "body")]
        public IWebElement Message { get; set; }

        [FindsBy(How = How.Id, Using = "select2-subject-container")]
        public IWebElement DropDownMenu { get; set; }

        [FindsBy(How = How.ClassName, Using = "select2-search__field")]
        public IWebElement DropDownSearch { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='result']/div/div/div/label/div/input[@value='email']")]
        public IWebElement ResponseType { get; set; }

        [FindsBy(How = How.Name, Using = "agreement_1")]
        public IWebElement Agreement { get; set; }

    }
}
