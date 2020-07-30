using NUnit.Framework;
using NUnitTestProject2.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace NUnitTestProject2.Features
{
    [Binding]
  
    class HomePageStep
    {
        LoginPage loginPage = null;
        IWebDriver Driver;
        

        [Given(@"user hits the url")]
        public void GivenUserHitsTheUrl()
        {
            Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl("https://phptravels.com/demo/");


            


            
        }

        /*[When(@"enter below credentials")]
        public void WhenEnterBelowCredentials(Table credentials)
        {
            loginPage = new LoginPage(Driver);
           dynamic data= credentials.CreateDynamicInstance();
            loginPage.LoginTest((String)data.username, (String)data.password);
            

        }*/
        [When(@"enter ""(.*)"" and ""(.*)""")]
        public void WhenEnterAnd(string p0, string p1)
        {
            loginPage = new LoginPage(Driver);
            loginPage.LoginTest(p0, p1);


        }


        [When(@"click on login")]
        public void WhenClickOnLogin()
        {
            
        }

        [Then(@"should be on homePage")]
        public void ThenShouldBeOnHomePage()
        {
            
        }

    }
}
