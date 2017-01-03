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
    class SettingsPage
    {
        private IWebDriver driver;
        private const string BASE_URL = "https://www.drive2.ru/my/profile/";

        

        [FindsBy(How = How.XPath, Using = ".//input[@type='file']")]
        private IWebElement fileInput;

        [FindsBy(How = How.XPath, Using = ".//button[text()='Сохранить']")]
        private IWebElement buttonSave;

        [FindsBy(How = How.XPath, Using = ".//a[@href='/users/usertest1/']")]
        private IWebElement buttonProfilePage;


        public SettingsPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }

        public void OpenPage()
        {
            driver.Navigate().GoToUrl(BASE_URL);
            Thread.Sleep(TimeSpan.FromSeconds(5));
            
        }

        public void UploadPicture(string picturePath)
        {
            fileInput.SendKeys(picturePath);
            Thread.Sleep(TimeSpan.FromSeconds(10));
        }

        public void ConfirmPicture()
        {
            buttonSave.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            buttonProfilePage.Click();
        }

       

    }
}
