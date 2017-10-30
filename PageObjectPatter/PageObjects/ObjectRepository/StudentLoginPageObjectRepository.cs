using OpenQA.Selenium;

namespace PageObjectPattern.PageObjects
{
    public class StudentLoginPageObjectRepository : BasePageObjectRepository
    {
        public StudentLoginPageObjectRepository(IWebDriver driver) : base(driver) { }

        public IWebElement UserName { get { return Driver.FindElement(By.Id("user_email")); } }
        public IWebElement Password { get { return Driver.FindElement(By.Id("user_password")); } }
        public IWebElement SignInButton { get { return Driver.FindElement(By.Id("btn-signin")); } }
    }
}
