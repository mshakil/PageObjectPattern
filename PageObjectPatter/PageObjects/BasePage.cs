using OpenQA.Selenium;

namespace PageObjectPattern.PageObjects
{
    public class BasePage<TObjectRepository> where TObjectRepository : BasePageObjectRepository
    {
        public BasePage(IWebDriver drive, TObjectRepository repository)
        {
            Driver = drive;
            ObjectRepository = repository;
        }

        public IWebDriver Driver { get; set; }
        internal TObjectRepository ObjectRepository { get; set; }
    }
}
