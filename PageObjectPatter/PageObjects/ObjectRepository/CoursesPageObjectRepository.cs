using OpenQA.Selenium;

namespace PageObjectPattern.PageObjects
{
    public class CoursesPageObjectRepository : BasePageObjectRepository
    {
        public CoursesPageObjectRepository(IWebDriver driver) : base(driver){}
        public IWebElement SignInLink { get { return Driver.FindElement(By.ClassName("my-account")); } }
        
    }
}
