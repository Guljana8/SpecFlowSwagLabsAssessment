using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using SpecFlowProjectForSwagLabs.BaseClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProjectForSwagLabs.Pages
{
    public class LoginPage : BaseTest
    {

        private readonly IWebDriver _driver;
        // private IWebDriver usernameField;
        //private IWebDriver passwordField;
        // private IWebDriver loginButton;

        
        private readonly By usernameField = By.Id("user-name");
        private readonly By passwordField = By.XPath("//input[@id='password']");
        private readonly By loginButton = By.Id("login-button");

         public LoginPage(IWebDriver driver, IWebDriver usernameField)
         {
             _driver = driver;
 
         }

        public LoginPage()
        {
        }

        public void SendUsername(string username)
         {
            if (username == null)
            {
                throw new ArgumentNullException(nameof(username));
            }
            _driver.FindElement(usernameField).SendKeys(username);
         }

         public void SendPassword(string password)
         {
             _driver.FindElement(passwordField).SendKeys(password);
         }
 
         public void Click()
         {
             _driver.FindElement(loginButton).Click();
         }

        /* [FindsBy(How = How.Id, Using = "user-name")]
         public IWebElement usernameField;

         [FindsBy(How = How.XPath, Using = "//input[@id='password']")]
         public IWebElement passwordField;

         [FindsBy(How = How.Id, Using = "login-button")]
         public IWebElement loginButton;

         public LoginPage()
         {
             _driver = driver;
             PageFactory.InitElements(BaseTest.driver, this);
         }*/

    }
}
