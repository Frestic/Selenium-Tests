using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using System.Threading;
namespace SeleniumWebDriverTests
{
    public class Steps
    {
        IWebDriver driver;
        IWebElement loggedUsername;

        public void Init()
        {
            driver = DDriver.GetInstance();
        }       

        public void LogIn(string username, string password)
        {
            Pages.MainPage mainPage = new Pages.MainPage(driver);
            mainPage.OpenPage();
            mainPage.Login(username, password);
        }


        public bool IsLoggedIn(string username)
        {
            try
            {
                loggedUsername = driver.FindElement(By.XPath(".//a[@href='/users/usertest1/']"));
                return true;
            }
            catch
            {
                return false;
            }
        }


        public void Search(string text)
        {
            Pages.SearchPage SearchPage = new Pages.SearchPage(driver);
            SearchPage.OpenPage();
            SearchPage.Search(text);
        }


        public bool ChahgeProfilePic(string picture)
        {
            try
            {
                Pages.SettingsPage settingsPage = new Pages.SettingsPage(driver);
                settingsPage.OpenPage();
                settingsPage.UploadPicture(picture);
                settingsPage.ConfirmPicture();
                                return true;
            }
            catch
            {
                return false;
            }
        }



        public void AddPostBlog(string title, string text)
        {
            Pages.PostPage mainPage = new Pages.PostPage(driver);
            mainPage.OpenPage();
            mainPage.WriteBlog(title, text);
           

        }



        public void LikePostBlog()
        {
            Pages.PostPage mainPage = new Pages.PostPage(driver);
            mainPage.OpenPage();
            mainPage.LikeBlog();
        }

        public void DeletePostBlog()
        {
            Pages.PostPage mainPage = new Pages.PostPage(driver);
            mainPage.OpenPage();
            mainPage.DeleteBlog();
        }



        public void CommentPost(string testtext)
        {
            Pages.MainPage mainPage = new Pages.MainPage(driver);
            mainPage.OpenPage();
            mainPage.AddComment(testtext);

        }


        public void DeleteComment()
        {
            Pages.MainPage mainPage = new Pages.MainPage(driver);
            mainPage.OpenPage();
            mainPage.DeleteComment();

        }



        public void LogOut()
        {
            Thread.Sleep(TimeSpan.FromSeconds(5));

            Pages.MainPage mainPage = new Pages.MainPage(driver);
               mainPage.LogOut();
          
        }

        public void Messages(string testtext)
        {
            Pages.MainPage mainPage = new Pages.MainPage(driver);
            mainPage.Messages(testtext);

        }

       

    }
}
