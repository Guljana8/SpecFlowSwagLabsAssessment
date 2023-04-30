using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SpecFlowProjectForSwagLabs.BaseClass;
using SpecFlowProjectForSwagLabs.Pages;
using SpecFlowProjectForSwagLabs.Utils;

namespace SpecFlowProjectForSwagLabs.StepDefinitions
{
    [Binding]
    public sealed class LoginStep : BaseTest
    {
        //define a global variable
        // private IWebDriver driver;
         string username = "standard_user";
         string password = "secret_sauce";

        LoginPage loginPageObj = new LoginPage();
      
         CommonMethods comObj = new CommonMethods();


        [Given(@"user is navigated to the application")]
        public void GivenUser›sNavigatedToTheApplication()
        {
            /*driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.saucedemo.com/";*/

            OpenBroswer();
            Thread.Sleep(3000);
        }

      /* [When(@"user enters valid username ""([^""]*)"" and valid password ""([^""]*)""")]
        public void WhenUserEntersValidUsernameAndValidPassword(string userName, string password)
        {
            // comObj.SendText(loginPageObj.usernameField, userName);
            // comObj.SendText(loginPageObj.passwordField, password);
            
        }*/


          [When(@"user enters valid username and valid password")]
          public void WhenUserEntersValidUsernameAndValidPassword()
          {
            // driver.FindElement(By.Id("user-name")).SendKeys("standard_user");
            // driver.FindElement(By.XPath("//input[@id='password']")).SendKeys("secret_sauce");

            if (loginPageObj == null)
            {
                loginPageObj = new LoginPage();
            }
            
            loginPageObj.SendUsername(username);
            loginPageObj.SendPassword(password);
     
          }

        [When(@"user clicks on login button")]
        public void WhenUserClicksOnLoginButton()
        {
            //driver.FindElement(By.Id("login-button")).Click();
            //comObj.Click(loginPageObj.loginButton);
            loginPageObj.Click();
            
        }

        [Then(@"user is successfully logged in")]
        public void ThenUser›sSuccessfullyLogged›n()
        {
            string ActualTitle = driver.Title;
            string ExpectedTitle = "Swag Labs";
            
            Assert.AreEqual(ExpectedTitle, ActualTitle);
         

        }

    }
}