using NUnit.Framework;
using OpenQA.Selenium;




namespace RazorWebUIExample.Pages
{
    class LandingPage
    {

        By signInButton = By.ClassName("login");


        public IWebElement SignInButton => Driver.driver.FindElement(signInButton);

        public void clickSignInButton() {
            SignInButton.Click();
        }

        public void verifyLandingPageTitleIsCorrect()
        {
            Assert.AreEqual(Constants.LANDING_PAGE_TITLE, Driver.driver.Title);
        }

        public void navigateToLoginPage()
        {
            
            Driver.driver.Url= Constants.URL;
            WaitFunctions.explicitWaitUntilDisplayed(Driver.driver, signInButton, 17);
            verifyLandingPageTitleIsCorrect();
            clickSignInButton();
        }
    }
}
