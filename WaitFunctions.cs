using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace RazorWebUIExample
{
    class WaitFunctions
    {

        public static void explicitWaitUntilDisplayed(IWebDriver driver, By element, int waitTime)
        {
            WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, waitTime));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(element));
        }
    }
}
