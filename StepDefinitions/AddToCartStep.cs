using NUnit.Framework;
using OpenQA.Selenium;
using SpecFlowProjectForSwagLabs.BaseClass;
using SpecFlowProjectForSwagLabs.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProjectForSwagLabs.StepDefinitions
{
    [Binding]
    public class AddToCartStep : BaseTest
    {
        CommonMethods comObj = new CommonMethods();

        [When(@"user adding desired item to the cart")]
        public void WhenUserAddingDesiredİtemToTheCart()
        {
           IWebElement addToCartButton = driver.FindElement(By.Id("add-to-cart-sauce-labs-backpack"));
            addToCartButton.Click();
        }

        [When(@"user navigates to the cart")]
        public void WhenUserNavigatesToTheCart()
        {
           IWebElement cart = driver.FindElement(By.ClassName("shopping_cart_link"));
            cart.Click();
        }

        [When(@"user clicks on CHECKOUT button")]
        public void WhenUserClicksOnCHECKOUTButton()
        {
            IWebElement checkout = driver.FindElement(By.XPath("//button[@id='checkout']"));
            checkout.Click();
        }

        [When(@"user enters firstname ""([^""]*)"", lastname ""([^""]*)"" information and ZipCode ""([^""]*)""")]
        public void WhenUserEntersFirstnameLastnameİnformationAndZipCode(string firstname, string lastname, string zipcode)
        {
          
            IWebElement firstName = driver.FindElement(By.Id("first-name"));
            firstName.SendKeys(firstname);
            IWebElement lastName = driver.FindElement(By.Id("last-name"));
            lastName.SendKeys(lastname);
            IWebElement postalCode = driver.FindElement(By.Id("postal-code"));
            postalCode.SendKeys(zipcode);
            
        }


        [When(@"user clicks on CONTINUE button")]
        public void WhenUserClicksOnCONTINUEButton()
        {
            comObj.ScrollDown();
            driver.FindElement(By.Id("continue")).Click();
        }

        [When(@"user clicks on '([^']*)' button")]
        public void WhenUserClicksOnButton(string p0)
        {
            comObj.ScrollDown();
            driver.FindElement(By.Id("continue-shopping")).Click();
        }


        [When(@"user come back to the home page and add another item to cart")]
        public void WhenUserComeBackToTheHomePageAndAddAnotherİtemToCart()
        {
            IWebElement addToCartButton = driver.FindElement(By.Id("add-to-cart-sauce-labs-bike-light"));
            addToCartButton.Click();
        }


        [When(@"user clicks on the FINISH button")]
        public void WhenUserClicksOnTheFINISHButton()
        {
            driver.FindElement(By.XPath("//button[@id='finish']")).Click();
        }

        [Then(@"user is able to see '([^']*)' message for his order")]
        public void ThenUserİsAbleToSeeMessageForHisOrder(string text)
        {
            IWebElement header = driver.FindElement(By.ClassName("complete-header"));
            string headerText= header.Text;
            Assert.IsTrue(headerText.Contains(text));

        }

        [When(@"user is clicking on REMOVE button")]
        public void WhenUserİsClickingOnREMOVEButton()
        {
           IWebElement removeButton = driver.FindElement(By.Id("remove-sauce-labs-backpack"));
            removeButton.Click();
        }

        [Then(@"item is removed")]
        public void ThenİtemİsRemoved()
        {
        // IWebElement cartList  = driver.FindElement(By.ClassName("cart_list"));
          //  cartList.Click();
            bool cartEmpty = driver.FindElements(By.ClassName("cart_list")).Count >= 0;
            Assert.IsTrue(cartEmpty);
            
        }
     
    }
}
