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
    class PostPage
    {
        private IWebDriver driver;
        string ratingCountBefore = "";
        string ratingCountAfter = "";
        private const string BASE_URL = "https://www.drive2.ru/users/usertest1/";

        [FindsBy(How = How.XPath, Using = ".//a[text()='Написать в блог']")]
        private IWebElement buttonWriteBlog;

        [FindsBy(How = How.Id, Using = "jtitle")]
        private IWebElement TitleTextbox;

        [FindsBy(How = How.Id, Using = "text")]
        private IWebElement TextTextbox;

        [FindsBy(How = How.XPath, Using = ".//button[text()='Опубликовать запись']")]
        private IWebElement buttonPublicBlog;

        [FindsBy(How = How.ClassName, Using = "c-like__button")]
        private IWebElement buttonLikeBlog;

        [FindsBy(How = How.XPath, Using = ".//a[text()='This is good car']")]
        private IWebElement buttonOpenPost;

        [FindsBy(How = How.XPath, Using = ".//button[text()='Удалить']")]
        private IWebElement buttonDeleteBlog;


        




        public PostPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }

        public void OpenPage()
        {
            Thread.Sleep(TimeSpan.FromSeconds(5));
            driver.Navigate().GoToUrl(BASE_URL);
           
        }


        public void WriteBlog(string title, string text)
        {
            buttonWriteBlog.Click();
            TitleTextbox.SendKeys(title);
            TextTextbox.SendKeys(text);
            Thread.Sleep(TimeSpan.FromSeconds(4));
            buttonPublicBlog.Click();

        }

        public void LikeBlog()
        {
            
            Thread.Sleep(TimeSpan.FromSeconds(4));
            buttonLikeBlog.Click();

        }


        public void DeleteBlog()
        {
            Thread.Sleep(TimeSpan.FromSeconds(4));
            buttonOpenPost.Click();
            buttonDeleteBlog.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
           
        }
    }
}
