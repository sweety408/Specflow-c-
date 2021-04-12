using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsQA.Pages
{
    class ProfilePage
    {
        public void GotoProfilePage(IWebDriver driver)
        {
            // click the go to profile sub-menu
            driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/div/div[2]/div/span")).Click();
            driver.FindElement(By.LinkText("Go to Profile")).Click();

           




        }

    }
}
