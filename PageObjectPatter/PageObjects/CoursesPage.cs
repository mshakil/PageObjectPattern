using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectPattern.PageObjects
{
    public class CoursesPage : BasePage<CoursesPageObjectRepository>
    {
        public CoursesPage(IWebDriver driver)
            : base(driver , new CoursesPageObjectRepository(driver))
        {
        }
        
        public void Goto()
        {
            Driver.Navigate().GoToUrl("http://courses.ultimateqa.com");
        }

        public StudentLoginPage ClickSignInLink()
        {
            ObjectRepository.SignInLink.Click();
            return new StudentLoginPage(Driver);
        }

    }
}
