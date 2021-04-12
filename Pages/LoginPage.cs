using MarsQA.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;


namespace MarsQA.Pages
{
    class LoginPage
    {
        public void LoginSteps(IWebDriver driver)
        {

            
            // Navigate the URL
            driver.Navigate().GoToUrl("http://localhost:5000/Account/Profile");

            // Maximize the browser  
            driver.Manage().Window.Maximize();

            // poppulate login page test data collection
            ExcelLibHelper.PopulateInCollection(@"D:\MarsQA\MarsQA\MarsQA\Helpers\TestData.xls", "Login");
            
            // Enter Email ID
            driver.FindElement(By.XPath("//input[@placeholder='Email address']")).SendKeys(ExcelLibHelper.ReadData(2,"Username"));

            // Eneter Password
            driver.FindElement(By.XPath("//input[@placeholder='Password']")).SendKeys(ExcelLibHelper.ReadData(2,"Password"));

            // Click on login button
            driver.FindElement(By.XPath("//BUTTON[@class='fluid ui teal button'][text()='Login']")).Click();
            Thread.Sleep(1000);
            try
            { // Verify the Home page is desplayed as expected
                if (driver.FindElement(By.XPath("//span[@class='item ui dropdown link active visible']")).Text == "Hi Sweety")
                {
                    Console.WriteLine("Test passed");
                }
                else
                {
                    Console.WriteLine("Test Faild");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Home page not despalyed", ex.Message);
            }
           










        }
    }
}
