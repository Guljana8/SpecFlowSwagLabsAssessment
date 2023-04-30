using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProjectForSwagLabs.BaseClass
{
    [Binding]
    public class BaseTest
    {
        public static IWebDriver driver;


        // [SetUp]
        [BeforeScenario]
        public static void OpenBroswer()
        {
           
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Url = "https://www.saucedemo.com/";
        }

        //[TearDown]
        [AfterScenario]
        public static void CloseBroswer()
        {
            if(driver != null)
            {
                driver.Quit();
            }
        }


    }
}
