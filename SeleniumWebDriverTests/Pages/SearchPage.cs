using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using System.Threading;

namespace SeleniumWebDriverTests.Pages
{
    class SearchPage
    {
        private IWebDriver driver;
        private const string BASE_URL = "https://www.drive2.ru/search/";



       
        [FindsBy(How = How.XPath, Using = ".//input[@name='q']")]
        private IWebElement SearchTextbox;

        [FindsBy(How = How.XPath, Using = ".//button[text()='Найти']")]
        private IWebElement buttonSearch;



        public SearchPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }

        public void OpenPage()
        {
            driver.Navigate().GoToUrl(BASE_URL);
            Thread.Sleep(TimeSpan.FromSeconds(3));
        }


        public void Search(string text)
        {
                    
            SearchTextbox.SendKeys(text);
            buttonSearch.Click();
        }



    }
}
