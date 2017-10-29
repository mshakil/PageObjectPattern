using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PageObjectPattern.PageObjects
{
    public class StudentDashboard : BasePage<StudentDashboardPageObjectRepository>
    {
        public StudentDashboard(IWebDriver driver)
            : base(driver, new StudentDashboardPageObjectRepository(driver))
        {
        }

        


        public bool IsAt()
        {
            try
            {
                var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(30));
                wait.Until(ExpectedConditions.ElementIsVisible(ObjectRepository.FilterByCategory));
            }
            catch (WebDriverTimeoutException)
            {
                return false;
            }
            return true;
        }

        public PageObjectPatternCoursePage ClickViewCourse()
        {
            ObjectRepository.ViewCourse.Click();

            return new PageObjectPatternCoursePage(Driver);
        }


    }
}
