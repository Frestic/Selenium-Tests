using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace SeleniumWebDriverTests
{
    class NUnitTests
    {
        private Steps step = new Steps();
        private PostData postData = new PostData("Header " + DateTime.Now.ToShortTimeString(),"проверка,тестирование сайтов",
                                                 "Test text " + DateTime.Now.ToShortTimeString(),
                                                 Path.GetFullPath("SeleniumWebDriverTests\\Data\\Pictures\\1.jpg"));
                      
      
        private const string username = "d.klybik@aplus.by";
        private const string password = "TEST1q2w3e";
        private const string name = "usertest1";
        private const string text = "Opel Vectra";
        private const string title = "This is good car";
        private const string testtext = "This is test message";
        private string picture = Path.GetFullPath(@"SeleniumWebDriverTests\\Data\\Pictures\\av1.png");

        [SetUp]
        public void Init()
        {
            step.Init();
        }

        /*[Test]
        public void AddPostTest()
        {
           step.LogIn(username, password);
           step.AddPost(postData);         
        }*/

     

        [Test]
        public void LogInTest()
        {
            step.LogIn(username, password);
            Assert.True(step.IsLoggedIn(name));
        }

        [Test]
        public void EndTest()
        {
            step.LogIn(username, password);
            step.LogOut();
        }



        [Test]
        public void SearchTest()
        {
            step.Search(text);
            
        }

        [Test]
        public void ChangePicTest()
        {
            step.LogIn(username, password);
            Assert.True(step.ChahgeProfilePic(picture));
        }

        [Test]
        public void AddPostTest()
        {
            step.LogIn(username, password);
            step.AddPostBlog(title, text);
        }

        [Test]
        public void LikePostTest()
        {
            step.LogIn(username, password);
            step.LikePostBlog();
        }

        [Test]
        public void DeletePostTest()
        {
            step.LogIn(username, password);
            step.DeletePostBlog();
        }


        [Test]
        public void CommentPostTest()
        {
            step.LogIn(username, password);
            step.CommentPost(testtext);
        }

        [Test]
        public void DeleteCommentPostTest()
        {
            step.LogIn(username, password);
            step.DeleteComment();
        }


        [Test]
        public void MessagesTest()
        {
            step.LogIn(username, password);
            step.Messages(testtext);
        }






    }
}
