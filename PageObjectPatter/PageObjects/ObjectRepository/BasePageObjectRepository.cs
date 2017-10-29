using OpenQA.Selenium;

namespace PageObjectPattern.PageObjects
{
    public class BasePageObjectRepository
    {
        protected readonly IWebDriver Driver;

        public BasePageObjectRepository(IWebDriver driver)
        {
            Driver = driver;
        }
    }
}
