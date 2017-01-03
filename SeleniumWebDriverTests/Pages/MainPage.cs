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
    class MainPage
    {
        private IWebDriver driver;
        private const string BASE_URL = "https://www.drive2.ru/";

        [FindsBy(How = How.XPath, Using = ".//button[text()='Почта']")]
        private IWebElement buttonSubmit;

        [FindsBy(How = How.Id, Using = "loginform.login")]
        private IWebElement usernameTextbox;

        [FindsBy(How = How.Id, Using = "loginform.password")]
        private IWebElement passwordTextbox;

        [FindsBy(How = How.XPath, Using = ".//button[text()='Войти']")]
        private IWebElement buttonSubmitLogin;

       
        [FindsBy(How = How.XPath, Using = ".//a[@href='/users/usertest1/']")]
        private IWebElement buttonProfilePage;

        [FindsBy(How = How.ClassName, Using = "c-link")]
        private IWebElement buttonPost;

        [FindsBy(How = How.Name, Using = "text")]
        private IWebElement commentTextBox;

        [FindsBy(How = How.XPath, Using = ".//button[text()='Отправить']")]
        private IWebElement buttonSendComment;

        [FindsBy(How = How.XPath, Using = ".//a[@href='/reception/logout.cshtml']")]
        private IWebElement buttonLogOut;

        
        
        [FindsBy(How = How.ClassName, Using = "js-top-nav-sub")]
        private IWebElement buttonSettings;




        [FindsBy(How = How.ClassName, Using = "c-comment__dropdown-button")]
        private IWebElement buttonMenu;

        [FindsBy(How = How.XPath, Using = ".//span[text()='Удалить']")]
        private IWebElement buttonDelete;

        [FindsBy(How = How.ClassName, Using = "bubble-confirm-button")]
        private IWebElement buttonConfirmDelete;

        [FindsBy(How = How.Id, Using = "messages-status")]
        private IWebElement buttonMessages;
        [FindsBy(How = How.XPath, Using = ".//span[text()='Frestic']")]
        private IWebElement buttonFrestic;

        [FindsBy(How = How.Name, Using = "text")]
        private IWebElement textarea;

        [FindsBy(How = How.XPath, Using = ".//button[text()='Отправить']")]
        private IWebElement buttonSend;





        public MainPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }

        public void OpenPage()
        {
            driver.Navigate().GoToUrl(BASE_URL);
            Thread.Sleep(TimeSpan.FromSeconds(3));
        }


        public void Login(string username, string password)
        {
            buttonSubmit.Click();
            usernameTextbox.SendKeys(username);
            passwordTextbox.SendKeys(password);
            buttonSubmitLogin.Click();
            
        }

        public void AddComment(string testtext)
        {
            buttonPost.Click();
            Thread.Sleep(TimeSpan.FromSeconds(3));
            commentTextBox.SendKeys(testtext);
            Thread.Sleep(TimeSpan.FromSeconds(3));
            buttonSendComment.Click();

        }

        public void DeleteComment()
        {
            buttonPost.Click();
            Thread.Sleep(TimeSpan.FromSeconds(3));
            buttonMenu.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            buttonDelete.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            buttonConfirmDelete.Click();
            

        }


        public void Messages(string testtext)
        {
           
            Thread.Sleep(TimeSpan.FromSeconds(3));
            buttonMessages.Click();
            Thread.Sleep(TimeSpan.FromSeconds(3));
            buttonFrestic.Click();
            Thread.Sleep(TimeSpan.FromSeconds(3));
            textarea.SendKeys(testtext);
            Thread.Sleep(TimeSpan.FromSeconds(3));
            buttonSend.Click();
        }




        public void LogOut()
        {
            
            buttonSettings.Click();
            Thread.Sleep(TimeSpan.FromSeconds(3));
            buttonLogOut.Click();
            
        }


    }
}
