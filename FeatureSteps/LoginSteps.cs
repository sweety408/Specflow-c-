using MarsQA.Pages;
using MarsQA.Utilities;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;
using System.Reflection;
using TechTalk.SpecFlow;

namespace MarsQA.FeatureSteps
{
    [Binding]
    class LoginSteps : CommonDriver
    {
        [Given(@"login to turn up portal")]
        public void GivenLoginToTurnUpPortal()
        {
            // Define Driver
            Driver = new ChromeDriver(@"C:\Users\sweet\Downloads\chromedriver_win32");

            // Page object for Login Page
            LoginPage loginobj = new LoginPage();
            loginobj.LoginSteps(Driver);
        }
    }
}
