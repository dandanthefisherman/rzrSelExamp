using NUnit.Framework;
using RazorWebUIExample.Pages;

namespace RazorWebUIExample

{
    class UserLoginTests 
    {
        Driver driverFunctions = new Driver();
        LandingPage landingPage = new LandingPage();
        LoginPage loginPage = new LoginPage();

        [SetUp]
        public void Setup()
        {
            driverFunctions.setUpChrome(Constants.BROWSER);
            landingPage.navigateToLoginPage();
        }

        [Test]
        public void VerifyLoginPageElementsExist()
        {
         
            loginPage.verifyAllLoginElementsAreVisible();
            loginPage.assertPageTitleIsCorrect();
        }

        [Test]
        public void verifyInvalidEmailFormatErrorMessageAppear()
        {

            loginPage.verifyAllLoginElementsAreVisible();
            loginPage.populateLoginDetails(Constants.INVALID_EMAIL, Constants.VALID_PASSWORD);
            loginPage.assertCorrectLoginErrorMessage(Constants.SINGLE_ERROR_MESSAGE, Constants.INVALID_EMAIL_ERROR_MESSAGE);
        }

        [Test]
        public void verifyEmptyLoginFieldsErrorMessageAppears()
        {
            loginPage.verifyAllLoginElementsAreVisible();
            loginPage.populateLoginDetails("", "");
            loginPage.assertCorrectLoginErrorMessage(Constants.SINGLE_ERROR_MESSAGE, Constants.REQUIRED_EMAIL_ERROR_MESSAGE);
        }

        [TearDown]
        public void TearDown()
        {
            driverFunctions.quitDriver();
        }
    }
}