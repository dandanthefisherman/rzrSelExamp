using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Configuration;

namespace RazorWebUIExample
{
    class Driver
    {
        public static IWebDriver driver { get; set; }

        public void setUpChrome(String browser) {

            switch (browser)
            {
                case "chrome":
                    driver = new ChromeDriver();
                    break;
                case "firefox":
                    driver = new FirefoxDriver();
                    break;
            }
           //this would be controlled in app settings as an environmental variable  
            
        }

        public void quitDriver(){
            driver.Quit();
            driver = null;
        }
    }
}
