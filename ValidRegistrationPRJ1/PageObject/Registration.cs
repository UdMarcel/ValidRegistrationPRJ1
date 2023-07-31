using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValidRegistrationPRJ1.Utilities;

namespace ValidRegistrationPRJ1.PageObject
{
    class Registration
    {

        IWebDriver driver;
        public Registration()
        {
            driver = Hooks.driver;
        
        }

        IWebElement SignUp => driver.FindElement(By.CssSelector("body > div > app-header > nav > div > ul:nth-child(2) > li:nth-child(3) > a"));
        IWebElement Username => driver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/fieldset/fieldset[1]/input"));

        IWebElement Email => driver.FindElement(By.CssSelector("body > div > div > div > div > div > div > form > fieldset > fieldset:nth-child(2) > input"));

        IWebElement Password => driver.FindElement(By.CssSelector("body > div > div > div > div > div > div > form > fieldset > fieldset:nth-child(3) > input"));

        IWebElement Login => driver.FindElement(By.CssSelector("body > div > div > div > div > div > div > form > fieldset > button"));

        public void ClickOnSignUP()
        {
            SignUp.Click();

        }

        public void EnterUsername()
        {
            Username.SendKeys("Ajibola500");
        }

        public void NavigateToWebsite()
        {
            driver.Navigate().GoToUrl("http://angularjs.realworld.io/#/register");
        }

        public void EnterEmail()
        {
            Email.SendKeys("ajibola500@yahoo.com");
        }

        public void EnterPassword()
        {
            Password.SendKeys("Pass500");
        }
        public void Enterlogin()
        {
            Login.Click();
        }

    }
}
