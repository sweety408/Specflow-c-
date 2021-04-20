using MarsQA.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsQA.Pages
{
    class ProfilePage : CommonDriver
    {
        public void GotoProfilePage(IWebDriver driver) 
        {
            // click the go to profile sub-menu
            driver.FindElement(By.XPath("//a[normalize-space()='Profile']")).Click();
            
            driver.FindElement(By.LinkText("Go to Profile")).Click();
        } 
    }
}
