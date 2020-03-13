using NUnit.Framework;
using OpenQA.Selenium;
using System;

namespace RazorWebUIExample.Pages
{
    class LoginPage
    {

		By userLoginName = By.Id("email");

		By userPassword = By.Id("Passwd");

		By saveButton = By.Id("SubmitLogin");

		public IWebElement UserLoginName => Driver.driver.FindElement(userLoginName);
        public IWebElement UserPassword => Driver.driver.FindElement(userPassword);
        public IWebElement SaveButton => Driver.driver.FindElement(saveButton);

		public IWebElement errorWarningMessage => Driver.driver.FindElement(By.XPath("//*[@class='alert alert-danger']/p"));
		
		public IWebElement detailedErrorWarningMessage => Driver.driver.FindElement(By.XPath("//*[@class='alert alert-danger']/ol"));

		public void setUserName(String userName)
		{
			UserLoginName.SendKeys(userName);
		}

		public void setPassword(String passWord)
		{
			UserPassword.SendKeys(passWord);
		}

		public void clickSaveButton()
		{
			SaveButton.Click();
		}

		public void verifyAllLoginElementsAreVisible()
		{
			WaitFunctions.explicitWaitUntilDisplayed(Driver.driver, userLoginName, 17);
			WaitFunctions.explicitWaitUntilDisplayed(Driver.driver, userPassword, 17);
			WaitFunctions.explicitWaitUntilDisplayed(Driver.driver, saveButton, 17);
		}

		public void populateLoginDetails(String userName, String passWord)
		{
			WaitFunctions.explicitWaitUntilDisplayed(Driver.driver, userLoginName, 17);

			setUserName(userName);

			setPassword(passWord);

			clickSaveButton();

		}

		public void assertPageTitleIsCorrect()
		{
			Assert.AreEqual(Constants.LOGIN_PAGE_TITLE, Driver.driver.Title);
		}

		public void assertCorrectLoginErrorMessage(String errorMessage, String detailedErrorMessage)
		{
			Assert.AreEqual(errorMessage, errorWarningMessage.Text);
			Assert.AreEqual(detailedErrorMessage, detailedErrorWarningMessage.Text);
		}
	}
}


