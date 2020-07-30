using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.Contracts;
using System.Text;
using System.Threading;

namespace NUnitTestProject2.Pages
{
  public  class LoginPage
    {
        public IWebDriver Driver { get; }
        public LoginPage(IWebDriver driver)
        {
            Driver = driver;
        }

        //UI Elements 
        public IWebElement lgn_lnk=> Driver.FindElement(By.XPath("//a[text()='Log in']"));
        public IWebElement UserName => Driver.FindElement(By.Id("inputEmail"));
        private IWebElement PassWord => Driver.FindElement(By.XPath("//input[@type='password']"));

        public IWebElement captcha=> Driver.FindElement(By.XPath("//span[@class='recaptcha-checkbox goog-inline-block recaptcha-checkbox-unchecked rc-anchor-checkbox']"));
        public IWebElement lgn_btn => Driver.FindElement(By.XPath("//input[@id='login']"));

       

        
        public void LoginTest(String username, String password)
        {
         
            lgn_lnk.Click();
            Driver.SwitchTo().Window(Driver.WindowHandles[1]);

            Thread.Sleep(3000);
            UserName.SendKeys(username);
            Thread.Sleep(2000);
            PassWord.SendKeys(password);
            Thread.Sleep(2000);
            
            lgn_btn.Click();





        }




    }
}
