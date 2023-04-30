using OpenQA.Selenium;
using SpecFlowProjectForSwagLabs.BaseClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace SpecFlowProjectForSwagLabs.Utils
{
    public class CommonMethods : BaseTest
    {

        
        /* public void SendText(WebElement element, string text)
          {
              element.Clear();
              Wait(5);
              element.SendKeys(text);
          }*/

        
        public string addScreenshot(IWebDriver driver, ScenarioContext scenarioContext)
        {
            ITakesScreenshot takesScreenshot = (ITakesScreenshot)driver;
            Screenshot screenshot = takesScreenshot.GetScreenshot();
            string screenshotLocation = Path.Combine(scenarioContext.ScenarioInfo.Title + ".png");
            screenshot.SaveAsFile(screenshotLocation, ScreenshotImageFormat.Png);
            return screenshotLocation;
        }
        public static void Wait(int sec)
        {
            try
            {
                Thread.Sleep(sec * 1000);
            }
            catch (WebDriverException e)
            {
                Console.WriteLine(e.Message);
                Console.Read();
            }

        }

        internal void Click(IWebElement element)
        {
            Wait(5);
            element.Click();
        }

        internal void SendText(IWebElement element, string text)
        {
            element.Clear();
            Wait(5);
            element.SendKeys(text);
        }

        internal void ScrollDown()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)BaseTest.driver;
            js.ExecuteScript("window.scrollBy(0,250);");

        }
    }
}
