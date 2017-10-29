using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PageObjectPattern.PageObjects
{
    public class PageObjectPatternCoursePage : BasePage<PageObjectPatternObjectRepository>
    {
        public PageObjectPatternCoursePage(IWebDriver driver)
            : base(driver , new PageObjectPatternObjectRepository(driver))
        {
        }

        public bool IsAt()
        {
            try
            {
                var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(30));
                wait.Until(ExpectedConditions.ElementIsVisible(ObjectRepository.FreeTrailButton));
            }
            catch (WebDriverTimeoutException)
            {
                return false;
            }
            return true;
        }
    }
}
