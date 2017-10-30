using OpenQA.Selenium;


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
