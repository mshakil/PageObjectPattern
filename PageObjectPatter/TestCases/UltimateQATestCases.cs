using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using AutomationLibrary.DataAccess;
using AutomationLibrary.Utilities;
using PageObjectPattern.PageObjects;
using System.Configuration;

namespace PageObjectPattern.TestCases
{
    [TestFixture]
    public class UltimateQATestCases : MainCall
    {
        [Test]
        [Description("Demo Test Using Page Object Pattern")]
        public void DemoTest001()
        {
            string userName = ConfigurationManager.AppSettings["UltimateQAUserName"];
            string password = ConfigurationManager.AppSettings["UltimateQAPassword"];
            var courcesPage = new CoursesPage(Driver);
            courcesPage.Goto();

            var loginPage = courcesPage.ClickSignInLink();
            var studentDashBoard = loginPage.Login(userName, password);

            Assert.IsTrue(studentDashBoard.IsAt(), "The Student Was Not Able To Login");
        }

        [Test]
        public void DemoTest002()
        {
            string userName = ConfigurationManager.AppSettings["UltimateQAUserName"];
            string password = ConfigurationManager.AppSettings["UltimateQAPassword"];
            var courcesPage = new CoursesPage(Driver);
            courcesPage.Goto();

            var loginPage = courcesPage.ClickSignInLink();
            var studentDashBoard = loginPage.Login(userName, password);

            Assert.IsTrue(studentDashBoard.IsAt(), "The Student Was Not Able To Login");

            var PageObjecPatternCoursePage = studentDashBoard.ClickViewCourse();
            Assert.IsTrue(PageObjecPatternCoursePage.IsAt(), "View Course Page Not open successfully.");
        }
    }
}
