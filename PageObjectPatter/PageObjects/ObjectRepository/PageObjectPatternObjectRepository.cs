using OpenQA.Selenium;

namespace PageObjectPattern.PageObjects
{
    public class PageObjectPatternObjectRepository : BasePageObjectRepository
    {
        public PageObjectPatternObjectRepository(IWebDriver driver) : base(driver)
        {
        }
        public By FreeTrailButton { get { return By.ClassName("btn-top-free-trial"); } }
    }
}
