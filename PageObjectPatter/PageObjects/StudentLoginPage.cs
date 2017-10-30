using OpenQA.Selenium;
using System.Threading;

namespace PageObjectPattern.PageObjects
{
    public class StudentLoginPage : BasePage<StudentLoginPageObjectRepository>
    {

        public StudentLoginPage(IWebDriver driver)
            : base(driver , new StudentLoginPageObjectRepository(driver))
        {
        }

        
        public StudentDashboard Login(string userName, string password)
        {
            TypeUserName(userName);
            TypePassword(password);
            ObjectRepository.SignInButton.Click();

            return new StudentDashboard(Driver);
        }

        private void TypeUserName(string userName)
        {
            ObjectRepository.UserName.Click();
            ObjectRepository.UserName.Clear();
            ObjectRepository.UserName.SendKeys(userName);
            Thread.Sleep(500);
        }

        private void TypePassword(string password)
        {
            ObjectRepository.Password.Click();
            ObjectRepository.Password.Clear();
            ObjectRepository.Password.SendKeys(password);
            Thread.Sleep(500);
        }
    }
}
