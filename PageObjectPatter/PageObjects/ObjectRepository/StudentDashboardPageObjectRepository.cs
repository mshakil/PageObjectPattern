using OpenQA.Selenium;

namespace PageObjectPattern.PageObjects
{
    public class StudentDashboardPageObjectRepository :BasePageObjectRepository
    {
        public IWebElement ViewCourse { get { return Driver.FindElement(By.CssSelector("a[href='/courses/page-objects-in-test-automation']")); } }
        public By FilterByCategory { get { return (By.Id("collection_id")); } }
        public StudentDashboardPageObjectRepository(IWebDriver driver) : base(driver) { }
    }
}
