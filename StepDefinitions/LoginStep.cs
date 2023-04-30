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
        // string username = "standard_user";
        //string password = "secret_sauce";

        // LoginPage loginPageObj = new LoginPage();
      
         CommonMethods comObj = new CommonMethods();


        [Given(@"user is navigated to the application")]
        public void GivenUser›sNavigatedToTheApplication()
        {
            /*driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.saucedemo.com/";*/

           // OpenBroswer();
            //Thread.Sleep(3000);
        }

        [When(@"user enters valid username ""([^""]*)"" and valid password ""([^""]*)""")]
        public void WhenUserEntersValidUsernameAndValidPassword(string userName, string password)
        {
            IWebElement usernameField = driver.FindElement(By.XPath("//input[@id='user-name']"));
            usernameField.SendKeys(userName);

            IWebElement passwordField = driver.FindElement(By.XPath("//input[@id='password']"));
            passwordField.SendKeys(password);
        
        }


        /* [When(@"user enters valid username and valid password")]
          public void WhenUserEntersValidUsernameAndValidPassword()
          {
            // driver.FindElement(By.Id("user-name")).SendKeys("standard_user");
            // driver.FindElement(By.XPath("//input[@id='password']")).SendKeys("secret_sauce");

            IWebElement userName = driver.FindElement(By.Id("user-name"));
            comObj.SendText(userName);
            IWebElement password = driver.FindElement(By.XPath("//input[@id='password']"));
            comObj.SendText(password);
        

//this implementation was throwing a NullReferenceException : Object reference not set to an instance of an object.
             if (loginPageObj == null)
              {
                  loginPageObj = new LoginPage();
              }

              loginPageObj.SendUsername(username);
              loginPageObj.SendPassword(password);
        }*/

        [When(@"user clicks on login button")]
        public void WhenUserClicksOnLoginButton()
        {
            //driver.FindElement(By.Id("login-button")).Click();
            //comObj.Click(loginPageObj.loginButton);
            IWebElement loginButton= driver.FindElement(By.Id("login-button"));
              comObj.Click(loginButton);
            
        }

        [Then(@"user is successfully logged in")]
        public void ThenUser›sSuccessfullyLogged›n()
        {
            string ActualTitle = driver.Title;
            string ExpectedTitle = "Swag Labs";
            
            Assert.AreEqual(ExpectedTitle, ActualTitle);
 
        }

        [When(@"user enters locked username ""([^""]*)"" and valid password ""([^""]*)""")]
        public void WhenUserEntersLockedUsernameAndValidPassword(string lockedUser, string password)
        {
            IWebElement usernameField = driver.FindElement(By.XPath("//input[@id='user-name']"));
            usernameField.SendKeys(lockedUser);

            IWebElement passwordField = driver.FindElement(By.XPath("//input[@id='password']"));
            passwordField.SendKeys(password);
        }

        [Then(@"error message is displayed")]
        public void ThenErrorMessage›sDisplayed()
        {
            IWebElement errorMessage = driver.FindElement(By.ClassName("error-button"));
            string dispalyedMessage = errorMessage.Text;
            Assert.That(errorMessage.Displayed, Is.True, "Sorry, this user has been locked out.");
            Console.WriteLine("Displayed text is: " + dispalyedMessage);
        }

        [When(@"user enters problem username ""([^""]*)"" and valid password ""([^""]*)""")]
        public void WhenUserEntersProblemUsernameAndValidPassword(string problemUser, string password)
        {
            IWebElement usernameField = driver.FindElement(By.XPath("//input[@id='user-name']"));
            usernameField.SendKeys(problemUser);

            IWebElement passwordField = driver.FindElement(By.XPath("//input[@id='password']"));
            passwordField.SendKeys(password);
        }

        [When(@"user enters performance glitch username ""([^""]*)"" and valid password ""([^""]*)""")]
        public void WhenUserEntersPerformanceGlitchUsernameAndValidPassword(string glitchUser, string password)
        {
            IWebElement usernameField = driver.FindElement(By.XPath("//input[@id='user-name']"));
            usernameField.SendKeys(glitchUser);

            IWebElement passwordField = driver.FindElement(By.XPath("//input[@id='password']"));
            passwordField.SendKeys(password);
        }


    }
}